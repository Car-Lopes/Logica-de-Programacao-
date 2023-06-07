Algoritmo "dardo"
// No arremesso de dardo, o atleta tem três chances para lançar o dardo à
//maior distância que conseguir.
//Você deve criar um programa para, dadas as medidas das três tentativas
//de lançamento, informar qual foi a maior

Var
   n1, n2, n3 : real

Inicio
   escreval("Digite as tres distancias: ")
   leia(n1)
   leia(n2)
   leia(n3)
   
   se (n1 > n2) e (n1 > n3) entao
      escreval("Maior Distancia = ", n1:4:2)
   senao
      se (n2 > n1) e (n2 > n3) entao
        escreval("Maior Distancia = ", n2:4:2)
      senao
        escreval("Maior Distancia = ", n3:4:2)
      fimse
   fimse

Fimalgoritmo