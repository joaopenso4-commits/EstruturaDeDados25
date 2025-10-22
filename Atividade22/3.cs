using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Carlos", "Ana", "Bruno", "Eduardo", "Daniel" };

        InsertionSort(nomes);

        Console.WriteLine("Ordenado com Insertion Sort:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void InsertionSort(string[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            string chave = vetor[i];
            int j = i - 1;

            // Move elementos maiores que a chave uma posição à frente
            while (j >= 0 && vetor[j].CompareTo(chave) > 0)
            {
                vetor[j + 1] = vetor[j];
                j--;
            }

            vetor[j + 1] = chave;
        }
    }
}