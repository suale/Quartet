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
         
        public BitArray LambdaFuncImplement(BitArray gelen64BitArray,int param1, int param2)
        {
            BitArray LambdaFuncSonuc;

           

            

            Rotate64 rotate64 = new Rotate64();

            BitArray kayik1;
            BitArray kayik2;
            BitArray sonuc;

         
                
                kayik1 = rotate64.rotateRight(gelen64BitArray, param1);
                
                kayik2 = rotate64.rotateRight(gelen64BitArray, param2);
               
                sonuc = (gelen64BitArray.Xor(kayik1).Xor(kayik2));
                 LambdaFuncSonuc = sonuc;
                
            
            return LambdaFuncSonuc;
        }


    }
}
