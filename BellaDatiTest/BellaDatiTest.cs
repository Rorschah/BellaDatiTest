using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BellaDatiTest
{
	[TestClass]
	public class BellaDatiTest
	{

		[TestMethod]
		public void TestMethod1()
		{
			/// GIVEN
			/// Main page is launched
			/// Valid credentials are filled in
			/// LoginBtn is confirmed
			IWebDriver driver = new ChromeDriver();

			MainPage mainPage = ApplicationHandler.OpenMainPage(driver);
			mainPage.SignIn();
			mainPage.clickLoginBtn();


			/// When
			/// Child page appears
			ChildPage childPage = ApplicationHandler.OpenChildPage(driver);

			/// Then
			/// "SupportElement" in the bottom exist 
			Assert.IsTrue(childPage.HasSupportElement());
		}
	}

}
