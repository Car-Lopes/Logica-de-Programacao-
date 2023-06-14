Algoritmo "par_impar"
//Leia um valor inteiro N. Este valor será a quantidade de números inteiros
//que serão lidos em seguida.
//Para cada valor lido, mostre uma mensagem dizendo se este valor lido é PAR
//ou IMPAR,e também se é POSITIVO ou NEGATIVO.No caso d valor ser = a zero(0)
//, seu programa deverá imprimir apenas NULO.

Var
   n,x,i,imparP,parP,imparN,parN,nulo : inteiro

Inicio
      imparP <- 0
      imparN <- 0
      parP <- 0
      parN <- 0
      
       escreva("Quantos numeros voce vai digitar? ")
       leia(n)
       
       para i de 1 ate n faça
            escreva("Digite um numero: ")
            leia(x)

            se (x % 2 <> 0) e (x > 0)  entao
              imparP <- imparP + 1
              escreval("IMPAR POSITIVO")
            senao
               se (x % 2 <> 0) e (x < 0) entao
                 imparN <- imparN + 1
                 escreval("IMPAR NEGATIVO")
               senao
                  se (x % 2 = 0) e (x > 0) entao
                     parP <- parP + 1
                     escreval("PAR POSITIVO")
                  senao
                     se (x % 2 = 0) e (x < 0) entao
                        parN <- parN + 1
                        escreval("PAR NEGATIVO")
                     senao
                        nulo <- nulo + 1
                        escreval("NULO")
                     fimse
                  fimse
               fimse
            fimse
       fimpara

       escreval(imparP, " Numeros Impares Positivo Digitado")
       escreval(imparN, " Numeros Impares Negativo Digitado")
       escreval(parP, " Numeros Pares Positivo Digitado")
       escreval(parN, " Numeros Pares Negativo Digitado")
       escreval(nulo, " numeros Nulos digitados")

Fimalgoritmo