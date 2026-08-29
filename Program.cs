Console.Write("What is your name? ");
string? name = Console.ReadLine();

Console.Write("How old are you? ");
string? ageText = Console.ReadLine();

bool isValidAge = int.TryParse(ageText, out int age);

Console.WriteLine($"Hello, {name}! Welcome to C#.");

if (isValidAge && age >= 1 && age <= 120)
{
    int ageNextYear = age + 1;
    Console.WriteLine($"Next year, you will be {ageNextYear} years old.");
}
else if (!isValidAge)
{
    Console.WriteLine("The age entered is not a valid number.");
}
else
{
    Console.WriteLine("The age must be between 1 and 120.");
}

