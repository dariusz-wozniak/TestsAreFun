namespace TestsAreFun.PersonWithHeight;

public class PersonByHeightComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.HeightInCentimeters.CompareTo(y.HeightInCentimeters);
    }
}