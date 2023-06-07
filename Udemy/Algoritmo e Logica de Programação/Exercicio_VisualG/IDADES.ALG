Algoritmo "IDADES"
// Fazer um programa para ler o nome e idade de duas pessoas.
// Ao final mostrar uma mensagem com os nomes e a idade média
// entre essas pessoas, com uma casa decimal, conforme exemplo.

Var

   nome1, nome2 : caractere
   idade1, idade2 : inteiro
   media : real

Inicio

   escreval("Dados da Primeira Pessoa: Nome e Idade")
   escreva("Nome: ")
   leia(nome1)
   escreva("Idade: ")
   leia(idade1)
   
   escreval
   
   escreval("Dados da Segunda Pessoa: Nome e Idade")
   escreva("Nome: ")
   leia(nome2)
   escreva("Idade: ")
   leia(idade2)
   
   media <- (idade1 + idade2) / 2
   
   escreval
   escreva("A idade média de ", nome1, " e ")
   escreva(nome2, " é de ", media:3:1, " anos")

Fimalgoritmo