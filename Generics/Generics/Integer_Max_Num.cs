using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Integer_Max_Num
    {
        //Variable Declaration of Numbers
        int First;
        int Second;
        int Third;
        public Integer_Max_Num(int First,int Second,int Third)// Parameterized Constructor
        {
            this.First = First;
           this.Second = Second;
            this.Third = Third;
        }
        public int FindMax()//Method for Comparing Numbers And Find Maximum Number
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
    }
}
