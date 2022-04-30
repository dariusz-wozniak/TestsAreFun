namespace TestsAreFun.Tests.Unit._03_SetupAndFixture._0_SimpleExample;

public class SimpleTest
{
    [SetUp]
    public void Setup() { TestContext.WriteLine("Setup"); }

    [TearDown]
    public void TearDown() { TestContext.WriteLine("TearDown"); }

    [Test]
    public void test() { TestContext.WriteLine("Test"); }

    [Test]
    public void test2() { TestContext.WriteLine("Test 2"); }
}