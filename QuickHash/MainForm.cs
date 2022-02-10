using System;
using System.Windows.Forms;

namespace QuickHash
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        } //constructor ends

        private void processButton_Click(object sender, EventArgs e)
        {
            string text = textTextBox.Text;

            if (hashTypeComboBox.SelectedIndex != -1)
                hashTextBox.Text = Hashing.Converter.Convert(text, hashTypeComboBox.SelectedIndex, littleEndianCheckBox.Checked, decimalCheckBox.Checked);
            else
                hashTextBox.Text = "Hash type not selected!";
        } //method proccessButton_click ends

        private void decimalCheckBox_Click(object sender, EventArgs e)
        {
            if (decimalCheckBox.Checked)
            {
                littleEndianCheckBox.Checked = false;
                littleEndianCheckBox.Enabled = false;
            }
            else
                littleEndianCheckBox.Enabled = true;
        }
    } //partial class MainForm ends
} //namespace QuickHash ends
