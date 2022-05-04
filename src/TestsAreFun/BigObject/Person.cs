namespace TestsAreFun.BigObject;

public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Born { get; set; }
    public Country Citizenship { get; set; }
    public City BirthCity { get; set; }
    public City LivingCity { get; set; }
}

public record City(string Name, Country Country);
public record Country(string Name);