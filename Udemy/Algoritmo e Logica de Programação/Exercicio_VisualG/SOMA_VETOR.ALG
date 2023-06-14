Algoritmo "soma_vetor"
//Faça um programa que leia N números reais e armazene-os em um vetor.
//Em seguida:
//- Imprimir todos os elementos do vetor
//- Mostrar na tela a soma e a média dos elementos do vetor


Var
   n, i : inteiro
   vet : vetor [0..9] de real
   soma: real

Inicio
      escreva("Quantos numeros voce vai digitar? ")
      leia(n)
      para i de 0 ate n-1 faca
           escreva("Digite um numero: ")
           leia(vet[i])
      fimpara

      escreval
      escreva("VALORES =")
      soma <- 0
      para i de 0 ate n-1 faca
           escreva("  ", vet[i]:4:2)
           soma <- soma + vet[i]
      fimpara
      escreval
      escreval("SOMA = ", soma:4:2)
      escreval("MEDIA = ", soma/n:4:2)

Fimalgoritmo