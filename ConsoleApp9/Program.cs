
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
            string secretKey = "1234567890123456";
            string nonce = "123456789012";

            InitializationPhase initializationPhase = new InitializationPhase();

            

            string assocData = "deneme";

            ProcAssocData procAssocData = new ProcAssocData();

            procAssocData.ProcAssocDataImp(initializationPhase.InitialPhase(secretKey, nonce), assocData);

            


           

            

         



            Console.ReadLine();

        }
    }
}




// List<BitArray> deneme = new List<BitArray>();

// XFunction xFunction = new XFunction();
// deneme= xFunction.XfunctionImplement(textOku.DivideLanes("aksdhjkasjkdlasffafadasdasdsadfafhylk"));



// BitArray dene = new BitArray(64, true);
// dene[1] = false;
// dene[7] = false;
// dene[3] = false;

// StringToHex stringToHex = new StringToHex();
// BitArray asd = new BitArray(8,true);

//asd= stringToHex.ConvertHexToBitArray("a5");

// RoFunction roFunction = new RoFunction();
// roFunction.RoFunctionImplement(deneme);

// LambdaFunction lambdaFunction = new LambdaFunction();

// lambdaFunction.LambdaFuncImplement(deneme);

// TauFunction tauFunction = new TauFunction();
// tauFunction.TauFuncImplement(deneme);