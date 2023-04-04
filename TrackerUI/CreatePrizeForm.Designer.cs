namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(22, 21);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(209, 50);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(282, 113);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(148, 31);
            placeNumberValue.TabIndex = 24;
            placeNumberValue.TextChanged += firstNameValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(58, 107);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 23;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.Click += firstNameLabel_Click;
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(282, 168);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(148, 31);
            placeNameValue.TabIndex = 26;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(58, 162);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 25;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(282, 419);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(148, 31);
            prizePercentageValue.TabIndex = 28;
            prizePercentageValue.Text = "0";
            prizePercentageValue.TextChanged += prizePercentageValue_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(58, 413);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 27;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(282, 224);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(148, 31);
            prizeAmountValue.TabIndex = 30;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(58, 218);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 29;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(222, 310);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 31;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(106, 511);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(292, 77);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 690);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}