using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Quartet_AE
    {

        public List<BitArray> Encrypt(string secretKey, string nonce, string assocData, string metin)
        {
            ProcPlainText procPlainText = new ProcPlainText();
            ProcAssocData procAssocData = new ProcAssocData();
            InitializationPhase initializationPhase = new InitializationPhase();


            List<BitArray> initialResult = initializationPhase.InitialPhase(secretKey, nonce);
            List<BitArray> procAssocResult = procAssocData.ProcAssocDataImp(initialResult, assocData);
            List<List<BitArray>> procPlainResult = procPlainText.ProcPlainTextImplement(procAssocResult, metin);


            

            List<BitArray> tagGelen = new List<BitArray>();
            List<BitArray> tagKeyStream = new List<BitArray>();
            List<BitArray> cryptedText = new List<BitArray>();
            tagGelen = procPlainResult[0];
            cryptedText = procPlainResult[1];
            tagKeyStream = procPlainResult[2];
            FinalTagGeneration finalTagGeneration = new FinalTagGeneration();//bu sınıftan emin değilsin

            BitArray Tag = finalTagGeneration.GenerateTag(tagGelen, tagKeyStream, secretKey);

            return cryptedText;
        }


    }
}
