Algoritmo "multiplos"
//Fazer um programa para ler dois n�meros inteiros,
//e dizer se um n�mero � m�ltiplo do outro.
//Os n�meros podem ser digitados em qualquer ordem

Var
   n,m,r : inteiro

Inicio
   escreval("Digite dois numeros inteiros: ")
   leia(n)
   leia(m)
   
   r <- int(m/n)*n

   se (r = 0) ou (r = m) entao
      escreva("sao multiplos")
   senao
      escreva("N�o � multiplo")
   fimse
   
   //ou pode ser feito dessa form tambem
   //se (n % m = 0) ou (m % n = 0) entao
     // escreva("sao multiplos")
   //senao
     // escreva("N�o � multiplo")
   //fimse
   
Fimalgoritmo