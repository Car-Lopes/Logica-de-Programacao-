Algoritmo "soma_impares_Estrutura_para"
//Leia 2 valores inteiros X e Y (em qualquer ordem).
//A seguir, calcule e mostre a soma dos números impares entre eles.

Var
   x,y,i,total : inteiro


Inicio
      escreval("Digite dois numeros: ")
      leia(x)
      leia(y)
      
      se (x < y) e (x mod 2 = 0) entao
        // x <- x + 1
         para i de x+1 ate y-1 faca
              se i mod 2 = 0 entao
                 i <- i + 1
              senao
                 total <- total + i
              fimse
         fimpara
         
      senao
           se (x < y) entao
             //  x <- x + 1
               para i de x+1 ate y-1 faca
                   se i mod 2 = 0 entao
                     i <- i + 1
                   senao
                      total <- total + i
                   fimse
               fimpara
               
           senao
               se (y < x) e (y mod 2 = 0) entao
                //y <- y + 1
                 para i de y+1 ate x-1 faca
                     se i mod 2 = 0 entao
                        i <- i + 1
                     senao
                        total <- total + i
                     fimse
                 fimpara
                 
               senao
                  se (y < x)entao
                  //  y <- y + 1
                    para i de y+1 ate x-1 faca
                      se i mod 2 = 0 entao
                        i <- i + 1
                      senao
                        total <- total + i
                      fimse
                    fimpara
                    
                  fimse
               fimse
           fimse
      fimse
      
      escreval("SOMA DOS IMPARES = ", total)
Fimalgoritmo