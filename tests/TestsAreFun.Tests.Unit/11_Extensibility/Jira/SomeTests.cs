namespace TestsAreFun.Tests.Unit._11_Extensibility.Jira;

public class SomeTests
{
    [Test]
    [JiraInfo(Id = 31337, Title ="Some hotfix", Description = "Sth didn't work as expected")]
    public void some_jira_hotfix()
    {
        Assert.Pass();
    }
}