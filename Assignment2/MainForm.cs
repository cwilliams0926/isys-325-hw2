namespace Assignment2
{
    public partial class MainForm : Form
    {
        private string year;
        private string makeAndModel;
        public MainForm()
        {
            InitializeComponent();
        }

        private void makeAndModelList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            string summary = $"You have purchased a {year} {makeAndModel} with the following features: ";
            if (acCheckBox.Checked) summary += acCheckBox.Text + ", ";
            if (powerWindowsCheckBox.Checked) summary += powerWindowsCheckBox.Text + ", ";
            if (syriusCheckBox.Checked) summary += syriusCheckBox.Text + ", ";
            if (laneAssistCheckBox.Checked) summary += laneAssistCheckBox.Text + ", ";
            summary = summary.TrimEnd(',', ' ');
            summaryLabel.Text = summary;
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void summaryLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void colorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void featuresGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
