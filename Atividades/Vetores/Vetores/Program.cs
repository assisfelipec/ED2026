/*
Arrays
Sintaxe: Type[] name;
*/

// Declaração sem inicialização
// Obs.. variavél alocada mas nula
using System.Runtime.ConstrainedExecution;

int[] numbers;

// Inicializando o array
numbers = new int[5];

// Atribuindo valores no array
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// É possível declarar o array e já definir e atribuir
int[] number2 = new int[]
{
    100, 200, 300
};
int[] number3 = new int[]
{
    1000, 2000, 3000, 4000
};

// Percorrendo um array e adicionando
// valores dinamicamente
System.Console.WriteLine("Inforeme o tamanho do vetor de inteiros:");
int size = Convert.ToInt32(
    Console.ReadLine()
);

int[] array = new int[size];

int Total = 0;

for(int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"Qual o valor do indíce {i}: ");
    array[i] = Convert.ToInt32(
        Console.ReadLine()
    );

    Total += array[i];
}
System.Console.WriteLine("Os valores dentro do array são:");

for(int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"Índice {i}: {array[i]}");
}

System.Console.WriteLine($"Valor acumulado do array: {Total}");

