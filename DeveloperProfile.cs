public class DeveloperProfile
{
    private readonly List<string> _technologies = new List<string>();

    public string Name { get; }

    public int Age { get; }

    public IReadOnlyList<string> Technologies
    {
        get
        {
            return _technologies;
        }
    }

    public DeveloperProfile(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool AddTechnology(string? technology)
    {
        if (string.IsNullOrWhiteSpace(technology))
        {
            return false;
        }

        _technologies.Add(technology.Trim());
        return true;
    }

    public int GetAgeNextYear()
    {
        return Age + 1;
    }
}
