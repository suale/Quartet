using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class RoundTauConsts
    {
       static List<BitArray> constantBits = new List<BitArray>();

        static RoundTauConsts()
        {
            
            string[] roundConstants = new string[24];
            roundConstants[0] = "f0";
            roundConstants[1] = "e1";
            roundConstants[2] = "d2";
            roundConstants[3] = "c3";
            roundConstants[4] = "b4";
            roundConstants[5] = "a5";
            roundConstants[6] = "96";
            roundConstants[7] = "87";
            roundConstants[8] = "78";
            roundConstants[9] = "69";
            roundConstants[10] = "5a";
            roundConstants[11] = "4b";
            roundConstants[12] = "13";
            roundConstants[13] = "26";
            roundConstants[14] = "0c";
            roundConstants[15] = "19";
            roundConstants[16] = "32";
            roundConstants[17] = "25";
            roundConstants[18] = "0a";
            roundConstants[19] = "15";
            roundConstants[20] = "2a";
            roundConstants[21] = "1d";
            roundConstants[22] = "3a";
            roundConstants[23] = "2b";

            StringToHex stringToHex = new StringToHex();

            foreach (var item in roundConstants)
            {
                constantBits.Add(stringToHex.ConvertHexToBitArray(item));
            }
        }








        static int roundSayi = 0;
        static BitArray donecekArray = new BitArray(8, true);
        public static BitArray AddConstant()
        {
            donecekArray = constantBits[roundSayi];
            
            roundSayi++;
            if (roundSayi == 24)
                roundSayi = 0;
            return donecekArray;

        }


        


}
}
