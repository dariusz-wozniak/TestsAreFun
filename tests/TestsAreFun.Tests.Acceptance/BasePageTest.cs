using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace TestsAreFun.Tests.Acceptance;

public class BasePageTest : ContextTest
{
    public IPage Page { get; private set; }

    public override BrowserNewContextOptions ContextOptions()
    {
       return new BrowserNewContextOptions
        {
            RecordVideoDir = $"test_reports/{CurrentState.RunName}/videos",
            RecordVideoSize = new RecordVideoSize { Width = 1024, Height = 768 },
        };
    }

    [SetUp]
    public async Task PageSetup()
    {
        Page = await Context.NewPageAsync();

        await Context.Tracing.StartAsync(new TracingStartOptions
        {
            Screenshots = true,
            Snapshots = true
        });

        await Page.GotoAsync(Config.BaseUrl);
    }

    [TearDown]
    public async Task PageTeardown()
    {
        await Context.Tracing.StopAsync(new TracingStopOptions
        {
            Path = $"test_reports/{CurrentState.RunName}/{DateTime.UtcNow.Ticks}.zip"
        });

        await Context.CloseAsync();
    }
}