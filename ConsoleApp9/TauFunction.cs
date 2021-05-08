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


        public BitArray TauFuncImplement(BitArray gelen64BitArray)
        {
            //x3 lane gelecek(tek 64 bit ona göre yazıyorsun)
            BitArray giden64BitArray = new BitArray(64,true);

            for (int i = 0; i < gelen64BitArray.Length; i++)
            {
                giden64BitArray[i] = gelen64BitArray[i];
            }



            BitArray gecici = new BitArray(8, true);
            BitArray gidenGecici;
            for (int j = 0; j < gecici.Count; j++)
            {
                gecici[j] = gelen64BitArray[gelen64BitArray.Count - (gecici.Count - j)];

            }



            BitArray gelenConstant;
            gelenConstant = RoundTauConsts.AddConstant();

            gidenGecici = gecici.Xor(gelenConstant);



            for (int t = 0; t < gelen64BitArray.Count; t++)
            {
                if (t >= gelen64BitArray.Count - gidenGecici.Count)
                    giden64BitArray[t] = gidenGecici[gecici.Count - (gelen64BitArray.Count - t)];

            }


            return giden64BitArray;


        }
    }
}












//for (int i = 0; i < gelen64BitArray.Count; i++)
//{

//    for (int j = 0; j < gecici.Count; j++)
//    {
//        gecici[j] = gelen64BitArray[gelen64BitArray.Count - (gecici.Count - j)];

//    }
//    BitArray gelenConstant = new BitArray(8, true);
//    gelenConstant = RoundTauConsts.AddConstant();


//    gidenGecici = gecici.Xor(gelenConstant);



//    for(int t = 0; t < gelen64BitArray.Count; t++)
//    {
//        if (t >= gelen64BitArray.Count - gidenGecici.Count)
//            giden64BitArray[t] = gidenGecici[gecici.Count - (gelen64BitArray.Count - t)];

//    }

//}