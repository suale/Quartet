using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Rotate64
    {

        public BitArray rotateRight(BitArray gelenBitArray, int neKadar)
        {
            BitArray gidenBitArray = new BitArray(gelenBitArray.Length, true);

            for (int i = 0; i < gelenBitArray.Length; i++)
            {
                if (i - neKadar >= 0)
                    gidenBitArray[i] = gelenBitArray[i - neKadar];
                else
                    gidenBitArray[i] = gelenBitArray[gelenBitArray.Length + (i - neKadar)];

            }


            return gidenBitArray;
        }


    }
}
