using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> rastreios = new Dictionary<string, string>();
        HashSet<string> barrasUsadas = new HashSet<string>();

        Console.WriteLine("\n--- Sistema de Gerenciamento de Etiquetas de Entrega ---");

        int qtd;
        while (true)
        {
            Console.Write("Quantos registros deseja inserir? ");

            if (int.TryParse(Console.ReadLine(), out qtd) && qtd > 0)
                break;
            else
                Console.WriteLine("Entrada inválida. Digite um número inteiro maior que zero.");
        }

        // Cadastro
        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"\n--- Registro {i + 1} de {qtd} ---");

            string rastreio;
            while (true)
            {
                Console.Write("Digite o código de rastreio: ");
                rastreio = Console.ReadLine().Trim();

                if (rastreios.ContainsKey(rastreio))
                    Console.WriteLine("⚠️  Este código de rastreio já foi cadastrado! Tente outro.");
                else
                    break;
            }

            string codigoBarra;
            while (true)
            {
                Console.Write("Digite o código de barras da encomenda: ");
                codigoBarra = Console.ReadLine().Trim();

                if (barrasUsadas.Contains(codigoBarra))
                    Console.WriteLine("⚠️  Este código de barras já está vinculado a outro rastreio! Tente outro.");
                else
                    break;
            }

            // Salvar
            rastreios[rastreio] = codigoBarra;
            barrasUsadas.Add(codigoBarra);

            Console.WriteLine("✔ Registro inserido com sucesso!");
        }

        // Busca
        while (true)
        {
            Console.WriteLine("\n--- Sistema de Busca ---");
            Console.WriteLine("1 - Buscar por código de rastreio");
            Console.WriteLine("2 - Buscar por código de barras");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            string opc = Console.ReadLine();

            if (opc == "1")
            {
                Console.Write("Digite o código de rastreio: ");
                string r = Console.ReadLine().Trim();

                if (rastreios.ContainsKey(r))
                    Console.WriteLine($"Encontrado! Rastreio: {r} → Código de barras: {rastreios[r]}");
                else
                    Console.WriteLine("Nenhuma encomenda encontrada para este código de rastreio.");
            }
            else if (opc == "2")
            {
                Console.Write("Digite o código de barras: ");
                string b = Console.ReadLine().Trim();

                bool encontrado = false;
                foreach (var par in rastreios)
                {
                    if (par.Value == b)
                    {
                        Console.WriteLine($"Encontrado! Código de barras: {b} → Rastreio: {par.Key}");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                    Console.WriteLine("Nenhuma encomenda encontrada para este código de barras.");
            }
            else if (opc == "0")
            {
                Console.WriteLine("Encerrando o sistema. Até mais!");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
