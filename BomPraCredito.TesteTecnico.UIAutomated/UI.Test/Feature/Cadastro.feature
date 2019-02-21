Feature: Cadastro
 Eu como usuário
 Quero realizar meu cadastro no site BomPraCredito
 E solicitar um empréstimo com sucesso.

Scenario: CT001 - Realizar Cadastro no site BomPraCredito
	Given Eu acesso a url "https://demo.bompracredito.com.br/emprestimo-pessoal/"
	And Eu seleciono o valor "2.000" da opção [De quanto você precisa?(R$)]
	And eu seleciono o valor "24" da opção [Em quantas vezes?]
	And Eu preencho o campo [Seu nome Completo] com a informação "Marcos Lima"
	And Eu preencheo o campo [Seu e-mail] com a informação "marcos@bompracredito.com.br"
	When Eu clicar no botão [Continuar]
	Then O sistema deve apresentar a tela [Seus Dados] com o nome da pessoa que está solicitando o crédito

Scenario Outline: CT002 - Validação dos Campos Obrigatórios da Página Cadastre
	Given Eu acesso a url "https://demo.bompracredito.com.br/emprestimo-pessoal/"
	And Eu seleciono o valor "<DeQtoVocePrecisa>" da opção [De quanto você precisa?(R$)]
	And eu seleciono o valor "<EmQtasVezes>" da opção [Em quantas vezes?]
	And Eu preencho o campo [Seu nome Completo] com a informação "<SeuNomeCompleto>"
	And Eu preencheo o campo [Seu e-mail] com a informação "<SeuEmail>"
	When Eu clicar no botão [Continuar]
	Then o sistema deve apresentar a mensagem de validação "<MsgValidacao>"
	Examples: 
		| DeQtoVocePrecisa | EmQtasVezes | SeuNomeCompleto | SeuEmail                   | MsgValidacao              |
		|                  | 24          | Marcos Lima     | marcos@bomprecedito.com.br | Valor obrigatório         |
		| 2000             |             | Marcos Lima     | marcos@bomprecedito.com.br | Qtd. Parcelas obrigatória |
		| 2000             | 9           |                 | marcos@bomprecedito.com.br | Nome obrigatório          |
		| 2000             | 9           | Marcos Lima     |                            | E-mail obrigatório        |