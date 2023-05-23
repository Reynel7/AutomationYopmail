using OpenQA.Selenium;
using AutomatizacionYopmail.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizacionYopmail.src.code.session;
using System.Xml.Linq;

namespace AutomatizacionYopmail.src.code.test
{
    [TestClass]
    public class SendEmail : TestBase
    {

        LoginEmail loginEmail = new LoginEmail();
        PrincipalFrame principalFrame = new PrincipalFrame();
        RightFrame rightFrame = new RightFrame();



        [TestMethod]
        public void VerifySendEmail()
        {
            loginEmail.Login("testreynel@yopmail.com");
            principalFrame.ButtonNewMessage();
            Assert.IsTrue(principalFrame.GetUserName(), "Error the mail is not visible");
            Assert.AreEqual(principalFrame.GetUserNameText(), "testreynel@yopmail.com");
            rightFrame.SendMessage("testmojix","testyopmail","Hi this is my first test in C#");
            Assert.IsTrue(rightFrame.GetPopUp(), "Error the mail was not sent");

        }

    }
}
