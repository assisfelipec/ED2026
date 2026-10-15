public class Vehicle
{
    public string Brand {get; set;}
    public int Year {get; set;}
    public string Color {get; set;}
    public double Value {get; set;}

    public void ShowCar()
    {
        System.Console.WriteLine($"Marca: {Brand}");
        System.Console.WriteLine($"Ano: {Year}");
        System.Console.WriteLine($"Cor: {Color}");
        System.Console.WriteLine($"Valor: {Value}");
    }
}