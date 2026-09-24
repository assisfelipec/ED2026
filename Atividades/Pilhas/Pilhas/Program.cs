using System.ComponentModel;

Stack<char> stack = new Stack<char>();

string text = Console.ReadLine()!;

string reversedText = string.Empty;

foreach(char c in text)
{
    stack.Push(c);
}

while(stack.Count > 0)
{
    reversedText += stack.Pop();
}

string isPalindromo =
    text == reversedText ?
        "é palindromo" :
        "não é palindromo";

System.Console.WriteLine(isPalindromo);