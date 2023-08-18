#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.05 (media_idades)

int main()
{
    int idade=0, contt=0, somaIdade=0;
    double mediaIdade=0;

    printf("Digite as idades: \n");
    scanf("%d", &idade);

    if (idade <= 0){
        printf("IMPOSSIVEL CALCULAR");
    }
    else{
        while ( idade > 0 )
        {
            somaIdade = somaIdade + idade;
            contt = contt+1;
            scanf("%d", &idade);
        }

        mediaIdade = (double)somaIdade / contt;

        printf("MEDIA = %.2lf", mediaIdade);
    }
    return 0;
}
