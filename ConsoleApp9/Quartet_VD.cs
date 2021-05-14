using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Quartet_VD
    {

        public void Decrypt(string secretKey, string nonce, string assocData, string sifreliMetin, string Tag)
        {
            InitializationPhase initializationPhase = new InitializationPhase();
            ProcAssocData procAssocData = new ProcAssocData();
            ProcPlainText procPlainText = new ProcPlainText();
            List<List<BitArray>> procPlainResult = new List<List<BitArray>>();

            procPlainResult = procPlainText.ProcPlainTextImplement(procAssocData.ProcAssocDataImp(initializationPhase.InitialPhase(secretKey, nonce), assocData), sifreliMetin);




        }


    }
}
