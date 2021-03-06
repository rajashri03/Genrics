using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxNum
    {
        public int FindIntMax(int First, int Second, int Third)//Method for Comparing Numbers And Find Maximum interger Number
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return 0;
        }
        public float FindFloatMax(float First, float Second, float Third)//Method for Comparing Numbers And Find Maximum floating Number
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return 0;
        }
        public string FindMax_String(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 )
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 )
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
            {
                return thirdString;
            }
            return null;
        }
    }
}