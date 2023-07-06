Algoritmo "soma_linhas_matriz_vetor"
//Fazer um programa para ler dois números inteiros M e N (máximo = 10).
//Em seguida, ler uma matriz de M linhas e N colunas contendo números reais.
//Gerar um vetor de modo que cada elemento do vetor seja a soma dos
//elementos da linha correspondente da matriz. Mostrar o vetor gerado.

Var
   n,m,i,j: inteiro
   soma: real
   mat : vetor [0..3,0..3] de real

Inicio
      escreva("Qual a quantidade de linhas da matriz? ")
      leia(n)
      escreva("Qual a quantidade de colunas da matriz? ")
      leia(m)
      
      para i de 0 ate n-1 faca
          escreval("Digite os elementos da ", i+1,"a. linha: ")
          para j de 0 ate m-1 faca
             leia(mat[i,j])
          fimpara
      fimpara

      soma <- 0
      escreval("VETOR GERADO:")
      para i de 0 ate n-1 faca
          para j de 0 ate n faca
            soma <- soma + mat[i,j]
          fimpara
          escreval(soma:3:1)
          soma <- 0
      fimpara

Fimalgoritmo