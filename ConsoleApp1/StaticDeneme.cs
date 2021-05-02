using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StaticDeneme
    {
        static int a = 0;


        public static void metod()
        {
            a++;
            Console.WriteLine(a);
        }

        public int nonStatic()
        {
            return 4;
        }
        //public static List<BitArray> TauFuncImplement(List<BitArray> gelen64BitArrayler)
        //{



        //    List<BitArray> constanBits = new List<BitArray>();
        //    string[] roundConstants = new string[24];
        //    roundConstants[0] = "f0";
        //    roundConstants[1] = "e1";
        //    roundConstants[2] = "d2";
        //    roundConstants[3] = "c3";
        //    roundConstants[4] = "b4";
        //    roundConstants[5] = "a5";
        //    roundConstants[6] = "96";
        //    roundConstants[7] = "87";
        //    roundConstants[8] = "78";
        //    roundConstants[9] = "69";
        //    roundConstants[10] = "5a";
        //    roundConstants[11] = "4b";
        //    roundConstants[12] = "13";
        //    roundConstants[13] = "26";
        //    roundConstants[14] = "0c";
        //    roundConstants[15] = "19";
        //    roundConstants[16] = "32";
        //    roundConstants[17] = "25";
        //    roundConstants[18] = "0a";
        //    roundConstants[19] = "15";
        //    roundConstants[20] = "2a";
        //    roundConstants[21] = "1d";
        //    roundConstants[22] = "3a";
        //    roundConstants[23] = "2b";

        //    StringToHex stringToHex = new StringToHex();

        //    foreach (var item in roundConstants)
        //    {
        //        constanBits.Add(stringToHex.ConvertHexToBitArray(item));
        //    }


        //}

    }
}
