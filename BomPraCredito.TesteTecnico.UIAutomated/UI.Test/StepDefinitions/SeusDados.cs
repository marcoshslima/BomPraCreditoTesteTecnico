using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UI.Test.PageObjects;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow.Assist;
using UI.Test.Utilities;

namespace UI.Test.StepDefinitions
{
    [Binding]
    public sealed class SeusDados
    {
        #region variables
        private IWebDriver _driver;
        private POSeusDados _seusDados;
        #endregion

        public SeusDados(IWebDriver _driver)
        {
            this._driver = _driver;
            _seusDados = new POSeusDados(_driver);
        }

        # region When

        [When(@"Eu preencher os campos da tela \[Seus dados] com as informações abaixo")]
        public void WhenEuPreencherOsCamposDaTelaSeusDadosComAsInformacoesAbaixo(Table table)
        {
            dynamic tabela = table.CreateDynamicInstance();

            _seusDados.PreencherSeusDados(
                tabela.CPF,
                Convert.ToString(tabela.DataNascimento),
                Convert.ToString(tabela.RendaMensal),
                tabela.Sexo,
                tabela.EstadoCivil,
                tabela.GrauInstrucao,
                tabela.ContaNoBanco,
                tabela.Cheques,
                tabela.RestricaoNome,
                tabela.ImovelProprio,
                tabela.AutomovelProprio);
        }

        [When(@"Informar a ocupação ""(.*)"" e Profissão ""(.*)""")]
        public void WhenInformarAOcupacaoEProfissao(string ocupacao, string profissao)
        {
            _seusDados.PreencherOcupacaoProfissao(ocupacao, profissao);
            Utils.Wait(3000);
        }

        [When(@"Eu clicar no botão \[Continuar] da funcionalidade \[Seus Dados]")]
        public void WhenEuClicarNoBotaoContinuarDaFuncionalidadeSeusDados()
        {
            _seusDados.Continuar();
        }

        #endregion

        #region Then
        [Then(@"O sistema deve apresentar a tela de \[Endereço]")]
        public void ThenOSistemaDeveApresentarATelaDeEndereco()
        {
            Utils.Wait(3000);
            _seusDados.ValidarTelaEndereco();
        }

        #endregion



    }
}
