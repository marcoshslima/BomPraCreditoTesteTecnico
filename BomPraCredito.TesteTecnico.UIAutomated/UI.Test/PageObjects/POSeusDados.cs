using NUnit.Framework;
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
    class POSeusDados
    {
        private IWebDriver _driver;

        public POSeusDados(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }


        #region Campos
        [FindsBy(How = How.Id,Using = "borrower.cpf")]
        public IWebElement campoCPF { get; set; }

        [FindsBy(How = How.Id,Using = "borrower.dateOfBirth")]
        public IWebElement campoDataNascimento { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.monthlyGrossIncome")]
        public IWebElement campoRendaMensal { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.maritalStatusOthers")]
        public IWebElement comboOutros { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.jobType")]
        public IWebElement comboOcupação { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.profession")]
        public IWebElement comboProfissao { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.workData.company")]
        public IWebElement comboOrgao { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.workData.jobContractType")]
        public IWebElement comboVinculoOrgao { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.educationLevel")]
        public IWebElement comboGrauInstrucao { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.bankingData.bankNumber")]
        public IWebElement comboContaNoBanco { get; set; }
        #endregion

        #region Botoes
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Feminino')]")]
        public IWebElement optSexoFeminino { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Masculino')]")]
        public IWebElement optSexoMasculino { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.maritalStatus")]
        public IWebElement estadoCivilCasado { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.maritalStatus2")]
        public IWebElement estadoCivilSolteiro { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.maritalStatus3")]
        public IWebElement estadoCivilSeparado { get; set; }


        [FindsBy(How = How.Id, Using = "borrower.bankingData.hasCheckbook")]
        public IWebElement optComChequesSim { get; set; }


        [FindsBy(How = How.Id, Using = "borrower.bankingData.hasCheckbook2")]
        public IWebElement optComChequesNao { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.hasNegativeCreditRecord")]
        public IWebElement opRestricaoNomeSim { get; set; }

        [FindsBy(How = How.Id, Using = "borrower.hasNegativeCreditRecord2")]
        public IWebElement opRestricaoNomeNao { get; set; }

        [FindsBy(How = How.Id, Using = "hasProperty")]
        public IWebElement opImovelNomeSim { get; set; }

        [FindsBy(How = How.Id, Using = "hasProperty2")]
        public IWebElement opImovelNomeNao { get; set; }

        [FindsBy(How = How.Id, Using = "hasVehicle")]
        public IWebElement opAutomovelProprioSim { get; set; }

        [FindsBy(How = How.Id, Using = "hasVehicle2")]
        public IWebElement opAutomovelProprionao { get; set; }

        [FindsBy(How = How.Id, Using = "button-borrower-info")]
        public IWebElement btnContinuar { get; set; }
        #endregion

        #region Metodos
        public void PreencherSeusDados(string cpf,string dataNascimento, string rendaMensal,string sexo,string estadoCivil
            ,string grauInstrucao,string contaBanco,string cheques,string resticaoNome, string imovelProprio, string automovelProrpio)
        {

            if (cpf.Equals("Dinamico"))
            {
                campoCPF.SendKeys(Utils.GerarCpf().ToString());
            }

            Utils.Wait(2000);
            campoDataNascimento.SendKeys(dataNascimento);

            Utils.Wait(2000);
            campoRendaMensal.SendKeys(rendaMensal);

            Utils.Wait(2000);
            if (sexo.Equals("M"))
            {
                optSexoMasculino.Click();
            }
            else
            {
                optSexoFeminino.Click();
            }
            //estado Civil
            switch (estadoCivil)
            { 
                case "Casado":
                    estadoCivilCasado.Click();
                    break;
                case "Solteiro":
                    estadoCivilSolteiro.Click();
                    break;
                case "Separado":
                    estadoCivilSeparado.Click();
                    break;
                default:
                    break;
            }

            Utils.Wait(2000);
            //Selecionando o elemento no combo Grau de Instrucao
             new SelectElement(comboGrauInstrucao).SelectByText(grauInstrucao);

            Utils.Wait(2000);
            //Selecionando o elemento no combo Grau de Instrucao
            new SelectElement(comboContaNoBanco).SelectByText(contaBanco);

            Utils.Wait(2000);
            //Selecionando o elemento no combo Grau de Instrucao
            new SelectElement(comboContaNoBanco).SelectByText(contaBanco);

            Utils.Wait(2000);

            if (cheques.Equals("Sim"))
            {
                optComChequesSim.Click();
            }
            else
            {
                optComChequesNao.Click();

            }

            Utils.Wait(2000);

            if (resticaoNome.Equals("Sim"))
            {
                opRestricaoNomeSim.Click();
            }
            else
            {
                opRestricaoNomeNao.Click();
            }
            Utils.Wait(2000);

            if (imovelProprio.Equals("Sim"))
            {
                opImovelNomeSim.Click();
            }
            else
            {
                opImovelNomeNao.Click();
            }

            Utils.Wait(2000);

            if (automovelProrpio.Equals("Sim"))
            {
                opAutomovelProprioSim.Click();
            }
            else
            {
                opAutomovelProprionao.Click();
            }
        }

        public void PreencherOcupacaoProfissao(string ocupacao, string profissao)
        {
            new SelectElement(comboOcupação).SelectByText(ocupacao);
            Utils.Wait(5000);
            new SelectElement(comboProfissao).SelectByText(profissao);

        }

        public void Continuar()
        {
            btnContinuar.Click();
        }


        public void ValidarTelaEndereco()
        {
            Assert.IsTrue(Utils.VerificarElementExists(_driver, By.Id("homeAddress.cep")),"O campo Cep não está presente na tela [Endereço]");
            Assert.IsTrue(Utils.VerificarElementExists(_driver, By.Id("homeAddress.streetAddress")), "O campo Rua não está presente na tela [Endereço]");
            Assert.IsTrue(Utils.VerificarElementExists(_driver, By.Id("homeAddress.number")), "O campo Numero da Casa não está presente na tela [Endereço]");
            Assert.IsTrue(Utils.VerificarElementExists(_driver, By.Id("mobilePhone")),"O campo Celular não está presente na tela [Endereço]");
            //Assert.IsTrue(Utils.VerificarElementExists(_driver, By.Id("loanObjective")),"O campo Qual a finalidade do Seu Empréstimo não está presente na tela [Endereço]");
        }

        #endregion
    }
}