using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Using_GenericClass<T> where T: IComparable// Implement the generic CompareTo method with the T
    {
        public T First, Second, Third;
        public Using_GenericClass(T First,T Second,T Third)
        {
            this.First = First;
            this.Second = Second;
            this.Third = Third;
        }
        public void FindMax()
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine(First+" is Greatest");
            }
            else if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine(Second+" is Greatest");
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                Console.WriteLine(Third + " is Greatest");
            }
        }
    }
}
