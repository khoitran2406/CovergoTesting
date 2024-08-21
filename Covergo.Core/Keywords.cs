using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace Covergo.Core
{
    public class Keywords
    {
        private readonly IPage _page;

        public Keywords(IPage page)
        {
            _page = page;
        }

        public async Task<string?> GetAttribute(string locator, string attribute)
        {
            return await _page.Locator(locator).GetAttributeAsync(attribute);
        }

        public async Task ClickOn(string locator)
        {
            await _page.ClickAsync(locator);
        }

        public async Task VerifyText(string locator, string? expectedText)
        {
            Assert.That(await GetAttribute(locator, "outerText"), Is.EqualTo(expectedText));
        }
    }
}
