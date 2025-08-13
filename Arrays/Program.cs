// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Ola Mundo!");

Console.WriteLine("Informe seu nome:");

string? name = Console.ReadLine();

// ? -> Operador nullable : indica que a variavel pode receber valor nulo 

Console.WriteLine(
    $"seja bem-vindo {name}"
);

//Declarando vetor 
//sem inicializaçao
int[] numbers;

//inicializando vetor 
numbers = new int[5];

int[] numbers2 = new int[5];

//atribuindo valores
numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

//declarando e inicializando com valores
int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

int[] numbers4 = new int[] { 1, 2, 3, 4, 5 };

//preenchendo um vetor com os 12 meses do ano 

string[] months = new string[12];
for (int i = 1; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    string monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));

    months[i - 1] = monthName;
}

foreach (var month in months)
{
    Console.WriteLine(month);
}

// ARRAY MULTI-DIMENSIONAL

int[,] numbers52 = new int[5, 2];

//3 dimencoes

int[,,] numbers543 = new int[5, 2, 3];

//inicializando matriz valorada

int[,] nmb = new int[,]
{
    { 1, 2, -9 },
    { 5, 7 , 10 },
    { 6, 115 , 54 }
};

//tambem podemos acessar a matriz da seguinte maneira

int myNumber = nmb[2, 1];

Console.WriteLine("imprimindo valor da matriz");
Console.WriteLine(myNumber);