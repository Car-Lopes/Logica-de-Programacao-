Algoritmo "alturas_vetor"
//Fazer um programa para ler nome, idade e altura de N pessoas,
//conforme exemplo. Depois, mostrar na tela a altura média das pessoas,
//e mostrar também a porcentagem de pessoas com menos de 16 anos,
//bem como os nomes dessas pessoas caso houver.

Var
   n, i, idade : inteiro
   mediaAltura, porcIdade : real
   vetIdade : vetor [0..9] de inteiro
   vetAltura : vetor [0..9] de real
   vetNome : vetor [0..9] de caracter

Inicio
      escreva("Quantas pessoas serao digitadas? ")
      leia(n)
      para i de 0 ate n-1 faca
           escreval("Dados da", i+1, "a pessoa:")
           escreva("Nome: ")
           leia(vetNome[i])
           escreva("Idade: ")
           leia(vetIdade[i])
           escreva("Altura: ")
           leia(vetAltura[i])
           escreval
      fimpara
      
      mediaAltura <- 0
      para i de 0 ate n-1 faca
           mediaAltura <- mediaAltura + vetAltura[i]
      fimpara
      
      escreval("Altura média: ",mediaAltura/n:4:2)

      porcIdade <- 0
      para i de 0 ate n-1 faca
          se vetIdade[i] < 16 entao
            porcIdade <- porcIdade + 1
          fimse
      fimpara
      
      escreval("Pessoas com menos de 16 anos: ", ((porcIdade/n)*100):3:1,"%")
      
      para i de 0 ate n-1 faca
          se vetIdade[i] < 16 entao
            escreval(vetNome[i])
          fimse
      fimpara

Fimalgoritmo