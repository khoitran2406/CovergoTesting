using Covergo.Pages;
using Covergo.Testing.UI.BaseTest;

namespace Covergo.Testing.UI.SimpleAccordian
{
    [TestFixture]
    public class Section : BaseUITestInit
    {
        private AccordionAndTabsPage accordionAndTabsPage;

        [Test]
        public async Task Covergo_VerifySection1Content()
        {
            var section1Content = "Mauris mauris ante, blandit et, ultrices a, suscipit eget, quam. Integer ut neque." +
                " Vivamus nisi metus, molestie vel, gravida in, condimentum sit amet, nunc. Nam a nibh." +
                " Donec suscipit eros. Nam mi. Proin viverra leo ut odio. Curabitur malesuada." +
                " Vestibulum a velit eu ante scelerisque vulputate.";
            await accordionAndTabsPage.ExpandSection1();
            await accordionAndTabsPage.VerifySection1Content(section1Content);
        }

        [SetUp]
        public void Setup()
        {
            accordionAndTabsPage = new AccordionAndTabsPage(page);
        }
    }
}
