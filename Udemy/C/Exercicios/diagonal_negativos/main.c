#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.07 (diagonal_negativos)

int main()
{
    int m, cont = 0;

    printf("Qual a ordem da matriz? ");
    scanf("%d",&m);

    int mat[m][m];

    for (int i = 0; i < m; i++ ){
        for(int j = 0; j < m; j++){
           printf("ELemento [%d,%d]: ", i, j);
           scanf("%d", &mat[i][j]);
        }
    }

    printf("DIAGONAL PRINCIPAL: \n");
    for (int i = 0; i < m; i++ ){
        for(int j = 0; j < m; j++){
           if (i == j){
           printf("%d ", mat[i][j]);
           }
        }
    }

    printf("\n");
    for (int i = 0; i < m; i++ ){
        for(int j = 0; j < m; j++){
           if (mat[i][j] < 0){
               cont++;
           }
        }
    }

    printf("QUANTIDADE DE NEGATIVOS = %d",cont);

    return 0;
}
