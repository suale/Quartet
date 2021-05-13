using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ProcDIV
    {
        List<BitArray> x1x2 = new List<BitArray>();
        StringToHex StringToHex = new StringToHex();
        string stringD0 = "ff";
        string stringD1 = "3f";
        string stringD2 = "00";
        string stringD3 = "80";

        NonceDivider nonceDivider = new NonceDivider();

        List<string> nonceler = new List<string>();

        public List<BitArray> ProcDivImp(string Nonce)
        {
            nonceler = nonceDivider.DivideNonce(Nonce);
            byte[] bytes = Encoding.ASCII.GetBytes(nonceler[1]);
            BitArray bits = new BitArray(bytes);
            x1x2.Add(bits);
            string st11 = nonceler[0].Substring(0, 1);
            string st10 = nonceler[0].Substring(1, 1);
            string st9 = nonceler[0].Substring(2, 1);
            string st8 = nonceler[0].Substring(3, 1);

            BitArray bitarray7=StringToHex.ConvertHexToBitArray(stringD3);
            BitArray bitarray6=StringToHex.ConvertHexToBitArray(stringD2);
            BitArray bitarray5=StringToHex.ConvertHexToBitArray(stringD1);
            BitArray bitarray4= StringToHex.ConvertHexToBitArray(st11);
            BitArray bitarray3 = StringToHex.ConvertHexToBitArray(st10);
            BitArray bitarray2= StringToHex.ConvertHexToBitArray(stringD0);
            BitArray bitarray1 = StringToHex.ConvertHexToBitArray(st9);
            BitArray bitarray0 = StringToHex.ConvertHexToBitArray(st8);
            BitArray bits2 = new BitArray(64, true);
            List<BitArray> birlescek = new List<BitArray>();
            birlescek.Add(bitarray7);
            birlescek.Add(bitarray6);
            birlescek.Add(bitarray5);
            birlescek.Add(bitarray4);
            birlescek.Add(bitarray3);
            birlescek.Add(bitarray2);
            birlescek.Add(bitarray1);
            birlescek.Add(bitarray0);
            for (int i = 0; i < birlescek.Count; i++)
            {
                for (int j = 0; j < birlescek[i].Length; j++)
                {
                    bits2[(i * 8) + j] = birlescek[i][j];
                }
            }


            x1x2.Add(bits2);


            return x1x2;
        }



    }
}
