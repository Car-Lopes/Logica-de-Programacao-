Algoritmo "Exercicio_Entrada_de_Dados"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Primeiro Programa para fixar como usar o VisualG
// Autor(a)    : Carlos Lopes
// Data atual  : 08/05/2023
Var
   idade : inteiro
   salario1, salario2 : real
   nome: caractere

Inicio

   escreva("Digite seu Nome: ")
   leia(nome)
   escreva("Digite sua idade: ")
   leia(idade)
   escreval("Digite quanto voçê ganhou nos dois ultimos messes: ")
   leia(salario1)
   leia(salario2)
   escreval
   escreval("DADOS DIGITADOS:")
   escreval("Nome: ", nome)
   escreval("Idade: ", idade)
   escreval("Salario 1 = ", salario1:8:2)
   escreval("Salario 2 = ", salario2:8:2)

Fimalgoritmo