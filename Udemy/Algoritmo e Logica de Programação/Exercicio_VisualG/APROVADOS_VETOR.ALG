Algoritmo "aprovados_vetor"
//Fazer um programa para ler um conjunto de N nomes de alunos,
//bem como as notas que eles tiraram no 1º e 2º semestres.
//Cada uma dessas informações deve ser armazenada em um vetor.
//Depois, imprimir os nomes dos alunos aprovados, considerando aprovados
//aqueles cuja média das notas seja maior ou igual a 6.0 (seis).

Var
   n,i : inteiro
   vetNome : vetor [0..9] de caractere
   vetN1 : vetor [0..9] de real
   vetN2 : vetor [0..9] de real
   vetMedia : vetor [0..9] de real

Inicio
      escreva("Quantos alunos serao digitados? ")
      leia(n)
      
      para i de 0 ate n-1 faca
         escreval("Digite nome, primeira e segunda nota do", i+1, "o aluno:")
         leia(vetNome[i])
         leia(vetN1[i])
         leia(vetN2[i])
         vetMedia[i] <- (vetN1[i] + vetN2[i])
         vetMedia[i] <- vetMedia[i] / 2
      fimpara
      
      escreval("Alunos Aprovados")

      para i de 0 ate n-1 faca
         se vetMedia[i] >= 6.0 entao
            escreval(vetNome[i])
         fimse
      fimpara

Fimalgoritmo