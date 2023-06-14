Algoritmo "numeros_pares"
//Faça um programa que leia N números inteiros e armazene-os em um vetor.
//Em seguida, mostre na tela todos os números pares,
//e também a quantidade de números pares.


Var
   n, i, contPares : inteiro
   vet : vetor [0..9] de inteiro
   
Inicio
      escreva("Quantos numeros voce vai digitar? ")
      leia(n)
      para i de 0 ate n-1 faca
           escreva("Digite um numero: ")
           leia(vet[i])
      fimpara
      
      escreval
      escreval("NUMEROS PARES:")
      
      contPares <- 0
      para i de 0 ate n-1 faca
          se vet[i] % 2 = 0 entao
            escreva( vet[i], " ")
            contPares <- contPares + 1
          fimse
      fimpara
      escreval
      escreval
      escreva("QUANTIDADE DE PARES = ")
      escreva(contPares)


Fimalgoritmo