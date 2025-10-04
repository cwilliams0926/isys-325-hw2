using System.Diagnostics.Eventing.Reader;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        // enum used to select the color radio buttons
        private enum carColor
        {
            Red, Blue, Black, White
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void makeAndModelList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            int year;
            string summary = "";

            if (makeAndModelList.SelectedItem == null)
            {
                summary = "Please select a make and model before purchasing.";
                summaryLabel.ForeColor = Color.Red;
            }
            else if (!int.TryParse(yearTextBox.Text, out year))
            {
                summary = "Please enter a valid year";
                summaryLabel.ForeColor = Color.Red;
            }
            else
            {
                carColor? selectedColor = null; // Null if none of the radio buttons are selected

                if (redRadioButton.Checked) selectedColor = carColor.Red;
                else if (blueRadioButton.Checked) selectedColor = carColor.Blue;
                else if (blackRadioButton.Checked) selectedColor = carColor.Black;
                else if (whiteRadioButton.Checked) selectedColor = carColor.White;

                summary = $"You have purchased a {selectedColor} {yearTextBox.Text} {makeAndModelList.SelectedItem} with the following features: ";

                if (acCheckBox.Checked) summary += acCheckBox.Text + ", ";
                if (powerWindowsCheckBox.Checked) summary += powerWindowsCheckBox.Text + ", ";
                if (syriusCheckBox.Checked) summary += syriusCheckBox.Text + ", ";
                if (laneAssistCheckBox.Checked) summary += laneAssistCheckBox.Text + ", ";

                summary = summary.TrimEnd(',', ' ');

                summaryLabel.ForeColor = Color.Black; // Change back to black if there was an error
            }
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
