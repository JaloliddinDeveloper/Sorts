//Buble Sort
internal class Program
{
    private static void Main(string[] args)
    {
        int[] Sonlar = { 1, 6, 0, -3, -4, 5, 0, 7 };

        for (int i = 0; i < Sonlar.Length - 1; i++)
        {
            for (int j = 0; j < Sonlar.Length - 1; j++)
            {
                //Kamayish
                if (Sonlar[j] < Sonlar[j + 1])
                {
                    int num = Sonlar[j];
                    Sonlar[j] = Sonlar[j + 1];
                    Sonlar[j + 1] = num;
                }
            }
        }
        for (int i = 0; i < Sonlar.Length; i++)
        {
            Console.WriteLine(Sonlar[i]);
        }
    }
}
