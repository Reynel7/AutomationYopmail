using AutomatizacionYopmail.src.code.control;
using AutomatizacionYopmail.src.code.session;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutomatizacionYopmail.src.code.page
{
    public class RightFrame
    {
        public TextBox reciver = new TextBox(By.Id("msgto"));
        public TextBox subject = new TextBox(By.Id("msgsubject"));
        public TextBox message = new TextBox(By.Id("msgbody"));
        public Button sendEmail = new Button(By.Id("msgsend"));
        public TextLabel popUp = new TextLabel(By.Id("msgpopmsg"));
        String IdFrame = "ifmail";
        public void SendMessage(String Sreciver, String Ssubject, String Smessage)
        {
            Session.Instance().ChangeIframe(IdFrame);
            reciver.SetText(Sreciver);
            subject.SetText(Ssubject);
            message.SetText(Smessage);
            sendEmail.Click();
        }

        public Boolean GetPopUp()
        {
            return popUp.IsControlDisplayed();
        }
        public String GetPopUpText()
        {
            return popUp.ControlText();
        }
    }
}
