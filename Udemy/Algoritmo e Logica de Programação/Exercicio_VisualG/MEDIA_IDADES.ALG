Algoritmo "media_idades"
//Faça um programa para ler um número indeterminado de dados,
//contendo cada um, a idade de um indivíduo. O último dado, que não entrará
//nos cálculos, contém um valor de idade negativa.
//Calcular e imprimir a idade média deste grupo de indivíduos.
//Se for entrado um valor negativo na primeira vez,mostrar a mensagem
//"IMPOSSIVEL CALCULAR".

Var
   idade, i, soma : inteiro
   media : real

Inicio
      escreval("Digite as idades: ")
      leia(idade)
      soma <-0
      i <- 0
      se (idade > 0) entao
         enquanto idade > 0 faca
            soma <- soma + idade
            leia(idade)
            i <- i + 1
         fimenquanto
         media <- soma / i
         escreval("MEDIA = ", media:4:2)
      senao
         escreval("IMPOSSIVEL CALCULAR")
      fimse

Fimalgoritmo