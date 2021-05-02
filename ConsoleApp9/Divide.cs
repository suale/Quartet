using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Divide
    {
        public List<BitArray> DivideBitArrayTwo(BitArray gelenBitArray)
        {
            List<BitArray> bolunmusArray = new List<BitArray>();
            BitArray bitArrayFirst = new BitArray(gelenBitArray.Length / 2, true);
            BitArray bitArraySec = new BitArray(gelenBitArray.Length / 2, true);
            for (int i = 0; i < gelenBitArray.Length; i++)
            {
                if (i < gelenBitArray.Length / 2)
                    bitArrayFirst[i] = gelenBitArray[i];
                else
                    bitArraySec[i - gelenBitArray.Length / 2] = gelenBitArray[i];
            }
            bolunmusArray.Add(bitArrayFirst);
            bolunmusArray.Add(bitArraySec);
            return bolunmusArray;
        }


    }
}
