Algoritmo "abaixo_da_media_vetor"
//Fazer um programa para ler um número inteiro N e depois um vetor de
//N números reais. Em seguida, mostrar na tela a média aritmética de todos
//elementos com três casas decimais. Depois mostrar todos os elementos do
//vetor que estejam abaixo da média, com uma casa decimal cada.


Var
   n, i : inteiro
   media, somaVet : real
   vet : vetor [0..9] de real

Inicio
      escreva("Quantos elementos vai ter o vetor? ")
      leia(n)
      
      somaVet <- 0
      para i de 0 ate n-1 faca
           escreva("Digite um numero: ")
           leia(vet[i])
           somaVet <- somaVet + vet[i]
      fimpara
      
      media <- somaVet / n
      escreval
      escreval("MEDIA DO VETOR = ", media:6:3)
      escreval("ELEMENTOS ABAIXO DA MEDIA:")
      para i de 0 ate n-1 faca
           se vet[i] < media entao
              escreval(vet[i]:3:1)
           fimse
      fimpara

Fimalgoritmo