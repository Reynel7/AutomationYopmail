using OpenQA.Selenium;
using System.Reflection.Emit;
using AutomatizacionYopmail.src.code.control;

namespace AutomatizacionYopmail.src.code.page
{
    public class PrincipalFrame
    {
        public TextLabel userName = new TextLabel(By.XPath("//div[@class=\"bname\"]"));
        public Button newMessage = new Button(By.Id("newmail"));
        public void ButtonNewMessage()
        {
            newMessage.Click();
        }
        public Boolean GetUserName()
        {
            return userName.IsControlDisplayed();
        }

        public String GetUserNameText()
        {
            return userName.ControlText();
        }
    }
}
