using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class XFunction
    {
        BitArray dogru = new BitArray(64, false);//64 bitlik true dolu bitArray oluşturur
        
        

        List<BitArray> XFuncSonuc = new List<BitArray>();
        BitArray x0;
        BitArray x1;
        BitArray x2;
        BitArray x3;

        public List<BitArray> XfunctionImplement(List<BitArray> bitArrayLer)
        {
            x0 = bitArrayLer[0];
            x1 = bitArrayLer[1];
            x2 = bitArrayLer[2];
            x3 = bitArrayLer[3];
            dogru[63] = true;

            x0 = (x0.Xor(x2.Xor(dogru)).And(x1));
            x1 = (x1.Xor(x3.Xor(dogru)).And(x2));
            x2 = (x2.Xor(x0.Xor(dogru)).And(x3));
            x3 = (x3.Xor(x1.Xor(dogru)).And(x0));

            XFuncSonuc.Add(x0);
            XFuncSonuc.Add(x1);
            XFuncSonuc.Add(x2);
            XFuncSonuc.Add(x3);

            return XFuncSonuc;

        }


    }
}
