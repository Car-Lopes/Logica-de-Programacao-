Algoritmo "fatorial"
//Fazer um programa para ler um n�mero natural N (valor m�ximo: 15),
//e depois calcular e mostrar o fatorial de N.

Var
   n, i, total : inteiro

Inicio

      escreva("Digite o valor de N: ")
      leia(n)
      total <- n
      se n = 0 entao
         total <- 1 * 1
      senao
          para i de n-1 ate 1 passo -1 fa�a
              total  <- total * i
          fimpara
      fimse
      escreval("FATORIAL de", n, "!", " = ", total)

Fimalgoritmo