Console.Write("What is your name? ");
string name = Console.ReadLine() ?? "Unknown";

int age = ReadValidAge();

DeveloperProfile profile = new DeveloperProfile(name, age);

while (profile.Technologies.Count < 3)
{
    int technologyNumber = profile.Technologies.Count + 1;

    Console.Write($"Enter technology #{technologyNumber}: ");
    string? technology = Console.ReadLine();

    bool wasAdded = profile.AddTechnology(technology);

    if (!wasAdded)
    {
        Console.WriteLine("Technology cannot be empty. Please try again.");
    }
}

int ageNextYear = profile.GetAgeNextYear();

Console.WriteLine($"\nHello, {profile.Name}! Welcome to C#.");
Console.WriteLine($"Next year, you will be {ageNextYear} years old.");

Console.WriteLine("\nYour learning plan:");

for (int i = 0; i < profile.Technologies.Count; i++)
{
    Console.WriteLine($"{i + 1}. {profile.Technologies[i]}");
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
