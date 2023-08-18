#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.05 (tabuada)

int main()
{
    int n, i, resultado;

    printf("Deseja a tabuada para qual valor? ");
    scanf("%d", &n);

    resultado = 0;
    for (i = 1; i <= 10; i++){

        resultado = n * i;
        printf("%d x %i = %d \n", n,i,resultado );

    }

    return 0;
}
