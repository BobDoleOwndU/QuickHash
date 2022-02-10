using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuickHash.Hashing
{
    public class FnvHashManager
    {
        public abstract class FNVHash : HashAlgorithm
        {
            protected const uint FNV32_PRIME = 16777619;
            protected const uint FNV32_OFFSETBASIS = 2166136261;

            public FNVHash(int hashSize)
            {
                this.HashSizeValue = hashSize;
                this.Initialize();
            }
        }

        public class FNV1Hash32 : FNVHash
        {
            private uint _hash;

            public FNV1Hash32()
                : base(32) { }

            public override void Initialize()
            {
                _hash = FNV32_OFFSETBASIS;
            }

            protected override void HashCore(byte[] array, int ibStart, int cbSize)
            {
                for (int i = 0; i < cbSize; i++)
                    _hash = (_hash * FNV32_PRIME) ^ array[ibStart + i];
            }

            protected override byte[] HashFinal()
            {
                return BitConverter.GetBytes(_hash);
            }
        }

        //tex fnvhash from https://gist.github.com/RobThree/25d764ea6d4849fdd0c79d15cda27d61 check.cs
        public static uint FNV1HashConvert(string text)
        {
            var fnvHash = new FNV1Hash32();
            var value = fnvHash.ComputeHash(Encoding.UTF8.GetBytes(text));//DEBUGNOW encoding? -v-
            var hash = BitConverter.ToUInt32(value, 0);
            return hash;
        }//FNV1Hash32Str
    }
}
