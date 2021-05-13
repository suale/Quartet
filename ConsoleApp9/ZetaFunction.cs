using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ZetaFunction
    {
        //kontrol edilmedi
        BitArray dogru = new BitArray(64, false);
        int nz = 11;
        Rotate64 rotate64 = new Rotate64();
        public BitArray ZetaFunctionImplement(List<BitArray> gelenBitArrayler)
        {
            BitArray gidenBitArray = new BitArray(64, true);
            dogru[63] = true;
            Rotate64 rotate64 = new Rotate64();

            gidenBitArray = (gelenBitArrayler[2].Xor(gelenBitArrayler[3]).Xor(gelenBitArrayler[1].Xor(dogru))).And((rotate64.rotateRight(gelenBitArrayler[0], nz)));

            return gidenBitArray;
        }

    }
}
