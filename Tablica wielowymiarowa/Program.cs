using System;

class Program
{
    static void Main()
    {
        int[,] macierz = new int[10, 10];

        WypelnijMacierz(macierz);
        WyswietlMacierz(macierz);

        int sumaPrzekatnej = SumujPrzekatna(macierz);
        Console.WriteLine($"Suma elementów na przekątnej: {sumaPrzekatnej}");

        Console.ReadKey();
    }

    static void WypelnijMacierz(int[,] macierz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == j)
                    macierz[i, j] = i % 10; 
                else
                    macierz[i, j] = 0;
            }
        }
    }

    static void WyswietlMacierz(int[,] macierz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{macierz[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int SumujPrzekatna(int[,] macierz)
    {
        int suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += macierz[i, i];
        }
        return suma;
    }
}
