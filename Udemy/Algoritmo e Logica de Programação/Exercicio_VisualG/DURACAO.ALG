Algoritmo "duracao"
// Fazer um programa para ler uma dura��o de tempo em segundos,
// da� imprimir na tela esta dura��o no formato horas:minutos:segundos.

Var

   duracao, h, m, s, resto : inteiro


Inicio
       escreval("Programa Duracao")
      escreva("Digite a dura��o em segundos: ")
      leia(duracao)
      escreval         //3600 � o valor de  segundos em 1 hora
      
      h <- duracao div 3600
      resto <- duracao % 3600

      m <- resto \ 60
      s <- resto mod 60

      escreval(h, ":", m, ":", s)

Fimalgoritmo