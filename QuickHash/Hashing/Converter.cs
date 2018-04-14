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
            ExtensionBytes = 5
        } //HashType

        public static string Convert(string text, int hashType, bool littleEndian)
        {
            string result = "";

            switch (hashType)
            {
                case (int)HashType.Path64:
                    result = Hashing.HashFileName(text).ToString("x");
                    break;
                case (int)HashType.Path64WithExtension:
                    result = Hashing.HashFileNameWithExtension(text).ToString("x");
                    break;
                case (int)HashType.String64:
                    result = Hashing.HashFileNameLegacy(text).ToString("x");
                    break;
                case (int)HashType.Path32:
                    result = ToThirtyTwoBit(Hashing.HashFileName(text).ToString("x"));
                    break;
                case (int)HashType.String32:
                    result = ToThirtyTwoBit(Hashing.HashFileNameLegacy(text).ToString("x"));
                    break;
                case (int)HashType.ExtensionBytes:
                    result = (Hashing.HashFileExtension(text) << 3).ToString("x");
                    break;
            } //switch

            if (littleEndian)
                result = ToLittleEndian(result);

            return result;
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

        private static string ToThirtyTwoBit(string sixtyFourBit)
        {
            return sixtyFourBit.Substring(sixtyFourBit.Length - 8, 8);
        } //To32Bit
    } //class
} //namespace
