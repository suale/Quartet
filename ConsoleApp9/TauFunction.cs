using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class TauFunction
    {


        public List<BitArray> TauFuncImplement(List<BitArray> gelen64BitArrayler)
        {
            //x3 lane gelecek(tek 64 bit ona göre yazıyorsun)
            List<BitArray> giden64BitArrayler = new List<BitArray>();

           
            for (int i = 0; i < gelen64BitArrayler.Count; i++)
            {
                gelen64BitArrayler[i]=gelen64BitArrayler[i].Xor(RoundTauConsts.AddConstant());
            }

            return giden64BitArrayler;


        }
    }
}
