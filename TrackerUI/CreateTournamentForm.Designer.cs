namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewLink = new System.Windows.Forms.LinkLabel();
            this.addteamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tornamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlaterlabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPricesButton = new System.Windows.Forms.Button();
            this.prizesLabels = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(56, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(224, 32);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameValue.Location = new System.Drawing.Point(20, 83);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(192, 29);
            this.tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(15, 55);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(175, 25);
            this.tournamentNameLabel.TabIndex = 10;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeValue.Location = new System.Drawing.Point(106, 120);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(90, 29);
            this.entryFeeValue.TabIndex = 13;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(15, 119);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(92, 25);
            this.entryFeeLabel.TabIndex = 12;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(15, 152);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(106, 25);
            this.selectTeamLabel.TabIndex = 14;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropDown.ForeColor = System.Drawing.Color.Black;
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(20, 180);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(191, 29);
            this.selectTeamDropDown.TabIndex = 15;
            // 
            // createNewLink
            // 
            this.createNewLink.AutoSize = true;
            this.createNewLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewLink.Location = new System.Drawing.Point(126, 156);
            this.createNewLink.Name = "createNewLink";
            this.createNewLink.Size = new System.Drawing.Size(88, 21);
            this.createNewLink.TabIndex = 16;
            this.createNewLink.TabStop = true;
            this.createNewLink.Text = "Create New";
            this.createNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLink_LinkClicked);
            // 
            // addteamButton
            // 
            this.addteamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addteamButton.FlatAppearance.BorderSize = 2;
            this.addteamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addteamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addteamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addteamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addteamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addteamButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addteamButton.Location = new System.Drawing.Point(41, 218);
            this.addteamButton.Name = "addteamButton";
            this.addteamButton.Size = new System.Drawing.Size(138, 39);
            this.addteamButton.TabIndex = 17;
            this.addteamButton.Text = "Add Team";
            this.addteamButton.UseVisualStyleBackColor = true;
            this.addteamButton.Click += new System.EventHandler(this.addteamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderSize = 2;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.createPrizeButton.Location = new System.Drawing.Point(41, 267);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(139, 37);
            this.createPrizeButton.TabIndex = 18;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tornamentTeamsListBox
            // 
            this.tornamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tornamentTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tornamentTeamsListBox.FormattingEnabled = true;
            this.tornamentTeamsListBox.ItemHeight = 20;
            this.tornamentTeamsListBox.Location = new System.Drawing.Point(239, 83);
            this.tornamentTeamsListBox.Name = "tornamentTeamsListBox";
            this.tornamentTeamsListBox.Size = new System.Drawing.Size(188, 82);
            this.tornamentTeamsListBox.TabIndex = 19;
            // 
            // tournamentPlaterlabel
            // 
            this.tournamentPlaterlabel.AutoSize = true;
            this.tournamentPlaterlabel.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlaterlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlaterlabel.Location = new System.Drawing.Point(250, 55);
            this.tournamentPlaterlabel.Name = "tournamentPlaterlabel";
            this.tournamentPlaterlabel.Size = new System.Drawing.Size(136, 25);
            this.tournamentPlaterlabel.TabIndex = 20;
            this.tournamentPlaterlabel.Text = "Teams/Players";
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayersButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(433, 83);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(78, 46);
            this.deleteSelectedPlayersButton.TabIndex = 21;
            this.deleteSelectedPlayersButton.Text = "Remove Selected";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPlayersButton.Click += new System.EventHandler(this.deleteSelectedPlayersButton_Click);
            // 
            // deleteSelectedPricesButton
            // 
            this.deleteSelectedPricesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPricesButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedPricesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPricesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPricesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPricesButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPricesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPricesButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.deleteSelectedPricesButton.Location = new System.Drawing.Point(433, 212);
            this.deleteSelectedPricesButton.Name = "deleteSelectedPricesButton";
            this.deleteSelectedPricesButton.Size = new System.Drawing.Size(78, 46);
            this.deleteSelectedPricesButton.TabIndex = 24;
            this.deleteSelectedPricesButton.Text = "Remove Selected";
            this.deleteSelectedPricesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPricesButton.Click += new System.EventHandler(this.deleteSelectedPricesButton_Click);
            // 
            // prizesLabels
            // 
            this.prizesLabels.AutoSize = true;
            this.prizesLabels.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizesLabels.Location = new System.Drawing.Point(250, 184);
            this.prizesLabels.Name = "prizesLabels";
            this.prizesLabels.Size = new System.Drawing.Size(64, 25);
            this.prizesLabels.TabIndex = 23;
            this.prizesLabels.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 20;
            this.prizesListBox.Location = new System.Drawing.Point(239, 212);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(188, 82);
            this.prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.BorderSize = 2;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.createTournamentButton.Location = new System.Drawing.Point(106, 327);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(290, 45);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "CREATE TOURNAMENT";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 401);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPricesButton);
            this.Controls.Add(this.prizesLabels);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.tournamentPlaterlabel);
            this.Controls.Add(this.tornamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addteamButton);
            this.Controls.Add(this.createNewLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.LinkLabel createNewLink;
        private System.Windows.Forms.Button addteamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tornamentTeamsListBox;
        private System.Windows.Forms.Label tournamentPlaterlabel;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPricesButton;
        private System.Windows.Forms.Label prizesLabels;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}