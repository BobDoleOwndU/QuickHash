using System;
using System.Windows.Forms;

namespace QuickHash
{
    public partial class MainForm : Form
    {
        enum HashType
        {
            Path64 = 0,
            Path64WithExtension = 1,
            String64 = 2,
            Path32 = 3,
            String32 = 4,
            ExtensionBytes = 5
        } //HashType

        public MainForm()
        {
            InitializeComponent();
        } //constructor ends

        private void processButton_Click(object sender, EventArgs e)
        {
            string text = textTextBox.Text;

            if (hashTypeComboBox.SelectedIndex != -1)
                hashTextBox.Text = Hashing.Converter.Convert(text, hashTypeComboBox.SelectedIndex, littleEndianCheckBox.Checked);
            else
                hashTextBox.Text = "Hash type not selected!";
        } //method proccessButton_click ends

        private string ToLittleEndian(string bigEndian)
        {
            string littleEndian = "";

            if (bigEndian.Length % 2 != 0)
                bigEndian = "0" + bigEndian;

            for (int i = 0; i < bigEndian.Length; i += 2)
                littleEndian = bigEndian.Substring(i, 2) + littleEndian;


            return littleEndian;
        } //ToLittleEndian

        private string ToThirtyTwoBit(string sixtyFourBit)
        {
            return sixtyFourBit.Substring(sixtyFourBit.Length - 8, 8);
        } //To32Bit
    } //partial class MainForm ends
} //namespace QuickHash ends
