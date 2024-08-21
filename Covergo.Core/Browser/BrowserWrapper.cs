using Microsoft.Playwright;

namespace Covergo.Core.Browser
{
    public class BrowserWrapper
    {
        public async Task<IBrowser> InitBrowser(EBrowserType browserType)
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            switch (browserType)
            {
                case EBrowserType.Chrome:
                    return await playwright.Chromium.LaunchAsync(new()
                    {
                        Headless = false,
                        Channel = "chrome"
                    });
                case EBrowserType.Edge:
                    return await playwright.Chromium.LaunchAsync(new()
                    {
                        Headless = false,
                        Channel = "msedge"
                    });
                case EBrowserType.Firefox:
                    return await playwright.Firefox.LaunchAsync();
                default:
                    throw new Exception("Not implemented browser type");
            }
        }
    }
}
