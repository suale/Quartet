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

        KeyIVLoad keyIVLoad = new KeyIVLoad();


        DivideSecretKey divideSecretKey = new DivideSecretKey();

        public List<BitArray> InitialPhase(string secretKey, string nonce)
        {
           List<BitArray> gelenBitArrayler= keyIVLoad.Load(secretKey, nonce);
            List<BitArray> xorLancak = new List<BitArray>();
            xorLancak = divideSecretKey.DivideKey(secretKey);
           
            for (int i = 0; i < 24; i++)
            {
                OneIniRound.OneIniRoundImplemen(gelenBitArrayler);


            }
            //Altta xorlanacak değerler başlangıçta gelen değerler olarak düzeltilecek
            gelenBitArrayler[0] = gelenBitArrayler[0].Xor(xorLancak[1]);
            gelenBitArrayler[1] = gelenBitArrayler[1].Xor(xorLancak[0]);

            return gelenBitArrayler;


        }









    }
}
