using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class InitializationPhase
    {

        OneIniRound OneIniRound = new OneIniRound();

        BitArray key70;
        BitArray key158;


        public List<BitArray> InitialPhase(List<BitArray> gelenBitArrayler)
        {
            for (int i = 0; i < 24; i++)
            {
                OneIniRound.OneIniRoundImplemen(gelenBitArrayler);


            }

            gelenBitArrayler[0] = gelenBitArrayler[0].Xor(key70);
            gelenBitArrayler[1] = gelenBitArrayler[1].Xor(key158);

            return gelenBitArrayler;


        }









    }
}
