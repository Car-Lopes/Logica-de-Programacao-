Algoritmo "matriz_geral"
//Ler uma matriz quadrada de ordem N (m�ximo = 10), contendo n�meros reais.
//Em seguida, fazer as seguintes a��es:
//a) calcular e imprimir a soma de todos os elementos positivos da matriz.
//b) fazer a leitura do �ndice de uma linha da matriz e,
//da�, imprimir todos os elementos desta linha.
//c) fazer a leitura do �ndice de uma coluna da matriz e,
//da�, imprimir todos os elementos desta coluna.
//d) imprimir os elementos da diagonal principal da matriz.
//e) alterar a matriz elevando ao quadrado todos os n�meros negativos
//da mesma. Em seguida imprimir a matriz alterada.

Var
   n,i,j : inteiro
   soma : real
   mat : vetor [0..5,0..5] de real

Inicio
      escreva("Qual a ordem da matriz? ")
      leia(n)
      
      para i de 0 ate n-1 faca
          para j de 0 ate n-1 faca
               escreva("Elemento [", i,",", j,"]: ")
               leia(mat[i,j])
          fimpara
      fimpara
      
      soma <- 0
      para i de 0 ate n-1 faca
          para j de 0 ate n-1 faca
              se (mat[i,j] > 0) entao
                 soma <- soma + mat[i,j]
              fimse
          fimpara
      fimpara
      
      escreval
      escreval("SOMA DOS POSITIVOS: ",soma:4:1)
      
      escreval
      escreva("Escolha uma linha: ")
      leia (i)
      escreva("LINHA ESCOLHIDA: ")
      para i de i ate i faca
         para j de 0 ate n-1 faca
           escreva(mat[i,j]:3:1," ")
         fimpara
      fimpara
      
      escreval
      escreval
      escreva("Escolha uma coluna: ")
      leia (j)
      escreva("COLUNA ESCOLHIDA: ")
      para i de 0 ate n-1 faca
         para j de j ate j faca
           escreva(mat[i,j]:3:1," ")
         fimpara
      fimpara
      
      escreval
      escreval
      escreva("DIAGONAL PRINCIPAL: ")
      para i de 0 ate n-1 faca
         para j de 0 ate n-1 faca
           se (i = j) entao
             escreva(mat[i,j]:3:1," ")
           fimse
         fimpara
      fimpara
      
      escreval
      escreval
      para i de 0 ate n-1 faca
         para j de 0 ate n-1 faca
            se mat[i,j] < 0 entao
               mat[i,j] <- Exp(mat[i,J],2)//mat[i,J] * mat[i,J]
            fimse
         fimpara
      fimpara
      
      escreval("MATRIZ ALTERADA: ")
      para i de 0 ate n-1 faca
         para j de 0 ate n-1 faca
            escreva  (mat[i,j]:3:1," ")
         fimpara
         escreval
      fimpara

Fimalgoritmo