Algoritmo "lanchonete"
//Uma lanchonete possui v�rios produtos. Cada produto possui um c�digo
//e um pre�o. Voc� deve fazer um programa para ler o c�digo e a
//quantidade comprada de um produto (suponha um c�digo v�lido), e da�
//informar qual o valor a ser pago, com duas casas decimais, conforme
//tabela de produtos ao lado.
//Cod.Produto        Pre�o Produto
//   1                5,00
//   2                3,50
//   3                4,80
//   4                8,90
//   5                7,32

Var
   codProduto, qntComprada : inteiro
   pagar : real

Inicio
      escreval("Codigo do produto comprado: ")
      leia(codProduto)

      se (codProduto > 5) ou (codProduto = 0) entao
         escreva("CODIGO INVALIDO")

      senao
        escreval("Quantidade Comprada: ")
        leia(qntComprada)
      fimse
      
           escolha codProduto
           caso 1
              pagar <- qntComprada * 5.00
              escreva("Valor a pagar: R$ ", pagar:4:2)
           caso 2
              pagar <- qntComprada * 3.50
              escreva("Valor a pagar: R$ ", pagar:4:2)
           caso 3
              pagar <- qntComprada * 4.80
              escreva("Valor a pagar: R$ ", pagar:4:2)
           caso 4
              pagar <- qntComprada * 8.90
              escreva("Valor a pagar: R$ ", pagar:4:2)
           caso 5
              pagar <- qntComprada * 7.32
              escreva("Valor a pagar: R$ ", pagar:4:2)

           fimescolha

Fimalgoritmo