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
            label1 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            apduCommanduc1 = new ApduCommandUC();
            tabPage2 = new System.Windows.Forms.TabPage();
            apduCommanduc2 = new ApduCommandUC();
            tabPage3 = new System.Windows.Forms.TabPage();
            comboInstruction = new System.Windows.Forms.ComboBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tabPage4 = new System.Windows.Forms.TabPage();
            apduCommanduc5 = new ApduCommandUC();
            tabPage5 = new System.Windows.Forms.TabPage();
            apduCommanduc4 = new ApduCommandUC();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 23);
            label1.TabIndex = 4;
            label1.Text = "Title";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(134, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(223, 23);
            txtTitle.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(134, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(223, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 23);
            label2.TabIndex = 4;
            label2.Text = "Key Structure";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.HotTrack = true;
            tabControl1.Location = new System.Drawing.Point(15, 70);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(352, 378);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(apduCommanduc1);
            tabPage1.Location = new System.Drawing.Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(344, 330);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Load Key";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // apduCommanduc1
            // 
            apduCommanduc1.Location = new System.Drawing.Point(5, 6);
            apduCommanduc1.Name = "apduCommanduc1";
            apduCommanduc1.Size = new System.Drawing.Size(345, 322);
            apduCommanduc1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(apduCommanduc2);
            tabPage2.Location = new System.Drawing.Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(344, 330);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Auth block";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // apduCommanduc2
            // 
            apduCommanduc2.Location = new System.Drawing.Point(0, 4);
            apduCommanduc2.Name = "apduCommanduc2";
            apduCommanduc2.Size = new System.Drawing.Size(345, 322);
            apduCommanduc2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboInstruction);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new System.Drawing.Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(344, 330);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "General Auth Block";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboInstruction
            // 
            comboInstruction.FormattingEnabled = true;
            comboInstruction.Location = new System.Drawing.Point(115, 99);
            comboInstruction.Name = "comboInstruction";
            comboInstruction.Size = new System.Drawing.Size(223, 23);
            comboInstruction.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(115, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(223, 23);
            textBox6.TabIndex = 3;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(-11, 128);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 49);
            label7.TabIndex = 4;
            label7.Text = "Key Number (byte)";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(-11, 99);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 23);
            label6.TabIndex = 4;
            label6.Text = "Key Type";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(115, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(223, 23);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(-11, 70);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 23);
            label5.TabIndex = 4;
            label5.Text = "Lsb(byte)";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(115, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(223, 23);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(-11, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 23);
            label4.TabIndex = 4;
            label4.Text = "Msb(byte)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(115, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(223, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(-11, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 23);
            label3.TabIndex = 4;
            label3.Text = "Version(byte)";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(apduCommanduc5);
            tabPage4.Location = new System.Drawing.Point(4, 44);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(344, 330);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Read Binary Blocks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // apduCommanduc5
            // 
            apduCommanduc5.Location = new System.Drawing.Point(0, 4);
            apduCommanduc5.Name = "apduCommanduc5";
            apduCommanduc5.Size = new System.Drawing.Size(345, 322);
            apduCommanduc5.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(apduCommanduc4);
            tabPage5.Location = new System.Drawing.Point(4, 44);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new System.Drawing.Size(344, 330);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Update Binary Blocks";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // apduCommanduc4
            // 
            apduCommanduc4.Location = new System.Drawing.Point(0, 4);
            apduCommanduc4.Name = "apduCommanduc4";
            apduCommanduc4.Size = new System.Drawing.Size(345, 322);
            apduCommanduc4.TabIndex = 1;
            // 
            // DeviceCommandForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(397, 459);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtTitle);
            Name = "DeviceCommandForm";
            Text = "Device Command Create";
            FormClosed += DeviceCommandForm_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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