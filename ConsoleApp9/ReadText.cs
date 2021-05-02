using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ReadText
    {
        public List<BitArray> lane = new List<BitArray>();

        public List<BitArray> DivideLanes(string plainText)
        {
            int laneCount;
            laneCount = ((plainText.Length) - (plainText.Length % 8)) / 8;

            List<string> laneWord = new List<string>();

            for (int i = 0; i < laneCount; i++)
            {
                int stringBaslangic = i * 8;
                laneWord.Add(plainText.Substring(stringBaslangic, 8));

            }

            foreach (var word in laneWord)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(word);
                BitArray bits = new BitArray(bytes);//64 bitlik bit dizileri
                lane.Add(bits);
            }
            return lane;//64 bitlik bit dizilerinden oluşan liste

        }

    }
}
