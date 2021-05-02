using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

  

    class RoFunction
    {


        public List<BitArray> RoFunctionImplement(List<BitArray> bitArrayLer)
        {
            List<BitArray> RoFuncSonuc = new List<BitArray>();

            Divide divide = new Divide();
            Rotate rotate = new Rotate();
            Concatenate concatenate = new Concatenate();

            List<BitArray> divided = new List<BitArray>();
            List<BitArray> willConcatenate = new List<BitArray>();

            int sayac = 0;
            int sabit1 = 20, sabit2 = 23, sabit3 = 5, sabit4 = 26;
            int[] sabitler = new int[4] { sabit1, sabit2, sabit3, sabit4 };

            foreach (var item in bitArrayLer)
            {


                divided = divide.DivideBitArrayTwo(item);
                willConcatenate.Add(rotate.rotateLeft(divided[0], sabitler[sayac]));
                willConcatenate.Add(rotate.rotateLeft(divided[1], sabitler[sayac]));
                concatenate.ConcTogether(willConcatenate);
                RoFuncSonuc.Add(concatenate.ConcTogether(willConcatenate));
                willConcatenate.Clear();
                sayac++;

            }


            return RoFuncSonuc;

        }


    }
}
