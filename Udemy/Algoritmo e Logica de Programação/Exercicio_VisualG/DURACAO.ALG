Algoritmo "duracao"
// Fazer um programa para ler uma duração de tempo em segundos,
// daí imprimir na tela esta duração no formato horas:minutos:segundos.

Var

   duracao, h, m, s, resto : inteiro


Inicio
       escreval("Programa Duracao")
      escreva("Digite a duração em segundos: ")
      leia(duracao)
      escreval         //3600 é o valor de  segundos em 1 hora
      
      h <- duracao div 3600
      resto <- duracao % 3600

      m <- resto \ 60
      s <- resto mod 60

      escreval(h, ":", m, ":", s)

Fimalgoritmo