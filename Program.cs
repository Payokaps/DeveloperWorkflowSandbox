Console.Write("What is your name? ");
string? name = Console.ReadLine();

int age = 0;
bool isValidAge = false;

while (!isValidAge)
{
    Console.Write("How old are you? ");
    string? ageText = Console.ReadLine();

    bool isNumber = int.TryParse(ageText, out age);

    if (!isNumber)
    {
        Console.WriteLine("The age entered is not a valid number.");
    }
    else if (age < 1 || age > 120)
    {
        Console.WriteLine("The age must be between 1 and 120.");
    }
    else
    {
        isValidAge = true;
    }
}

int ageNextYear = age + 1;

Console.WriteLine($"Hello, {name}! Welcome to C#.");
Console.WriteLine($"Next year, you will be {ageNextYear} years old.");


