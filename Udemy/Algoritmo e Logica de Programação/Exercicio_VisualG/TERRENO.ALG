Algoritmo "TERRENO"
// Descri��o   : Calculando a area de um terreno
// e calculando seu pre�o do terreno

Var
   largura, comprimento, metroQuadrado, area, preco: real

Inicio

      escreval("Digite a largura do terreno: ")
      leia(largura)
      escreval("Digite o comprimento do terreno: ")
      leia(comprimento)
      escreval("Digite o valor do metro quadrado: ")
      leia(metroQuadrado)

      area <- largura * comprimento
      preco <- area * metroQuadrado
      escreval
      escreval("Area do terreno = ", area:8:2)
      escreval("Pre�o do terreno = ", preco:8:2)

Fimalgoritmo