using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcCardInfo
{
	/// <summary>
	/// 비어있는 더미
	/// </summary>
	public class CardInfo_Dummy : CardInfoInterface
	{
		/// <summary>
		/// 외부로 노출시킬 제목
		/// </summary>
		public string Title { get; set; } = "Dummy";

		/// <summary>
		/// 데이터로 사용가능한 블럭 주소
		/// <para>꼭 주소 순서대로 넣어야 한다.<br />
		/// 그래야 특정번호를 기준으로 데이터를 읽고/쓰고 하는
		/// 상대주소 처리가 가능하다.</para>
		/// </summary>
		public byte[] DataBlocks { get; set; }
				= new byte[] { 
					0x00
				};

		/// <summary>
		/// 꼬리 블럭으로 사용되서 사용할수 없는 블럭 주소
		/// </summary>
		public byte[] TrailerBlocks { get; set; }
				= new byte[] {
					0x00,
				};

		/// <summary>
		/// 블록하나가 가지고 있는 바이트(byte) 개수
		/// </summary>
		public int BlockSize { get; set; } = 0;

	}
}
