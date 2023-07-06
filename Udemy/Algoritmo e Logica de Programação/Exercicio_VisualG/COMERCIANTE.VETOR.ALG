Algoritmo "comerciante.vetor"
//Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele
//comercializa. Para isto, mandou digitar um conjunto de N mercadorias,
//cada uma contendo nome, preço de compra e preço de venda das mesmas.
//Fazer um programa que leia tais dados e determine e escreva quantas
//mercadorias proporcionaram:
//    lucro < 10%
//    lucro 10% entre lucro 20%
//    lucro > 20%
//Determine e escreva também o valor total de compra e de venda de todas
//as mercadorias, assim como o lucro total.

Var
   n,i, dezPorCento, dezEVintePorCento, acimaVintePorCento : inteiro
   Porc, somaCompra, somaVenda, lucroTotal : real
   vetNome : vetor [0..5] de caractere
   vetCompra : vetor [0..5] de real
   vetVenda : vetor [0..5] de real

Inicio
      escreva("Serao digitados dados de quantos produtos? ")
      leia(n)
      
      para i de 0 ate n-1 faca
         escreval("Produto ", i+1, ":")
         escreva("Nome: ")
         leia(vetNome[i])
         escreva("Preco de compra: ")
         leia(vetCompra[i])
         escreva("Preco de venda: ")
         leia(vetVenda[i])
      fimpara
      
      porc <- 0
      dezPorCento <- 0
      dezEVintePorCento <- 0
      acimaVintePorCento <- 0
      para i de 0 ate n-1 faca
          porc <- (vetVenda[i] / vetCompra[i]-1)*100
            se porc < 10 entao
               dezPorCento <- dezPorCento + 1
            senao
               se porc <= 20 entao
                   dezEVintePorCento <- dezEVintePorCento + 1
               senao
                   acimaVintePorCento <- acimaVintePorCento + 1
               fimse
            fimse
      fimpara
      
      somaCompra <- 0
      somaVenda <- 0
      para i de 0 ate n-1 faca
             somaCompra <- somaCompra + vetCompra[i]
             somaVenda <- somaVenda + vetVenda[i]
      fimpara
      
      lucroTotal <- somaVenda - somaCompra
      escreval
      escreval("RELATORIO:")
      escreval("Lucro abaixo de 10%: ",dezPorCento)
      escreval("Lucro entre 10% e 20%: ",dezEVintePorCento)
      escreval("Lucro acima de 20%: ",acimaVintePorCento)
      escreval("Valor total de compra: ", somaCompra:5:2)
      escreval("Valor total de venda: ", somaVenda:5:2)
      escreval("Lucro Total: ", lucroTotal:5:2)

Fimalgoritmo