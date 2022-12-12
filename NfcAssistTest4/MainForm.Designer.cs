namespace NfcAssistTest4
{
	partial class MainForm
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

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Form1
			// 
			this.comboCardReaderList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCardListRefresh = new System.Windows.Forms.Button();
			this.listLog = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.txtUpdateBinary = new System.Windows.Forms.TextBox();
			this.labInfo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericBlockNumber = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnGetStatus = new System.Windows.Forms.Button();
			this.btnGetArt = new System.Windows.Forms.Button();
			this.btnUpdateBinaryBlocks = new System.Windows.Forms.Button();
			this.btnReadBinaryBlocks = new System.Windows.Forms.Button();
			this.btnAuthBlock = new System.Windows.Forms.Button();
			this.btnLoadKey = new System.Windows.Forms.Button();
			this.listviewDevice = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.listviewCard = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNfcReaderData = new System.Windows.Forms.TextBox();
			this.btnUpdateBinary = new System.Windows.Forms.Button();
			this.btnUseBlockSet = new System.Windows.Forms.Button();
			this.btnReadBinary = new System.Windows.Forms.Button();
			this.numericBlockCount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numericStartBlock = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReaderTransmit_GetData = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReaderTransmit_SetData = new System.Windows.Forms.ToolStripMenuItem();
			this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deviceCommandDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cardInfoCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDev_Test = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDev_DeviceCmdJsonSave = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.numericBlockNumber)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBlockCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericStartBlock)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboCardReaderList
			// 
			this.comboCardReaderList.FormattingEnabled = true;
			this.comboCardReaderList.Location = new System.Drawing.Point(118, 29);
			this.comboCardReaderList.Name = "comboCardReaderList";
			this.comboCardReaderList.Size = new System.Drawing.Size(471, 23);
			this.comboCardReaderList.TabIndex = 0;
			this.comboCardReaderList.SelectedIndexChanged += new System.EventHandler(this.comboCardReaderList_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Card Reader List";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCardListRefresh
			// 
			this.btnCardListRefresh.Location = new System.Drawing.Point(597, 29);
			this.btnCardListRefresh.Name = "btnCardListRefresh";
			this.btnCardListRefresh.Size = new System.Drawing.Size(100, 23);
			this.btnCardListRefresh.TabIndex = 2;
			this.btnCardListRefresh.Text = "Refresh";
			this.btnCardListRefresh.UseVisualStyleBackColor = true;
			this.btnCardListRefresh.Click += new System.EventHandler(this.btnCardListRefresh_Click);
			// 
			// listLog
			// 
			this.listLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2});
			this.listLog.HideSelection = false;
			this.listLog.Location = new System.Drawing.Point(12, 247);
			this.listLog.Name = "listLog";
			this.listLog.Size = new System.Drawing.Size(692, 342);
			this.listLog.TabIndex = 3;
			this.listLog.UseCompatibleStateImageBehavior = false;
			this.listLog.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Time";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Contents";
			this.columnHeader2.Width = 580;
			// 
			// txtUpdateBinary
			// 
			this.txtUpdateBinary.Location = new System.Drawing.Point(172, 137);
			this.txtUpdateBinary.Name = "txtUpdateBinary";
			this.txtUpdateBinary.Size = new System.Drawing.Size(160, 23);
			this.txtUpdateBinary.TabIndex = 11;
			// 
			// labInfo
			// 
			this.labInfo.Location = new System.Drawing.Point(6, 108);
			this.labInfo.Name = "labInfo";
			this.labInfo.Size = new System.Drawing.Size(160, 52);
			this.labInfo.TabIndex = 10;
			this.labInfo.Text = "Card List";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(172, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Use Block";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericBlockNumber
			// 
			this.numericBlockNumber.Location = new System.Drawing.Point(278, 23);
			this.numericBlockNumber.Name = "numericBlockNumber";
			this.numericBlockNumber.Size = new System.Drawing.Size(54, 23);
			this.numericBlockNumber.TabIndex = 0;
			this.numericBlockNumber.Value = new decimal(new int[] {
			8,
			0,
			0,
			0});
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnGetStatus);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.labInfo);
			this.groupBox3.Controls.Add(this.btnGetArt);
			this.groupBox3.Controls.Add(this.numericBlockNumber);
			this.groupBox3.Controls.Add(this.txtUpdateBinary);
			this.groupBox3.Controls.Add(this.btnUpdateBinaryBlocks);
			this.groupBox3.Controls.Add(this.btnReadBinaryBlocks);
			this.groupBox3.Controls.Add(this.btnAuthBlock);
			this.groupBox3.Controls.Add(this.btnLoadKey);
			this.groupBox3.Location = new System.Drawing.Point(195, 58);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(336, 175);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Card Test";
			// 
			// btnGetStatus
			// 
			this.btnGetStatus.Location = new System.Drawing.Point(6, 21);
			this.btnGetStatus.Name = "btnGetStatus";
			this.btnGetStatus.Size = new System.Drawing.Size(160, 23);
			this.btnGetStatus.TabIndex = 14;
			this.btnGetStatus.Text = "Get Status";
			this.btnGetStatus.UseVisualStyleBackColor = true;
			this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
			// 
			// btnGetArt
			// 
			this.btnGetArt.Location = new System.Drawing.Point(6, 50);
			this.btnGetArt.Name = "btnGetArt";
			this.btnGetArt.Size = new System.Drawing.Size(160, 23);
			this.btnGetArt.TabIndex = 13;
			this.btnGetArt.Text = "Get ATR";
			this.btnGetArt.UseVisualStyleBackColor = true;
			this.btnGetArt.Click += new System.EventHandler(this.btnGetArt_Click);
			// 
			// btnUpdateBinaryBlocks
			// 
			this.btnUpdateBinaryBlocks.Location = new System.Drawing.Point(172, 108);
			this.btnUpdateBinaryBlocks.Name = "btnUpdateBinaryBlocks";
			this.btnUpdateBinaryBlocks.Size = new System.Drawing.Size(160, 23);
			this.btnUpdateBinaryBlocks.TabIndex = 3;
			this.btnUpdateBinaryBlocks.Text = "Update Binary Blocks";
			this.btnUpdateBinaryBlocks.UseVisualStyleBackColor = true;
			this.btnUpdateBinaryBlocks.Click += new System.EventHandler(this.btnUpdateBinaryBlocks_Click);
			// 
			// btnReadBinaryBlocks
			// 
			this.btnReadBinaryBlocks.Location = new System.Drawing.Point(172, 79);
			this.btnReadBinaryBlocks.Name = "btnReadBinaryBlocks";
			this.btnReadBinaryBlocks.Size = new System.Drawing.Size(160, 23);
			this.btnReadBinaryBlocks.TabIndex = 2;
			this.btnReadBinaryBlocks.Text = "Read Binary Blocks";
			this.btnReadBinaryBlocks.UseVisualStyleBackColor = true;
			this.btnReadBinaryBlocks.Click += new System.EventHandler(this.btnReadBinaryBlocks_Click);
			// 
			// btnAuthBlock
			// 
			this.btnAuthBlock.Location = new System.Drawing.Point(172, 50);
			this.btnAuthBlock.Name = "btnAuthBlock";
			this.btnAuthBlock.Size = new System.Drawing.Size(160, 23);
			this.btnAuthBlock.TabIndex = 1;
			this.btnAuthBlock.Text = "Auth Block";
			this.btnAuthBlock.UseVisualStyleBackColor = true;
			this.btnAuthBlock.Click += new System.EventHandler(this.btnAuthBlock_Click);
			// 
			// btnLoadKey
			// 
			this.btnLoadKey.Location = new System.Drawing.Point(6, 79);
			this.btnLoadKey.Name = "btnLoadKey";
			this.btnLoadKey.Size = new System.Drawing.Size(160, 23);
			this.btnLoadKey.TabIndex = 0;
			this.btnLoadKey.Text = "Load Key";
			this.btnLoadKey.UseVisualStyleBackColor = true;
			this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
			// 
			// listviewDevice
			// 
			this.listviewDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader3});
			this.listviewDevice.HideSelection = false;
			this.listviewDevice.Location = new System.Drawing.Point(11, 58);
			this.listviewDevice.Name = "listviewDevice";
			this.listviewDevice.Size = new System.Drawing.Size(180, 85);
			this.listviewDevice.TabIndex = 15;
			this.listviewDevice.UseCompatibleStateImageBehavior = false;
			this.listviewDevice.View = System.Windows.Forms.View.Details;
			this.listviewDevice.SelectedIndexChanged += new System.EventHandler(this.listviewDevice_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Device";
			this.columnHeader3.Width = 155;
			// 
			// listviewCard
			// 
			this.listviewCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader4});
			this.listviewCard.HideSelection = false;
			this.listviewCard.Location = new System.Drawing.Point(11, 148);
			this.listviewCard.Name = "listviewCard";
			this.listviewCard.Size = new System.Drawing.Size(180, 85);
			this.listviewCard.TabIndex = 16;
			this.listviewCard.UseCompatibleStateImageBehavior = false;
			this.listviewCard.View = System.Windows.Forms.View.Details;
			this.listviewCard.SelectedIndexChanged += new System.EventHandler(this.listviewCard_SelectedIndexChanged);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Card";
			this.columnHeader4.Width = 155;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNfcReaderData);
			this.groupBox1.Controls.Add(this.btnUpdateBinary);
			this.groupBox1.Controls.Add(this.btnUseBlockSet);
			this.groupBox1.Controls.Add(this.btnReadBinary);
			this.groupBox1.Controls.Add(this.numericBlockCount);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numericStartBlock);
			this.groupBox1.Location = new System.Drawing.Point(534, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(170, 175);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nfc Reader";
			// 
			// txtNfcReaderData
			// 
			this.txtNfcReaderData.Location = new System.Drawing.Point(3, 136);
			this.txtNfcReaderData.Name = "txtNfcReaderData";
			this.txtNfcReaderData.Size = new System.Drawing.Size(160, 23);
			this.txtNfcReaderData.TabIndex = 11;
			// 
			// btnUpdateBinary
			// 
			this.btnUpdateBinary.Location = new System.Drawing.Point(3, 109);
			this.btnUpdateBinary.Name = "btnUpdateBinary";
			this.btnUpdateBinary.Size = new System.Drawing.Size(160, 23);
			this.btnUpdateBinary.TabIndex = 10;
			this.btnUpdateBinary.Text = "Update Binary";
			this.btnUpdateBinary.UseVisualStyleBackColor = true;
			this.btnUpdateBinary.Click += new System.EventHandler(this.btnUpdateBinary_Click);
			// 
			// btnUseBlockSet
			// 
			this.btnUseBlockSet.Location = new System.Drawing.Point(123, 51);
			this.btnUseBlockSet.Name = "btnUseBlockSet";
			this.btnUseBlockSet.Size = new System.Drawing.Size(40, 23);
			this.btnUseBlockSet.TabIndex = 9;
			this.btnUseBlockSet.Text = "Set";
			this.btnUseBlockSet.UseVisualStyleBackColor = true;
			this.btnUseBlockSet.Click += new System.EventHandler(this.btnUseBlockSet_Click);
			// 
			// btnReadBinary
			// 
			this.btnReadBinary.Location = new System.Drawing.Point(3, 80);
			this.btnReadBinary.Name = "btnReadBinary";
			this.btnReadBinary.Size = new System.Drawing.Size(160, 23);
			this.btnReadBinary.TabIndex = 8;
			this.btnReadBinary.Text = "Read Binary";
			this.btnReadBinary.UseVisualStyleBackColor = true;
			this.btnReadBinary.Click += new System.EventHandler(this.btnReadBinary_Click);
			// 
			// numericBlockCount
			// 
			this.numericBlockCount.Location = new System.Drawing.Point(63, 51);
			this.numericBlockCount.Name = "numericBlockCount";
			this.numericBlockCount.Size = new System.Drawing.Size(54, 23);
			this.numericBlockCount.TabIndex = 7;
			this.numericBlockCount.Value = new decimal(new int[] {
			6,
			0,
			0,
			0});
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Start Block  Count";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericStartBlock
			// 
			this.numericStartBlock.Location = new System.Drawing.Point(3, 51);
			this.numericStartBlock.Name = "numericStartBlock";
			this.numericStartBlock.Size = new System.Drawing.Size(54, 23);
			this.numericStartBlock.TabIndex = 3;
			this.numericStartBlock.Value = new decimal(new int[] {
			8,
			0,
			0,
			0});
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.testToolStripMenuItem,
			this.dataToolStripMenuItem,
			this.devToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(713, 24);
			this.menuStrip1.TabIndex = 18;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiReaderTransmit_GetData,
			this.tsmiReaderTransmit_SetData});
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.testToolStripMenuItem.Text = "Nfc Reader";
			// 
			// tsmiReaderTransmit_GetData
			// 
			this.tsmiReaderTransmit_GetData.Name = "tsmiReaderTransmit_GetData";
			this.tsmiReaderTransmit_GetData.Size = new System.Drawing.Size(176, 22);
			this.tsmiReaderTransmit_GetData.Text = "Transmit - GetData";
			this.tsmiReaderTransmit_GetData.Click += new System.EventHandler(this.tsmiReaderTransmit_GetData_Click);
			// 
			// tsmiReaderTransmit_SetData
			// 
			this.tsmiReaderTransmit_SetData.Name = "tsmiReaderTransmit_SetData";
			this.tsmiReaderTransmit_SetData.Size = new System.Drawing.Size(176, 22);
			this.tsmiReaderTransmit_SetData.Text = "Transmit - SetData";
			this.tsmiReaderTransmit_SetData.Click += new System.EventHandler(this.tsmiReaderTransmit_SetData_Click);
			// 
			// dataToolStripMenuItem
			// 
			this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deviceCommandDataToolStripMenuItem,
			this.cardInfoCreateToolStripMenuItem});
			this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
			this.dataToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.dataToolStripMenuItem.Text = "Data";
			// 
			// deviceCommandDataToolStripMenuItem
			// 
			this.deviceCommandDataToolStripMenuItem.Name = "deviceCommandDataToolStripMenuItem";
			this.deviceCommandDataToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.deviceCommandDataToolStripMenuItem.Text = "Device Command Create";
			this.deviceCommandDataToolStripMenuItem.Click += new System.EventHandler(this.deviceCommandDataToolStripMenuItem_Click);
			// 
			// cardInfoCreateToolStripMenuItem
			// 
			this.cardInfoCreateToolStripMenuItem.Name = "cardInfoCreateToolStripMenuItem";
			this.cardInfoCreateToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.cardInfoCreateToolStripMenuItem.Text = "Card Info Create";
			this.cardInfoCreateToolStripMenuItem.Click += new System.EventHandler(this.cardInfoCreateToolStripMenuItem_Click);
			// 
			// devToolStripMenuItem
			// 
			this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiDev_Test,
			this.tsmiDev_DeviceCmdJsonSave});
			this.devToolStripMenuItem.Name = "devToolStripMenuItem";
			this.devToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.devToolStripMenuItem.Text = "Dev";
			// 
			// tsmiDev_Test
			// 
			this.tsmiDev_Test.Name = "tsmiDev_Test";
			this.tsmiDev_Test.Size = new System.Drawing.Size(223, 22);
			this.tsmiDev_Test.Text = "Test";
			this.tsmiDev_Test.Click += new System.EventHandler(this.tsmiDev_Test_Click);
			// 
			// tsmiDev_DeviceCmdJsonSave
			// 
			this.tsmiDev_DeviceCmdJsonSave.Name = "tsmiDev_DeviceCmdJsonSave";
			this.tsmiDev_DeviceCmdJsonSave.Size = new System.Drawing.Size(223, 22);
			this.tsmiDev_DeviceCmdJsonSave.Text = "DeviceCommand Json Save";
			this.tsmiDev_DeviceCmdJsonSave.Click += new System.EventHandler(this.tsmiDev_DeviceCmdJsonSave_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 601);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listviewCard);
			this.Controls.Add(this.listviewDevice);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.listLog);
			this.Controls.Add(this.btnCardListRefresh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboCardReaderList);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numericBlockNumber)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBlockCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericStartBlock)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboCardReaderList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCardListRefresh;
		private System.Windows.Forms.ListView listLog;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label labInfo;
		private System.Windows.Forms.TextBox txtUpdateBinary;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericBlockNumber;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnLoadKey;
		private System.Windows.Forms.Button btnAuthBlock;
		private System.Windows.Forms.Button btnReadBinaryBlocks;
		private System.Windows.Forms.Button btnUpdateBinaryBlocks;
		private System.Windows.Forms.Button btnGetArt;
		private System.Windows.Forms.Button btnGetStatus;
		private System.Windows.Forms.ListView listviewDevice;
		private System.Windows.Forms.ListView listviewCard;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericBlockCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericStartBlock;
		private System.Windows.Forms.Button btnReadBinary;
		private System.Windows.Forms.Button btnUseBlockSet;
		private System.Windows.Forms.TextBox txtNfcReaderData;
		private System.Windows.Forms.Button btnUpdateBinary;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiDev_Test;
		private System.Windows.Forms.ToolStripMenuItem tsmiDev_DeviceCmdJsonSave;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deviceCommandDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cardInfoCreateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiReaderTransmit_GetData;
		private System.Windows.Forms.ToolStripMenuItem tsmiReaderTransmit_SetData;
	}
}

