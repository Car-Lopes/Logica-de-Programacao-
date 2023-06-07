Algoritmo "menor_de_tres"
// Fazer um programa para ler três números inteiros.
// Em seguida, mostrar qual o menor dentre os três
// números lidos. Em caso de empate, mostrar apenas uma vez.

Var
   a, b, c, menor : inteiro

Inicio
      escreva("Digite valor de a: ")
      leia(a)
      escreva("Digite valor de b: ")
      leia(b)
      escreva("Digite valor de c: ")
      leia(c)
      
      escreval
      se (a < b) e (a < c) entao
         menor <- a
      senao
           se b < c entao
              menor <- b
           senao
              menor <- c
           fimse
      fimse
      
      escreval("Menor entre os tres é = ", menor)

Fimalgoritmo