using System.Collections;
using System.Collections.Generic;

/* 
SISTEMA DE CONTROLE DE AUTOMÓVEIS

1 - Cadastrar automóvel
2 - Buscar automóvel pela placa
3 - Listar todos os automóveis
4 - Buscar automóveis por marca
5 - Sair

*/

int choice = 1;
Dictionary<string, List<string>> dataBank = new Dictionary<string, List<string>>();

while(true)
{  
    Menu();

    if(choice == 1)
    {
        Register();
    }

    if(choice == 2)
    {
        SearchByLicensePlate();
    }

    if(choice == 3)
    {
        ShowAll;
    }

    if(choice == 4)
    {
        SearchByBrand();
    }

    if(choice == 5)
    {
        Console.Clear();
        Console.WriteLine("Programa encerrado.");
        break;
    }
}

void Menu()
{
    Console.WriteLine("- Sistema de controle de automóveis -");
    Console.WriteLine("Escolha o que deseja fazer:");
    Console.WriteLine("1 - Cadastrar automóvel");
    Console.WriteLine("2 - Buscar automóvel pela placa");
    Console.WriteLine("3 - Listar todos os automóveis");
    Console.WriteLine("4 - Buscar automóveis por marca");
    Console.WriteLine("5 - Sair");
}

void Register()
{
    Console.Clear();
    Console.WriteLine("Qual a placa do carro?");
    String licensePlate = Console.ReadLine()!;

    Console.WriteLine("Qual a marca do carro?");
    String brand = Console.ReadLine()!;

    Console.WriteLine("Qual o ano do carro?");
    String year = Console.ReadLine()!;

    Console.WriteLine("Qual a cor do carro?");
    String color = Console.ReadLine()!;

    Console.WriteLine("Qual o valor do carro?");
    String value = Console.ReadLine()!;

    List<string> informations = new List<string>
    {
        brand,
        year,
        color,
        value
    };

    dataBank.Add
    (
        licensePlate, informations
    );
}

void SearchByLicensePlate()
{
    foreach(KeyValuePair<string, List<string>> entry in dataBank)
    {
        
    }
}
