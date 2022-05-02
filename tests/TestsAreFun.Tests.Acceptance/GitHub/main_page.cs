using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace TestsAreFun.Tests.Acceptance.GitHub
{
    public class main_page : BasePageTest
    {
        [Test] public async Task team_link_should_be_visible() => await Expect(Team).ToBeVisibleAsync();
        [Test] public async Task team_link_should_have_text_team() => await Expect(Team).ToHaveTextAsync("Team");

        private ILocator Team => Page.Locator("[aria-label=\"Global\"] >> text=Team");
    }
}