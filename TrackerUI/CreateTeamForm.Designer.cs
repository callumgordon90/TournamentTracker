namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTournamentLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropdown = new ComboBox();
            selectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            emailValue = new TextBox();
            cellphoneLabel = new Label();
            lastNameValue = new TextBox();
            emailLabel = new Label();
            firstNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMember = new Button();
            createTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(29, 108);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(281, 31);
            teamNameValue.TabIndex = 13;
            teamNameValue.TextChanged += tournamentNameValue_TextChanged;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.ImageAlign = ContentAlignment.TopLeft;
            teamNameLabel.Location = new Point(21, 68);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            teamNameLabel.Click += tournamentNameLabel_Click;
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentLabel.Location = new Point(12, 18);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(213, 50);
            createTournamentLabel.TabIndex = 11;
            createTournamentLabel.Text = "Create Team";
            createTournamentLabel.Click += createTournamentLabel_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(61, 256);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(189, 50);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(27, 202);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(281, 31);
            selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(21, 162);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(cellphoneLabel);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(12, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 315);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(49, 227);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(189, 50);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(176, 178);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(130, 31);
            cellphoneValue.TabIndex = 28;
            // 
            // emailValue
            // 
            emailValue.Location = new Point(176, 130);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(130, 31);
            emailValue.TabIndex = 26;
            emailValue.TextChanged += textBox1_TextChanged;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellphoneLabel.Location = new Point(15, 172);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(138, 37);
            cellphoneLabel.TabIndex = 27;
            cellphoneLabel.Text = "Cellphone";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(176, 81);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(130, 31);
            lastNameValue.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(15, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(176, 30);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(130, 31);
            firstNameValue.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(15, 75);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 23;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(15, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 23;
            teamMembersListBox.Location = new Point(451, 101);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(258, 533);
            teamMembersListBox.TabIndex = 21;
            teamMembersListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // removeSelectedMember
            // 
            removeSelectedMember.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMember.FlatStyle = FlatStyle.Flat;
            removeSelectedMember.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMember.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedMember.Location = new Point(747, 310);
            removeSelectedMember.Name = "removeSelectedMember";
            removeSelectedMember.Size = new Size(120, 84);
            removeSelectedMember.TabIndex = 22;
            removeSelectedMember.Text = "Remove Selected";
            removeSelectedMember.UseVisualStyleBackColor = true;
            removeSelectedMember.Click += removeSelectedMember_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(318, 651);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(292, 77);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTournamentButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 757);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMember);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTournamentLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropdown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox emailValue;
        private TextBox lastNameValue;
        private Label emailLabel;
        private Label lastNameLabel;
        private TextBox textBox2;
        private Label label2;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMember;
        private Button createTeamButton;
    }
}