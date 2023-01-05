using NfcCardInfo;
using NfcDeviceCommandAssists;
using NfcReaderAssists;
using PcscSharpAssists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NfcAssistTest4_Net5
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// 디바이스와 카드정보를 이용하여 생성한 NFC 리더 지원 개체
		/// </summary>
		NfcReader m_nfc;

		public Form1()
		{
			InitializeComponent();

			this.m_nfc
				= new NfcReader(
						new DeviceCmd_Dummy()
						, new CardInfo_Dummy());

			string[] sNameList = NfcListInfo.ReaderList();
			Debug.WriteLine(sNameList.Length);
			if (sNameList.Length == 12)
			{
			}
		}

	}
}
