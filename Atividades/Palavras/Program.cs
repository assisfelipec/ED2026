string firstName = "Bilbo";
string lastName = "Bolseiro";

string note = $"{lastName.ToUpper()} {firstName}";

string initials = $"{lastName[0]} {firstName[0]}";

Console.WriteLine(initials);

//Formtação de strings

string texto = string.Format(
    "{0} {1} nascido em {2}",
    firstName,
    lastName,
    "1984"
);

System.Console.WriteLine(texto);
