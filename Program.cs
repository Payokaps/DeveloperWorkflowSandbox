Console.Write("What is your name? ");
string? name = Console.ReadLine();

int age = ReadValidAge();
int ageNextYear = age + 1;

List<string> technologies = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Enter technology #{i}: ");
    string technology = Console.ReadLine() ?? "Unknown";

    technologies.Add(technology);
}

Console.WriteLine($"\nHello, {name}! Welcome to C#.");
Console.WriteLine($"Next year, you will be {ageNextYear} years old.");

Console.WriteLine("\nYour learning plan:");

for (int i = 0; i < technologies.Count; i++)
{
    Console.WriteLine($"{i + 1}. {technologies[i]}");
}

static int ReadValidAge()
{
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

    return age;
}



