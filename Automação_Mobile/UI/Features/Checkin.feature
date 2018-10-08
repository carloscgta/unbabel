#language: pt-BR
Funcionalidade: Checkin
	
Esquema do Cenário: Realizar reserva com tarifa Promo- Check-in compra de uma bagagem
	Dado que estou logado no aplicativo
	Quando Clicar em Checkin
	E Selecionar a opcao de localizar a passagem
	E preencher os dados "<CodigoVoo>" "<Sobrenome>"
	E Clicar em Continuar
	E Preencho os dados "<Email>" "<Telefone>"
	Então realizo o check-in com sucesso

	Exemplos:
	| Email                | Telefone    | CodigoVoo | Sobrenome |
	| carloscgta@gmail.com | 71992040812 | UMW7JN    | Tirone    |