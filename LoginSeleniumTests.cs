
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestClass]
public class LoginSeleniumTest
{
    private IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
    
    [TestMethod]
    public void SuccessfulTest()
    {
        driver.Navigate().GoToUrl("https://www.letsusedata.com/login");

        var loginUrl = driver.Url;
        driver.FindElement(By.Id("txtUser")).Click();
        driver.FindElement(By.Id("txtUser")).Clear();
        driver.FindElement(By.Id("txtUser")).SendKeys("test1");
        
        driver.FindElement(By.Id("txtPassword")).Click();
        driver.FindElement(By.Id("txtPassword")).Clear();
        driver.FindElement(By.Id("txtPassword")).SendKeys("Test12456");
        
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        Thread.Sleep(2000);

        Assert.AreNotEqual(loginUrl, driver.Url);


    }
    
    [TestMethod]
    public void UnsuccessfulTest()
    {
        driver.Navigate().GoToUrl("https://www.letsusedata.com/login");

        var loginUrl = driver.Url;
        driver.FindElement(By.Id("txtUser")).Click();
        driver.FindElement(By.Id("txtUser")).Clear();
        driver.FindElement(By.Id("txtUser")).SendKeys("test1");
        
        driver.FindElement(By.Id("txtPassword")).Click();
        driver.FindElement(By.Id("txtPassword")).Clear();
        driver.FindElement(By.Id("txtPassword")).SendKeys("test1234");
        
        driver.FindElement(By.CssSelector("button[type='submit']")).Click();

        Thread.Sleep(2000);

        Assert.AreEqual(loginUrl, driver.Url);
    }
}
