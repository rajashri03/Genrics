// See https://aka.ms/new-console-template for more information
using Generics;

bool check = true;
MaxNum max = new MaxNum();
while (check)
{
    Console.Write("Select Option:\n1)Find Integer Maximum Number\n2)Find Float Maximum Number\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
           int result = max.FindIntMax(2,3,4);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
            Console.WriteLine("-----------------------------------");
            break;
        case 2:
            float result1 = max.FindFloatMax(2.7f,5.6f,3.5f);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum Number is:" + result1);// To display Maximum Number
            Console.WriteLine("-----------------------------------");

            break;
        default:
            check = !check;
            break;
    }
}