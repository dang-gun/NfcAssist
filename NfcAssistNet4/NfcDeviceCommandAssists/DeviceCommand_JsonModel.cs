using PCSC;
using PCSC.Iso7816;
using PcscSharpAssists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcDeviceCommandAssists
{
	/// <summary>
	/// 설정파일 같은 문자열을 장치 명령으로 변환하기위한 모델
	/// </summary>
	public class DeviceCommand_JsonModel
	{
		/// <summary>
		/// 외부로 노출시킬 제목
		/// </summary>
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Key Structure
		/// </summary>
		public KeyStructure KeyStructure { get; set; } 
			= KeyStructure.NonVolatileMemory;

		/// <summary>
		/// APDU 명령 - LoadKey
		/// <para>인증키를 불러온다.</para>
		/// </summary>
		public DeviceCommand_ApduItemModel Apdu_LoadKey { get; set; }
			= new DeviceCommand_ApduItemModel();

		/// <summary>
		/// APDU 명령 - Authentication Block
		/// <para>사용할 블록을 인증한다.</para>
		/// </summary>
		public DeviceCommand_ApduItemModel Apdu_AuthBlock { get; set; }
			= new DeviceCommand_ApduItemModel();

		/// <summary>
		/// APDU 블록 인증에 사용될 정보
		/// </summary>
		public GeneralAuthenticate GeneralAuthBlock { get; set; }
			= new GeneralAuthenticate();


		/// <summary>
		/// APDU 명령 - Read Binary Blocks
		/// <para>인증 받은 블록의 내용을 읽는다.</para>
		/// </summary>
		public DeviceCommand_ApduItemModel Apdu_ReadBinaryBlocks { get; set; }
			= new DeviceCommand_ApduItemModel();

		/// <summary>
		/// APDU 명령 - Update Binary Blocks
		/// <para>인증 받은 블록의 내용을 읽는다.</para>
		/// </summary>
		public DeviceCommand_ApduItemModel Apdu_UpdateBinaryBlocks { get; set; }
			= new DeviceCommand_ApduItemModel();

		public DeviceCommandInterface ToInterface()
		{
			return this.ToInterface(this);
		}

		/// <summary>
		/// 문자열로된 장치명령을 
		/// </summary>
		/// <param name="deviceCommandStringModel"></param>
		/// <returns></returns>
		public DeviceCommandInterface ToInterface(
			DeviceCommand_JsonModel deviceCommandStringModel)
		{
			DeviceCmd_Dummy dcRetrun = new DeviceCmd_Dummy();
			dcRetrun.Title = deviceCommandStringModel.Title;

			dcRetrun.KeyStructure
				= deviceCommandStringModel.KeyStructure;

			dcRetrun.Apdu_LoadKey
				= this.ToCommandApdu(deviceCommandStringModel.Apdu_LoadKey);
			dcRetrun.Apdu_AuthBlock
				= this.ToCommandApdu(deviceCommandStringModel.Apdu_AuthBlock);
			dcRetrun.GeneralAuthBlock
				= deviceCommandStringModel.GeneralAuthBlock;
			dcRetrun.Apdu_ReadBinaryBlocks
				= this.ToCommandApdu(deviceCommandStringModel.Apdu_ReadBinaryBlocks);
			dcRetrun.Apdu_UpdateBinaryBlocks
				= this.ToCommandApdu(deviceCommandStringModel.Apdu_UpdateBinaryBlocks);


			return dcRetrun;
		}

		public CommandApdu ToCommandApdu(DeviceCommand_ApduItemModel dcApduItem)
		{
			CommandApdu apduReturn
				= new CommandApdu(dcApduItem.isoCase, dcApduItem.protocol);

			if (null != dcApduItem.CLA)
			{
				apduReturn.CLA = (byte)dcApduItem.CLA;
			}

			if (null != dcApduItem.Instruction)
			{
				apduReturn.Instruction = (InstructionCode)dcApduItem.Instruction;
			}

			if (0 != dcApduItem.Data.Length)
			{
				apduReturn.Data = dcApduItem.Data;
			}

			if (null != dcApduItem.INS)
			{
				apduReturn.INS = (byte)dcApduItem.INS;
			}

			if (null != dcApduItem.Le)
			{
				apduReturn.Le = (int)dcApduItem.Le;
			}

			if (null != dcApduItem.P1)
			{
				apduReturn.P1 = (byte)dcApduItem.P1;
			}

			if (null != dcApduItem.P2)
			{
				apduReturn.P2 = (byte)dcApduItem.P2;
			}

			if (null != dcApduItem.P1P2)
			{
				apduReturn.P1P2 = (int)dcApduItem.P1P2;
			}

			if (null != dcApduItem.P3)
			{
				apduReturn.P3 = (byte)dcApduItem.P3;
			}

			return apduReturn;
		}


	}
}
