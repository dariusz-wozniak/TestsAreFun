using System;
using FakeTimeZone;
using NUnit.Framework;

namespace TestsAreFun.Tests.Unit.Multitargeted
{
    public class TimezoneTests
    {
        [Test]
        public void TimezoneCanBeFaked()
        {
            using (new FakeLocalTimeZone(TimeZoneInfo.FindSystemTimeZoneById("UTC+12")))
            {
                var localDateTime = new DateTime(2020, 12, 31, 23, 59, 59, DateTimeKind.Local);
                var utcDateTime = TimeZoneInfo.ConvertTimeToUtc(localDateTime);

                Assert.Multiple(() =>
                {
                    Assert.That(TimeZoneInfo.Local.Id, Is.EqualTo("UTC+12"));
                    Assert.That(localDateTime, Is.EqualTo(utcDateTime.AddHours(12)));
                });
            }
        }
    }
}