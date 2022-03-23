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
	/// 비어있는 더미
	/// </summary>
	public class DeviceCmd_Dummy : DeviceCommandInterface
	{
		/// <summary>
		/// 외부로 노출시킬 제목
		/// </summary>
		public string Title { get; set; } = "Dummy";

		/// <summary>
		/// ARC122U시리즈는 Volatile Memory(0x00)만 사용가능한다.
		/// </summary>
		public KeyStructure KeyStructure { get; set; }

		/// <summary>
		/// APDU 명령 - LoadKey
		/// </summary>
		public CommandApdu Apdu_LoadKey { get; set; }

		
		/// <summary>
		/// APDU 명령 - Authentication Block
		/// <para>사용할 블록을 인증한다.</para>
		/// </summary>
		public CommandApdu Apdu_AuthBlock { get; set; }

		/// <summary>
		/// APDU 블록 인증에 사용될 정보
		/// </summary>
		public GeneralAuthenticate GeneralAuthBlock { get; set; }

		/// <summary>
		/// APDU 명령 - Read Binary Blocks
		/// <para>인증 받은 블록의 내용을 읽는다.</para>
		/// </summary>
		public CommandApdu Apdu_ReadBinaryBlocks { get; set; }

		/// <summary>
		/// APDU 명령 - Update Binary Blocks
		/// <para>인증 받은 블록의 내용을 읽는다.</para>
		/// </summary>
		public CommandApdu Apdu_UpdateBinaryBlocks { get; set; }

		public DeviceCmd_Dummy()
		{
			//키 불러오기 *************
			this.Apdu_LoadKey
				= new CommandApdu(IsoCase.Case3Short, SCardProtocol.Any);


			//블록 인증 *************
			this.GeneralAuthBlock = new GeneralAuthenticate();

			this.Apdu_AuthBlock
				= new CommandApdu(IsoCase.Case3Short, SCardProtocol.Any);


			//블록의 데이터를 읽는다. *************
			this.Apdu_ReadBinaryBlocks
				= new CommandApdu(IsoCase.Case2Short, SCardProtocol.Any);


			//블록의 데이터를 쓴다. *************
			this.Apdu_UpdateBinaryBlocks
				= new CommandApdu(IsoCase.Case3Short, SCardProtocol.Any);
		}
	}
}
