public class DeveloperProfile
{
    public string Name { get; }

    public int Age { get; }

    public List<string> Technologies { get; }

    public DeveloperProfile(
        string name,
        int age,
        List<string> technologies)
    {
        Name = name;
        Age = age;
        Technologies = technologies;
    }

    public int GetAgeNextYear()
    {
        return Age + 1;
    }
}
