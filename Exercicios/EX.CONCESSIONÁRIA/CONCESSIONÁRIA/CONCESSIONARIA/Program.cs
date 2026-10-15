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
Dictionary<string, Vehicle> dataBank = new Dictionary<string, Vehicle>();

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
    Vehicle newCar = new Vehicle();

    Console.Clear();
    Console.WriteLine("Qual a placa do carro?");
    String licensePlate = Console.ReadLine()!;

    Console.WriteLine("Qual a marca do carro?");
    newCar.Brand = Console.ReadLine()!;

    Console.WriteLine("Qual o ano do carro?");
    newCar.Year = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Qual a cor do carro?");
    newCar.Color = Console.ReadLine()!;

    Console.WriteLine("Qual o valor do carro?");
    newCar.Value = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Carro registrado com sucesso!");

    dataBank.Add
    (
        licensePlate, newCar
    );
}

void SearchByLicensePlate()
{
    Console.Clear();
    Console.WriteLine("Qual a placa do veículo?");
    string licensePlate = Console.ReadLine()!;
    foreach(KeyValuePair<string, Vehicle> entry in dataBank)
    {
        if(entry.Key == licensePlate)
        {
            Console.WriteLine("Carro encontrado!\n");
            
        }
    }
}

void ShowInformations(Dictionary<string, Vehicle> DataBank)
{
    
}