using System.Collections;
using System.Formats.Tar;
using System.Globalization;

/*
// ArrayLists

ArrayList arrayList = new ArrayList();

// Adicionando itens à Lista
arrayList.Add(5);

// Adicionando quantias de itens à Lista
arrayList.AddRange(new int[] { 1, 2, 3 });

// Insere o valor 7.8 na posição 3 da lista
arrayList.Insert(3, 7.8);

//Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    System.Console.WriteLine(obj);
}

*/

// LISTAS GENÉRICAS

/* List<double> numbers = new List<double>();
System.Console.WriteLine("DIgite 'sair' para enecerrar.");

bool run = true;

do
{
    System.Console.WriteLine("Digite um número:");
    string numberStr = Console.ReadLine();

    if(numberStr.Equals("sair"))
    {
        System.Console.WriteLine("Procedimento encerrado.");
        System.Console.WriteLine($"A média dos valores informados é: {numbers.Average()}");      
        run = false;
        break;
    }
    else
    {
        if(!double.TryParse(
            numberStr,
            System.Globalization.NumberStyles.Float,
            new NumberFormatInfo(),
            out double number
            )
        )
        {
            System.Console.WriteLine("Você não digiotu um número.");
            continue;
        }

        numbers.Add(number);
    }
    

}while(run); */

List<Person> people = new List<Person>();

// Criar uma variável do tipo Person

Person p1 = new Person();
p1.Name = "João";
p1.Age = 43;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

// Adicionando à lista inline

people.Add( new Person()
{
    Name = "Mary",
    Age = 39,
    Nationality = CountryEnum.US
});

people.Add( new Person()
{
    Name = "Carlito",
    Age = 39,
    Nationality = CountryEnum.AR
});

people.Add( new Person()
{
    Name = "Juanito",
    Age = 39,
    Nationality = CountryEnum.PY
});

// Exemplo de ordenação de Lista Genérica
// Utilizando LINQ

List<Person> results = people.OrderBy(p => p.Name).ToList();

// Percorrendo a lista

foreach(Person p in results)
{

    System.Console.WriteLine(
        $"Nome {p.Name}, Idade {p.Age}, Nac: {p.Nationality}"
    );

}