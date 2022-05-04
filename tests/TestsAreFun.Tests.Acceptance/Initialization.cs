using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace TestsAreFun.Tests.Acceptance;

public class Initialization
{
    [OneTimeSetUp]
    public async Task InitializeWithAuthorizationAsync()
    {
        await InstallPlaywright();

        CurrentState.StartedUtc = DateTime.UtcNow;

        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Channel = "chrome" });
        await using var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();
    }

    private static async Task InstallPlaywright()
    {
        await TestContext.Out.WriteLineAsync("Installing Playwright");

        Program.Main(new[] { "install" });

        await TestContext.Out.WriteLineAsync("Installed Playwright");

    }
}