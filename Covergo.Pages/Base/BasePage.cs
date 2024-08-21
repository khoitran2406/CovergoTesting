using Covergo.Core;
using Microsoft.Playwright;

namespace Covergo.Pages
{
    public class BasePage
    {
        protected readonly Keywords keywords;
        public BasePage(IPage page)
        {
            keywords = new Keywords(page);
        }
    }
}
