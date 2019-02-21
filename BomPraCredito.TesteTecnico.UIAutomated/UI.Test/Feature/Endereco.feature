Feature: Endereco
 Eu como usuário
 Quero realizar meu cadastro no site BomPraCredito
 E solicitar um empréstimo com sucesso.

Scenario Outline: CT001 - Realizar o Preecdhimento do Formulario Endereço
	Given Eu acesso a url "https://demo.bompracredito.com.br/emprestimo-pessoal/"
	And Eu seleciono o valor "2.000" da opção [De quanto você precisa?(R$)]
	And eu seleciono o valor "24" da opção [Em quantas vezes?]
	And Eu preencho o campo [Seu nome Completo] com a informação "Marcos Lima"
	And Eu preencheo o campo [Seu e-mail] com a informação "marcos@bompracredito.com.br"
	When Eu clicar no botão [Continuar]
	Then O sistema deve apresentar a tela [Seus Dados] com o nome da pessoa que está solicitando o crédito
	When Eu preencher os campos da tela [Seus dados] com as informações abaixo
		| CPF      | DataNascimento | RendaMensal | Sexo | EstadoCivil | GrauInstrucao       | ContaNoBanco | Cheques | RestricaoNome | ImovelProprio | AutomovelProprio |
		| Dinamico | 25111991       | 300000      | M    | Solteiro    | Superior Incompleto | Outros       | Não     | Sim           | Não           | Sim              |
	And Informar a ocupação "<Ocupacao>" e Profissão "<Profissao>"
	When Eu clicar no botão [Continuar] da funcionalidade [Seus Dados]
	Then O sistema deve apresentar a tela de [Endereço]
	When Eu informar o Cep "09854050"
	And Preenher o campo Número "510" , Telefone Celular "99976545432" e Finalidade do Emprestimo "Viajar"
	When Eu clicar no botão [Continuar] da tela [Endereco]
	Then  O sistema deve apresentar a páina "https://demo.bompracredito.com.br/v2/resultado"
	And  Deve ocorrer um redirect para página "https://demo.bompracredito.com.br/v2/cadastrocompleto"
	Examples: 
		| Ocupacao    | Profissao   |
		| Assalariado | Desenhista  |
