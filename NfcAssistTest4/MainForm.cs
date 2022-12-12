using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NfcAssist;
using NfcCardInfo;
using NfcDeviceCommandAssists;
using NfcReaderAssists;
using PCSC;
using PCSC.Iso7816;
using PCSC.Monitoring;
using PcscSharpAssists;

namespace NfcAssistTest4
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// 장치 명령 확인/생성 폼
		/// </summary>
		private DeviceCommandForm frmDeviceCommand;
		/// <summary>
		/// 카드 인포 확인/생성 폼
		/// </summary>
		private CardInfoForm frmCardInfo;


		/// <summary>
		/// 디바이스와 카드정보를 이용하여 생성한 NFC 리더 지원 개체
		/// </summary>
		NfcReader m_nfc;
		/// <summary>
		/// (test)디바이스와 카드정보를 이용하여 생성한 NFC 리더 지원 개체
		/// </summary>
		NfcReaderTest m_nfcTest;

		IMonitorFactory monitorFactory;
		ISCardMonitor monitor;

		/// <summary>
		/// NFC 카드 리스트
		/// </summary>
		private List<CardInfoInterface> CardInfoList
			= new List<CardInfoInterface>();
		/// <summary>
		/// 디바이스 명령 리스트
		/// </summary>
		private List<DeviceCommandInterface> DeviceCommandList
			= new List<DeviceCommandInterface>();

		public MainForm()
		{
			InitializeComponent();

			//장비를 기본값으로 설정한다.**************
			//여기서는 리스트뷰의 셀랙트가 동작하므로 더미만 만들어 둔다.
			this.m_nfc
				= new NfcReader(
						new DeviceCmd_Dummy()
						, new CardInfo_Dummy());
			this.m_nfcTest
				= new NfcReaderTest(
						new DeviceCmd_Dummy()
						, new CardInfo_Dummy());

			//인스턴스 생성
			monitorFactory = MonitorFactory.Instance;
			monitor = monitorFactory.Create(SCardScope.System);
			//monitor = monitorFactory.Create(SCardScope.User);
			//이벤트 연결
			monitor.StatusChanged -= Monitor_StatusChanged;
			monitor.StatusChanged += Monitor_StatusChanged;

			//json 파일 로드
			NfcInfoFile nfcInfoFile = new NfcInfoFile();
			this.CardInfoList
				= nfcInfoFile.FolderLoad_CardInfo(@"CardInfo");
			this.DeviceCommandList
				= nfcInfoFile.FolderLoad_DeviceCommand(@"DeviceCommand");

			//가지고 있는 정보를 UI에 표시한다.
			//카드 ◇◇◇◇
			foreach (CardInfoInterface itemCI in this.CardInfoList)
			{
				listviewCard.Items.Add(itemCI.Title);
			}
			listviewCard.Items[0].Selected = true;

			//디바이스 ◇◇◇◇
			foreach (DeviceCommandInterface itemDC in this.DeviceCommandList)
			{
				listviewDevice.Items.Add(itemDC.Title);
			}
			listviewDevice.Items[0].Selected = true;


			//카드 리스트 새로고침
			btnCardListRefresh_Click(null, null);
		}

		#region 폼 관련
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.m_nfc.Dispose();
			monitor.Cancel();
			monitor.Dispose();

			//열린 폼 닫기 및 제거
			if (null != this.frmDeviceCommand)
			{
				this.frmDeviceCommand.Close();
			}
			this.frmDeviceCommand = null;

			if (null != this.frmCardInfo)
			{
				this.frmCardInfo.Close();
			}
			this.frmCardInfo = null;
		}

		/// <summary>
		/// 로그 추가
		/// </summary>
		/// <param name="sMessage"></param>
		private void LogAdd(string sMessage)
		{
			if (true == InvokeRequired)
			{//다른 쓰래드다.
				this.Invoke(new Action(
					delegate ()
					{
						this.LogAddNotInvoke(sMessage);
					}));
			}
			else
			{//같은 쓰래드다.
				this.LogAddNotInvoke(sMessage);
			}
		}
		/// <summary>
		/// 로그 추가(인보크 없음)
		/// </summary>
		/// <param name="sMessage"></param>
		private void LogAddNotInvoke(string sMessage)
		{
			ListViewItem item = new ListViewItem();
			item.Text = DateTime.Now.ToString("HH:mm:ss");
			item.SubItems.Add(sMessage);

			this.listLog.Items.Add(item);
			this.listLog.Items[this.listLog.Items.Count - 1].EnsureVisible();
		}

		private void InfoLable(string sText)
		{
			this.InfoLable(sText, null);
		}
		/// <summary>
		/// 정보 레이블 설정
		/// </summary>
		/// <param name="sText"></param>
		private void InfoLable(string sText, Color? color)
		{
			if (true == InvokeRequired)
			{//다른 쓰래드다.
				this.Invoke(new Action(
					delegate ()
					{
						this.InfoLableNotInvoke(sText, color);
					}));
			}
			else
			{//같은 쓰래드다.
				this.InfoLableNotInvoke(sText, color);
			}
		}
		/// <summary>
		/// 정보 레이블 설정(인보크 없음)
		/// </summary>
		/// <param name="sMessage"></param>
		private void InfoLableNotInvoke(string sMessage, Color? color)
		{
			labInfo.Text = sMessage;
			if (null != color)
			{
				labInfo.BackColor = (Color)color;
			}

		}

		#endregion

		#region UI관련
		/// <summary>
		/// 디바이스 변경
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listviewDevice_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.NfcInfoChanged();
		}
		/// <summary>
		/// 카드 변경
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listviewCard_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.NfcInfoChanged();
		}
		/// <summary>
		/// UI에 표시된 정보로 디바이스와 카드를 초기화 한다.
		/// </summary>
		private void NfcInfoChanged()
		{
			if (0 < this.listviewDevice.SelectedItems.Count
				&& 0 < this.listviewCard.SelectedItems.Count)
			{
				//디바이스 판단. ****************
				string sDeviceTitle = this.listviewDevice.SelectedItems[0].Text;
				DeviceCommandInterface selectDeviceCmd
					= this.DeviceCommandList
						.Where(w => w.Title == sDeviceTitle)
						.FirstOrDefault();


				//카드 판단 *************
				string sCardTitle = this.listviewCard.SelectedItems[0].Text;
				CardInfoInterface selectCardInfo
					= this.CardInfoList
						.Where(w => w.Title == sCardTitle)
						.FirstOrDefault();

				if (null == selectDeviceCmd)
				{//디바이스 정보 없다.
					this.LogAdd("NFC 리더기를 선택해 주세요.");
				}
				else if (null == selectCardInfo)
				{
					this.LogAdd("카드를 선택해 주세요.");
				}
				else
				{//성공
				 //장비 재설정

					if (null != this.m_nfc)
					{//기존 개체가 있다.
					 //this.m_nfc.OnCardInOutChanged -= M_nfc_OnCardInOutChanged;
						this.m_nfc.Dispose();
					}
					if (null != this.m_nfcTest)
					{//기존 개체가 있다.
						this.m_nfcTest.Dispose();
					}

					this.m_nfc
						= new NfcReader(
							selectDeviceCmd
							, selectCardInfo);
					this.m_nfcTest
						= new NfcReaderTest(
								selectDeviceCmd
								, selectCardInfo);

					this.m_nfc.OnCardInOutChanged -= M_nfc_OnCardInOutChanged;
					this.m_nfc.OnCardInOutChanged += M_nfc_OnCardInOutChanged;
				}
			}
		}

		private void M_nfc_OnCardInOutChanged(NfcReader sender, bool bCardIn)
		{
			if (true == bCardIn)
			{
				this.InfoLable("Card In", Color.SkyBlue);
				Debug.WriteLine("Card In");
			}
			else
			{
				this.InfoLable("Card Out", Color.White);
				Debug.WriteLine("Card Out");
			}
		}
		#endregion

		#region Device Test

		/// <summary>
		/// ui의 블록 번호를 바이트로 변환해 리턴한다.
		/// </summary>
		/// <returns></returns>
		public byte BlockNumberGet()
		{
			return BitConverter.GetBytes((short)this.numericBlockNumber.Value)[0];
		}

		private void btnGetStatus_Click(object sender, EventArgs e)
		{


			if (true == this.m_nfcTest.CardIn())
			{
				this.m_nfcTest.GetStatus();
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}

		/// <summary>
		/// 카드 ATR 정보 받기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGetArt_Click(object sender, EventArgs e)
		{
			if (true == this.m_nfcTest.CardIn())
			{
				byte[] byteAtr
				= this.m_nfcTest.CardAttributeGet(SCardAttribute.AtrString);


				if (null != byteAtr)
				{
					string sData = string.Empty;
					sData = BitConverter.ToString(byteAtr);
					this.LogAdd(string.Format("ATR: {0}", sData));
				}
				else
				{
					this.LogAdd(string.Format("ATR: Failure"));
				}
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}

		/// <summary>
		/// 키 로드 테스트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLoadKey_Click(object sender, EventArgs e)
		{
			if (true == this.m_nfcTest.CardIn())
			{
				byte[] byteLoadKeyData = new byte[] { };
				this.m_nfcTest.LoadKey(out byteLoadKeyData);

				if (true == this.m_nfcTest.LoadKey(out byteLoadKeyData))
				{
					this.LogAdd(BitConverter.ToString(byteLoadKeyData.ToArray()));
				}
				else
				{
					this.LogAdd("키 로드 실패");
				}
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}

		/// <summary>
		/// 블록 권한 테스트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAuthBlock_Click(object sender, EventArgs e)
		{
			byte byteBlockNumber = this.BlockNumberGet();

			if (true == this.m_nfcTest.CardIn())
			{
				if (true == this.m_nfcTest.AuthBlock(byteBlockNumber))
				{
					this.LogAdd(String.Format("블록 권한 얻기 성공 : {0:X2}", byteBlockNumber));

					this.InfoLable("Authentication : success"
									, Color.FromArgb(255, 80, 240, 180));
					this.LogAdd(string.Format("AUTHENTICATE success."));
				}
				else
				{
					this.LogAdd(">>> 블록 권한 얻기 실패");
					this.InfoLable("Authentication : none"
									, Color.FromArgb(255, 160, 0, 184));
					this.LogAdd(string.Format("- Error - Read Binary failed. - 인증을 다시 받으면 해결 될 수 있음."));
				}
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}

		/// <summary>
		/// 블록 읽기 테스트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReadBinaryBlocks_Click(object sender, EventArgs e)
		{
			byte byteBlockNumber = this.BlockNumberGet();

			if (true == this.m_nfcTest.CardIn())
			{
				byte[] byteLoadKeyData = new byte[] { };

				if (true == this.m_nfcTest.ReadBinaryBlocks(byteBlockNumber, out byteLoadKeyData))
				{
					this.LogAdd(String.Format("--- 블록 읽기({0:X2}) ---", byteBlockNumber));
					this.LogAdd(BitConverter.ToString(byteLoadKeyData.ToArray()));
				}
				else
				{
					this.LogAdd("블록 읽기 실패 ");
				}
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}


		/// <summary>
		/// 블록 쓰기 테스트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdateBinaryBlocks_Click(object sender, EventArgs e)
		{
			byte byteBlockNumber = this.BlockNumberGet();
			string sData = this.txtUpdateBinary.Text;
			//a타입 기준 1블럭은 16bytes 이다.(ACR122U 기준)
			byte[] byteData_Write
				= Get_Left(ASCIIEncoding.Default.GetBytes(sData), 16);

			if (true == this.m_nfcTest.CardIn())
			{
				if (true == this.m_nfcTest.UpdateBinaryBlocks(
											byteBlockNumber
											, byteData_Write))
				{
					this.LogAdd(String.Format("--- 블록 쓰기({0:X2}) --- 성공"
											, byteBlockNumber));
				}
				else
				{
					this.LogAdd("블록 쓰기 실패 ");
				}
			}
			else
			{
				this.LogAdd("카드를 읽을 수 없습니다.");
			}
		}
		#endregion

		#region Nfc Reader

		private void btnUseBlockSet_Click(object sender, EventArgs e)
		{
			//시작 블록번호 변경
			//this.m_nfc.StartBlockNumberInt = (short)this.numericBlockCount.Value;

			//읽을 블럭 개수
			int nLength = (int)this.numericBlockCount.Value;
		}

		/// <summary>
		/// Nfc Reader - Read Binary
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void btnReadBinary_Click(object sender, EventArgs e)
		{
			this.LogAdd("-- 카드의 지정된 번호 데이터 읽기 시작");
			StringBuilder sb = new StringBuilder();
			foreach (byte itemBlockNum in this.m_nfc.UseDataBlocks)
			{
				//sb.Append(", " + Convert.ToHexString(new byte[] { itemBlockNum }));
			}
			this.LogAdd("지정된 번호 : " + sb.ToString().Substring(1));

			//Task.Run(() => LongCalcAsync(10));

			byte[] byteReturn = await this.m_nfc.ReadBinary();
			if (null == byteReturn
				|| 0 >= byteReturn.Length)
			{//데이터가 없다.
				this.LogAdd("-- 카드의 지정된 범위 데이터 읽기 실패");
			}
			else
			{
				this.LogAdd("-- 카드의 지정된 범위 데이터 읽기 성공");
				//this.LogAdd(Convert.ToHexString(byteReturn));
				this.LogAdd("--  --  --  --  --  --  --  --  --");
				this.LogAdd(ASCIIEncoding.Default.GetString(byteReturn));
				this.LogAdd("--  --  --  --  --  --  --  --  --");
			}
		}


		private async void btnUpdateBinary_Click(object sender, EventArgs e)
		{
			this.LogAdd("-- 카드의 지정된 번호 데이터 쓰기 시작");
			StringBuilder sb = new StringBuilder();
			foreach (byte itemBlockNum in this.m_nfc.UseDataBlocks)
			{
				//sb.Append(", " + Convert.ToHexString(new byte[] { itemBlockNum }));
			}
			this.LogAdd("지정된 번호 : " + sb.ToString().Substring(1));


			byte[] byteData_Write
				= ASCIIEncoding.Default.GetBytes(this.txtNfcReaderData.Text);


			if (false == await this.m_nfc.UpdateBinary(byteData_Write))
			{
				this.LogAdd("-- 카드의 지정된 범위 데이터 쓰기 실패");
			}
			else
			{
				this.LogAdd("-- 카드의 지정된 범위 데이터 쓰기 성공");
			}
		}

		#endregion

		private void comboCardReaderList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (string.Empty != this.m_nfc.ReaderName)
			{
				//this.monitor.ReaderNames
			}

			this.m_nfc.ReaderNameSet(comboCardReaderList.Text);
			this.m_nfcTest.ReaderNameSet(comboCardReaderList.Text);

			if (string.Empty != comboCardReaderList.Text)
			{
				//기존 모니터링 제거
				//monitorFactory.Release(monitor);
				//monitor.StatusChanged -= Monitor_StatusChanged;
				//monitor.Cancel();
				//monitor.Dispose();

				//새 모니터링 작성
				//this.monitor = monitorFactory.Create(SCardScope.System);
				//모니터링 시작
				this.monitor.Start(this.m_nfc.ReaderName);
				//리더기 정보 출력
				//this.btnReadReaderAttr_Click(null, null);

				//this.NfcInfoChanged();
			}
			else
			{
				this.m_nfc.ReaderNameSet(string.Empty);
				this.LogAdd("please Select Reader");
			}

		}


		private void Monitor_StatusChanged(object sender, StatusChangeEventArgs e)
		{
			StringBuilder sbTemp = new StringBuilder();
			StringBuilder sbTemp2 = new StringBuilder();
			sbTemp.Append(">> Status Changed : ");

			if (e.NewState.HasFlag(SCRState.Present))
			{
				sbTemp2.Append(", Card inserted(카드 들어있음)");
			}
			if (e.NewState.HasFlag(SCRState.InUse))
			{
				sbTemp2.Append(", In use(사용중, 공유 모드일 가능성 있음)");
			}
			if (e.NewState.HasFlag(SCRState.Empty))
			{
				sbTemp2.Append(", Card removed(비어 있음)");
			}

			if (0 == sbTemp2.Length)
			{
				sbTemp2.Append(e.NewState);
			}

			this.LogAdd(sbTemp.ToString() + sbTemp2.ToString());
		}

		/// <summary>
		/// 카드리스트 새로고침 버튼
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCardListRefresh_Click(object sender, EventArgs e)
		{
			string[] sNameList = NfcListInfo.ReaderList();

			//기존 리스트를 지우고
			comboCardReaderList.Items.Clear();

			//새 리스트를 만든다.
			foreach (string itemName in sNameList)
			{
				comboCardReaderList.Items.Add(itemName);
				this.LogAdd("find Reader : " + itemName);
			}
		}

		/// <summary>
		/// 왼쪽부터 지정한 길이만큼 데이터를 가지고 온다.
		/// <see href="https://github.com/dang-gun/DGUtility_DotNet/blob/main/DGU_ByteAssist/ByteArray.cs#L144">Get_Left</see>
		/// </summary>
		/// <param name="byteA"></param>
		/// <param name="nLength"></param>
		/// <returns></returns>
		public static byte[] Get_Left(byte[] byteA, int nLength)
		{
			byte[] byteCut = new byte[nLength];

			int nLeng = nLength;
			if (byteA.Length <= nLength)
			{//데이터가 입력된 길이보다 작다.

				//데이터 길이만큼만 사용한다.
				nLeng = byteA.Length;
			}

			Array.Copy(byteA, 0, byteCut, 0, nLeng);

			return byteCut;
		}

		private void tsmiDev_Test_Click(object sender, EventArgs e)
		{

		}

		private void tsmiDev_DeviceCmdJsonSave_Click(object sender, EventArgs e)
		{
			NfcInfoFile nfcInfoFile
				= new NfcInfoFile();

			//nfcInfoFile.FileLoad_CardInfo(@"CardInfo\CardInfo_Mifare1k.json");


			DeviceCommand_JsonModel temp = new DeviceCommand_JsonModel();

			temp.Title = "ARC122U Series";
			temp.KeyStructure = KeyStructure.VolatileMemory;

			//키 불러오기 *************
			temp.Apdu_LoadKey
				= new DeviceCommand_ApduItemModel(IsoCase.Case3Short, SCardProtocol.Any)
				{
					CLA = 0xFF,
					Instruction = InstructionCode.ExternalAuthenticate,
					P1 = (byte)KeyStructure.VolatileMemory,
					P2 = 0x00, // first key slot
					Data = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } // key
				};


			//블록 인증 *************
			temp.GeneralAuthBlock = new GeneralAuthenticate
			{
				Msb = 0x00,
				//블록 위치
				Lsb = 0x08,
				KeyNumber = 0x00,
				KeyType = KeyType.KeyA
			};

			temp.Apdu_AuthBlock
				= new DeviceCommand_ApduItemModel(IsoCase.Case3Short, SCardProtocol.Any)
				{
					CLA = 0xFF,
					Instruction = InstructionCode.InternalAuthenticate,
					P1 = 0x00,
					P2 = 0x00,
					Data = temp.GeneralAuthBlock.ToArray(),
				};



			//블록의 데이터를 읽는다. *************
			temp.Apdu_ReadBinaryBlocks
				= new DeviceCommand_ApduItemModel(IsoCase.Case2Short, SCardProtocol.Any)
				{
					CLA = 0xFF,
					Instruction = InstructionCode.ReadBinary,
					P1 = 0x00,
					//블록 위치
					P2 = 0x08,
					//블록 사이즈
					Le = 16,
				};



			//블록의 데이터를 쓴다. *************
			temp.Apdu_UpdateBinaryBlocks
				= new DeviceCommand_ApduItemModel(IsoCase.Case3Short, SCardProtocol.Any)
				{
					CLA = 0xFF,
					Instruction = InstructionCode.UpdateBinary,
					P1 = 0x00,
					//블록 위치
					P2 = 0x08,
					//기록할 데이터
					Data = new byte[] { 0x0F, 0x0E, 0x0D, 0x0C, 0x0B, 0x0A, 0x09, 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 0x00 }
				};

			nfcInfoFile.Test1(temp);
		}

		#region 메뉴 - Data
		/// <summary>
		/// Device Command Create
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deviceCommandDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (null == this.frmDeviceCommand)
			{
				this.frmDeviceCommand = new DeviceCommandForm();
			}

			this.frmDeviceCommand.Show();
		}

		/// <summary>
		/// Card Info Create
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cardInfoCreateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (null == this.frmCardInfo)
			{
				this.frmCardInfo = new CardInfoForm();
			}

			this.frmCardInfo.Show();
		}
		#endregion

		#region 메뉴 - Nfc Reader

		/// <summary>
		/// 리더기의 연결된 정보를 읽는다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tsmiReaderTransmit_GetData_Click(object sender, EventArgs e)
		{
			using (var context = ContextFactory.Instance.Establish(SCardScope.System))
			{
				using (var rfidReader = context.ConnectReader(
											this.m_nfc.ReaderName
											, SCardShareMode.Shared
											, SCardProtocol.Any))
				{
					var apdu = new CommandApdu(IsoCase.Case2Short, rfidReader.Protocol)
					{
						CLA = 0xFF,
						Instruction = InstructionCode.GetData,
						P1 = 0x00,
						P2 = 0x00,
						Le = 0 // We don't know the ID tag size
					};

					using (rfidReader.Transaction(SCardReaderDisposition.Leave))
					{
						var sendPci = SCardPCI.GetPci(rfidReader.Protocol);
						var receivePci = new SCardPCI(); // IO returned protocol control information.

						var receiveBuffer = new byte[256];
						var command = apdu.ToArray();

						var bytesReceived = rfidReader.Transmit(
							sendPci, // Protocol Control Information (T0, T1 or Raw)
							command, // command APDU
							command.Length,
							receivePci, // returning Protocol Control Information
							receiveBuffer,
							receiveBuffer.Length); // data buffer

						var responseApdu =
							new ResponseApdu(receiveBuffer, bytesReceived, IsoCase.Case2Short, rfidReader.Protocol);

						this.LogAdd(string.Format("SW1: {0:X2}, SW2: {1:X2}\n Uid: {2}"
								, responseApdu.SW1,
							responseApdu.SW2,
							responseApdu.HasData
								? BitConverter.ToString(responseApdu.GetData())
								: "No uid received"));
					}
				}
			}//end using context
		}

		private void tsmiReaderTransmit_SetData_Click(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
