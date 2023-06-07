Algoritmo "quadrante"
//Escreva um programa p/ler as coordenadas(X,Y)de uma quantdd indeterminada
//de pontos no sistema cartesiano.
//Para cada ponto escrever o quadrante a que ele pertence (Q1, Q2, Q3 ou Q4).
//O algoritmo será encerrado quando p/menos uma de duas coordenadas for NULA
//(nesta situação sem escrever mensagem alguma).

Var
   x, y : real

Inicio
      escreval("Digite os valores das coordenadas X e Y: ")
      leia(x,y)

      enquanto (x <> 0 ) e (y <> 0) faca
               se (x > 0) e (y > 0) entao
                  escreval("QUADRADE Q1")
               senao
                    se (x < 0) e (y > 0) entao
                       escreval("QUADRADE Q2")
                    senao
                         se (x < 0) e (y < 0) entao
                            escreval("QUADRADE Q3")
                         senao
                            escreval("QUADRADE Q4")
                         fimse
                    fimse
               fimse
      escreval("Digite os valores das coordenadas X e Y: ")
      leia(x,y)
      fimenquanto

Fimalgoritmo