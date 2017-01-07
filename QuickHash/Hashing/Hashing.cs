using System;

namespace QuickHash.Hashing
{
    public static class Hashing
    {
        private const string ASSETS_CONST = "/Assets/";

        public static string GetHashFromString(string text)
        {
            string toHash = text;

            if (text.Contains(ASSETS_CONST))
            {
                toHash = text.Substring(ASSETS_CONST.Length);
            } //if ends

            return GetStrCode32(toHash).ToString("x");
        } //method getNameHash ends

        private static ulong GetStrCode32(string text)
        {
            const ulong seed0 = 0x9ae16a3b2f90404f;
            byte[] seed1Bytes = new byte[sizeof(ulong)];
            for (int i = text.Length - 1, j = 0; i >= 0 && j < sizeof(ulong); i--, j++)
            {
                seed1Bytes[j] = Convert.ToByte(text[i]);
            }
            ulong seed1 = BitConverter.ToUInt64(seed1Bytes, 0);
            ulong maskedHash = CityHash.CityHash.CityHash64WithSeeds(text, seed0, seed1) & 0x3FFFFFFFFFFFF;
            return maskedHash;
        } //method GetStrCode32 ends
    } //class Hashing ends
} //namespace QuickHash.Hashing ends
