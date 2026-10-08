using System.Collections;

Hashtable phoneBook = new Hashtable()
    {
        {"Edson Arantes do Nascimento", "0000"},
        {"Ronaldo Nazário dos Santos", "1111"},
        {"Luiz Inacio Lula da SIlva", "2222"}
    };


// Adicionando em tempo de execução
phoneBook["Acelino popó de Freitas"] = "3333";

//Tratamento de erro
try
{
    phoneBook.Add("Edson Arantes do Nascimento", "000000");
}
catch(System.ArgumentException ae) 
{
    System.Console.WriteLine("Chave já existente. \n" + ae.Message );
}
catch(System.Exception ex)
{
    System.Console.WriteLine("Erro imprevisto. \n" + ex.Message);
}

//Percorrendo valores HashTable
System.Console.WriteLine("Caderninho de telefone");

if(phoneBook.Count == 0)
{
    System.Console.WriteLine("Agenda vazia.");
}
else
{
    int i = 1;
    foreach(DictionaryEntry entry in phoneBook)
    {
        System.Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");

        if(i >= phoneBook.Count)
        {
            System.Console.WriteLine("Fim da lista. \n");    
        }
        else
        {
            i++;
        }
    }
}

// Buscando valores

System.Console.WriteLine("Busca por nome:");
string name = Console.ReadLine()!;

if (phoneBook.Contains(name))
{
    string number = (string)phoneBook[name]!;
    System.Console.WriteLine($"Número: {number}");
}
else
{
    System.Console.WriteLine($"{name} não encontrado");
}

// Dicionários

Dictionary<string, string> dic = new Dictionary<string, string>(); 

dic["Dom Pedrão II"] = "666";

foreach(KeyValuePair<string, string> pair in dic)
{
    System.Console.WriteLine("" + pair.Key + " " + pair.Value);
}

    

