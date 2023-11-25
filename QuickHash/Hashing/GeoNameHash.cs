using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace QuickHash.Hashing
{
    public class GeoNameHash
    {
        //Reversed by Joey: https://discord.com/channels/364177293133873153/364178190588968970/893488488299757569
        public static uint GeoNameHashConvert(string text)
        {
            uint nameLength = (uint)text.Length;
            uint hash = nameLength;

            for (int i = (int)(nameLength - 1); i >= 0; i--)
                hash ^= text[i] + hash * 0x20 + (hash >> 2);
            return hash;
        }
    }
}
