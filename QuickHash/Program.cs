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
                bool isDecimal = false;

                text = args[0];

                if (args.Length > 1)
                    switch (args[1].ToLower())
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
                        case "-fnv32":
                            hashType = 6;
                            break;
                        case "-geonamehash":
                            hashType = 7;
                            break;
                    } //switch

                if (args.Length > 2)
                    if (args[2] == "-l")
                        littleEndian = true;
                    else if (args[2] == "-d")
                        isDecimal = true;
                else if (args.Length > 3)
                        if (args[3] == "-l")
                            littleEndian = true;
                        else if (args[3] == "-d")
                            isDecimal = true;

                Console.WriteLine(Hashing.Converter.Convert(text, hashType, littleEndian, isDecimal));

                return;
            } //if

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
