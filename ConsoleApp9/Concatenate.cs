using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Concatenate
    {
        public BitArray ConcTogether(List<BitArray> gelenBitArray)
        {
            BitArray returnBitArray = new BitArray(gelenBitArray[0].Length * 2, true);

            for (int i = 0; i < returnBitArray.Length / 2; i++)
            {
                returnBitArray[i] = gelenBitArray[0][i];
                returnBitArray[i + gelenBitArray[0].Length] = gelenBitArray[1][i];
            }

            return returnBitArray;

        }

    }
}
