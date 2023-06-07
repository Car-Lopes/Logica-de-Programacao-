Algoritmo "troco_verificado"
//Fazer um programa para calcular o troco no processo de pagamento
//de um produto de uma mercearia.
//O programa deve ler o preço unitário do produto, a quantidade de unidades
//compradas deste produto, e o valor em dinheiro dado pelo cliente.
//Seu programa deve mostrar o valor do troco a ser devolvido ao cliente.
//Se o dinheiro dado pelo cliente não for suficiente,
//mostrar uma mensagem informando o valor restante conforme exemplo.

Var
   precoProduto, dinheiroRecebido, total : real
   qtddComprada : inteiro

Inicio
      escreval("Preço Unitario do Produto: ")
      leia(precoProduto)
      escreval("Quantidade Comprada: ")
      leia(qtddComprada)
      escreval("Dinheiro Recebido")
      leia(dinheiroRecebido)

      total <- (precoProduto * qtddComprada)
      
      se total < dinheiroRecebido  entao
            total <- dinheiroRecebido - total
            escreval("TROCO = ", total:4:2)
      senao
           total <- total - dinheiroRecebido
           escreval("DINHEIRO INSUFICIENTE. FALTAM ", total:4:2, " REAIS")
      fimse

Fimalgoritmo
