using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHash.Hashing
{
    public static class Converter
    {
        enum HashType
        {
            Path64 = 0,
            Path64WithExtension = 1,
            String64 = 2,
            Path32 = 3,
            String32 = 4,
            ExtensionBytes = 5,
            Fnv132 = 6,
        } //HashType

        public static string Convert(string text, int hashType, bool littleEndian, bool isDecimal)
        {
            ulong result = 0;

            switch (hashType)
            {
                case (int)HashType.Path64:
                    result = Hashing.HashFileName(text);
                    break;
                case (int)HashType.Path64WithExtension:
                    result = Hashing.HashFileNameWithExtension(text);
                    break;
                case (int)HashType.String64:
                    result = Hashing.HashFileNameLegacy(text);
                    break;
                case (int)HashType.Path32:
                    result = Hashing.HashFileName(text) & uint.MaxValue;
                    break;
                case (int)HashType.String32:
                    result = Hashing.HashFileNameLegacy(text) & uint.MaxValue;
                    break;
                case (int)HashType.ExtensionBytes:
                    result = (Hashing.HashFileExtension(text) << 3);
                    break;
                case (int)HashType.Fnv132:
                    result = FnvHashManager.FNV1HashConvert(text.ToLower());
                    break;
            } //switch

            string resultString = "";

            if (!isDecimal)
            {
                resultString = result.ToString("x");
                if (littleEndian)
                    resultString = ToLittleEndian(resultString);
            }
            else
            {
                resultString = result.ToString("d");
            }

            return resultString;
        } //Convert

        private static string ToLittleEndian(string bigEndian)
        {
            string littleEndian = "";

            if (bigEndian.Length % 2 != 0)
                bigEndian = "0" + bigEndian;

            for (int i = 0; i < bigEndian.Length; i += 2)
                littleEndian = bigEndian.Substring(i, 2) + littleEndian;


            return littleEndian;
        } //ToLittleEndian
    } //class
} //namespace
