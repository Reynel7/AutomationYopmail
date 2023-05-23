using AutomatizacionYopmail.src.code.control;
using AutomatizacionYopmail.src.code.session;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionYopmail.src.code.page
{
    public class LefthFrame
    {

        String IdFrame = "ifinbox";
        public Boolean CorrectSendEmail(String nameValue)
        {
            Session.Instance().ChangeIframe(IdFrame);
            TextLabel nameEmail = new TextLabel(By.XPath("//div[@class=\"m\"]//span[contains(text(),\'"+ nameValue +"')]"));
            return nameEmail.IsControlDisplayed();
        }
        public String CorrectTextEmail(String nameValue)
        {
            Session.Instance().ChangeIframe(IdFrame);
            TextLabel nameEmail = new TextLabel(By.XPath("//div[@class=\"m\"]//span[contains(text(),\'" + nameValue + "')]"));
            return nameEmail.ControlText();
        }
    }
}
