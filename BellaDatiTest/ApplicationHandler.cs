using OpenQA.Selenium;

namespace BellaDatiTest
{
	internal class ApplicationHandler
	{



		internal static MainPage OpenMainPage(IWebDriver driver)
		{
			return new MainPage(driver);
		}

		internal static ChildPage OpenChildPage(IWebDriver driver)
		{
			return new ChildPage(driver);
		}
	}
}