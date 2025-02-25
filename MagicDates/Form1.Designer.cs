namespace MagicDates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MonthTextBox = new TextBox();
            YearTextBox = new TextBox();
            DayTextBox = new TextBox();
            MonthLabel = new Label();
            DayLabel = new Label();
            YearLabel = new Label();
            MagicButton = new Button();
            ExitButton = new Button();
            InstructionalLabel = new Label();
            MessageDisplay = new Label();
            SuspendLayout();
            // 
            // MonthTextBox
            // 
            MonthTextBox.Location = new Point(204, 82);
            MonthTextBox.Name = "MonthTextBox";
            MonthTextBox.Size = new Size(125, 27);
            MonthTextBox.TabIndex = 0;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(204, 172);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 1;
            // 
            // DayTextBox
            // 
            DayTextBox.Location = new Point(204, 126);
            DayTextBox.Name = "DayTextBox";
            DayTextBox.Size = new Size(125, 27);
            DayTextBox.TabIndex = 2;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Location = new Point(113, 85);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(55, 20);
            MonthLabel.TabIndex = 3;
            MonthLabel.Text = "Month:";
            // 
            // DayLabel
            // 
            DayLabel.AutoSize = true;
            DayLabel.Location = new Point(113, 129);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(38, 20);
            DayLabel.TabIndex = 4;
            DayLabel.Text = "Day:";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(113, 175);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(40, 20);
            YearLabel.TabIndex = 5;
            YearLabel.Text = "Year:";
            // 
            // MagicButton
            // 
            MagicButton.Location = new Point(100, 280);
            MagicButton.Name = "MagicButton";
            MagicButton.Size = new Size(94, 54);
            MagicButton.TabIndex = 6;
            MagicButton.Text = "Magic Button";
            MagicButton.UseVisualStyleBackColor = true;
            MagicButton.Click += MagicButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(246, 280);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 54);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // InstructionalLabel
            // 
            InstructionalLabel.AutoSize = true;
            InstructionalLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InstructionalLabel.Location = new Point(26, 31);
            InstructionalLabel.Name = "InstructionalLabel";
            InstructionalLabel.Size = new Size(385, 31);
            InstructionalLabel.TabIndex = 8;
            InstructionalLabel.Text = "Enter a date to find out if it's magic!";
            // 
            // MessageDisplay
            // 
            MessageDisplay.BorderStyle = BorderStyle.FixedSingle;
            MessageDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageDisplay.Location = new Point(76, 221);
            MessageDisplay.Name = "MessageDisplay";
            MessageDisplay.Size = new Size(283, 38);
            MessageDisplay.TabIndex = 9;
            MessageDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 374);
            Controls.Add(MessageDisplay);
            Controls.Add(InstructionalLabel);
            Controls.Add(ExitButton);
            Controls.Add(MagicButton);
            Controls.Add(YearLabel);
            Controls.Add(DayLabel);
            Controls.Add(MonthLabel);
            Controls.Add(DayTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(MonthTextBox);
            Name = "Form1";
            Text = "Magic Dates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MonthTextBox;
        private TextBox YearTextBox;
        private TextBox DayTextBox;
        private Label MonthLabel;
        private Label DayLabel;
        private Label YearLabel;
        private Button MagicButton;
        private Button ExitButton;
        private Label InstructionalLabel;
        private Label MessageDisplay;
    }
}
