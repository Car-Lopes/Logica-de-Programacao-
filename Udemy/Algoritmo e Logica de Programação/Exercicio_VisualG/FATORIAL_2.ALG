Algoritmo "fatorial_2"
//Fazer um programa para ler um número natural N (valor máximo: 15),
//e depois calcular e mostrar o fatorial de N.

Var
   n, i, fat : inteiro

Inicio
      escreva("Digite o valor de N: ")
      leia(n)

      fat <- 1
      para i de 1 ate n faça
          fat <- fat * i
      fimpara

      escreval("FATORIAL = ", fat)

Fimalgoritmo