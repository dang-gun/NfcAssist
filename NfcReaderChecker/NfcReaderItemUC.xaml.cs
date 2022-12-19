using NfcCardInfo;
using NfcDeviceCommandAssists;
using NfcReaderAssists;
using PCSC;
using PCSC.Monitoring;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NfcReaderChecker
{
    /// <summary>
    /// NfcReaderItemUC.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NfcReaderItemUC : UserControl
    {
		private NfcReader m_nfc;

		private ISCardMonitor? monitor;

		public NfcReaderItemUC()
        {
            InitializeComponent();

			if (null != this.m_nfc)
			{//아직 개체가 남아있으면

				//이벤트 해제
				this.m_nfc.OnCardInOutChanged -= M_nfc_OnCardInOutChanged;
			}

			//NFC 개체 초기화
			this.m_nfc
				= new NfcReader(
						new DeviceCmd_Dummy()
						, new CardInfo_Dummy());
		}

        public NfcReaderItemUC(
			DeviceCommandInterface deviceCommand
            , CardInfoInterface cardInfo)
        {
			InitializeComponent();

			try
			{
				//NFC 개체 초기화
				this.m_nfc
					= new NfcReader(
						deviceCommand
						, cardInfo);

			}
			catch (Exception ex)
			{
				Debug.WriteLine("※※※※※※ " + ex.ToString());

				if (null != this.m_nfc)
				{//아직 개체가 남아있으면

					//이벤트 해제
					this.m_nfc.OnCardInOutChanged -= M_nfc_OnCardInOutChanged;
				}


				//에러나면 데미로 초기화
				this.m_nfc
					= new NfcReader(
							new DeviceCmd_Dummy()
							, new CardInfo_Dummy());
			}
            
		}

		private void M_nfc_OnCardInOutChanged(NfcReader sender, bool bCardIn)
		{
			if (true == Dispatcher.CheckAccess())
			{//내 쓰래드다.
				this.CardInOutView(bCardIn);
			}
			else
			{//내 쓰래드가 아니다.
				Dispatcher.Invoke(DispatcherPriority.Normal
					, new Action(
						delegate
						{
							//사용할 메서드 및 동작
							this.CardInOutView(bCardIn);
						}));
			}

			
		}

		private void CardInOutView(bool bCardIn)
		{
			if (true == bCardIn)
			{
				this.labStatus.Content = "Card In";
				this.labStatus.Background = Brushes.SkyBlue;
				Debug.WriteLine("Card In");
			}
			else
			{
				this.labStatus.Content = "Card Out";
				this.labStatus.Background = Brushes.White;
				Debug.WriteLine("Card Out");
			}
		}

		string ReaderName = string.Empty;
		public void NameSet(string sName)
		{
			this.ReaderName = sName;
			this.txtViewName.Text = sName;

			this.m_nfc.ReaderNameSet(this.ReaderName);

			this.m_nfc.OnCardInOutChanged -= M_nfc_OnCardInOutChanged;
			this.m_nfc.OnCardInOutChanged += M_nfc_OnCardInOutChanged;
		}


		public void CardMonitorSet(ISCardMonitor monitor)
		{
			this.monitor = monitor;
			//이벤트 연결
			this.monitor.StatusChanged -= Monitor_StatusChanged;
			this.monitor.StatusChanged += Monitor_StatusChanged;

			this.monitor.Start(this.ReaderName);
		}

		private void Monitor_StatusChanged(object sender, StatusChangeEventArgs e)
		{
			StringBuilder sbTemp = new StringBuilder();
			StringBuilder sbTemp2 = new StringBuilder();
			sbTemp.Append(">> Status Changed("+ this.ReaderName + ") : ");

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

			Debug.WriteLine(sbTemp.ToString() + sbTemp2.ToString());
		}

		private void btnCopyClipboard_Click(object sender, RoutedEventArgs e)
		{
			//클립보드에 텍스트 복사
			Clipboard.SetText(this.txtViewName.Text);
		}
	}
}
