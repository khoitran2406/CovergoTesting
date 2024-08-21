using Microsoft.Playwright;

namespace Covergo.Pages
{
    public class AccordionAndTabsPage : BasePage
    {
        protected readonly string Lbl_section1Header = "css=#ui-id-1";
        protected readonly string Lbl_section1Content = "css=#ui-id-2";

        public AccordionAndTabsPage(IPage page) : base(page)
        {
        }

        public async Task ExpandSection1()
        {
            var isExpanded = await keywords.GetAttribute(Lbl_section1Header, "aria-expanded");
            if (isExpanded != "true")
            {
                await keywords.ClickOn(Lbl_section1Header);
            }
        }

        public async Task VerifySection1Content(string expectedContent)
        {
            await keywords.VerifyText(Lbl_section1Content, expectedContent);
        }
    }
}
