using Flurl;
using Flurl.Http;
using NUnit.Framework;
using System.Threading.Tasks;
using FluentAssertions;
using static TestsAreFun.Tests.Integration.ApiTests.Config;

namespace TestsAreFun.Tests.Integration.ApiTests;

public class UsersApiTests
{
    [Test]
    public async Task get_returns_success()
    {
        var rs = await ApiUrl.AppendPathSegment(UsersResource).GetAsync();

        rs.StatusCode.Should().Be(200);
    }
}