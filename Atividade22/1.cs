using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Carlos", "Ana", "Bruno", "Eduardo", "Daniel" };

        BubbleSortCrescente(nomes);

        Console.WriteLine("Ordem Crescente:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void BubbleSortCrescente(string[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // CompareTo faz comparação lexicográfica (ordem alfabética)
                if (vetor[j].CompareTo(vetor[j + 1]) > 0)
                {
                    string temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
}