Algoritmo "divisao"
//Escreva um algoritmo q leia dois n�meros e imprima o resultado da divis�o
//do primeiro pelo segundo.
//Caso n�o for poss�vel, mostre a mensagem �DIVISAO IMPOSSIVEL�

Var
   x,y,divisao : real
   i,n : inteiro
Inicio
       escreva("Quantos casos voce vai digitar? ")
       leia(n)
       
       para i de 1 ate n fa�a
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