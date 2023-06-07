Algoritmo "glicose"
//Fazer um programa para ler a quantidade de glicose
//no sangue de uma pessoa e depois mostrar na tela a
//classificação desta glicose de acordo com a tabela de
//referência ao lado.
//Classificação            Glicose
// Normal                 Até 100 mg/dl
// Elevado             Maior que 100 até 140 mg/dl
// Diabetes              Maior de 140 mg/dl

Var
     glicose : real

Inicio
  escreva("Digite a medida da glicose: ")
   escreval
   leia(glicose)
   
   se glicose < 100 entao
      escreval("Normal")
   senao
      se glicose <= 140 entao
         escreval("Elevado")
      senao
          escreval("Diabete")
      fimse
   fimse
   
Fimalgoritmo