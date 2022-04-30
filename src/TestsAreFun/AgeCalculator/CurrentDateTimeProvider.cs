namespace TestsAreFun.AgeCalculator;

public class CurrentDateTimeProvider : IDateTimeProvider
{
    public DateTime GetDateTime()
    {
        return DateTime.Now;
    }
}