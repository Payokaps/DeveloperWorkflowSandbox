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

    public void AddTechnology(string technology)
    {
        _technologies.Add(technology);
    }

    public int GetAgeNextYear()
    {
        return Age + 1;
    }
}
