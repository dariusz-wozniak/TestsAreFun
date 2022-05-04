using System;
using NBomber.Contracts;
using NBomber.CSharp;
using NUnit.Framework;
using NBomber.Plugins.Http.CSharp;
using NBomber.Plugins.Network.Ping;

namespace TestsAreFun.Tests.Load;

public class api_load_tests
{
    [Test]
    public void get()
    {
        var url = "https://626ff06fc508beec488c91ed.mockapi.io/api/v1/users";
        var httpFactory = HttpClientFactory.Create();

        var step = Step.Create("get",
            clientFactory: httpFactory,
            execute: async context =>
            {
                
                var rs = await context.Client.GetAsync(url, context.CancellationToken);

                return rs.IsSuccessStatusCode ? 
                    Response.Ok(statusCode: (int)rs.StatusCode) :
                    Response.Fail(statusCode: (int)rs.StatusCode);
            });

        var scenario = ScenarioBuilder
            .CreateScenario("simplehttp", step)
            .WithWarmUpDuration(TimeSpan.FromSeconds(3))
            .WithLoadSimulations(new[]
            {
                Simulation.InjectPerSec(rate: 20, TimeSpan.FromSeconds(10))
            });

        NBomberRunner
            .RegisterScenarios(scenario)
            .Run();
    }
}