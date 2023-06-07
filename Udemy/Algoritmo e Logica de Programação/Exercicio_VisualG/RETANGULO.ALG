Algoritmo "RETANGULO"
// Fazer um programa para ler as medidas da base e altura de um retângulo.
// Em seguida, mostrar o valorda área,
// perímetro e diagonal deste retângulo,
// com quatro casas decimais, conforme exemplos.

Var

   base, altura, diagonal, area, perimetro : real

Inicio

   escreval("Digite a base que o retangulo possui: ")
   leia(base)
   escreval("Digite a altura que o retangulo possui: ")
   leia(altura)

   area <- base * altura
   perimetro <- 2 * base + 2 * altura
   diagonal <- RaizQ(Exp(base,2) + Exp(altura,2))
   escreval
   escreval("Area do retangulo = ", area:10:4)
   escreval("Perimetro do retangulo = ", perimetro:10:4)
   escreval("Diagonal do retangulo = ", diagonal:10:4)

Fimalgoritmo