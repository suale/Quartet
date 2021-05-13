using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class DivideSecretKey
    {
        public List<BitArray> sifreler = new List<BitArray>();

        public List<BitArray> DivideKey(string sifre)
        {
            int laneCount;
            laneCount = ((sifre.Length) - (sifre.Length % 8)) / 8;

            List<string> laneWord = new List<string>();

            for (int i = 0; i < laneCount; i++)
            {
                int stringBaslangic = i * 8;
                laneWord.Add(sifre.Substring(stringBaslangic, 8));

            }

            foreach (var word in laneWord)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(word);
                BitArray bits = new BitArray(bytes);//64 bitlik bit dizileri
                sifreler.Add(bits);
            }
            return sifreler;//64 bitlik bit dizilerinden oluşan liste

        }

    }
}
