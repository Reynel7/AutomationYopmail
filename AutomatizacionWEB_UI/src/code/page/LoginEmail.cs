using OpenQA.Selenium;
using AutomatizacionYopmail.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionYopmail.src.code.page
{
    public class LoginEmail
    {
        public TextBox emailTextBox = new TextBox(By.Id("login"));
        public Button loginButton = new Button(By.XPath("//button[@class=\"md\"]"));

        public void Login(String emailTest)
        {
            emailTextBox.SetText(emailTest);
            loginButton.Click();
        }
    }
}
