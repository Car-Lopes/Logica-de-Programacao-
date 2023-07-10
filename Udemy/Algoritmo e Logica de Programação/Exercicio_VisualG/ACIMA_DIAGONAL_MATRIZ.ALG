Algoritmo "acima_diagonal_matriz"
//Ler um inteiro N (máximo = 10) e uma matriz quadrada de ordem N
//contendo números inteiros. Mostrar a soma dos elementos acima da
//diagonal principal. Um exemplo de números acima da diagonal
//principal é mostrado ao lado (no caso as células com fundo cinza).

Var
   n,m,i,j,soma,cont : inteiro
   mat : vetor [0..5,0..5] de inteiro

Inicio
      escreva("Qual a ordem da matriz? ")
      leia(n)

      para i de 0 ate n-1 faca
          para j de 0 ate n-1 faca
             escreva("Elemento [",i,",",j,"]: ")
             leia(mat[i,j])
          fimpara
      fimpara
      
      soma <- 0
      para i de 0 ate n-1 faca
          para j de i+1 ate n-1 faca
             //j <- j+1
             soma <- soma + mat[i,j]
          fimpara
      fimpara

      escreva("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = ", soma)

Fimalgoritmo