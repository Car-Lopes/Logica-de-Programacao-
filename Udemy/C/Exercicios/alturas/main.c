#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//Exercio CAP.06 (alturas)

int main()
{
    int n;
    double soma=0, media=0, porc=0, contt=0;

    printf("Quantas pessoas serao digitadas? ");
    scanf("%d", &n);

    char nomes[n][50];
    int idades[n];
    double alturas[n];

    for(int i = 0; i < n; i++){
        printf("Dados da %da pessoa\n", i+1);

        printf("Nome: ");
        fseek(stdin, 0, SEEK_END);
        gets(nomes[i]);

        printf("Idade: ");
        scanf("%d", &idades[i]);

        printf("Altura: ");
        scanf("%lf", &alturas[i]);

    }

    for (int i =0; i < n; i++){
        soma = soma + alturas[i];
    }

    media = soma / n;

    printf("\nAltura media: %.2lf\n", media);

    for (int i =0; i < n; i++){
        if (idades[i] < 16) {
            contt++;
        }
    }

    porc = (contt / n) * 100;
    printf ("Pessoas com menos de 16 anos: %.1lf%%\n", porc);

    for (int i =0; i < n; i++){
        if (idades[i] < 16) {
            printf(nomes[i]);
            printf("\n");
        }
    }

    return 0;
}
