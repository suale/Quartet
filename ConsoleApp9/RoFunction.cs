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


        public BitArray RoFunctionImplement(BitArray bitArray, int gelenSabit)
        {
            BitArray RoFuncSonuc;

            Divide divide = new Divide();
            Rotate rotate = new Rotate();
            Concatenate concatenate = new Concatenate();

            List<BitArray> divided = new List<BitArray>();
            List<BitArray> willConcatenate = new List<BitArray>();

            
            
            


                divided = divide.DivideBitArrayTwo(bitArray);
                willConcatenate.Add(rotate.rotateLeft(divided[0], gelenSabit));
                willConcatenate.Add(rotate.rotateLeft(divided[1], gelenSabit));
                concatenate.ConcTogether(willConcatenate);
                RoFuncSonuc=concatenate.ConcTogether(willConcatenate);
                willConcatenate.Clear();
           


            return RoFuncSonuc;

        }


    }
}
