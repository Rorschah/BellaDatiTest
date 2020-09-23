using OpenQA.Selenium;

namespace BellaDatiTest
{
	public class MainPage
	{

		private IWebDriver Driver { get; set; }


		public MainPage(IWebDriver driver)
		{
			this.Driver = driver;
			Driver.Navigate().GoToUrl("https://service-test.belladati.com/login/$N/$N");
		}

		internal void SignIn()
		{
			Driver.FindElement(By.Name("login")).SendKeys("tpreiss");
			Driver.FindElement(By.Name("password")).SendKeys("Password123");
		}

		internal void clickLoginBtn()
		{
			var loginBtn = Driver.FindElement(By.Name("submit_0"));
			loginBtn.Click();
		}
	}
}