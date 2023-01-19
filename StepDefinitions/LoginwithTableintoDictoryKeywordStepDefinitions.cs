using DataTable.TableExtensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DataTable.StepDefinitions
{
    [Binding]
    public class LoginwithTableintoDictoryKeywordStepDefinitions
    {
          IWebDriver driver;
        [Given(@"as a user is on Home Page")]
        public void GivenAsAUserIsOnHomePage()
        {
			Console.WriteLine("User is on Home Page");
		}

        [Given(@"navigate to Login Page")]
        public void GivenNavigateToLoginPage()
        {
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();

			driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
		}

        [When(@"user enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
			Thread.Sleep(3000);

			var dictionary = TableExtensionsgiven.ToDictionary(table);
			var testusername = dictionary["username"];
			var testpassword = dictionary["password"];

			driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(testusername);
			//  driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(dictionary["password"]);
			driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(testpassword);
		}

        [When(@"user is clicking on login button\.")]
        public void WhenUserIsClickingOnLoginButton_()
        {
			var LoginBtn = driver.FindElement(By.XPath("//button[@type='submit']"));
			LoginBtn.Click();
			Thread.Sleep(3000);
		}

        [Then(@"user should lands on Dashboard Page\.")]
        public void ThenUserShouldLandsOnDashboardPage_()
        {
            Console.WriteLine("On Dashboard");
        }
    }
}
