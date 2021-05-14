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
        readonly BitArray dogru = new BitArray(64, false);//64 bitlik true dolu bitArray oluşturur



       
       
        

        public BitArray XfunctionImplement(BitArray x0, BitArray x1, BitArray x2)
        {


            dogru[63] = true;

            if (x2[63] == true)
                x2[63] = false;
            else
                x2[63] = true;

            x0 = x0.Xor((x2).And(x1));
            

            

            return x0;

        }


    }
}
