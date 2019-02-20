Feature: Cadastro
 Eu como usuário
 Quero realizar meu cadastro no site BomPraCredito
 E solicitar um empréstimo com sucesso.


Scenario: Realizar Cadastro no site BomPraCredito
	Given Eu acesso a url "https://demo.bompracredito.com.br/emprestimo-pessoal/"
	And Eu seleciono o valor "2.000" da opção [De quanto você precisa?(R$)]
	And eu seleciono o valor "24" da opção [Em quantas vezes?]
	And Eu preencho o campo [Seu nome Completo] com a informação "Marcos Lima"
	And Eu preencheo o campo [Seu e-mail] com a informação "marcos@bompracredito.com.br"
	When Eu clicar no botão [Continuar]
	Then O sistema deve apresentar a tela [Seus Dados] com o nome da pessoa que está solicitando o crédito

