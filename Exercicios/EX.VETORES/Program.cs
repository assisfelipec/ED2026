int[] mainArray = new int[10];
int evenCounter = 0;
int oddCounter = 0;

Console.WriteLine(
    "Separador de pares e impares:"
);

for(int i = 0; i < mainArray.Length; i++)
{
    Console.WriteLine("Digite um valor:");
    mainArray[i] = Convert.ToInt32(
        Console.ReadLine()  
    );

    if(mainArray[i] % 2 == 0)
    {
        evenCounter += 1;
    }
    else
    {
        oddCounter += 1;
    }
}

int[] evenArray = new int[evenCounter];
int[] oddArray = new int[oddCounter];

for(int i = 0, j = 0, k = 0; i < mainArray.Length; i++)
{
    if(mainArray[i] % 2 == 0)
    {
        evenArray[j] = mainArray[i];
        j++;
    }
    else
    {
        oddArray[k] = mainArray[i];
        k++;
    }   
}

Console.WriteLine("\nNumeros pares:");

foreach(int i in evenArray)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\nNumeros impares:");

foreach(int i in oddArray)
{
    Console.Write($"{i} ");
}


