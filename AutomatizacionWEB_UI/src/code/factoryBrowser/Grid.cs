﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionYopmail.src.code.factoryBrowser
{
    public class Grid : IBrowser
    {
        public IWebDriver Create()
        {
            ChromeOptions options = new ChromeOptions();    
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
