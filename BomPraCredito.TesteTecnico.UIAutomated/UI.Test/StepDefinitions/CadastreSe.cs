﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using UI.Test.PageObjects;
using UI.Test.Utilities;
namespace UI.Test.StepDefinitions
{
    [Binding]
    public sealed class CadastreSe
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        #region variables
        private IWebDriver _driver;
        private Cadastro _cadastro;
        #endregion

        public CadastreSe(IWebDriver _driver)
        {
            this._driver = _driver;
            _cadastro = new Cadastro(_driver);
        }

        #region Given

        [Given(@"Eu acesso a url ""(.*)""")]
        public void GivenEuAcessoAUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [Given(@"Eu seleciono o valor ""(.*)"" da opção \[De quanto você precisa\?\(R\$\)]")]
        public void GivenEuSelecionoOValorDaOpcaoDeQuantoVocePrecisaR(string precisaQuanto)
        {
            _cadastro.PrecisaDeQuanto(precisaQuanto);
            Utils.Wait(3000);
        }

        [Given(@"eu seleciono o valor ""(.*)"" da opção \[Em quantas vezes\?]")]
        public void GivenEuSelecionoOValorDaOpcaoEmQuantasVezes(string qtasVezes)
        {
            _cadastro.QuantasVezes(qtasVezes);
            Utils.Wait(3000);
        }

        [Given(@"Eu preencho o campo \[Seu nome Completo] com a informação ""(.*)""")]
        public void GivenEuPreenchoOCampoSeuNomeCompletoComAInformacao(string pnomeCompleto)
        {
            _cadastro.PreencherNome(pnomeCompleto);
            Utils.Wait(3000);
        }

        [Given(@"Eu preencheo o campo \[Seu e-mail] com a informação ""(.*)""")]
        public void GivenEuPreencheoOCampoSeuE_MailComAInformacao(string email)
        {
            _cadastro.PreencherEmail(email);
            Utils.Wait(3000);
        }

        #endregion

        #region When
        [When(@"Eu clicar no botão \[Continuar]")]
        public void WhenEuClicarNoBotaoContinuar()
        {
            _cadastro.ConfirmarCadastro();
            Utils.Wait(3);
        }

        #endregion

        #region Then
        [Then(@"O sistema deve apresentar a tela Seus dados")]
        public void ThenOSistemaDeveApresentarATelaSeusDados()
        {
           //
        }

        #endregion
    }
}
