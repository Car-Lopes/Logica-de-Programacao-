Algoritmo "media_ponderada"
//Leia um vlr inteiro N,q representa o n�mero de casos d teste q vem a seguir.
//Cada caso de teste consiste de 3 valores reais, para os quais voc� dever�
//calcular e mostrar a m�dia ponderada, sendo que o primeiro valor tem peso 2
//,o segundo valor tem peso 3 e o terceiro valor tem peso 5.
//Vale lembrar que a m�dia ponderada � a soma de todos os valores
//multiplicados pelo seu respectivo peso, dividida pela soma dos pesos.

Var
   x,y,z,media : real
   i,n : inteiro
Inicio
       escreva("Quantos casos voce vai digitar? ")
       leia(n)
       
       para i de 1 ate n fa�a
            escreval("Digite tres numeros: ")
            leia(x,y,z)

            media <- ((x * 2) + (y * 3) + (z * 5)) / 10
            escreval("MEDIA = ", media:2:1)
       fimpara

Fimalgoritmo