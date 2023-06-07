Algoritmo "Exercio_Fixação"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Primeiro Programa para fixar como usar o VisualG
// Autor(a)    : Carlos Lopes
// Data atual  : 08/05/2023
Var
   produto1, produto2, genero : caractere
   preco1, preco2 : real
   idade, codigo : inteiro

Inicio

   produto1 <- "Computador"
   produto2 <- "TV"
   preco1 <- 2100.5
   preco2 <- 1830.0
   idade <- 30
   codigo <- 5291
   genero <- "F"

   escreval("Produtos:")
   escreval("O produto ", produto1, " custa R$ ", preco1:8:2)
   escreval("O produto ", produto2, " custa R$ ", preco2:8:2)
   escreval
   escreval("Código = ", codigo)
   escreval
   escreva("Dados da pessoa: genero ", genero, " e idade ", idade)
Fimalgoritmo