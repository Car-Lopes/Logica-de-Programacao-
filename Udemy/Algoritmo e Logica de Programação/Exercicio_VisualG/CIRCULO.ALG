Algoritmo "circulo"
// Fazer um programa para ler o valor "r" do raio de um c�rculo,
// e depois mostrar o valor da �rea do c�rculo com tr�s casas decimais.
// A f�rmula da �rea do c�rculo � a seguinte: area = PI.r ao quadrado
// Voc� pode usar o valor de PI fornecido pela biblioteca da sua linguagem
// de programa��o, ou ent�o, se preferir, use diretamente o valor 3.14159.

Var
   raioCirculo, area : real

Inicio

      escreval("Digite o valor do raio do circulo: ")
      leia(raioCirculo)

     // area <- pi * (raioCirculo * raioCirculo)   ou
     area <- pi * Exp(raioCirculo,2)
       escreval
      escreval("Area do Circulo = ", area:10:3)

Fimalgoritmo