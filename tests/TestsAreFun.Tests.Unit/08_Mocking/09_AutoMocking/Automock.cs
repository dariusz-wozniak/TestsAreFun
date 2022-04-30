using System;
using AutoMoq;
using TestsAreFun.AgeCalculator;

namespace TestsAreFun.Tests.Unit._08_Mocking._09_AutoMocking;

public class Automock
{
    [Test]
    public void mock_dependencies_automatically()
    {
        var moqer = new AutoMoqer();

        moqer.GetMock<IDateTimeProvider>()
             .Setup(x => x.GetDateTime())
             .Returns(new DateTime(2010, 2, 1));

        var lotsOfDependencies = moqer.Create<LotsOfDependencies>();

        var currentDateTime = lotsOfDependencies.GetCurrentDateTime();

        currentDateTime.Should().HaveYear(2010).And.HaveMonth(2).And.HaveDay(1);
    }
}