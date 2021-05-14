using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//KONTROL EDİLECEK TAG GENERATION A GEÇİLECEK
namespace ConsoleApp9
{
    class ProcPlainText
    {
        ZetaFunction zetaFunction = new ZetaFunction();

       List<BitArray> okunanBitArray; //64bitlik plain text parçası


        BitArray zI;

        BitArray crypted;

        ProcPlainR procPlainR = new ProcPlainR();

        ReadText textOku = new ReadText();

        List<BitArray> cryptedTextList = new List<BitArray>();

        List<BitArray> keyStreamList = new List<BitArray>();


        public List<List<BitArray>> ProcPlainTextImplement(List<BitArray> gelenBitArray, string text)
        {
            okunanBitArray = textOku.DivideLanes(text);

            List<List<BitArray>> donecek = new List<List<BitArray>>();

            for (int i = 0; i < okunanBitArray.Count; i++)
            {
                zI = zetaFunction.ZetaFunctionImplement(gelenBitArray);
                keyStreamList.Add(zI);
                crypted = zI.Xor(okunanBitArray[i]);
                cryptedTextList.Add(crypted);
                gelenBitArray[0] = gelenBitArray[0].Xor(okunanBitArray[i]);
                procPlainR.OneIniRoundImplemen(gelenBitArray);


            }
            donecek.Add(gelenBitArray);
            donecek.Add(cryptedTextList);
            donecek.Add(keyStreamList);
            return donecek;
        }


    }
}
