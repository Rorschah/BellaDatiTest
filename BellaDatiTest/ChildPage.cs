using OpenQA.Selenium;

namespace BellaDatiTest
{
	internal class ChildPage
	{
		private IWebDriver Driver { get; set; }

		public ChildPage(IWebDriver driver)
		{
			this.Driver = driver;
			Driver.Navigate().GoToUrl("https://service-test.belladati.com/en/bi;jsessionid=6cf90569c0f7ddcaaab24d2777e9");
		}

		internal bool HasSupportElement()
		{
			var supportElement = Driver.FindElement(By.ClassName("support"));

			return supportElement != null;
		}
	}
}