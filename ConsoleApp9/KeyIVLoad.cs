using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class KeyIVLoad
    {
        DivideSecretKey divideSecretKey = new DivideSecretKey();
        ProcDIV procDIV = new ProcDIV();
        List<BitArray> sifreBolunmus = new List<BitArray>();

        List<BitArray> x1x2 = new List<BitArray>();
     

        List<BitArray> state0 = new List<BitArray>();

        public List<BitArray> Load(string secretKey, string nonce)
        {

            sifreBolunmus = divideSecretKey.DivideKey(secretKey);
            x1x2 = procDIV.ProcDivImp(nonce);
            state0.Add(sifreBolunmus[1]);
            state0.Add(x1x2[0]);
            state0.Add(x1x2[1]);
            state0.Add(sifreBolunmus[0]);
           
            return state0;
        }



    }
}
