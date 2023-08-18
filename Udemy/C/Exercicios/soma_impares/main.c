#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.05 (soma_impares)

int main()
{
    int x, y, i, somaImpares=0, troca;

    printf("Digite dois numeros: \n");
    scanf("%d %d", &x, &y);

    if (x > y){
        troca = x;
        x = y;
        y = troca;
    }

    for (i=x+1; i < y; i++){
        if (i % 2 != 0){
          somaImpares = somaImpares + i;
        }
     }

     printf("Soma dos Impares = %d", somaImpares);

    return 0;
}
