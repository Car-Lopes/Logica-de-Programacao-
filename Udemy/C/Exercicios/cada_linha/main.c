#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.07 (cada_linha)

int main()
{
    int m, maior;

    printf("Qual a ordem da matriz? ");
    scanf("%d", &m);

    int mat[m][m];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < m; j++){
            printf("Elemento [%d,%d]: ", i, j);
            scanf("%d", &mat[i][j]);
        }
    }

    printf("MAIOR ELEMENTO DE CADA LINHA: \n");

    //maior=mat[0][0];
    for (int i = 0; i < m; i++){
        maior = 0;
        for (int j = 0; j < m; j++){
            if (maior > mat[i][j]){
                maior = maior;
            }
            else{
                maior = mat[i][j];
            }

        }
    printf(" %d ", maior);
    }



    return 0;
}
