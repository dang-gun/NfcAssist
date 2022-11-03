namespace NfcAssistTest
{
	partial class ApduCommandUC
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboInstruction = new System.Windows.Forms.ComboBox();
			this.comboProtocol = new System.Windows.Forms.ComboBox();
			this.comboIsoCase = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboInstruction
			// 
			this.comboInstruction.FormattingEnabled = true;
			this.comboInstruction.Location = new System.Drawing.Point(109, 87);
			this.comboInstruction.Name = "comboInstruction";
			this.comboInstruction.Size = new System.Drawing.Size(223, 23);
			this.comboInstruction.TabIndex = 5;
			// 
			// comboProtocol
			// 
			this.comboProtocol.FormattingEnabled = true;
			this.comboProtocol.Location = new System.Drawing.Point(109, 29);
			this.comboProtocol.Name = "comboProtocol";
			this.comboProtocol.Size = new System.Drawing.Size(223, 23);
			this.comboProtocol.TabIndex = 5;
			// 
			// comboIsoCase
			// 
			this.comboIsoCase.FormattingEnabled = true;
			this.comboIsoCase.Location = new System.Drawing.Point(109, 3);
			this.comboIsoCase.Name = "comboIsoCase";
			this.comboIsoCase.Size = new System.Drawing.Size(223, 23);
			this.comboIsoCase.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(3, 290);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "P3(byte)";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(3, 261);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "P1P2(int)";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(3, 232);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 4;
			this.label9.Text = "P2(byte)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(3, 203);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "P1(byte)";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(3, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Le(int)";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(3, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "INS(byte)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(3, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Data(byte[])";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(3, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Instruction";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(3, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "CLA(byte)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(3, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Protocol";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "ISO Case";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(109, 290);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(223, 23);
			this.textBox11.TabIndex = 3;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(109, 261);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(223, 23);
			this.textBox10.TabIndex = 3;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(109, 232);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(223, 23);
			this.textBox9.TabIndex = 3;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(109, 203);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(223, 23);
			this.textBox8.TabIndex = 3;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(109, 174);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(223, 23);
			this.textBox7.TabIndex = 3;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(109, 145);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(223, 23);
			this.textBox6.TabIndex = 3;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(109, 116);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(223, 23);
			this.textBox5.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(109, 58);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(223, 23);
			this.textBox3.TabIndex = 3;
			// 
			// ApduCommandUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboInstruction);
			this.Controls.Add(this.comboProtocol);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboIsoCase);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "ApduCommandUC";
			this.Size = new System.Drawing.Size(334, 316);
			this.Load += new System.EventHandler(this.ApduCommandUC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.ComboBox comboInstruction;
		private System.Windows.Forms.ComboBox comboProtocol;
		private System.Windows.Forms.ComboBox comboIsoCase;
	}
}
