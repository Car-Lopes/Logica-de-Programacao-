#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.04 (menor_de_tres)

int main()
{
    int primeiroNum, segundoNum, terceiroNum, menor ;

    printf("Primeiro valor: ");
    scanf("%d", &primeiroNum);

    printf("Segundo valor: ");
    scanf("%d", &segundoNum);

    printf("Terceiro valor: ");
    scanf("%d", &terceiroNum);

    if (terceiroNum < segundoNum && terceiroNum < primeiroNum){
        menor = terceiroNum  ;
    } else if (segundoNum < primeiroNum && segundoNum < terceiroNum) {
        menor = segundoNum;
    } else {
        menor = primeiroNum;
    }

    printf("MENOR = %d", menor) ;

    return 0;
}
