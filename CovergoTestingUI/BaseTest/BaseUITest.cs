using Covergo.Core.Browser;
using Microsoft.Playwright;

namespace Covergo.Testing.UI.BaseTest
{
    [TestFixture]
    public class BaseUITestInit : PageTest
    {
        protected IBrowser browser;
        protected IPage page;

        [OneTimeSetUp]
        public void BeforeRunTests()
        {

        }

        [OneTimeTearDown]
        public void AfterRunTests()
        {
            
        }

        [SetUp]
        public async Task TestInit()
        {
            browser = await new BrowserWrapper().InitBrowser(EBrowserType.Chrome);
            page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.globalsqa.com/demo-site/accordion-and-tabs/");
        }

        [TearDown]
        public async Task TestCleanup()
        {
            await browser.CloseAsync();
        }
    }
}
