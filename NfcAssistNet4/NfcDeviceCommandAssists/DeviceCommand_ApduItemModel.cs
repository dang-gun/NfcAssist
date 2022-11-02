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
	/// APDU 아이템 바인딩용 모델
	/// </summary>
	/// <remarks>
	/// json 파일을 바인딩할때와 같은 상황에서 사용한다.<br />
	/// 모든 값은 최소값으로 초기화 된다.
	/// </remarks>
	public class DeviceCommand_ApduItemModel
	{
		/// <summary>
		/// The ISO case to use.
		/// </summary>
		public IsoCase isoCase { get; set; } = IsoCase.Case1;
		/// <summary>
		/// The protocol.
		/// </summary>
		public SCardProtocol protocol { get; set; } = SCardProtocol.Any;

		/// <summary>
		/// Gets or sets the CLA byte.
		/// </summary>
		public byte? CLA { get; set; } = null;

		/// <summary>
		/// Sets the instruction.
		/// </summary>
		public InstructionCode? Instruction { get; set; } = null;

		/// <summary>
		/// Command APDU data to be transmitted.
		/// </summary>
		public byte[] Data { get; set; } = new byte[0];

		/// <summary>
		/// Gets or sets the instruction.
		/// </summary>
		public byte? INS { get; set; } = null;

		/// <summary>
		/// Length expected.
		/// </summary>
		public int? Le { get; set; } = null;

		/// <summary>
		/// The first parameter (P1)
		/// </summary>
		public byte? P1 { get; set; } = null;

		/// <summary>
		/// The second parameter (P2)
		/// </summary>
		public byte? P2 { get; set; } = null;

		/// <summary>
		/// A combination of parameter P1 and P2
		/// </summary>
		public int? P1P2 { get; set; } = null;
		/// <summary>
		/// The third parameter (P3 or Le)
		/// </summary>
		public byte? P3 { get; set; } = null;

		public DeviceCommand_ApduItemModel()
		{
		}

		public DeviceCommand_ApduItemModel(IsoCase isoCase, SCardProtocol protocol)
		{
			this.isoCase = isoCase;
			this.protocol = protocol;
		}
	}
}
