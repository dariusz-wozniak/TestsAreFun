using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using NUnit.Framework;
using VerifyNUnit;
using VerifyTests;
using static TestsAreFun.Tests.Approval.Config;

namespace TestsAreFun.Tests.Approval;

public class Users
{
    [Test]
    public Task get()
    {
        var json = ApiUrl.AppendPathSegment(UsersResource).GetStringAsync()
            .GetAwaiter()
            .GetResult();

        return Verifier.Verify(json);
    }
}