Algoritmo "tempo_de_jogo"
//Leia a hora inicial e a hora final de um jogo.
//A seguir calcule a dura��o do jogo, sabendo que o mesmo pode come�ar
//em um dia e terminar em outro, tendo uma dura��o m�nima de 1 hora
//e m�xima de 24 horas.

Var
    hrInicial, hrFinal, totalHoras : inteiro

Inicio
      escreva("Hora Inicial: ")
      leia(hrInicial)
      escreva("Hora Final: ")
      leia(hrFinal)


      se hrInicial <  hrFinal entao
          totalHoras <- hrFinal - hrInicial
      senao
          totalHoras <- (24-hrInicial) + hrFinal
      fimse

      escreval("O JOGO DUROU ", totalHoras:4:2 , " HORA(S)")
      
Fimalgoritmo