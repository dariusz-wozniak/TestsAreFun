﻿using System;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

[Parallelizable(ParallelScope.None)]
public class OrderingTests
{
    private List<string> _order;

    [OneTimeSetUp]
    public void Setup()
    {
        _order = new List<string>();
    }

    [Test]
    public void unordered()
    {
        _order.Add("Unordered");
    }

    [Test]
    [Order(2)]
    public void test2()
    {
        _order.Add("2");
    }

    [Test]
    [Order(1)]
    public void test1()
    {
        _order.Add("1");
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _order.ForEach(Console.WriteLine);
    }
}