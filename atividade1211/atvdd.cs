using System;

class Program
{
    static void Main()
    {

        string[] vetor = { "George Harrison", "Paul McCartney", "John Lennon", "Ringo Starr", "Lula", "Bolsonaro", "123", "456", "789", "2006" };

        Console.Write("Digite o nome ou número que deseja buscar: ");
        string busca = Console.ReadLine();

        int posicao = -1;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
            {
                posicao = i;
                break;
            }
        }

        if (posicao != -1)
        {
            Console.WriteLine($"Valor encontrado na posição {posicao} do vetor.");
        }
        else
        {
            Console.WriteLine("Não encontrado.");
        }

        Console.ReadKey();
    }
}