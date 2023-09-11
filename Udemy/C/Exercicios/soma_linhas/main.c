#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.07 (soma_linhas)

int main()
{
    int m, n;
    //double soma=0;

    printf("Qual a quantidade de linhas da matriz? ");
    scanf("%d", &m);
    printf("Qual a quantidade de colunas da matriz? ");
    scanf("%d", &n);

    double mat[m][n];
    double vet [m];

    for (int i = 0; i < m; i++ ){
        printf("Digite os elementos da %da. linha: \n", i+1);
        for (int j =0; j<n; j++){
            scanf("%lf", &mat[i][j]);
        }
    }
/*
    printf("VETOR GERADO: \n");
    for (int i = 0; i < m; i++ ){      //Uma forma de Fazer
        for (int j =0; j<n; j++){
            soma = soma + mat[i][j];
        }
        printf("%.1lf \n", soma);
        soma = 0;
    }*/

    for (int i = 0; i < m; i++){          //Outra forma de fazer
        vet[i] = 0;
        for (int j = 0; j < n; j++){
            vet[i] = vet[i] + mat[i][j];
        }
    }

    printf("VETOR GERADO: \n");
    for (int i = 0; i < m; i++){
        printf("%.1lf\n", vet[i]);
    }

    return 0;
}
