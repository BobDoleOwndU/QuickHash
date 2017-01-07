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
            if(!string.IsNullOrWhiteSpace(textTextBox.Text))
            {
                hashTextBox.Text = Hashing.Hashing.GetHashFromString(textTextBox.Text);
            } //if ends
            else
            {
                hashTextBox.Text = "Text can't be whitespace or empty!";
            } //else ends
        } //method proccessButton_click ends
    } //partial class MainForm ends
} //namespace QuickHash ends
