Algoritmo "pagamento"
// Fazer um programa para ler o nome de um(a) funcionário(a),
// o valor que ele(a) recebe por hora,
// e aquantidade de horas trabalhadas por ele(a).
// Ao final, mostrar o valor do pagamento do funcionário com
// uma mensagem explicativa, conforme exemplo.


Var
   nome : caractere
   valorHora, pagamento : real
   horaTrabalhada : inteiro

Inicio
      escreva("Digite o Nome: ")
      leia(nome)
      escreva("Digite o Valor por hora: ")
      leia(valorHora)
      escreva("Digite as horas trabalhadas: ")
      leia(horaTrabalhada)

      pagamento <- valorHora * horaTrabalhada
      escreval
      escreval("O pagamento para ",nome, "deve ser R$", pagamento:10:2)

Fimalgoritmo