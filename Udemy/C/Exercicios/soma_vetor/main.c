#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.06 (soma_vetor)

int main()
{
    int n;
    double soma=0, media=0;

    printf("Quantos numeros voce vai digitar? ");
    scanf("%d", &n);

    double vet[n];

    for(int i=0; i<n; i++){
        printf("Digite um numero: ");
        scanf("%lf", &vet[i]);
    }

    printf("\nVALORES = ");
    for(int i=0; i<n; i++){
        printf(" %.1lf ", vet[i]);
    }

    for(int i=0; i<n; i++){
        soma = soma + vet[i];
    }

    printf("\nSOMA = %.2lf", soma);

    media = soma / n;

    printf("\nMEDIA = %.2lf", media);


    return 0;
}
