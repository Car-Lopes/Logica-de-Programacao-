#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.07 (soma_matrizes)

int main()
{
    int m, n, soma=0 ;

    printf("Quantas linhas vai ter cada matriz? ");
    scanf("%d",&m);
    printf("Quantas colunas vai ter cada matriz? ");
    scanf("%d",&n);

    int matA[m][n];
    printf("Digite os valores da matriz A:\n");
    for (int i = 0; i < m; i++ ){
        for (int j = 0; j < n; j++){
            printf("ELEMENTO [%d,%d]: ", i, j);
            scanf("%d", &matA[i][j]);
        }
    }

    int matB[m][n];
    printf("Digite os valores da matriz B:\n ");
    for (int i = 0; i < m; i++ ){
        for (int j = 0; j < n; j++){
            printf("ELEMENTO [%d,%d]: ", i, j);
            scanf("%d", &matB[i][j]);
        }
    }

    int matC[m][n];
    for (int i=0; i<m; i++){
        for (int j=0; j<n; j++){
            matC[i][j] = matA[i][j] + matB[i][j];
        }
    }

    printf("MATRIZ SOMA: \n");
    for (int i=0; i<m; i++){
        for (int j=0; j<n; j++){
            printf("%d ",matC[i][j]);
        }
        printf("\n");
    }

    return 0;
}
