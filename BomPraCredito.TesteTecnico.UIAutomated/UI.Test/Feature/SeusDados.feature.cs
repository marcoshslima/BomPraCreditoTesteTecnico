﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UI.Test.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SeusDados")]
    public partial class SeusDadosFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SeusDados.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SeusDados", " Eu como usuário\r\n Quero realizar meu cadastro no site BomPraCredito\r\n E solicita" +
                    "r um empréstimo com sucesso.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CT003 - Realizar o Preecdhimento do Formulario Seus Dados")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Assalariado", "Desenhista", null)]
        [NUnit.Framework.TestCaseAttribute("Empresário", "Piscicultor", null)]
        [NUnit.Framework.TestCaseAttribute("Estudante", "Estudante", null)]
        public virtual void CT003_RealizarOPreecdhimentoDoFormularioSeusDados(string ocupacao, string profissao, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CT003 - Realizar o Preecdhimento do Formulario Seus Dados", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("Eu acesso a url \"https://demo.bompracredito.com.br/emprestimo-pessoal/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("Eu seleciono o valor \"2.000\" da opção [De quanto você precisa?(R$)]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("eu seleciono o valor \"24\" da opção [Em quantas vezes?]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Eu preencho o campo [Seu nome Completo] com a informação \"Marcos Lima\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Eu preencheo o campo [Seu e-mail] com a informação \"marcos@bompracredito.com.br\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("Eu clicar no botão [Continuar]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("O sistema deve apresentar a tela [Seus Dados] com o nome da pessoa que está solic" +
                    "itando o crédito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "CPF",
                        "DataNascimento",
                        "RendaMensal",
                        "Sexo",
                        "EstadoCivil",
                        "GrauInstrucao",
                        "ContaNoBanco",
                        "Cheques",
                        "RestricaoNome",
                        "ImovelProprio",
                        "AutomovelProprio"});
            table1.AddRow(new string[] {
                        "Dinamico",
                        "25111991",
                        "300000",
                        "M",
                        "Solteiro",
                        "Superior Incompleto",
                        "Outros",
                        "Não",
                        "Sim",
                        "Não",
                        "Sim"});
#line 15
 testRunner.When("Eu preencher os campos da tela [Seus dados] com as informações abaixo", ((string)(null)), table1, "When ");
#line 18
 testRunner.And(string.Format("Informar a ocupação \"{0}\" e Profissão \"{1}\"", ocupacao, profissao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("Eu clicar no botão [Continuar] da funcionalidade [Seus Dados]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("O sistema deve apresentar a tela de [Endereço]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion