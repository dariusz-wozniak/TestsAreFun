﻿using System;
using TestsAreFun.Customer;

namespace TestsAreFun.Tests.Unit._08_Mocking._02_ArgumentMatching;

public class MatchersInSeparateMethods
{
    [Test]
    public void customer_is_added_depending_on_validation_result()
    {
        var validator = Mock.Of<ICustomerValidator>(v =>
            v.Validate(StartsWithJ) == true); // custom argument matcher

        var customerRepository = new CustomerRepository(validator);

        customerRepository.Add(Mock.Of<ICustomer>(customer =>
            customer.FirstName == "John"));

        customerRepository.Add(Mock.Of<ICustomer>(customer =>
            customer.FirstName == "james"));

        customerRepository.Add(Mock.Of<ICustomer>(customer =>
            customer.FirstName == "Ken"));

        Assert.That(customerRepository.AllCustomers, Has.Count.EqualTo(1));

        Assert.That(customerRepository.AllCustomers,
            Has.Exactly(1).Matches<ICustomer>(customer => customer.FirstName == "John"));
    }

    private ICustomer StartsWithJ => It.Is<ICustomer>(x =>
        x != null &&
        !string.IsNullOrEmpty(x.FirstName) &&
        x.FirstName.StartsWith("J", StringComparison.InvariantCulture));

    // ReSharper disable once UnusedMember.Local
    // ReSharper disable once InconsistentNaming
    private ICustomer StartsWithJ_ByMatchCreate => Match.Create<ICustomer>(x =>
        !string.IsNullOrEmpty(x?.FirstName) &&
        x.FirstName.StartsWith("J", StringComparison.InvariantCulture));
}