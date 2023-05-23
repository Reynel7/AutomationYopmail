using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatizacionYopmail
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            Console.WriteLine("setup");
            //    string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yopmail.com/");
        }
        [TestCleanup]
        public void CloseBrowser()
        {
            Console.WriteLine("clean");
            driver.Quit();
        }

        [TestMethod]
        public void VerifyTheSendEmail()
        {
            // click input login
            driver.FindElement(By.Id("login")).SendKeys("TestReynel");
            Thread.Sleep(1000);
            // click button login
            driver.FindElement(By.XPath("//button[@class=\"md\"]")).Click();
            Thread.Sleep(2000);
            // verify that page is the correct login with the name
            var email = driver.FindElement(By.XPath("//div[@class=\"bname\"]"));
            Assert.IsTrue(email.Displayed);
            Assert.AreEqual(email.Text.ToLower(), "testreynel@yopmail.com".ToLower());
            
            // send the new email
            driver.FindElement(By.Id("newmail")).Click();

            // switch to frame mensajeto
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame("ifmail");
            // input destinatario
            driver.FindElement(By.Id("msgto")).SendKeys("AutomationMojix");
         
            // input asunto
            driver.FindElement(By.Id("msgsubject")).SendKeys("I am testing");
            // input in "div" menssage
            driver.FindElement(By.Id("msgbody")).SendKeys("Hi this is a test mojix bootcamp version 2.0");
            
            // click send button
            driver.FindElement(By.Id("msgsend")).Click();
            // verify that message send correctly
            Thread.Sleep(2000);
            var pop = driver.FindElement(By.Id("msgpopmsg"));
            Assert.IsTrue(pop.Displayed);
            
            Assert.AreEqual(pop.Text.ToLower(), "Tu mensaje ha sido enviado".ToLower());
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame("ifinbox");

            /*    // click login button
                driver.FindElement(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]")).Click();
                // fill email textbox
                driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail")).SendKeys("bootcamp2@mojix.com");
                // fill password textbox
                driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword")).SendKeys("12345");
                // click login button
                driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin")).Click();
                // verify -> the logout button should be displayed

                Assert.IsTrue(driver.FindElement(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout")).Displayed,
                    "ERROR !! the login was not successfully, review credentials please");*/

        }
    }
}