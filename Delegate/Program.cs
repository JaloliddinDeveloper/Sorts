internal class Program
{
    delegate int Operation(int a, int b);
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Multiple(int a, int b)
    {
        return a * b;
    }
    private static void Main(string[] args)
    {
        Operation operationAdd = Add;
        Console.WriteLine(operationAdd(7, 9));

        Operation operationMultiple = Multiple;
        Console.WriteLine(operationMultiple(8, 4));
    }
}