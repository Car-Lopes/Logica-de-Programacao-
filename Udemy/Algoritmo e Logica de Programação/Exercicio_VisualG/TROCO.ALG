Algoritmo "troco"
// Fazer um programa para calcular o troco no processo de pagamento
// de um produto de uma mercearia.
// O programa deve ler o preço unitário do produto, a quantidade de unidades
// compradas deste produto,
// e o valor em dinheiro dado pelo cliente
// (suponha que haja dinheiro suficiente).
// Seu programa deve mostrar o valor do troco a ser devolvido ao cliente.

Var
   preco, dinheiroRecebido, troco : real
   quantidadeComprada : inteiro
   
Inicio
      escreval("Preço Unitario do Produto: ")
      leia(preco)
      escreval("Quantidade Comprada: ")
      leia(quantidadeComprada)
      escreval("Dinheiro Recebido: ")
      leia(dinheiroRecebido)
      
      troco <- dinheiroRecebido - (preco * quantidadeComprada)
      escreval
      escreval("TROCO ", troco:10:2)

Fimalgoritmo