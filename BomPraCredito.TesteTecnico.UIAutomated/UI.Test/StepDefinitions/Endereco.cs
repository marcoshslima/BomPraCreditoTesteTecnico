using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UI.Test.PageObjects;
using UI.Test.Utilities;

namespace UI.Test.StepDefinitions
{
    [Binding]
    public sealed class Endereco
    {
        #region variables
        private IWebDriver _driver;
        private POEndereco _endereco;
        #endregion

        public Endereco(IWebDriver _driver)
        {
            this._driver = _driver;
            _endereco = new POEndereco(_driver);
        }


        [When(@"Eu informar o Cep ""(.*)""")]
        public void WhenEuInformarOCep(string cep)
        {
            _endereco.PreencherCep(cep);
            Utils.Wait(3000);
        }

        [When(@"Preenher o campo Número ""(.*)"" , Telefone Celular ""(.*)"" e Finalidade do Emprestimo ""(.*)""")]
        public void WhenPreenherOCampoNumeroTelefoneCelularEFinalidadeDoEmprestimo(string numeroCasa, string numeroCelular, string motivo)
        {
            _endereco.PreecherEndereco(numeroCasa,numeroCelular,motivo);
        }


        [When(@"Eu clicar no botão \[Continuar] da tela \[Endereco]")]
        public void WhenEuClicarNoBotaoContinuarDaTelaEndereco()
        {
            _endereco.btnContinuar.Click(); 
        }

        [Then(@"O sistema deve apresentar a páina ""(.*)""")]
        public void ThenOSistemaDeveApresentarAPaina(string url)
        {
            Assert.IsTrue(_driver.Url.Contains(url), "O sistema não carregou a URL " + url + "conforme esperado");
        }

        [Then(@"Deve ocorrer um redirect para página ""(.*)""")]
        public void ThenDeveOcorrerUmRedirectParaPagina(string url)
        {
            Utils.Wait(30000);
            Assert.IsTrue(_driver.Url.Contains(url), "O sistema não direcionou para a URL " + url + "conforme esperado");
        }


    }
}
