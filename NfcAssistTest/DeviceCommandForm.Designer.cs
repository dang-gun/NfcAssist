namespace NfcAssistTest
{
	partial class DeviceCommandForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.apduCommanduc1 = new NfcAssistTest.ApduCommandUC();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.apduCommanduc2 = new NfcAssistTest.ApduCommandUC();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.comboInstruction = new System.Windows.Forms.ComboBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.apduCommanduc5 = new NfcAssistTest.ApduCommandUC();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.apduCommanduc4 = new NfcAssistTest.ApduCommandUC();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Title";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(134, 12);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(223, 23);
			this.txtTitle.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(134, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(223, 23);
			this.textBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(8, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Key Structure";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.HotTrack = true;
			this.tabControl1.Location = new System.Drawing.Point(15, 70);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(352, 378);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.apduCommanduc1);
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(344, 330);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Load Key";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// apduCommanduc1
			// 
			this.apduCommanduc1.Location = new System.Drawing.Point(5, 6);
			this.apduCommanduc1.Name = "apduCommanduc1";
			this.apduCommanduc1.Size = new System.Drawing.Size(345, 322);
			this.apduCommanduc1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.apduCommanduc2);
			this.tabPage2.Location = new System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(344, 330);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Auth block";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// apduCommanduc2
			// 
			this.apduCommanduc2.Location = new System.Drawing.Point(0, 4);
			this.apduCommanduc2.Name = "apduCommanduc2";
			this.apduCommanduc2.Size = new System.Drawing.Size(345, 322);
			this.apduCommanduc2.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.comboInstruction);
			this.tabPage3.Controls.Add(this.textBox6);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.textBox2);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(344, 330);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "General Auth Block";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// comboInstruction
			// 
			this.comboInstruction.FormattingEnabled = true;
			this.comboInstruction.Location = new System.Drawing.Point(115, 99);
			this.comboInstruction.Name = "comboInstruction";
			this.comboInstruction.Size = new System.Drawing.Size(223, 23);
			this.comboInstruction.TabIndex = 6;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(115, 128);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(223, 23);
			this.textBox6.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(-11, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 49);
			this.label7.TabIndex = 4;
			this.label7.Text = "Key Number (byte)";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(-11, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Key Type";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(115, 70);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(223, 23);
			this.textBox4.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(-11, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Lsb(byte)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(115, 41);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(223, 23);
			this.textBox3.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(-11, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Msb(byte)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(115, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(223, 23);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(-11, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Version(byte)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.apduCommanduc5);
			this.tabPage4.Location = new System.Drawing.Point(4, 44);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(344, 330);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Read Binary Blocks";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// apduCommanduc5
			// 
			this.apduCommanduc5.Location = new System.Drawing.Point(0, 4);
			this.apduCommanduc5.Name = "apduCommanduc5";
			this.apduCommanduc5.Size = new System.Drawing.Size(345, 322);
			this.apduCommanduc5.TabIndex = 1;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.apduCommanduc4);
			this.tabPage5.Location = new System.Drawing.Point(4, 44);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(344, 330);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Update Binary Blocks";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// apduCommanduc4
			// 
			this.apduCommanduc4.Location = new System.Drawing.Point(0, 4);
			this.apduCommanduc4.Name = "apduCommanduc4";
			this.apduCommanduc4.Size = new System.Drawing.Size(345, 322);
			this.apduCommanduc4.TabIndex = 1;
			// 
			// DeviceCommandForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 459);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtTitle);
			this.Name = "DeviceCommandForm";
			this.Text = "Device Command Create";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private ApduCommandUC apduCommanduc1;
		private ApduCommandUC apduCommanduc2;
		private ApduCommandUC apduCommanduc5;
		private ApduCommandUC apduCommanduc4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboInstruction;
	}
}