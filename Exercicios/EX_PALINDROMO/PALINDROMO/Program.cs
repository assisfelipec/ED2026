System.Console.WriteLine("Digite uma palavra:");
string word = Console.ReadLine();
char[] reverseWord = new char[word.Length];

for(int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
{
    reverseWord[j] = word[i];
}

string charReverse = new string(reverseWord);

if(charReverse == word)
{
    System.Console.WriteLine("É palíndromo");
}
else
{
    System.Console.WriteLine("Não é palíndromo");   
}