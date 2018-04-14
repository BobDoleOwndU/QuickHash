using System;
using System.Windows.Forms;

namespace QuickHash
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string text = "";
                int hashType = 0;
                bool littleEndian = false;
                
                text = args[0];

                if (args.Length > 1)
                    switch (args[1])
                {
                    case "-p64":
                        hashType = 0;
                        break;
                    case "-p64e":
                        hashType = 1;
                        break;
                    case "-s64":
                        hashType = 2;
                        break;
                    case "-p32":
                        hashType = 3;
                        break;
                    case "-s32":
                        hashType = 4;
                        break;
                    case "-e":
                        hashType = 5;
                        break;
                } //switch

                if (args.Length > 2)
                    if (args[2] == "-l")
                        littleEndian = true;

                Console.WriteLine(Hashing.Converter.Convert(text, hashType, littleEndian));

                return;
            } //if

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
