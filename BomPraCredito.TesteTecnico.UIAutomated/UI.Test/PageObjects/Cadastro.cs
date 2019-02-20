﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Test.PageObjects
{
    class Cadastro
    {
        public Cadastro(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver,this);
        }

        #region Botoes
        [FindsBy(How = How.Id,Using = "btnTwoThousand")]
        public IWebElement btnDoisMil { get; set; }

        [FindsBy(How = How.Id, Using = "btnThreeThousand")]
        public IWebElement btnTresMil { get; set; }

        [FindsBy(How = How.Id, Using = "btnFiveThousand")]
        public IWebElement btnCincoMil { get; set; }

        [FindsBy(How = How.Id, Using = "btnTenThousand")]
        public IWebElement btnDezMil { get; set; }

        [FindsBy(How = How.Id, Using = "btnOtherValue")]
        public IWebElement btnOutroValor { get; set; }

        [FindsBy(How = How.Id, Using = "btnNineTerm")]
        public IWebElement btnNoveVezes { get; set; }

        [FindsBy(How = How.Id, Using = "btnTwelveTerm")]
        public IWebElement btnDozeVezes { get; set; }

        [FindsBy(How = How.Id, Using = "btnEighteenTerm")]
        public IWebElement btnDezoiteVezes { get; set; }

        [FindsBy(How = How.Id, Using = "btnTwentyFourTerm")]
        public IWebElement btnVinteQuatroVezes { get; set; }

        [FindsBy(How = How.Id, Using = "btnOtherTerm")]
        public IWebElement btnOutroPrazo { get; set; }

        [FindsBy(How = How.Id, Using = "btnContinue")]
        public IWebElement btnContinue { get; set; }
        
        #endregion

        #region Campos
        [FindsBy(How = How.Id,Using = "name")]
        public IWebElement txtNomeCompleto { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }
        #endregion

        #region Metodos

        public void PrecisaDeQuanto(string value)
        {
            switch (value.Replace(".","").Replace(",",""))
            {
                case "2000":
                    btnDoisMil.Click();
                    break;
                case "3000":
                    btnTresMil.Click();
                    break;
                case "5000":
                    btnCincoMil.Click();
                    break;
                case "10000":
                    btnDezMil.Click();
                    break;
                default:
                    btnOutroValor.Click();
                    break;
            }
        }

        public void QuantasVezes(string value)
        {
            switch (value)
            {
                case "9":
                    btnNoveVezes.Click();
                    break;
                case "12":
                    btnDezoiteVezes.Click();
                    break;
                case "18":
                    btnDezoiteVezes.Click();
                    break;
                case "24":
                    btnVinteQuatroVezes.Click();
                    break;
                default:
                    btnOutroPrazo.Click();
                    break;
            }
        }

        public void PreencherNome(string name)
        {
            txtNomeCompleto.SendKeys(name);
        }
        public void PreencherEmail(string email)
        {
            txtEmail.SendKeys(email);
        }

        public void ConfirmarCadastro()
        {
            btnContinue.Click();
        }
        #endregion
    }
}