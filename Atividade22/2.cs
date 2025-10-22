using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Carlos", "Ana", "Bruno", "Eduardo", "Daniel" };

        BubbleSortDecrescente(nomes);

        Console.WriteLine("Ordem Decrescente:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void BubbleSortDecrescente(string[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Inverte a condição para ordem decrescente
                if (vetor[j].CompareTo(vetor[j + 1]) < 0)
                {
                    string temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
}