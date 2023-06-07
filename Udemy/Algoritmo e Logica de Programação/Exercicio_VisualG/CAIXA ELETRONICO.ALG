Algoritmo "Caixa_Eletronico"
// Programa simples de um caixa eletronico

Var
   opcao_selecionada: caractere
   valor: real
   saldo: real
   encerrar_programa: logico
   
   funcao mostrar_menu : caracter
   inicio

         escreval ("Menu de Operações: ")
         escreval ("[a] Mostrar Saldo ")
         escreval ("[b] Efetuar Deposito  ")
         escreval ("[c] Efetuar Saque  ")
         escreval ("[d] Finalizar  ")
         escreval
         leia  (opcao_selecionada)
         retorne opcao_selecionada
   fimfuncao
   

Inicio
     encerrar_programa <- falso
     saldo <- 0

     enquanto encerrar_programa = falso faca

       opcao_selecionada <- mostrar_menu()
            
         se opcao_selecionada = "a"  entao
                    escreval ("Seu saldo é R$  ", saldo:5:2)
                    escreval
         senao
              se opcao_selecionada = "b" entao
                         escreval("Digite o valor a Depositar : ")
                         leia (valor)
                         escreval
                         escreval ("Deposito de R$ ", valor:5:2, " efetuado! ")
                         saldo <- saldo + valor
                         escreval
              senao
                   se opcao_selecionada = "c"  entao
                        escreval ("Digite o valor a sacar : ")
                        leia(valor)
                        escreval
                            se valor > saldo  entao
                               escreval ("Saque não permitido, saldo insulficiente!")
                               escreval
                            senao
                                saldo <- saldo - valor
                                escreval ("Saque de R$ ", valor:5:2,  " Efetuado!")
                                escreval
                            fimse
                   senao
                        se opcao_selecionada = "d"  entao
                           encerrar_programa <- verdadeiro
                        senao
                           escreval("opcao Invalida, tente novamente")
                           escreval
                        fimse
                   fimse
              fimse
         fimse
              
     fimenquanto

Fimalgoritmo