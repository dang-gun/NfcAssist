using NfcCardInfo;
using NfcDeviceCommandAssists;
using PCSC;
using PCSC.Iso7816;
using PCSC.Monitoring;
using PcscSharpAssists;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NfcReaderAssists
{
	/// <summary>
	/// 간단하게 Nfc Reader를 사용하기 위해 
	/// </summary>
	public class NfcReader : NfcReaderAssistsBase, IDisposable
	{
		#region 외부로 노출할 이벤트
		/// <summary>
		/// 카드 상태가 변했다.
		/// </summary>
		/// <param name="e"></param>
		public delegate void StatusChangedDelegate(NfcReader sender, StatusChangeEventArgs e);
		/// <summary>
		/// 카드 상태가 변했다.
		/// </summary>
		public event StatusChangedDelegate OnStatusChanged;
		/// <summary>
		/// 카드 상태가 변했음을 외부에 알림
		/// </summary>
		/// <param name="e"></param>
		private void OnStatusChangedCall(StatusChangeEventArgs e)
		{
			if (null != this.OnStatusChanged)
			{
				this.OnStatusChanged(this, e);
			}
		}


		/// <summary>
		/// 들어고/나가고 상태가 변함
		/// </summary>
		/// <param name="e"></param>
		public delegate void CardInOutChangedDelegate(NfcReader sender, bool bCardIn);
		/// <summary>
		/// 들어고/나가고 상태가 변했을때 발생하는 이벤트<br />
		/// 카드가 들어가거나 나갔을때 발생한다.
		/// </summary>
		public event CardInOutChangedDelegate OnCardInOutChanged;
		/// <summary>
		/// 들어고/나가고 상태가 변했음을 외부에 알림
		/// </summary>
		/// <param name="e"></param>
		private void OnCardInOutChangedCall(bool bCardIn)
		{
			if (null != this.OnCardInOutChanged)
			{
				this.OnCardInOutChanged(this, bCardIn);
			}
		}
		#endregion

		/// <summary>
		/// 사용할 블록 지정
		/// <para>사용할 블록은 미리 지정해놓는 것이 좋다.<br />
		/// 사용하려는 블록의 주소나 순서가 바뀌면 인코딩/디코딩이 안될 수 있기 때문이다.</para>
		/// </summary>
		public byte[] UseDataBlocks { get; set; }
				= new byte[] {
					0x04, 0x05, 0x06,//sector 1
					0x08, 0x09, 0x0A,//sector 2
				};

		/// <summary>
		/// 명령어를 연속으로 보낼때 간격(ms)
		/// <para>너무 빨리명령어를 연속으로 보내면 리더기가 처리를 못할수 있으므로
		/// 일정간격을 주고 처리하는데 쓰이는 간격이다.<br />
		/// 직접 테스트해보고 적절한 시간을 찾아서 넣는다.</para>
		/// </summary>
		public int CommandDelay { get; set; } = 500;

		/// <summary>
		/// 모니터링용 개체
		/// </summary>
		private ISCardMonitor nfcMonitor;

		/// <summary>
		/// 카드가 들어있는여부<br />
		/// 내부용으로 카드가 들어있는 이벤트가 여러번 오기 때문에
		/// 한번만 처리하기위한 용도로만 쓰인다.
		/// </summary>
		private bool m_bCardIn = false;

		/// <summary>
		/// 카드 리더기를 초기화 한다.
		/// </summary>
		/// <param name="deviceInfoInterface">초기화에 사용할 디바이스 정보</param>
		/// <param name="cardInfoInterface">초기화에 사용할 카드 정보</param>
		public NfcReader(
				DeviceCommandInterface deviceInfoInterface
				, CardInfoInterface cardInfoInterface)
			: base(deviceInfoInterface
				  , cardInfoInterface)
		{
		}


		/// <summary>
		/// 파괴자
		/// </summary>
		public override void Dispose()
		{
			base.Dispose();
		}

		public override void ReaderNameSet(string sReaderName)
		{
			base.ReaderNameSet(sReaderName);

			//인스턴스 생성
			IMonitorFactory monitorFactory = MonitorFactory.Instance;
			nfcMonitor = monitorFactory.Create(SCardScope.System);
			//이벤트 연결
			nfcMonitor.StatusChanged -= Monitor_StatusChanged;
			nfcMonitor.StatusChanged += Monitor_StatusChanged;


			//모니터링 시작
			this.nfcMonitor.Start(base.ReaderName);
		}

		/// <summary>
		/// 상태 변경 알림
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Monitor_StatusChanged(object sender, StatusChangeEventArgs e)
		{
			this.OnStatusChangedCall(e);

			if (true == e.NewState.HasFlag(SCRState.Present))
			{
				if (false == this.m_bCardIn)
				{
					this.m_bCardIn = true;
					//카드 들어옴 이벤트 알림
					this.OnCardInOutChangedCall(true);
				}
			}
			else if (e.NewState.HasFlag(SCRState.Empty))
			{
				m_bCardIn = false;
				//카드 들어옴 이벤트 알림
				this.OnCardInOutChangedCall(false);
			}

		}

		#region 상태 정보 확인

		/// <summary>
		/// 카드의 상태정보를 받아온다.
		/// </summary>
		/// <returns></returns>
		public byte[] GetStatus()
		{
			byte[] byteReturn = null;

			using (ISCardContext Context1
						= ContextFactory.Instance.Establish(SCardScope.System))
			{
				using (ICardReader reader = Context1.ConnectReader(
										this.ReaderName
										, SCardShareMode.Shared
										, SCardProtocol.Any))
				{
					var status = reader.GetStatus();
					Debug.WriteLine("Reader {0} connected with protocol {1} in state {2}",
						status.GetReaderNames().FirstOrDefault(),
						status.Protocol,
						status.State);
				}
			}

			return byteReturn;
		}


		/// <summary>
		/// 카드의 속성을 가지고 온다.
		/// </summary>
		/// <param name="typeCardAttribute">가지고올 속성 타입</param>
		/// <returns></returns>
		public byte[] CardAttributeGet(SCardAttribute typeCardAttribute)
		{
			byte[] byteReturn = null;

			using (ISCardContext Context1
						= ContextFactory.Instance.Establish(SCardScope.System))
			{
				using (ICardReader reader = Context1.ConnectReader(
										this.ReaderName
										, SCardShareMode.Shared
										, SCardProtocol.Any))
				{
					var cardAtr = reader.GetAttrib(typeCardAttribute);
					byteReturn = cardAtr;
				}
			}

			return byteReturn;
		}


		#endregion


		/// <summary>
		/// 가지고 있는 블록 리스트의 데이터를 순서대로 읽는다.
		/// </summary>
		/// <returns>읽어들인 데이터. null == 오류</returns>
		public async Task<byte[]> ReadBinary()
		{
			bool bSuccess = true;
			List<byte> listByteReturn = new List<byte>();


			if (true == bSuccess)
			{
				if (false == base.CardIn())
				{//카드가 없다.
					Debug.WriteLine("카드를 읽을 수 없습니다.");
					bSuccess = false;
				}
			}
			

			if (true == bSuccess)
			{
				try
				{
					//각 블록에 접근한다.
					foreach (byte itemBlock in this.UseDataBlocks)
					{
						//이 블록의 권한을 얻고
						this.AuthBlock(itemBlock);
						//데이터를 읽는다.
						byte[] byteBinaryBlocksData;
						this.ReadBinaryBlocks(itemBlock, out byteBinaryBlocksData);
						listByteReturn.AddRange(byteBinaryBlocksData);

						//대기
						Task task1 = Task.Run(() => Thread.Sleep(this.CommandDelay));
						await task1;
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine("NfcReader > ReadBinary : "
									+ Environment.NewLine
									+ ex);
					bSuccess = false;
					//비워서 전달
					listByteReturn.Clear();
				}
			}

			if (false == bSuccess)
			{//요청이 실패 했다.

				//가끔 listByteReturn에 찌꺼기가 남아있는 현상이 있어서 방어코드
				//테스트 더 해보고 아니면 제거해도 된다.
				//비워서 전달
				listByteReturn.Clear();
			}

			return listByteReturn.ToArray();
		}


		/// <summary>
		/// 가지고 있는 블록 리스트에 데이터를 순서대로 저장한다.
		/// </summary>
		/// <param name="byteBinaryData"></param>
		/// <returns></returns>
		public async Task<bool> UpdateBinary(byte[] byteBinaryData)
		{
			bool bSuccess = true;

			if (true == bSuccess)
			{
				if (false == base.CardIn())
				{//카드가 없다.
					Debug.WriteLine("카드를 읽을 수 없습니다.");
					bSuccess = false;
				}
			}


			if (true == bSuccess)
			{
				//사용할 수 있는 총 크기를 구한다. = 블럭 1개 크기 * 블럭수
				int nTotalSize = this.UseDataBlocks.Length * this.CardInfo.BlockSize;
				byte[] byteData = new byte[nTotalSize];
				//사용할 크기만큼 복사
				this.Copy_CutAll(ref byteData, byteBinaryData);

				

				try
				{
					int nOffset = 0;

					//각 블록에 접근한다.
					foreach (byte itemBlock in this.UseDataBlocks)
					{
						//이 블록의 권한을 얻고
						this.AuthBlock(itemBlock);

						//원본 데이터에서 필요한 만큼 자른다.
						byte[] byteTemp = new byte[this.CardInfo.BlockSize];
						nOffset
							= ArrayCopyOffset(
								byteData
								, byteTemp
								, nOffset);
						//해당 블록에 작성한다.
						this.UpdateBinaryBlocks(itemBlock, byteTemp);

						//대기
						Task task1 = Task.Run(() => Thread.Sleep(this.CommandDelay));
						await task1;
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine("NfcReader > UpdateBinary : "
									+ Environment.NewLine
									+ ex);
					bSuccess = false;
				}
			}//end if (true == bSuccess)

			return bSuccess;
		}



		/// <summary>
		/// 블록인증을 받는다.
		/// </summary>
		/// <param name="byteBlock">사용할 블록 번호</param>
		/// <returns></returns>
		public bool AuthBlock(byte byteBlock)
		{
			bool bReturn = false;

			//들어온 블록번호가 사용가능한 번호인지 확인한다.
			bool bUseBlock = base.BlockUseCheck(byteBlock);

			if (true == bUseBlock)
			{//사용 가능한 블럭이다

				//진행
				GeneralAuthenticate tempGA = this.DeviceInfo.GeneralAuthBlock;
				tempGA.Lsb = byteBlock;
				CommandApdu cmdAuthBlock = this.DeviceInfo.Apdu_AuthBlock;
				cmdAuthBlock.Data = tempGA.ToArray();

				Response response = base.TransmitThis(cmdAuthBlock);
				bReturn = PcscSharpAssist.IsSuccess(response);
			}


			return bReturn;
		}


		/// <summary>
		/// 지정된 블록의 데이터를 읽는다.
		/// </summary>
		/// <param name="byteBlock">읽을 블록 번호</param>
		/// <param name="byteBinaryBlocksData">읽어들인 데이터</param>
		/// <returns></returns>
		public bool ReadBinaryBlocks(
			byte byteBlock
			, out byte[] byteBinaryBlocksData)
		{
			bool bReturn = false;

			//들어온 블록번호가 사용가능한 번호인지 확인한다.
			bool bUseBlock = base.BlockUseCheck(byteBlock);

			if (true == bUseBlock)
			{//사용 가능한 블럭이다

				//진행
				CommandApdu cmdReadBinaryBlocksCmd = this.DeviceInfo.Apdu_ReadBinaryBlocks;
				cmdReadBinaryBlocksCmd.P2 = byteBlock;
				cmdReadBinaryBlocksCmd.Le = this.CardInfo.BlockSize;


				Response response = base.TransmitThis(cmdReadBinaryBlocksCmd);
				//성공여부
				bReturn = PcscSharpAssist.IsSuccess(response);
				byteBinaryBlocksData = response.GetData();
			}
			else
			{
				byteBinaryBlocksData = new byte[] { };
			}


			return bReturn;
		}


		/// <summary>
		/// 지정된 블록에 데이터를 쓴다.
		/// </summary>
		/// <param name="byteBlock">읽을 블록 번호</param>
		/// <param name="byteBinaryBlocksData">쓸 데이터 데이터</param>
		/// <returns></returns>
		public bool UpdateBinaryBlocks(
			byte byteBlock
			, byte[] byteBinaryBlocksData)
		{
			bool bReturn = false;

			//들어온 블록번호가 사용가능한 번호인지 확인한다.
			bool bUseBlock = base.BlockUseCheck(byteBlock);

			if (true == bUseBlock)
			{//사용 가능한 블럭이다

				//진행
				CommandApdu cmdReadBinaryBlocksCmd = this.DeviceInfo.Apdu_UpdateBinaryBlocks;
				cmdReadBinaryBlocksCmd.P2 = byteBlock;
				cmdReadBinaryBlocksCmd.Data
					= byteBinaryBlocksData;


				Response response = base.TransmitThis(cmdReadBinaryBlocksCmd);
				//성공여부
				bReturn = PcscSharpAssist.IsSuccess(response);
			}

			return bReturn;
		}


		/// <summary>
		/// byteB의 내용을 그대로 byteA로 복사하는데 byteA 크기 만큼만 복사한다.
		/// <see href="https://github.com/dang-gun/DGUtility_DotNet/blob/main/DGU_ByteAssist/ByteArray.cs#L53">Get_Left</see>
		/// </summary>
		/// <param name="byteA"></param>
		/// <param name="byteB"></param>
		/// <returns></returns>
		public void Copy_CutAll(ref byte[] byteA, byte[] byteB)
		{
			int nLength = byteA.Length;
			if (byteA.Length > byteB.Length)
			{
				nLength = byteB.Length;
			}

			Array.Copy(byteB, 0, byteA, 0, nLength);
		}

		/// <summary>
		/// 원본에서 저장할 대상에 크기만큼 복사한후 계산된 위치를 반환한다.
		/// <see href="https://github.com/dang-gun/DGUtility_DotNet/blob/main/DGU_ByteAssist/ByteArray.cs#L168">Get_Left</see>
		/// </summary>
		/// <param name="byteOriginal">원본</param>
		/// <param name="byteStorage">저장할 대상</param>
		/// <param name="nOffsetStart">오프셋 시작</param>
		/// <returns>이동이 끝나 다시 계산된 오프셋시작 위치</returns>
		public static int ArrayCopyOffset(
			byte[] byteOriginal
			, byte[] byteStorage
			, int nOffsetStart)
		{
			Array.Copy(byteOriginal, nOffsetStart, byteStorage, 0, byteStorage.Length);

			//오프셋 스타트지점에서 사용한 만큼 더해서 리턴한다.
			return nOffsetStart + byteStorage.Length;
		}
	}
}
