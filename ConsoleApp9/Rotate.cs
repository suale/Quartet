using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Rotate
    {


        

        public BitArray rotateLeft(BitArray gelenBitArray, int neKadar)
        {
            BitArray gidenBitArray = new BitArray(gelenBitArray.Length, true);

            for (int i = 0; i < gelenBitArray.Length; i++)
            {

                gidenBitArray[i] = gelenBitArray[(i + neKadar) % (gelenBitArray.Length)];


            }

            return gidenBitArray;
        }
    }    
}
