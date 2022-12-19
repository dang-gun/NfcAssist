using NfcAssist;
using NfcCardInfo;
using NfcDeviceCommandAssists;
using PCSC;
using PCSC.Monitoring;
using PcscSharpAssists;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace NfcReaderChecker
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

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

		IMonitorFactory monitorFactory;


		public List<NfcReaderItemUC> NfcReaderList
			= new List<NfcReaderItemUC>();

		public MainWindow()
		{
			InitializeComponent();

			//json 파일 로드
			NfcInfoFile nfcInfoFile = new NfcInfoFile();
			this.CardInfoList
				= nfcInfoFile.FolderLoad_CardInfo(@"CardInfo");
			this.DeviceCommandList
				= nfcInfoFile.FolderLoad_DeviceCommand(@"DeviceCommand");


			//인스턴스 생성
			monitorFactory = MonitorFactory.Instance;
			//monitor = monitorFactory.Create(SCardScope.System);

		}

		/// <summary>
		/// 컨텐츠 랜더링이 끝나고 동작
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_ContentRendered(object sender, EventArgs e)
		{
			this.Button_Click(null, null);
		}

		private void Button_Click(object? sender, RoutedEventArgs? e)
		{
			string[] sNameList = NfcListInfo.ReaderList();

			//기존 리스트를 지우고
			this.NfcReaderList.Clear();
			this.spNfcList.Children.Clear();

			
			//새 리스트를 만든다.
			foreach (string itemName in sNameList)
			{
				NfcReaderItemUC newItem = new NfcReaderItemUC();
				newItem.NameSet(itemName);

				//모니터링 세팅
				//newItem.CardMonitorSet( monitorFactory.Create(SCardScope.System));
				
				

				this.NfcReaderList.Add(newItem);
				this.spNfcList.Children.Add(newItem);
			}

			
		}

		
	}
}
