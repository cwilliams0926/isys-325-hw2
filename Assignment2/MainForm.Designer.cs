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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(makeAndModelList);
            Controls.Add(makeAndModelLabel);
            Name = "MainForm";
            Text = "Assignment 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeAndModelLabel;
        private ListBox makeAndModelList;
    }
}
