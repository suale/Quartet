using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class FinalTagGeneration
    {

        TagGenR tagGenR = new TagGenR();
        Concatenate concatenate = new Concatenate();
        DivideSecretKey divideSecretKey = new DivideSecretKey();

        public BitArray GenerateTag(List<BitArray> gelenBitarray, List<BitArray> keyStreamList,string secretKeyString)
        {
            List<BitArray> birlesecekKeyStream = new List<BitArray>();
            BitArray Tag = new BitArray(128, true);
            BitArray secretKey = new BitArray(128, true);
            for (int i = 0; i < 24; i++)
            {
                tagGenR.OneTagGenRoundImplement(gelenBitarray);
            }

            birlesecekKeyStream.Add(keyStreamList[keyStreamList.Count - 1]);
            birlesecekKeyStream.Add(keyStreamList[keyStreamList.Count - 2]);

            secretKey=concatenate.ConcTogether(divideSecretKey.DivideKey(secretKeyString));

            Tag = (concatenate.ConcTogether(birlesecekKeyStream)).Xor(secretKey);


            return Tag;
        }

    }
}
