Algoritmo "experiencias"
//Maria acabou de iniciar seu curso de gradua��o na faculdade de medicina e
//precisa de sua ajuda para organizar os experimentos de um laborat�rio
//o qual ela � respons�vel. Ela quer saber no final do ano,
//quantas cobaias foram utilizadas no laborat�rio e o percentual de cada tipo
//de cobaia utilizada. Este laborat�rio em especial utiliza tr�s tipos de
//cobaias: sapos, ratos e coelhos. Para obter estas informa��es,
//ela sabe exatamente o n�mero de experimentos que foram realizados,
//o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada
//experimento. Fa�a um programa que leia um valor inteiro N que indica os
//v�rios casos de teste que vem a seguir. Cada caso de teste cont�m um
//inteiro que representa a quantidade de cobaias utilizadas e uma letra
//('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).
//Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia
//utilizada e o percentual de cada uma em rela��o ao total de cobaias
//utilizadas, sendo que o percentual deve ser apresentado com dois d�gitos
//ap�s o ponto

Var
   n, i: inteiro
   totalGeral, totalC, totalR, totalS, qntdd : real
   tpCobaia : caractere

Inicio
      escreva("Quantos casos de teste serao digitados? ")
      leia(n)

      para i de 1 ate n fa�a
           escreva("Quantidade de cobaias: ")
           leia(qntdd)
           escreva("Tipo de cobaia (C,R,S) : ")
           leia(tpCobaia)
           
           escolha tpCobaia
           caso "C"
           totalC <- totalC + qntdd
           caso "R"
           totalR <- totalR + qntdd
           caso "S"
           totalS <- totalS + qntdd
           outrocaso
               escreval("TIPO INVALIDO")
           fimescolha
      fimpara
      
      totalGeral <- totalC + totalS + totalR
      escreval
      escreval("RELATORIO FINAL:")
      escreval("Total: ", totalGeral, " cobaias" )
      escreval("Total de coelhos: = ", totalC)
      escreval("Total de ratos: = ", totalR)
      escreval("Total de sapos: = ", totalS)
      escreval("Percentual de coelhos: ", ((totalC/totalGeral)*100):4:2,"%")
      escreval("Percentual de ratos: ", ((totalR/totalGeral)*100):4:2,"%")
      escreval("Percentual de sapos: ", ((totalS/totalGeral)*100):4:2,"%")

Fimalgoritmo