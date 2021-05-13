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


        public void ProcPlainTextImplement(List<BitArray> gelenBitArray, string text)
        {
           okunanBitArray= textOku.DivideLanes(text);

            for (int i = 0; i < okunanBitArray.Count; i++)
            {
                zI = zetaFunction.ZetaFunctionImplement(gelenBitArray);
                crypted = zI.Xor(okunanBitArray[i]);
                cryptedTextList.Add(crypted);
                gelenBitArray[0]=gelenBitArray[0].Xor(okunanBitArray[i]);
                procPlainR.OneIniRoundImplemen(gelenBitArray);
            }
        }


    }
}
