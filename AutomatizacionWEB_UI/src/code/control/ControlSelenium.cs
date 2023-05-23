using OpenQA.Selenium;
using AutomatizacionYopmail.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V111.Page;

namespace AutomatizacionYopmail.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;
        protected IWebElement controlText;
        protected IWebElement iframeName;


        public ControlSelenium(By locator) 
        {
            this.locator = locator;
        }

        protected void FindControl() 
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click() 
        { 
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }catch (Exception ex)
            {
                return false;
            }
        }
        public String ControlText()
        {
            try
            {
                FindControl();
                return control.Text.ToLower();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public void ChangeFrame(String name)
        {
            Session.Instance().GetBrowser().SwitchTo().Frame(name);
        }
    }
}
