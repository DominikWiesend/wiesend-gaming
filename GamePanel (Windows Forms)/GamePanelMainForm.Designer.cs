namespace GamePanel
{
    partial class GamePanelMainForm
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
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblSubTitel = new System.Windows.Forms.Label();
            this.tcMainTabControl = new System.Windows.Forms.TabControl();
            this.tapPlayer = new System.Windows.Forms.TabPage();
            this.lblPlayerSteamAccounts = new System.Windows.Forms.Label();
            this.pnlSelectPlayer = new System.Windows.Forms.Panel();
            this.pnlSelectLastName = new System.Windows.Forms.Panel();
            this.cbSelectPlayerLastName = new System.Windows.Forms.ComboBox();
            this.lblSelectPlayerLastName = new System.Windows.Forms.Label();
            this.pnlSelectFirstName = new System.Windows.Forms.Panel();
            this.cbSelectPlayerFirstName = new System.Windows.Forms.ComboBox();
            this.SelectPlayerFirstName = new System.Windows.Forms.Label();
            this.lblSelectPlayer = new System.Windows.Forms.Label();
            this.pnlSelectPlayerId = new System.Windows.Forms.Panel();
            this.tbSelectPlayerId = new System.Windows.Forms.TextBox();
            this.SelectPlayerId = new System.Windows.Forms.Label();
            this.dgvPlayerSteamAccounts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCreateNewPlayer = new System.Windows.Forms.Panel();
            this.btnCreateNewPlayer = new System.Windows.Forms.Button();
            this.pnlCreateNewPlayerLastName = new System.Windows.Forms.Panel();
            this.tbCreateNewPlayerLastName = new System.Windows.Forms.TextBox();
            this.lblCreateNewPlayerLastName = new System.Windows.Forms.Label();
            this.lblCreateNewPlayer = new System.Windows.Forms.Label();
            this.pnlCreateNewPlayerFirstName = new System.Windows.Forms.Panel();
            this.tbCreateNewPlayerFirstName = new System.Windows.Forms.TextBox();
            this.lblCreatePlayerFirstName = new System.Windows.Forms.Label();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pnlCreateNewPlayerButton = new System.Windows.Forms.Panel();
            this.pnlMainPanel.SuspendLayout();
            this.tcMainTabControl.SuspendLayout();
            this.tapPlayer.SuspendLayout();
            this.pnlSelectPlayer.SuspendLayout();
            this.pnlSelectLastName.SuspendLayout();
            this.pnlSelectFirstName.SuspendLayout();
            this.pnlSelectPlayerId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSteamAccounts)).BeginInit();
            this.pnlCreateNewPlayer.SuspendLayout();
            this.pnlCreateNewPlayerLastName.SuspendLayout();
            this.pnlCreateNewPlayerFirstName.SuspendLayout();
            this.pnlCreateNewPlayerButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainPanel.Controls.Add(this.lblTitel);
            this.pnlMainPanel.Controls.Add(this.lblSubTitel);
            this.pnlMainPanel.Controls.Add(this.tcMainTabControl);
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(784, 462);
            this.pnlMainPanel.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(176, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(351, 24);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Match Making (GamePanel) - [GET5]";
            // 
            // lblSubTitel
            // 
            this.lblSubTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitel.AutoSize = true;
            this.lblSubTitel.Location = new System.Drawing.Point(369, 33);
            this.lblSubTitel.Name = "lblSubTitel";
            this.lblSubTitel.Size = new System.Drawing.Size(158, 13);
            this.lblSubTitel.TabIndex = 1;
            this.lblSubTitel.Text = "Counter Strike: Global Offensive";
            // 
            // tcMainTabControl
            // 
            this.tcMainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainTabControl.Controls.Add(this.tapPlayer);
            this.tcMainTabControl.Controls.Add(this.tabTeam);
            this.tcMainTabControl.Controls.Add(this.tabPage3);
            this.tcMainTabControl.Controls.Add(this.tabPage4);
            this.tcMainTabControl.Controls.Add(this.tabPage5);
            this.tcMainTabControl.Location = new System.Drawing.Point(3, 42);
            this.tcMainTabControl.Name = "tcMainTabControl";
            this.tcMainTabControl.SelectedIndex = 0;
            this.tcMainTabControl.Size = new System.Drawing.Size(778, 420);
            this.tcMainTabControl.TabIndex = 0;
            // 
            // tapPlayer
            // 
            this.tapPlayer.Controls.Add(this.lblPlayerSteamAccounts);
            this.tapPlayer.Controls.Add(this.pnlSelectPlayer);
            this.tapPlayer.Controls.Add(this.dgvPlayerSteamAccounts);
            this.tapPlayer.Controls.Add(this.pnlCreateNewPlayer);
            this.tapPlayer.Location = new System.Drawing.Point(4, 22);
            this.tapPlayer.Name = "tapPlayer";
            this.tapPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tapPlayer.Size = new System.Drawing.Size(770, 394);
            this.tapPlayer.TabIndex = 0;
            this.tapPlayer.Text = "Player (Table)";
            this.tapPlayer.UseVisualStyleBackColor = true;
            // 
            // lblPlayerSteamAccounts
            // 
            this.lblPlayerSteamAccounts.AutoSize = true;
            this.lblPlayerSteamAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSteamAccounts.Location = new System.Drawing.Point(9, 134);
            this.lblPlayerSteamAccounts.Name = "lblPlayerSteamAccounts";
            this.lblPlayerSteamAccounts.Size = new System.Drawing.Size(255, 18);
            this.lblPlayerSteamAccounts.TabIndex = 4;
            this.lblPlayerSteamAccounts.Text = "Steam (Accounts) of the Person:";
            // 
            // pnlSelectPlayer
            // 
            this.pnlSelectPlayer.AutoScroll = true;
            this.pnlSelectPlayer.AutoScrollMinSize = new System.Drawing.Size(275, 114);
            this.pnlSelectPlayer.Controls.Add(this.pnlSelectLastName);
            this.pnlSelectPlayer.Controls.Add(this.pnlSelectFirstName);
            this.pnlSelectPlayer.Controls.Add(this.lblSelectPlayer);
            this.pnlSelectPlayer.Controls.Add(this.pnlSelectPlayerId);
            this.pnlSelectPlayer.Location = new System.Drawing.Point(3, 3);
            this.pnlSelectPlayer.Name = "pnlSelectPlayer";
            this.pnlSelectPlayer.Size = new System.Drawing.Size(275, 114);
            this.pnlSelectPlayer.TabIndex = 3;
            // 
            // pnlSelectLastName
            // 
            this.pnlSelectLastName.Controls.Add(this.cbSelectPlayerLastName);
            this.pnlSelectLastName.Controls.Add(this.lblSelectPlayerLastName);
            this.pnlSelectLastName.Location = new System.Drawing.Point(1, 75);
            this.pnlSelectLastName.Name = "pnlSelectLastName";
            this.pnlSelectLastName.Size = new System.Drawing.Size(250, 25);
            this.pnlSelectLastName.TabIndex = 9;
            // 
            // cbSelectPlayerLastName
            // 
            this.cbSelectPlayerLastName.FormattingEnabled = true;
            this.cbSelectPlayerLastName.Location = new System.Drawing.Point(67, 1);
            this.cbSelectPlayerLastName.Name = "cbSelectPlayerLastName";
            this.cbSelectPlayerLastName.Size = new System.Drawing.Size(177, 21);
            this.cbSelectPlayerLastName.TabIndex = 10;
            // 
            // lblSelectPlayerLastName
            // 
            this.lblSelectPlayerLastName.AutoSize = true;
            this.lblSelectPlayerLastName.Location = new System.Drawing.Point(4, 3);
            this.lblSelectPlayerLastName.Name = "lblSelectPlayerLastName";
            this.lblSelectPlayerLastName.Size = new System.Drawing.Size(58, 13);
            this.lblSelectPlayerLastName.TabIndex = 3;
            this.lblSelectPlayerLastName.Text = "LastName:";
            // 
            // pnlSelectFirstName
            // 
            this.pnlSelectFirstName.Controls.Add(this.cbSelectPlayerFirstName);
            this.pnlSelectFirstName.Controls.Add(this.SelectPlayerFirstName);
            this.pnlSelectFirstName.Location = new System.Drawing.Point(1, 50);
            this.pnlSelectFirstName.Name = "pnlSelectFirstName";
            this.pnlSelectFirstName.Size = new System.Drawing.Size(250, 25);
            this.pnlSelectFirstName.TabIndex = 8;
            // 
            // cbSelectPlayerFirstName
            // 
            this.cbSelectPlayerFirstName.FormattingEnabled = true;
            this.cbSelectPlayerFirstName.Location = new System.Drawing.Point(67, 1);
            this.cbSelectPlayerFirstName.Name = "cbSelectPlayerFirstName";
            this.cbSelectPlayerFirstName.Size = new System.Drawing.Size(177, 21);
            this.cbSelectPlayerFirstName.TabIndex = 4;
            // 
            // SelectPlayerFirstName
            // 
            this.SelectPlayerFirstName.AutoSize = true;
            this.SelectPlayerFirstName.Location = new System.Drawing.Point(4, 3);
            this.SelectPlayerFirstName.Name = "SelectPlayerFirstName";
            this.SelectPlayerFirstName.Size = new System.Drawing.Size(57, 13);
            this.SelectPlayerFirstName.TabIndex = 3;
            this.SelectPlayerFirstName.Text = "FirstName:";
            // 
            // lblSelectPlayer
            // 
            this.lblSelectPlayer.AutoSize = true;
            this.lblSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayer.Location = new System.Drawing.Point(6, 6);
            this.lblSelectPlayer.Name = "lblSelectPlayer";
            this.lblSelectPlayer.Size = new System.Drawing.Size(199, 15);
            this.lblSelectPlayer.TabIndex = 0;
            this.lblSelectPlayer.Text = "Select Player (from Database)";
            // 
            // pnlSelectPlayerId
            // 
            this.pnlSelectPlayerId.Controls.Add(this.tbSelectPlayerId);
            this.pnlSelectPlayerId.Controls.Add(this.SelectPlayerId);
            this.pnlSelectPlayerId.Location = new System.Drawing.Point(1, 25);
            this.pnlSelectPlayerId.Name = "pnlSelectPlayerId";
            this.pnlSelectPlayerId.Size = new System.Drawing.Size(250, 25);
            this.pnlSelectPlayerId.TabIndex = 7;
            // 
            // tbSelectPlayerId
            // 
            this.tbSelectPlayerId.Location = new System.Drawing.Point(67, 1);
            this.tbSelectPlayerId.Name = "tbSelectPlayerId";
            this.tbSelectPlayerId.ReadOnly = true;
            this.tbSelectPlayerId.Size = new System.Drawing.Size(177, 20);
            this.tbSelectPlayerId.TabIndex = 1;
            // 
            // SelectPlayerId
            // 
            this.SelectPlayerId.AutoSize = true;
            this.SelectPlayerId.Location = new System.Drawing.Point(4, 3);
            this.SelectPlayerId.Name = "SelectPlayerId";
            this.SelectPlayerId.Size = new System.Drawing.Size(48, 13);
            this.SelectPlayerId.TabIndex = 3;
            this.SelectPlayerId.Text = "PlayerId:";
            // 
            // dgvPlayerSteamAccounts
            // 
            this.dgvPlayerSteamAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayerSteamAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerSteamAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPlayerSteamAccounts.Location = new System.Drawing.Point(12, 155);
            this.dgvPlayerSteamAccounts.Name = "dgvPlayerSteamAccounts";
            this.dgvPlayerSteamAccounts.Size = new System.Drawing.Size(739, 170);
            this.dgvPlayerSteamAccounts.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SteamId";
            this.Column1.Name = "Column1";
            // 
            // pnlCreateNewPlayer
            // 
            this.pnlCreateNewPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCreateNewPlayer.AutoScroll = true;
            this.pnlCreateNewPlayer.AutoScrollMinSize = new System.Drawing.Size(261, 114);
            this.pnlCreateNewPlayer.Controls.Add(this.pnlCreateNewPlayerButton);
            this.pnlCreateNewPlayer.Controls.Add(this.pnlCreateNewPlayerLastName);
            this.pnlCreateNewPlayer.Controls.Add(this.lblCreateNewPlayer);
            this.pnlCreateNewPlayer.Controls.Add(this.pnlCreateNewPlayerFirstName);
            this.pnlCreateNewPlayer.Location = new System.Drawing.Point(506, 3);
            this.pnlCreateNewPlayer.Name = "pnlCreateNewPlayer";
            this.pnlCreateNewPlayer.Size = new System.Drawing.Size(261, 114);
            this.pnlCreateNewPlayer.TabIndex = 1;
            // 
            // btnCreateNewPlayer
            // 
            this.btnCreateNewPlayer.Location = new System.Drawing.Point(66, 1);
            this.btnCreateNewPlayer.Name = "btnCreateNewPlayer";
            this.btnCreateNewPlayer.Size = new System.Drawing.Size(180, 23);
            this.btnCreateNewPlayer.TabIndex = 9;
            this.btnCreateNewPlayer.Text = "Create";
            this.btnCreateNewPlayer.UseVisualStyleBackColor = true;
            // 
            // pnlCreateNewPlayerLastName
            // 
            this.pnlCreateNewPlayerLastName.Controls.Add(this.tbCreateNewPlayerLastName);
            this.pnlCreateNewPlayerLastName.Controls.Add(this.lblCreateNewPlayerLastName);
            this.pnlCreateNewPlayerLastName.Location = new System.Drawing.Point(1, 50);
            this.pnlCreateNewPlayerLastName.Name = "pnlCreateNewPlayerLastName";
            this.pnlCreateNewPlayerLastName.Size = new System.Drawing.Size(250, 25);
            this.pnlCreateNewPlayerLastName.TabIndex = 8;
            // 
            // tbCreateNewPlayerLastName
            // 
            this.tbCreateNewPlayerLastName.Location = new System.Drawing.Point(67, 1);
            this.tbCreateNewPlayerLastName.Name = "tbCreateNewPlayerLastName";
            this.tbCreateNewPlayerLastName.Size = new System.Drawing.Size(177, 20);
            this.tbCreateNewPlayerLastName.TabIndex = 1;
            // 
            // lblCreateNewPlayerLastName
            // 
            this.lblCreateNewPlayerLastName.AutoSize = true;
            this.lblCreateNewPlayerLastName.Location = new System.Drawing.Point(4, 4);
            this.lblCreateNewPlayerLastName.Name = "lblCreateNewPlayerLastName";
            this.lblCreateNewPlayerLastName.Size = new System.Drawing.Size(58, 13);
            this.lblCreateNewPlayerLastName.TabIndex = 3;
            this.lblCreateNewPlayerLastName.Text = "LastName:";
            // 
            // lblCreateNewPlayer
            // 
            this.lblCreateNewPlayer.AutoSize = true;
            this.lblCreateNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewPlayer.Location = new System.Drawing.Point(6, 6);
            this.lblCreateNewPlayer.Name = "lblCreateNewPlayer";
            this.lblCreateNewPlayer.Size = new System.Drawing.Size(123, 15);
            this.lblCreateNewPlayer.TabIndex = 0;
            this.lblCreateNewPlayer.Text = "Create new Player";
            // 
            // pnlCreateNewPlayerFirstName
            // 
            this.pnlCreateNewPlayerFirstName.Controls.Add(this.tbCreateNewPlayerFirstName);
            this.pnlCreateNewPlayerFirstName.Controls.Add(this.lblCreatePlayerFirstName);
            this.pnlCreateNewPlayerFirstName.Location = new System.Drawing.Point(1, 25);
            this.pnlCreateNewPlayerFirstName.Name = "pnlCreateNewPlayerFirstName";
            this.pnlCreateNewPlayerFirstName.Size = new System.Drawing.Size(250, 25);
            this.pnlCreateNewPlayerFirstName.TabIndex = 7;
            // 
            // tbCreateNewPlayerFirstName
            // 
            this.tbCreateNewPlayerFirstName.Location = new System.Drawing.Point(67, 1);
            this.tbCreateNewPlayerFirstName.Name = "tbCreateNewPlayerFirstName";
            this.tbCreateNewPlayerFirstName.Size = new System.Drawing.Size(177, 20);
            this.tbCreateNewPlayerFirstName.TabIndex = 1;
            // 
            // lblCreatePlayerFirstName
            // 
            this.lblCreatePlayerFirstName.AutoSize = true;
            this.lblCreatePlayerFirstName.Location = new System.Drawing.Point(4, 3);
            this.lblCreatePlayerFirstName.Name = "lblCreatePlayerFirstName";
            this.lblCreatePlayerFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblCreatePlayerFirstName.TabIndex = 3;
            this.lblCreatePlayerFirstName.Text = "FirstName:";
            // 
            // tabTeam
            // 
            this.tabTeam.Location = new System.Drawing.Point(4, 22);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeam.Size = new System.Drawing.Size(786, 383);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "Team (Table)";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 383);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(786, 383);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pnlCreateNewPlayerButton
            // 
            this.pnlCreateNewPlayerButton.Controls.Add(this.btnCreateNewPlayer);
            this.pnlCreateNewPlayerButton.Location = new System.Drawing.Point(1, 75);
            this.pnlCreateNewPlayerButton.Name = "pnlCreateNewPlayerButton";
            this.pnlCreateNewPlayerButton.Size = new System.Drawing.Size(250, 25);
            this.pnlCreateNewPlayerButton.TabIndex = 11;
            // 
            // GamePanelMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlMainPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "GamePanelMainForm";
            this.Text = "Match Making (GamePanel) - [GET5]";
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlMainPanel.PerformLayout();
            this.tcMainTabControl.ResumeLayout(false);
            this.tapPlayer.ResumeLayout(false);
            this.tapPlayer.PerformLayout();
            this.pnlSelectPlayer.ResumeLayout(false);
            this.pnlSelectPlayer.PerformLayout();
            this.pnlSelectLastName.ResumeLayout(false);
            this.pnlSelectLastName.PerformLayout();
            this.pnlSelectFirstName.ResumeLayout(false);
            this.pnlSelectFirstName.PerformLayout();
            this.pnlSelectPlayerId.ResumeLayout(false);
            this.pnlSelectPlayerId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerSteamAccounts)).EndInit();
            this.pnlCreateNewPlayer.ResumeLayout(false);
            this.pnlCreateNewPlayer.PerformLayout();
            this.pnlCreateNewPlayerLastName.ResumeLayout(false);
            this.pnlCreateNewPlayerLastName.PerformLayout();
            this.pnlCreateNewPlayerFirstName.ResumeLayout(false);
            this.pnlCreateNewPlayerFirstName.PerformLayout();
            this.pnlCreateNewPlayerButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.TabControl tcMainTabControl;
        private System.Windows.Forms.TabPage tapPlayer;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.Label lblSubTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvPlayerSteamAccounts;
        private System.Windows.Forms.Panel pnlCreateNewPlayer;
        private System.Windows.Forms.Button btnCreateNewPlayer;
        private System.Windows.Forms.Panel pnlCreateNewPlayerLastName;
        private System.Windows.Forms.TextBox tbCreateNewPlayerLastName;
        private System.Windows.Forms.Label lblCreateNewPlayerLastName;
        private System.Windows.Forms.Label lblCreateNewPlayer;
        private System.Windows.Forms.Panel pnlCreateNewPlayerFirstName;
        private System.Windows.Forms.TextBox tbCreateNewPlayerFirstName;
        private System.Windows.Forms.Label lblCreatePlayerFirstName;
        private System.Windows.Forms.Panel pnlSelectPlayer;
        private System.Windows.Forms.Panel pnlSelectFirstName;
        private System.Windows.Forms.Panel pnlSelectLastName;
        private System.Windows.Forms.Label lblSelectPlayerLastName;
        private System.Windows.Forms.Label SelectPlayerFirstName;
        private System.Windows.Forms.Label lblSelectPlayer;
        private System.Windows.Forms.Panel pnlSelectPlayerId;
        private System.Windows.Forms.TextBox tbSelectPlayerId;
        private System.Windows.Forms.Label SelectPlayerId;
        private System.Windows.Forms.ComboBox cbSelectPlayerLastName;
        private System.Windows.Forms.ComboBox cbSelectPlayerFirstName;
        private System.Windows.Forms.Label lblPlayerSteamAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel pnlCreateNewPlayerButton;
    }
}

