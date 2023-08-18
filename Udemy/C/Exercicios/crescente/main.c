#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.05 (crescente)

int main()
{
    int x=0, y=0 ;

    printf("Digite dois numeros: \n");
    scanf("%d", &x);
    scanf("%d", &y);

    while (x != y) {

        if (x > y ){
          printf("DECRESCENTE");
        }else{
          printf("CRESCENTE");
        }
        printf("\n");

        printf("Digite outros dois numeros: \n");
        scanf("%d", &x);
        scanf("%d", &y);
    }

    return 0;
}
