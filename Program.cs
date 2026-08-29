Console.Write("What is your name? ");
string? name = Console.ReadLine();

Console.Write("How old are you? ");
string? ageText = Console.ReadLine();

int age = Convert.ToInt32(ageText);
int ageNextYear = age + 1;

Console.WriteLine($"Hello, {name}! Welcome to C#.");
Console.WriteLine($"Next year, you will be {ageNextYear} years old.");
