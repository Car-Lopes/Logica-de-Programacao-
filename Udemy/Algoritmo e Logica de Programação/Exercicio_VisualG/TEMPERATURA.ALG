Algoritmo "temperatura"
//Deseja-se converter uma medida d temperatura d escala Celsius p/ Fahrenheit
//ou vice-versa. Para isso, voc� deve construir um programa que leia a letra
// C" ou "F" indicando em qual escala vai ser informada uma temperatura.
//Em seguida o programa deve mostrar a temperatura na outra escala com
//duas casas decimais. A seguir � dada a f�rmula para converter de Fahrenheit
//para Celsius (voc� deve deduzir a f�rmula de Celsius para Fahrenheit):
//C = 5 /9 (F-32)

Var
   c,f : real
   x : caractere
   
Inicio
      escreva("Voce vai digitar a temperatura em qual escala (C/F)? ")
      leia(x)
      
      escolha x
      caso "F"
          escreval("Digite a temperatura em Fahrenheit: ")
          leia(f)
           c <- 5/9*(f-32)
           escreval("Temperatura equivalente em Celsius: ", c:4:2)
      caso "C"
          escreval("Digite a temperatura em Celsius: ")
          leia(c)
          f <- c *(9/5)+32
           escreval("Temperatura equivalente em Fahrenheit: ", f:4:2)
      fimescolha

Fimalgoritmo