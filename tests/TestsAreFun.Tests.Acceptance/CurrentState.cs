using System;

namespace TestsAreFun.Tests.Acceptance
{
    public static class CurrentState
    {
        public static DateTime StartedUtc { get; set; } = DateTime.UtcNow;
        public static string RunName => StartedUtc.ToString("yyyy-MM-dd--hh-mm-ss--ffff");
    }
}
