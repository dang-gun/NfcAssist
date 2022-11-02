using Newtonsoft.Json;
using NfcCardInfo;
using NfcDeviceCommandAssists;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcAssist
{
	/// <summary>
	/// 파일 처리를 위한 클래스
	/// </summary>
	public class NfcInfoFile
	{

		/// <summary>
		/// 
		/// </summary>
		public NfcInfoFile()
		{
		}

		/// <summary>
		/// 폴더 읽기 - 카드 정보
		/// </summary>
		/// <param name="sNfcCardInfoFolderDir"></param>
		/// <returns></returns>
		public List<CardInfoInterface> FolderLoad_CardInfo(
			string sNfcCardInfoFolderDir)
		{
			List<CardInfoInterface> listReturn = new List<CardInfoInterface>();

			try
			{
				//폴더 안의 파일 읽기
				string[] listFilesDir =	Directory.GetFiles(sNfcCardInfoFolderDir);
				foreach (string itemFile in listFilesDir)
				{
					CardInfoInterface temp = this.FileLoad_CardInfo(itemFile);
					if (null != temp)
					{
						listReturn.Add(temp);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("FolderLoad_CardInfo({0}) : {1}"
					, sNfcCardInfoFolderDir
					, ex.ToString());
			}

			return listReturn;
		}

		/// <summary>
		/// 파일 읽기 - 카드 정보
		/// </summary>
		/// <param name="sNfcCardInfoFileDir">사용할 NFC 카드 정보를 가지고 있는 파일의 경로</param>
		/// <returns></returns>
		public CardInfoInterface FileLoad_CardInfo(string sNfcCardInfoFileDir)
		{
			CardInfo_Dummy loadCI = null;

			try
			{
				//파일 읽기
				string sJson = File.ReadAllText(sNfcCardInfoFileDir);
				//json문자열을 모델로 변환
				loadCI = JsonConvert.DeserializeObject<CardInfo_Dummy>(sJson);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("FileLoad_CardInfo({0}) : {1}"
					, sNfcCardInfoFileDir 
					, ex.ToString());
			}
			
			return loadCI;
		}

		/// <summary>
		/// 폴더 읽기 - 장치 명령
		/// </summary>
		/// <param name="sNfcDeviceCommandFolderDir"></param>
		/// <returns></returns>
		public List<DeviceCommandInterface> FolderLoad_DeviceCommand(
			string sNfcDeviceCommandFolderDir)
		{
			List<DeviceCommandInterface> listReturn = new List<DeviceCommandInterface>();

			try
			{
				//폴더 안의 파일 읽기
				string[] listFilesDir = Directory.GetFiles(sNfcDeviceCommandFolderDir);
				foreach (string itemFile in listFilesDir)
				{
					DeviceCommandInterface temp = this.FileLoad_DeviceCommand(itemFile);
					if (null != temp)
					{
						listReturn.Add(temp);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("FolderLoad_DeviceCommand({0}) : {1}"
					, sNfcDeviceCommandFolderDir
					, ex.ToString());
			}

			return listReturn;
		}


		/// <summary>
		/// 파일 읽기 - 장치 명령
		/// </summary>
		/// <param name="sNfcDeviceCommandFileDir">사용할 NFC 장치 정보를 가지고 있는 파일의 경로</param>
		/// <returns></returns>
		public DeviceCommandInterface FileLoad_DeviceCommand(string sNfcDeviceCommandFileDir)
		{
			DeviceCommandInterface loadDC = null;

			try
			{
				//파일 읽기
				string sJson = File.ReadAllText(sNfcDeviceCommandFileDir);
				//json문자열을 모델로 변환
				DeviceCommand_JsonModel loadDCS
					= JsonConvert.DeserializeObject<DeviceCommand_JsonModel>(sJson);

				if (null != loadDCS)
				{
					loadDC = loadDCS.ToInterface();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("FileLoad_DeviceCommand({0}) : {1}"
					, sNfcDeviceCommandFileDir
					, ex.ToString());

				loadDC = null;
			}

			return loadDC;
		}


		public void Test1(DeviceCommand_JsonModel s)
		{
			string sJson = JsonConvert.SerializeObject(s);
			File.WriteAllText("temp.json", sJson);
		}
	}
}
