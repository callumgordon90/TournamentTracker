namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadExistingTournamentDropdown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentDashboardLabel.Location = new Point(115, 54);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(385, 50);
            tournamentDashboardLabel.TabIndex = 13;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            tournamentDashboardLabel.Click += tournamentDashboardLabel_Click;
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(102, 179);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(425, 31);
            loadExistingTournamentDropdown.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentLabel.Location = new Point(150, 126);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(322, 37);
            loadExistingTournamentLabel.TabIndex = 19;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            loadExistingTournamentLabel.Click += selectTeamMemberLabel_Click;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(210, 243);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(189, 50);
            loadTournamentButton.TabIndex = 21;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(159, 327);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(292, 77);
            createTournamentButton.TabIndex = 33;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 690);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}