namespace TestsAreFun.Tests.Unit._03_SetupAndFixture._1_OneTimeSetup;

[SetUpFixture]
public class OneTimeSetup
{
    [OneTimeSetUp]
    public void OneTime()
    {
        TestContext.WriteLine("Project_OneTimeSetup");
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        TestContext.WriteLine("Project_OneTimeTearDown");
    }
}