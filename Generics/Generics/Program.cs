// See https://aka.ms/new-console-template for more information
using Generics;

// Creating an object using 'new'
// Calling the parameterized constructor With parameters 2,3,4
Integer_Max_Num max = new Integer_Max_Num(2,7,5);
int result =max.FindMax();
Console.WriteLine("-----------------------------------");
Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
Console.WriteLine("-----------------------------------");
