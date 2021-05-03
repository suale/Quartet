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

            foreach (var item in gelen64BitArrayler)
            {
                giden64BitArrayler.Add(item);
            }

            BitArray gecici = new BitArray(8, true);
            BitArray gidenGecici = new BitArray(8, true);

            for (int i = 0; i < gelen64BitArrayler.Count; i++)
            {

                for (int j = 0; j < gecici.Count; j++)
                {
                    gecici[j] = gelen64BitArrayler[i][gelen64BitArrayler[i].Count - (gecici.Count - j)];

                }
                BitArray gelenConstant = new BitArray(8, true);
                gelenConstant = RoundTauConsts.AddConstant();


                gidenGecici = gecici.Xor(gelenConstant);

                

                for(int t = 0; t < gelen64BitArrayler[i].Count; t++)
                {
                    if (t >= gelen64BitArrayler[i].Count - gidenGecici.Count)
                        giden64BitArrayler[i][t] = gidenGecici[gecici.Count - (gelen64BitArrayler[i].Count - t)];
                   
                }

            }

            return giden64BitArrayler;


        }
    }
}
