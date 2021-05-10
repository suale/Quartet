using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class AssociatedDataSec
    {

        List<BitArray> gidenBitArrayler = new List<BitArray>();
        XFunction xFunction = new XFunction();
        RoFunction roFunction = new RoFunction();
        LambdaFunction lambdaFunction = new LambdaFunction();
        TauFunction tauFunction = new TauFunction();

        int sabit0 = 20, sabit1 = 23, sabit2 = 5, sabit3 = 26;//ro için sabitler



        int[] param0 = new int[2] { 1, 6 };
        int[] param1 = new int[2] { 10, 17 };
        int[] param2 = new int[2] { 7, 41 };
        int[] param3 = new int[2] { 61, 39 };

        public List<BitArray> OneIniRoundImplemen(List<BitArray> gelenBitArrayler)
        {


            BitArray x3 = lambdaFunction.LambdaFuncImplement(roFunction.RoFunctionImplement(xFunction.XfunctionImplement(gelenBitArrayler[0], gelenBitArrayler[1], gelenBitArrayler[2]), sabit2), param3[0], param3[1]);
            BitArray x2 = lambdaFunction.LambdaFuncImplement(roFunction.RoFunctionImplement(xFunction.XfunctionImplement(gelenBitArrayler[1], gelenBitArrayler[2], gelenBitArrayler[3]), sabit3), param2[0], param2[1]);
            BitArray x1 = lambdaFunction.LambdaFuncImplement(roFunction.RoFunctionImplement(xFunction.XfunctionImplement(gelenBitArrayler[2], gelenBitArrayler[3], gelenBitArrayler[0]), sabit0), param1[0], param1[1]);
            BitArray x0 = lambdaFunction.LambdaFuncImplement(roFunction.RoFunctionImplement(xFunction.XfunctionImplement(gelenBitArrayler[3], gelenBitArrayler[0], gelenBitArrayler[1]), sabit1), param0[0], param0[1]);


            gidenBitArrayler.Add(x0);
            gidenBitArrayler.Add(x1);
            gidenBitArrayler.Add(x2);
            gidenBitArrayler.Add(x3);

            return gidenBitArrayler;
        }


    }
}
