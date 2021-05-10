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


        


        public List<BitArray> InitialPhase(List<BitArray> gelenBitArrayler, List<BitArray> assocData)
        {
            if (assocData.Count > 0)
            {
                for (int i = 0; i < assocData.Count; i++)
                {
                    gelenBitArrayler[1] = gelenBitArrayler[1].Xor(assocData[i]);//gelenbit 64 assocdata[i] 8 bit --düzenlenecek
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
