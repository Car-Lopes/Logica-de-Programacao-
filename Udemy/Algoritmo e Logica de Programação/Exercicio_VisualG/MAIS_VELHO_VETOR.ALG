Algoritmo "mais_velho_vetor"
//Fazer um program para ler um conjunto d nomes d pessoas e suas respectivas
//idades. Os nomes devem ser armazenados em um vetor,
//e as idades em um outro vetor.
//Depois, mostrar na tela o nome da pessoa mais velha.

Var
   n,i,velho : inteiro
   nome : caractere
   vetNome : vetor [0..9] de caractere
   vetIdade : vetor [0..9] de inteiro

Inicio
      escreva("Quantas pessoas voce vai digitar? ")
      leia(n)
      
      para i de 0 ate n-1 faca
           escreval("Dados da ", i+1, "a pessoa:")
           escreva("Nome: ")
           leia(vetNome[i])
           escreva("Idade: ")
           leia(vetIdade[i])
      fimpara
      
      velho <- vetIdade[0]
      para i de 1 ate n-1 faca
          se vetIdade[i] > velho entao
             velho <- vetIdade[i]
             nome <- vetNome[i]
          fimse
      fimpara
      
      escreva("PESSOA MAIS VELHA: ", nome )
Fimalgoritmo