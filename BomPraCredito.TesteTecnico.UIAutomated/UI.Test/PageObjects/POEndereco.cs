using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Test.Utilities;

namespace UI.Test.PageObjects
{
    class POEndereco
    {
        private OpenQA.Selenium.IWebDriver _driver;

        public POEndereco(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id,Using = "homeAddress.cep")]
        public IWebElement cep { get; set; }

        [FindsBy(How = How.Id, Using = "homeAddress.number")]
        public IWebElement numeroCasa { get; set; }

        [FindsBy(How = How.Id, Using = "mobilePhone")]
        public IWebElement numeroCelular { get; set; }

        [FindsBy(How = How.Id, Using = "loanObjective")]
        public IWebElement motivoEmprestimo { get; set; }

        [FindsBy(How = How.Id, Using = "button-borrower-info")]
        public IWebElement btnContinuar { get; set; }

        public void PreencherCep(string cep)
        {
            this.cep.SendKeys(cep);
        }

        public void PreecherEndereco(string numero, string telefone, string motivo)
        {
            numeroCasa.SendKeys(numero);
            Utils.Wait(2000);
            numeroCelular.Clear();
            numeroCelular.SendKeys(telefone);
            Utils.Wait(2000);
            new SelectElement(motivoEmprestimo).SelectByText(motivo);
            Utils.Wait(2000);
        }
    }
}
