Algoritmo "baskara"
// Fazer um programa para ler os três coeficientes de uma equação do segundo
// grau. Usando a fórmula de Baskara, calcular e
// mostrar os valores das raízes x1 e x2 da equação c/quatro casas decimais,
// conforme exemplo. Se a equação não possuir raízes reais,
// mostrar uma mensagem

Var
   coeficienteA, coeficienteB, coeficienteC, x1, x2, delta : real

Inicio
      escreva("Coefiente a: ")
      leia(coeficienteA)
      escreva("Coefiente b: ")
      leia(coeficienteB)
      escreva("Coefiente c: ")
      leia(coeficienteC)
      
      delta <- Exp(coeficienteB,2) - 4 * coeficienteA * coeficienteC
      escreval
      se (coeficienteA = 0) ou (delta < 0) entao
         escreval("Esta equacao nao possui raizes reais")
      senao
         x1 <- (-coeficienteB + RaizQ(delta)) / (2 * coeficienteA)
         x2 <- (-coeficienteB - RaizQ(delta)) / (2 * coeficienteA)
         escreval("X1 = ", x1:6:4)
         escreval("X2 = ", x2:6:4)
      fimse

Fimalgoritmo