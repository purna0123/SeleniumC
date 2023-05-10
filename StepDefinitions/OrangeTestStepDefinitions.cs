using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class OrangeTestStepDefinitions
    {
        private IWebDriver driver;
        LoginPage orangePage;
        HomePage homePage;

        public OrangeTestStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

    [Given(@"Enter the Orange login URL")]
        public void GivenEnterTheOrangeLoginURL()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/saveSystemUser";
            Thread.Sleep(4000);
        }

        [When(@"user enters ""([^""]*)"" and ""([^""]*)"" to login")]
        public void WhenUserEntersAndToLogin(string username, string password)
        {
            orangePage = new LoginPage(driver);
            homePage = orangePage.login(username, password);
        }


        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            homePage = new HomePage(driver);
            Thread.Sleep(3000);
            homePage = homePage.VerifyTitleOfThePage();
        }
    }
}