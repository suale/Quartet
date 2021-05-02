using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class LambdaFunction
    {
         
        public List<BitArray> LambdaFuncImplement(List<BitArray> gelen64BitArrayler)
        {
            List<BitArray> LambdaFuncSonuc = new List<BitArray>();

            List<int[]> parametreler = new List<int[]>();

            int[] param1 = new int[2] { 1, 6 };
            int[] param2 = new int[2] { 10, 17 };
            int[] param3 = new int[2] { 7, 41 };
            int[] param4 = new int[2] { 61, 39 };

            parametreler.Add(param1);
            parametreler.Add(param2);
            parametreler.Add(param3);
            parametreler.Add(param4);

            Rotate64 rotate64 = new Rotate64();

            BitArray kayik1 = new BitArray(64,true);
            BitArray kayik2 = new BitArray(64, true);
            BitArray sonuc = new BitArray(64, true);

            int sayac = 0;
            foreach (var item in gelen64BitArrayler)
            {
                int sayac2 = 0;
                kayik1 = rotate64.rotateRight(item, parametreler[sayac][sayac2]);
                sayac2++;
                kayik2 = rotate64.rotateRight(item, parametreler[sayac][sayac2]);
                sayac++;
                sonuc = (item.Xor(kayik1).Xor(kayik2));
                LambdaFuncSonuc.Add(sonuc);
                
            }
            return LambdaFuncSonuc;
        }


    }
}
