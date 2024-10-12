using System;

class Program
{
    static void Main()
    {
        dynamic myVariable;

        myVariable = 10;
        Console.WriteLine("Integer: " + myVariable);

        myVariable = "Salom, Dunyo!";
        Console.WriteLine("String: " + myVariable);

        myVariable = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array: " + string.Join(", ", myVariable));

        myVariable = new Action(() =>
            Console.WriteLine("Dynamic Funksiya!")); 

        myVariable();
    }
}
