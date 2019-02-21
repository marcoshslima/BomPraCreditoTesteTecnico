using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace UI.Test.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        #region Variables
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        #endregion

        //Construtor Hooks que permite inicialiar o 
        //Obejto Container para que possamos utilizar o webdriver nas outras classes..
        public Hooks(IObjectContainer _objectContainer)
        {
            this._objectContainer = _objectContainer;
        }

        [BeforeScenario]
        public void Inicializar()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void Sair()
        {
            _driver.Quit();
        }
                
    }
}
