
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            string secretKey = "AAAAAAAAAAAAAAAA";
            string nonce = "BBBBBBBBBBBB";
            string assocData = "deneme";
            string metin = "abcdefglssertyul";
            Quartet_AE quartet_AE = new Quartet_AE();
            List<BitArray> crypted = new List<BitArray>();
            crypted=quartet_AE.Encrypt(secretKey, nonce, assocData, metin);

            BitToString bitToString = new BitToString();
            int sayac = 0;
            foreach (var item in crypted)
            {
                Console.WriteLine(bitToString.BitArrayToByteArray(item));
                Console.WriteLine(sayac);
                sayac++;
            }

            

            Console.ReadLine();

        }
    }
}



