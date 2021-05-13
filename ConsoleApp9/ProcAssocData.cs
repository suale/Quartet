using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ProcAssocData
    {
        AssociatedData associatedData = new AssociatedData();
        AssociatedDataSec associatedDataSec = new AssociatedDataSec();
        BitArray dogru = new BitArray(64, false);


        


        public List<BitArray> ProcAssocDataImp(List<BitArray> gelenBitArrayler, string assocDataString)
        {


            List<BitArray> assocData = new List<BitArray>();
            List<string> harfler = new List<string>();

            for (int i = 0; i < assocDataString.Length; i++)
            {
                harfler.Add(assocDataString.Substring(i, 1));

            }
            foreach (var word in harfler)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(word);
                BitArray bits = new BitArray(bytes);
                assocData.Add(bits);
            }

            BitArray gecici = new BitArray(8, true);


            if (assocData.Count > 0)
            {
                for (int i = 0; i < assocData.Count; i++)
                {



                    
                    BitArray gidenGecici;
                    for (int j = 0; j < gecici.Count; j++)
                    {
                        gecici[j] = gelenBitArrayler[1][gelenBitArrayler[1].Count - (gecici.Count - j)];

                    }




                    gidenGecici = gecici.Xor(assocData[i]);



                    for (int t = 0; t < gelenBitArrayler[1].Count; t++)
                    {
                        if (t >= gelenBitArrayler[1].Count - gidenGecici.Count)
                            gelenBitArrayler[1][t] = gidenGecici[gecici.Count - (gelenBitArrayler[1].Count - t)];

                    }


                    // gelenBitArrayler[1] = gelenBitArrayler[1].Xor(assocData[i]);//gelenbit 64 assocdata[i] 8 bit --düzenlenecek
                    associatedData.OneIniRoundImplemen(gelenBitArrayler);



                }
            }

            for (int i = 0; i < 12; i++)
            {
                associatedDataSec.OneIniRoundImplemen(gelenBitArrayler);
            }
            dogru[63] = true;

            gelenBitArrayler[3] = gelenBitArrayler[3].Xor(dogru);

            return gelenBitArrayler;


        }

    }
}
