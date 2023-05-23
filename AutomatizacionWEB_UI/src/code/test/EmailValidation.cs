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
    public class EmailValidation : TestBase
    {

        LoginEmail loginEmail = new LoginEmail();
        PrincipalFrame principalFrame = new PrincipalFrame();
        LefthFrame lefthFrame = new LefthFrame();



        [TestMethod]
        public void VerifySendEmail()
        {
            loginEmail.Login("testmojix@yopmail");
            Assert.IsTrue(principalFrame.GetUserName(), "Error the mail is not visible");
            Assert.AreEqual(principalFrame.GetUserNameText(), "testmojix@yopmail.com");
            Assert.IsTrue(lefthFrame.CorrectSendEmail("testreynel@yopmail.com"), "Error the mail was not sent");
            Assert.AreEqual(lefthFrame.CorrectTextEmail("testreynel@yopmail.com"), "testreynel@yopmail.com");
        }

    }
}
