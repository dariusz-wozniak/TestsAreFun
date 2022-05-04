using System;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class DefectAttribute : CategoryAttribute { }