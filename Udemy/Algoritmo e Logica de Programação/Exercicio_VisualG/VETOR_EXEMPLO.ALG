Algoritmo "Vetor_exemplo"
//Exemplo de Vetor vendo como ele funciona
//Fazer um programa para ler um número inteiro positivo N (máximo = 10),
//depois lerN números quaisquer e armazená-los em um vetor.
//Em seguida, mostrar na telatodos elementos do vetor.

Var
   n, i : inteiro
   vet : vetor [0..9] de real

Inicio
      escreva("Quantos numeros voce vai digitar? ")
      leia(N)
      para i de 0 ate N-1 faca
           escreva("Digite um numero: ")
           leia(vet[i])
      fimpara
      
      escreval

      escreval("NUMEROS DIGITADOS:")
      para i de 0 ate N-1 faca
           escreval(vet[i]:5:1)
      fimpara

Fimalgoritmo