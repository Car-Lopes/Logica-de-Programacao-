Algoritmo "coordenadas"
//Leia os valores das coordenadas X e Y de um ponto no plano
//cartesiano. A seguir, determine qual o quadrante ao qual pertence o
//ponto (Q1, Q2, Q3 ou Q4). Se o ponto estiver na origem, escreva a
//mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva
//“Eixo X” ou “Eixo Y”, conforme for a situação.

Var
    x, y : real
    ponto : caractere

Inicio

      escreva("Valor de X: ")
      leia(x)
      escreva("Valor de Y: ")
      leia(y)
      
      se (x > 0) e (y > 0) entao
         ponto <- "Q1"
      senao
         se (x < 0 ) e (y > 0) entao
              ponto <- "Q2"
         senao
             se (x < 0) e (y < 0 ) entao
                ponto <- "Q3"
             senao
                se (x > 0) e (y < 0) entao
                   ponto <- "Q4"
                senao
                   se (x > 0) e (y=0) entao
                     ponto <- "Eixo X"
                   senao
                      se (x = 0) e (y > 0) entao
                         ponto <- "Eixo Y"
                      senao
                          ponto <- "Origem"
                      fimse
                   fimse
                fimse
             fimse
         fimse
      fimse
      escreval(ponto)
Fimalgoritmo