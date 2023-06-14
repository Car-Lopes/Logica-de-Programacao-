Algoritmo "divisao"
//Escreva um algoritmo q leia dois números e imprima o resultado da divisão
//do primeiro pelo segundo.
//Caso não for possível, mostre a mensagem “DIVISAO IMPOSSIVEL”

Var
   x,y,divisao : real
   i,n : inteiro
Inicio
       escreva("Quantos casos voce vai digitar? ")
       leia(n)
       
       para i de 1 ate n faça
            escreva("Entre com o numerador: ")
            leia(x)
            escreva("Entre com o denominador: ")
            leia(y)
            
            se y = 0 entao
               escreval("IMPOSSIVEL DIVIDIR")
            senao
               divisao <- x / y
               escreval("DIVISAO = ", divisao:2:2)
            fimse
       fimpara

Fimalgoritmo