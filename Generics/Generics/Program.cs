// See https://aka.ms/new-console-template for more information
using Generics;

bool check = true;
MaxNum max = new MaxNum();
while (check)
{
    Console.Write("Select Option:\n" +
        "1)Find Integer Maximum Number\n" +
        "2)Find Float Maximum Number\n" +
        "3)Find Maximum String\n" +
        "4)Refactor All to One Generic Method\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            int result = max.FindIntMax(2, 3, 4);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
            Console.WriteLine("-----------------------------------");
            break;
        case 2:
            float result1 = max.FindFloatMax(2.7f, 5.6f, 3.5f);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum Number is:" + result1);// To display Maximum Number
            Console.WriteLine("-----------------------------------");
            break;
        case 3:
            string result2 = max.FindMax_String("Apple","Peach","Banana");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum String is:" + result2);// To display Maximum Number
            Console.WriteLine("-----------------------------------");
            break;
        case 4:
            Using_GenericMethod refactor = new Using_GenericMethod();
            int intresult=refactor.FindMax<int>(2, 3, 4);
            string stringresult=refactor.FindMax<string>("Apple", "Banana", "Peach");
            float floatresult=refactor.FindMax<float>(2.7f, 3.4f, 6.4f);
            Console.WriteLine("-------------Int Max----------------------");
            Console.WriteLine("Maximum Interger is:" + intresult);
            Console.WriteLine("\n-------------String Max----------------------");
            Console.WriteLine("Maximum String is:" + stringresult);
            Console.WriteLine("\n-------------Float Max----------------------");
            Console.WriteLine("Maximum Float Number  is:" + floatresult);
            Console.WriteLine("-----------------------------------");
            break;
        default:
            check = !check;
            break;
    }
}