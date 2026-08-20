/*
Arrays
Sintaxe: Type[] name;
*/

// Declaração sem inicialização
// Obs.. variavél alocada mas nula
using System.Runtime.ConstrainedExecution;
using System.Globalization;

/* int[] numbers;

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

*/

// Exemplo dos nomes dos meses do ano
string[] months = new string[12];

for(int i = 1; i <= 12; i++)
{
    DateTime firstDay =
     new DateTime(DateTime.Now.Year, i, 1);

    DateTime LastDayMonthBefore = 
     firstDay.AddDays(-1);

    string monthName = 
     firstDay.ToString(
            "MMMM",
            CultureInfo.CreateSpecificCulture("pt-BR")
        );
    
    months[i - 1] = monthName;
}

foreach(string monthName in months)
{
    System.Console.WriteLine($"---> {monthName}");
}