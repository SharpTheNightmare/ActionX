namespace ActionX
{
    partial class ActionX
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
            this.ClientCheckBox = new System.Windows.Forms.CheckBox();
            this.HostIPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectionGB = new System.Windows.Forms.GroupBox();
            this.StartConButton = new System.Windows.Forms.Button();
            this.SendOptionsGB = new System.Windows.Forms.GroupBox();
            this.CellJumpCheckBox = new System.Windows.Forms.CheckBox();
            this.CompleteQuestCheckBox = new System.Windows.Forms.CheckBox();
            this.MapJoinCheckBox = new System.Windows.Forms.CheckBox();
            this.BuyCheckBox = new System.Windows.Forms.CheckBox();
            this.GetMapItemCheckBox = new System.Windows.Forms.CheckBox();
            this.AcceptQuestCheckBox = new System.Windows.Forms.CheckBox();
            this.LoadQuestCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsGB = new System.Windows.Forms.GroupBox();
            this.UnlockLabel = new System.Windows.Forms.LinkLabel();
            this.SkipCutsceneCheckBox = new System.Windows.Forms.CheckBox();
            this.HidePlayersCheckBox = new System.Windows.Forms.CheckBox();
            this.LagKillerCheckBox = new System.Windows.Forms.CheckBox();
            this.ProvokeCheckBox = new System.Windows.Forms.CheckBox();
            this.InfiniteRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.HostTooCheckBox = new System.Windows.Forms.CheckBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ConClientTextBox = new System.Windows.Forms.Label();
            this.BroadcastTextBox = new System.Windows.Forms.TextBox();
            this.BroadcastMSG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortTextBox)).BeginInit();
            this.ConnectionGB.SuspendLayout();
            this.SendOptionsGB.SuspendLayout();
            this.OptionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientCheckBox
            // 
            this.ClientCheckBox.AutoSize = true;
            this.ClientCheckBox.Location = new System.Drawing.Point(200, 14);
            this.ClientCheckBox.Name = "ClientCheckBox";
            this.ClientCheckBox.Size = new System.Drawing.Size(62, 19);
            this.ClientCheckBox.TabIndex = 0;
            this.ClientCheckBox.Text = "Client?";
            this.ClientCheckBox.UseVisualStyleBackColor = true;
            this.ClientCheckBox.CheckedChanged += new System.EventHandler(this.ClientCheckBox_CheckedChanged);
            // 
            // HostIPTextBox
            // 
            this.HostIPTextBox.Location = new System.Drawing.Point(49, 16);
            this.HostIPTextBox.Name = "HostIPTextBox";
            this.HostIPTextBox.ReadOnly = true;
            this.HostIPTextBox.Size = new System.Drawing.Size(115, 23);
            this.HostIPTextBox.TabIndex = 1;
            this.HostIPTextBox.Text = "127.0.0.1";
            this.HostIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(49, 44);
            this.PortTextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortTextBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(115, 23);
            this.PortTextBox.TabIndex = 2;
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortTextBox.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // ConnectionGB
            // 
            this.ConnectionGB.Controls.Add(this.HostIPTextBox);
            this.ConnectionGB.Controls.Add(this.PortTextBox);
            this.ConnectionGB.Controls.Add(this.label2);
            this.ConnectionGB.Controls.Add(this.label1);
            this.ConnectionGB.Location = new System.Drawing.Point(7, 7);
            this.ConnectionGB.Name = "ConnectionGB";
            this.ConnectionGB.Size = new System.Drawing.Size(180, 75);
            this.ConnectionGB.TabIndex = 5;
            this.ConnectionGB.TabStop = false;
            this.ConnectionGB.Text = "Host Address";
            // 
            // StartConButton
            // 
            this.StartConButton.Location = new System.Drawing.Point(193, 31);
            this.StartConButton.Name = "StartConButton";
            this.StartConButton.Size = new System.Drawing.Size(75, 51);
            this.StartConButton.TabIndex = 5;
            this.StartConButton.Text = "Start";
            this.StartConButton.UseVisualStyleBackColor = true;
            this.StartConButton.Click += new System.EventHandler(this.StartConButton_Click);
            // 
            // SendOptionsGB
            // 
            this.SendOptionsGB.Controls.Add(this.CellJumpCheckBox);
            this.SendOptionsGB.Controls.Add(this.CompleteQuestCheckBox);
            this.SendOptionsGB.Controls.Add(this.MapJoinCheckBox);
            this.SendOptionsGB.Controls.Add(this.BuyCheckBox);
            this.SendOptionsGB.Controls.Add(this.GetMapItemCheckBox);
            this.SendOptionsGB.Controls.Add(this.AcceptQuestCheckBox);
            this.SendOptionsGB.Controls.Add(this.LoadQuestCheckBox);
            this.SendOptionsGB.Location = new System.Drawing.Point(7, 82);
            this.SendOptionsGB.Name = "SendOptionsGB";
            this.SendOptionsGB.Size = new System.Drawing.Size(261, 77);
            this.SendOptionsGB.TabIndex = 6;
            this.SendOptionsGB.TabStop = false;
            this.SendOptionsGB.Text = "Send Options";
            // 
            // CellJumpCheckBox
            // 
            this.CellJumpCheckBox.AutoSize = true;
            this.CellJumpCheckBox.Checked = true;
            this.CellJumpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CellJumpCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellJumpCheckBox.Location = new System.Drawing.Point(106, 55);
            this.CellJumpCheckBox.Name = "CellJumpCheckBox";
            this.CellJumpCheckBox.Size = new System.Drawing.Size(75, 17);
            this.CellJumpCheckBox.TabIndex = 14;
            this.CellJumpCheckBox.Text = "Cell Jump";
            this.CellJumpCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompleteQuestCheckBox
            // 
            this.CompleteQuestCheckBox.AutoSize = true;
            this.CompleteQuestCheckBox.Checked = true;
            this.CompleteQuestCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompleteQuestCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompleteQuestCheckBox.Location = new System.Drawing.Point(6, 36);
            this.CompleteQuestCheckBox.Name = "CompleteQuestCheckBox";
            this.CompleteQuestCheckBox.Size = new System.Drawing.Size(108, 17);
            this.CompleteQuestCheckBox.TabIndex = 4;
            this.CompleteQuestCheckBox.Text = "Quest Complete";
            this.CompleteQuestCheckBox.UseVisualStyleBackColor = true;
            // 
            // MapJoinCheckBox
            // 
            this.MapJoinCheckBox.AutoSize = true;
            this.MapJoinCheckBox.Checked = true;
            this.MapJoinCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MapJoinCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapJoinCheckBox.Location = new System.Drawing.Point(17, 55);
            this.MapJoinCheckBox.Name = "MapJoinCheckBox";
            this.MapJoinCheckBox.Size = new System.Drawing.Size(73, 17);
            this.MapJoinCheckBox.TabIndex = 13;
            this.MapJoinCheckBox.Text = "Map Join";
            this.MapJoinCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuyCheckBox
            // 
            this.BuyCheckBox.AutoSize = true;
            this.BuyCheckBox.Checked = true;
            this.BuyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BuyCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuyCheckBox.Location = new System.Drawing.Point(199, 55);
            this.BuyCheckBox.Name = "BuyCheckBox";
            this.BuyCheckBox.Size = new System.Drawing.Size(44, 17);
            this.BuyCheckBox.TabIndex = 3;
            this.BuyCheckBox.Text = "Buy";
            this.BuyCheckBox.UseVisualStyleBackColor = true;
            // 
            // GetMapItemCheckBox
            // 
            this.GetMapItemCheckBox.AutoSize = true;
            this.GetMapItemCheckBox.Checked = true;
            this.GetMapItemCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GetMapItemCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetMapItemCheckBox.Location = new System.Drawing.Point(134, 36);
            this.GetMapItemCheckBox.Name = "GetMapItemCheckBox";
            this.GetMapItemCheckBox.Size = new System.Drawing.Size(95, 17);
            this.GetMapItemCheckBox.TabIndex = 5;
            this.GetMapItemCheckBox.Text = "Get Map Item";
            this.GetMapItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // AcceptQuestCheckBox
            // 
            this.AcceptQuestCheckBox.AutoSize = true;
            this.AcceptQuestCheckBox.Checked = true;
            this.AcceptQuestCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AcceptQuestCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptQuestCheckBox.Location = new System.Drawing.Point(144, 17);
            this.AcceptQuestCheckBox.Name = "AcceptQuestCheckBox";
            this.AcceptQuestCheckBox.Size = new System.Drawing.Size(93, 17);
            this.AcceptQuestCheckBox.TabIndex = 2;
            this.AcceptQuestCheckBox.Text = "Quest Accept";
            this.AcceptQuestCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoadQuestCheckBox
            // 
            this.LoadQuestCheckBox.AutoSize = true;
            this.LoadQuestCheckBox.Checked = true;
            this.LoadQuestCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoadQuestCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadQuestCheckBox.Location = new System.Drawing.Point(27, 17);
            this.LoadQuestCheckBox.Name = "LoadQuestCheckBox";
            this.LoadQuestCheckBox.Size = new System.Drawing.Size(84, 17);
            this.LoadQuestCheckBox.TabIndex = 1;
            this.LoadQuestCheckBox.Text = "Quest Load";
            this.LoadQuestCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsGB
            // 
            this.OptionsGB.Controls.Add(this.UnlockLabel);
            this.OptionsGB.Controls.Add(this.SkipCutsceneCheckBox);
            this.OptionsGB.Controls.Add(this.HidePlayersCheckBox);
            this.OptionsGB.Controls.Add(this.LagKillerCheckBox);
            this.OptionsGB.Controls.Add(this.ProvokeCheckBox);
            this.OptionsGB.Controls.Add(this.InfiniteRangeCheckBox);
            this.OptionsGB.Controls.Add(this.HostTooCheckBox);
            this.OptionsGB.Location = new System.Drawing.Point(7, 167);
            this.OptionsGB.Name = "OptionsGB";
            this.OptionsGB.Size = new System.Drawing.Size(261, 90);
            this.OptionsGB.TabIndex = 7;
            this.OptionsGB.TabStop = false;
            this.OptionsGB.Text = "Send Toggle Options";
            // 
            // UnlockLabel
            // 
            this.UnlockLabel.AutoSize = true;
            this.UnlockLabel.Location = new System.Drawing.Point(205, 0);
            this.UnlockLabel.Name = "UnlockLabel";
            this.UnlockLabel.Size = new System.Drawing.Size(52, 15);
            this.UnlockLabel.TabIndex = 13;
            this.UnlockLabel.TabStop = true;
            this.UnlockLabel.Text = "[Unlock]";
            this.UnlockLabel.Visible = false;
            this.UnlockLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UnlockLabel_LinkClicked);
            // 
            // SkipCutsceneCheckBox
            // 
            this.SkipCutsceneCheckBox.AutoSize = true;
            this.SkipCutsceneCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipCutsceneCheckBox.Location = new System.Drawing.Point(77, 64);
            this.SkipCutsceneCheckBox.Name = "SkipCutsceneCheckBox";
            this.SkipCutsceneCheckBox.Size = new System.Drawing.Size(103, 17);
            this.SkipCutsceneCheckBox.TabIndex = 6;
            this.SkipCutsceneCheckBox.Text = "Skip Custscene";
            this.SkipCutsceneCheckBox.UseVisualStyleBackColor = true;
            this.SkipCutsceneCheckBox.CheckedChanged += new System.EventHandler(this.SkipCutsceneCheckBox_CheckedChanged);
            // 
            // HidePlayersCheckBox
            // 
            this.HidePlayersCheckBox.AutoSize = true;
            this.HidePlayersCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HidePlayersCheckBox.Location = new System.Drawing.Point(154, 41);
            this.HidePlayersCheckBox.Name = "HidePlayersCheckBox";
            this.HidePlayersCheckBox.Size = new System.Drawing.Size(88, 17);
            this.HidePlayersCheckBox.TabIndex = 4;
            this.HidePlayersCheckBox.Text = "Hide Players";
            this.HidePlayersCheckBox.UseVisualStyleBackColor = true;
            this.HidePlayersCheckBox.CheckedChanged += new System.EventHandler(this.HidePlayersCheckBox_CheckedChanged);
            // 
            // LagKillerCheckBox
            // 
            this.LagKillerCheckBox.AutoSize = true;
            this.LagKillerCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LagKillerCheckBox.Location = new System.Drawing.Point(26, 41);
            this.LagKillerCheckBox.Name = "LagKillerCheckBox";
            this.LagKillerCheckBox.Size = new System.Drawing.Size(72, 17);
            this.LagKillerCheckBox.TabIndex = 3;
            this.LagKillerCheckBox.Text = "Lag Killer";
            this.LagKillerCheckBox.UseVisualStyleBackColor = true;
            this.LagKillerCheckBox.CheckedChanged += new System.EventHandler(this.LagKillerCheckBox_CheckedChanged);
            // 
            // ProvokeCheckBox
            // 
            this.ProvokeCheckBox.AutoSize = true;
            this.ProvokeCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProvokeCheckBox.Location = new System.Drawing.Point(165, 22);
            this.ProvokeCheckBox.Name = "ProvokeCheckBox";
            this.ProvokeCheckBox.Size = new System.Drawing.Size(67, 17);
            this.ProvokeCheckBox.TabIndex = 2;
            this.ProvokeCheckBox.Text = "Provoke";
            this.ProvokeCheckBox.UseVisualStyleBackColor = true;
            this.ProvokeCheckBox.CheckedChanged += new System.EventHandler(this.ProvokeCheckBox_CheckedChanged);
            // 
            // InfiniteRangeCheckBox
            // 
            this.InfiniteRangeCheckBox.AutoSize = true;
            this.InfiniteRangeCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfiniteRangeCheckBox.Location = new System.Drawing.Point(13, 22);
            this.InfiniteRangeCheckBox.Name = "InfiniteRangeCheckBox";
            this.InfiniteRangeCheckBox.Size = new System.Drawing.Size(99, 17);
            this.InfiniteRangeCheckBox.TabIndex = 1;
            this.InfiniteRangeCheckBox.Text = "Infinite Range";
            this.InfiniteRangeCheckBox.UseVisualStyleBackColor = true;
            this.InfiniteRangeCheckBox.CheckedChanged += new System.EventHandler(this.InfiniteRangeCheckBox_CheckedChanged);
            // 
            // HostTooCheckBox
            // 
            this.HostTooCheckBox.AutoSize = true;
            this.HostTooCheckBox.Checked = true;
            this.HostTooCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HostTooCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HostTooCheckBox.Location = new System.Drawing.Point(127, 0);
            this.HostTooCheckBox.Name = "HostTooCheckBox";
            this.HostTooCheckBox.Size = new System.Drawing.Size(72, 17);
            this.HostTooCheckBox.TabIndex = 0;
            this.HostTooCheckBox.Text = "Host Too";
            this.HostTooCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(274, 14);
            this.LogTextBox.MaxLength = 2147483647;
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(463, 198);
            this.LogTextBox.TabIndex = 9;
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // ConClientTextBox
            // 
            this.ConClientTextBox.AutoSize = true;
            this.ConClientTextBox.Location = new System.Drawing.Point(274, 239);
            this.ConClientTextBox.Name = "ConClientTextBox";
            this.ConClientTextBox.Size = new System.Drawing.Size(111, 15);
            this.ConClientTextBox.TabIndex = 10;
            this.ConClientTextBox.Text = "Client Connected: 0";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BroadcastTextBox.Location = new System.Drawing.Point(274, 215);
            this.BroadcastTextBox.MaxLength = 65535;
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.Size = new System.Drawing.Size(419, 23);
            this.BroadcastTextBox.TabIndex = 11;
            this.BroadcastTextBox.Text = "Hello World!";
            // 
            // BroadcastMSG
            // 
            this.BroadcastMSG.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BroadcastMSG.Location = new System.Drawing.Point(694, 214);
            this.BroadcastMSG.Name = "BroadcastMSG";
            this.BroadcastMSG.Size = new System.Drawing.Size(43, 26);
            this.BroadcastMSG.TabIndex = 12;
            this.BroadcastMSG.Text = "Send";
            this.BroadcastMSG.UseVisualStyleBackColor = true;
            this.BroadcastMSG.Click += new System.EventHandler(this.BroadcastMSG_Click);
            // 
            // ActionX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 268);
            this.Controls.Add(this.StartConButton);
            this.Controls.Add(this.BroadcastMSG);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.ConClientTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.OptionsGB);
            this.Controls.Add(this.SendOptionsGB);
            this.Controls.Add(this.ConnectionGB);
            this.Controls.Add(this.ClientCheckBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 307);
            this.MinimumSize = new System.Drawing.Size(517, 307);
            this.Name = "ActionX";
            this.Text = "ActionX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActionX_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PortTextBox)).EndInit();
            this.ConnectionGB.ResumeLayout(false);
            this.ConnectionGB.PerformLayout();
            this.SendOptionsGB.ResumeLayout(false);
            this.SendOptionsGB.PerformLayout();
            this.OptionsGB.ResumeLayout(false);
            this.OptionsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ClientCheckBox;
        private TextBox HostIPTextBox;
        private NumericUpDown PortTextBox;
        private Label label1;
        private Label label2;
        private GroupBox ConnectionGB;
        private Button StartConButton;
        private GroupBox SendOptionsGB;
        private GroupBox OptionsGB;
        private CheckBox HostTooCheckBox;
        private TextBox LogTextBox;
        private Label ConClientTextBox;
        private TextBox BroadcastTextBox;
        private Button BroadcastMSG;
        private CheckBox CellJumpCheckBox;
        private CheckBox CompleteQuestCheckBox;
        private CheckBox MapJoinCheckBox;
        private CheckBox BuyCheckBox;
        private CheckBox GetMapItemCheckBox;
        private CheckBox AcceptQuestCheckBox;
        private CheckBox LoadQuestCheckBox;
        private CheckBox SkipCutsceneCheckBox;
        private CheckBox HidePlayersCheckBox;
        private CheckBox LagKillerCheckBox;
        private CheckBox ProvokeCheckBox;
        private CheckBox InfiniteRangeCheckBox;
        private LinkLabel UnlockLabel;
    }
}