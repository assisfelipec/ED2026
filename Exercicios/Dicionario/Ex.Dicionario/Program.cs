using System.Collections;
using System.Collections.Generic;

Dictionary<string, string> Products = new Dictionary<string, string>
{
    {"78949007100", "A1"},
    {"78981520063", "B7"},
    {"78971556610", "C5"},
    {"78988611401", "D9"}
};

Products["78989110067"] = "E3";

System.Console.WriteLine("Procure pelo código de barras: ");
string barcode = Console.ReadLine()!;

foreach(DictionaryEntry entry in Products)
{
    if(barcode == entry.Key)
    {
        System.Console.WriteLine($"O produto está localizado em {entry.Value}");
    }
    else
    {
        System.Console.WriteLine("O produto não existe.");
    }
}

//errado