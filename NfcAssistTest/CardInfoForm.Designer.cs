namespace NfcAssistTest
{
	partial class CardInfoForm
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
            button1 = new System.Windows.Forms.Button();
            txtTitle = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDataBlocks = new System.Windows.Forms.TextBox();
            txtTrailerBlocks = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(437, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(157, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(223, 23);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 23);
            label1.TabIndex = 2;
            label1.Text = "Title";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Data Blocks";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 237);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 23);
            label3.TabIndex = 2;
            label3.Text = "Trailer Blocks";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataBlocks
            // 
            txtDataBlocks.Location = new System.Drawing.Point(12, 58);
            txtDataBlocks.Multiline = true;
            txtDataBlocks.Name = "txtDataBlocks";
            txtDataBlocks.Size = new System.Drawing.Size(500, 160);
            txtDataBlocks.TabIndex = 1;
            // 
            // txtTrailerBlocks
            // 
            txtTrailerBlocks.Location = new System.Drawing.Point(12, 263);
            txtTrailerBlocks.Multiline = true;
            txtTrailerBlocks.Name = "txtTrailerBlocks";
            txtTrailerBlocks.Size = new System.Drawing.Size(500, 160);
            txtTrailerBlocks.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 438);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 23);
            label4.TabIndex = 2;
            label4.Text = "Block Size";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(157, 438);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(32, 23);
            textBox4.TabIndex = 1;
            textBox4.Text = "0";
            textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CardInfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 478);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTrailerBlocks);
            Controls.Add(txtDataBlocks);
            Controls.Add(textBox4);
            Controls.Add(txtTitle);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardInfoForm";
            Text = "Card Info Create";
            FormClosed += CardInfoForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDataBlocks;
		private System.Windows.Forms.TextBox txtTrailerBlocks;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
	}
}