namespace Assignment2
{
    partial class MainForm
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
            makeAndModelLabel = new Label();
            makeAndModelList = new ListBox();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            colorGroupBox = new GroupBox();
            redRadioButton = new RadioButton();
            blueRadioButton = new RadioButton();
            blackRadioButton = new RadioButton();
            whiteRadioButton = new RadioButton();
            featuresGroupBox = new GroupBox();
            acCheckBox = new CheckBox();
            powerWindowsCheckBox = new CheckBox();
            syriusCheckBox = new CheckBox();
            laneAssistCheckBox = new CheckBox();
            colorGroupBox.SuspendLayout();
            featuresGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // makeAndModelLabel
            // 
            makeAndModelLabel.AutoSize = true;
            makeAndModelLabel.Location = new Point(12, 32);
            makeAndModelLabel.Name = "makeAndModelLabel";
            makeAndModelLabel.Size = new Size(96, 15);
            makeAndModelLabel.TabIndex = 0;
            makeAndModelLabel.Text = "&Make and Model";
            // 
            // makeAndModelList
            // 
            makeAndModelList.FormattingEnabled = true;
            makeAndModelList.ItemHeight = 15;
            makeAndModelList.Items.AddRange(new object[] { "Chevy Silverado", "Ford F-150", "Toyota Yaris", "Honda Element" });
            makeAndModelList.Location = new Point(12, 50);
            makeAndModelList.Name = "makeAndModelList";
            makeAndModelList.Size = new Size(120, 94);
            makeAndModelList.TabIndex = 1;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(186, 32);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(29, 15);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "&Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(186, 50);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(100, 23);
            yearTextBox.TabIndex = 3;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(whiteRadioButton);
            colorGroupBox.Controls.Add(blackRadioButton);
            colorGroupBox.Controls.Add(blueRadioButton);
            colorGroupBox.Controls.Add(redRadioButton);
            colorGroupBox.Location = new Point(342, 32);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(200, 174);
            colorGroupBox.TabIndex = 4;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "&Color";
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(18, 41);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(45, 19);
            redRadioButton.TabIndex = 0;
            redRadioButton.TabStop = true;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            blueRadioButton.AutoSize = true;
            blueRadioButton.Location = new Point(18, 66);
            blueRadioButton.Name = "blueRadioButton";
            blueRadioButton.Size = new Size(48, 19);
            blueRadioButton.TabIndex = 1;
            blueRadioButton.TabStop = true;
            blueRadioButton.Text = "Blue";
            blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            blackRadioButton.AutoSize = true;
            blackRadioButton.Location = new Point(18, 91);
            blackRadioButton.Name = "blackRadioButton";
            blackRadioButton.Size = new Size(53, 19);
            blackRadioButton.TabIndex = 2;
            blackRadioButton.TabStop = true;
            blackRadioButton.Text = "Black";
            blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteRadioButton
            // 
            whiteRadioButton.AutoSize = true;
            whiteRadioButton.Location = new Point(18, 116);
            whiteRadioButton.Name = "whiteRadioButton";
            whiteRadioButton.Size = new Size(56, 19);
            whiteRadioButton.TabIndex = 3;
            whiteRadioButton.TabStop = true;
            whiteRadioButton.Text = "White";
            whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // featuresGroupBox
            // 
            featuresGroupBox.Controls.Add(laneAssistCheckBox);
            featuresGroupBox.Controls.Add(syriusCheckBox);
            featuresGroupBox.Controls.Add(powerWindowsCheckBox);
            featuresGroupBox.Controls.Add(acCheckBox);
            featuresGroupBox.Location = new Point(588, 32);
            featuresGroupBox.Name = "featuresGroupBox";
            featuresGroupBox.Size = new Size(200, 174);
            featuresGroupBox.TabIndex = 5;
            featuresGroupBox.TabStop = false;
            featuresGroupBox.Text = "&Features";
            // 
            // acCheckBox
            // 
            acCheckBox.AutoSize = true;
            acCheckBox.Location = new Point(17, 41);
            acCheckBox.Name = "acCheckBox";
            acCheckBox.Size = new Size(42, 19);
            acCheckBox.TabIndex = 0;
            acCheckBox.Text = "AC";
            acCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerWindowsCheckBox
            // 
            powerWindowsCheckBox.AutoSize = true;
            powerWindowsCheckBox.Location = new Point(17, 66);
            powerWindowsCheckBox.Name = "powerWindowsCheckBox";
            powerWindowsCheckBox.Size = new Size(111, 19);
            powerWindowsCheckBox.TabIndex = 1;
            powerWindowsCheckBox.Text = "Power Windows";
            powerWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // syriusCheckBox
            // 
            syriusCheckBox.AutoSize = true;
            syriusCheckBox.Location = new Point(17, 91);
            syriusCheckBox.Name = "syriusCheckBox";
            syriusCheckBox.Size = new Size(90, 19);
            syriusCheckBox.TabIndex = 2;
            syriusCheckBox.Text = "Syrius Radio";
            syriusCheckBox.UseVisualStyleBackColor = true;
            // 
            // laneAssistCheckBox
            // 
            laneAssistCheckBox.AutoSize = true;
            laneAssistCheckBox.Location = new Point(17, 116);
            laneAssistCheckBox.Name = "laneAssistCheckBox";
            laneAssistCheckBox.Size = new Size(84, 19);
            laneAssistCheckBox.TabIndex = 3;
            laneAssistCheckBox.Text = "Lane Assist";
            laneAssistCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(featuresGroupBox);
            Controls.Add(colorGroupBox);
            Controls.Add(yearTextBox);
            Controls.Add(yearLabel);
            Controls.Add(makeAndModelList);
            Controls.Add(makeAndModelLabel);
            Name = "MainForm";
            Text = "Assignment 2";
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            featuresGroupBox.ResumeLayout(false);
            featuresGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeAndModelLabel;
        private ListBox makeAndModelList;
        private Label yearLabel;
        private TextBox yearTextBox;
        private GroupBox colorGroupBox;
        private RadioButton whiteRadioButton;
        private RadioButton blackRadioButton;
        private RadioButton blueRadioButton;
        private RadioButton redRadioButton;
        private GroupBox featuresGroupBox;
        private CheckBox laneAssistCheckBox;
        private CheckBox syriusCheckBox;
        private CheckBox powerWindowsCheckBox;
        private CheckBox acCheckBox;
    }
}
