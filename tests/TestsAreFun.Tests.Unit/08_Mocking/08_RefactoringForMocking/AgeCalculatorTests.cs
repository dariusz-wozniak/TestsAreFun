﻿using System;
using TestsAreFun.AgeCalculator;

namespace TestsAreFun.Tests.Unit._08_Mocking._08_RefactoringForMocking;

public class AgeCalculatorTests
{
    [Test]
    public void calculates_age_properly()
    {
        var currentDate = new DateTime(2015, 1, 1);

        var dateTimeProvider = Mock.Of<IDateTimeProvider>(provider =>
            provider.GetDateTime() == currentDate);

        var ageCalculator = new AgeCalculator.AgeCalculator(dateTimeProvider);

        var dateOfBirth = new DateTime(1990, 1, 1);
        int age = ageCalculator.GetAge(dateOfBirth);

        Assert.That(age, Is.EqualTo(25));
    }
}