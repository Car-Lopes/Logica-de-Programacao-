Algoritmo "tabuada_Estrutura_para"
//Ler um n�mero inteiro N, da� mostrar na tela a tabuada de N para 1 a 10,
//conforme exemplo

Var
   x,i,total : inteiro


Inicio
      escreva("Deseja a tabuada para qual valor? ")
      leia(x)
      
      para i de 1 ate 10 faca
           total <- x * i
           escreval(x, " x", i, " = ", total)
      fimpara

Fimalgoritmo