Algoritmo "dados_pessoas_vetor"
//Tem-se um conjunto de dados contendo a altura eo gênero(M, F) de N pessoas.
//Fazer um programa que calcule e escreva a maior e a menor altura do grupo,
//a média de altura das mulheres, e o número de homens.

Var
   n,i, contHomens, contMulheres : inteiro
   maior, menor, media : real
   vetGenero : vetor [0..5] de caractere
   vetAltura : vetor [0..5] de real

Inicio
      escreva("Quantas pessoas serao digitadas? ")
      leia(n)
      
      para i de 0 ate n-1 faca
         escreva("Altura da ", i+1, "a pessoa:")
         leia(vetAltura[i])
         escreva("Genero da ", i+1, "a pessoa:")
         leia(vetGenero[i])
      fimpara
      
      escreval
      menor <- vetAltura[0]
      maior <- vetAltura[0]
      para i de 1 ate n-1 faca
         se vetAltura[i] > maior entao
            maior <- vetAltura[i]
         fimse
      fimpara

      para i de 1 ate n-1 faca
         se vetAltura[i] < menor entao
            menor <- vetAltura[i]
         fimse
      fimpara
      
      media <- 0
      contHomens <- 0
      contMulheres <- 0
      para i de 0 ate n-1 faca
          escolha vetGenero[i]
          caso "F"
              media <- media + vetAltura[i]
              contMulheres <- contMulheres + 1
          caso "M"
              contHomens <- contHomens + 1
          fimescolha
      fimpara
      
      media <- media / contMulheres
      
      escreval("Menor altura = ", menor:4:2)
      escreval("Maior altura = ", maior:4:2)
      escreval("Media das alturas das mulheres = ", media:4:2)
      escreval("Numero de homens = ",contHomens)

Fimalgoritmo