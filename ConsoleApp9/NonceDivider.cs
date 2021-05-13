using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class NonceDivider
    {

        public List<string> nonceler = new List<string>();
        string nonce4;
        string nonce8;

        public List<string> DivideNonce(string nonce)
        {
            nonce4 = nonce.Substring(0, 4);

            nonce8 = nonce.Substring(4, 8);

            nonceler.Add(nonce4);
            nonceler.Add(nonce8);
          
            return nonceler;
        }


    }
}
