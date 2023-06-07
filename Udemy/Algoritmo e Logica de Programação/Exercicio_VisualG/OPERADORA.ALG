Algoritmo "operadora"
// Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito
// a 100 minutos de telefone.
// Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00.
// Fazer um programa par ler a quantidade de minutos que uma pessoa consumiu,
// daí mostrar o valor a ser pago

Var
   minutos, pagar : real

Inicio
     escreva("Digite a quantidade de minutos: ")
     leia (minutos)

     escreval
     se minutos > 100 entao

        pagar <- 50 + ((minutos-100)*2)

     senao
           pagar <- 50
     fimse

     escreval("Valor a Pagar: R$ ", pagar:4:2)

Fimalgoritmo