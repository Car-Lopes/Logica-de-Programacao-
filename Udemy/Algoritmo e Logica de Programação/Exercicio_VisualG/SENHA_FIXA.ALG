Algoritmo "senha_fixa"
//Escreva um programa q repita a leitura de uma senha até q ela seja válida.
//Para cada leitura de senha incorreta informada,
//escrever a mensagem "Senha Invalida! Tente novamente:".
//Quando a senha for informada corretamente deve ser impressa a mensagem
//"Acesso Permitido" e o algoritmo encerrado.
//Considere que a senha correta é o valor 2002.

Var
   senha : inteiro

Inicio
      escreva("Digite a senha:")
      leia(senha)
      
      enquanto senha <> 2023 faca
          escreva("Senha Invalida! Tente novamente: ")
          leia(senha)
      fimenquanto
      escreval("Acesso Permitido!")

Fimalgoritmo