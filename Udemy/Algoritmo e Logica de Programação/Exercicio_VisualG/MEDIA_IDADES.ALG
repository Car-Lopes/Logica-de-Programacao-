Algoritmo "media_idades"
//Fa�a um programa para ler um n�mero indeterminado de dados,
//contendo cada um, a idade de um indiv�duo. O �ltimo dado, que n�o entrar�
//nos c�lculos, cont�m um valor de idade negativa.
//Calcular e imprimir a idade m�dia deste grupo de indiv�duos.
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