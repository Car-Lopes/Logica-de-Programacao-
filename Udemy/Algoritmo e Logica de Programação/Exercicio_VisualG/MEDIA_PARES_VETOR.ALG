Algoritmo "media_pares_vetor"
//Fazer um programa para ler um vetor de N números inteiros.
//Em seguida, mostrar na tela a média aritmética somente dos números pares
//lidos, com uma casa decimal. Se nenhum número par for digitado,
//mostrar a mensagem "NENHUM NUMERO PAR"

Var
   n, i, contPar, somaPar : inteiro
   media : real
   vet : vetor [0..9] de inteiro

Inicio
      escreva("Quantos elementos vai ter o vetor? ")
      leia(n)
      
      somaPar <- 0
      contPar <- 0
      para i de 0 ate n-1 faca
           escreva("Digite um numero: ")
           leia(vet[i])
           se vet[i] % 2 = 0 entao
             somaPar <- somaPar + vet[i]
             contPar <- contPar + 1
          fimse
      fimpara
      
      se contPar <> 0 entao
         media <- somaPar / contPar
         escreval("MEDIA DOS PARES = ", media:4:1)
      senao
          escreval("NENHUM NUMERO PAR")
      fimse

Fimalgoritmo