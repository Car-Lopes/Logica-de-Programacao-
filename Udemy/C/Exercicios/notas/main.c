#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.04 (Notas)

int main()
{
    double nota1, nota2, notaFinal ;

    printf("Digite a primeira nota: ");
    scanf("%lf", &nota1);
    fseek(stdin, 0, SEEK_END);

    printf("Digite a segunda nota: ");
    scanf("%lf", &nota2);

    notaFinal = nota1 + nota2;

    printf("NOTA FINAL = %.1lf\n",notaFinal);

    if (notaFinal > 60) {
        printf("Aprovado");
    } else {
        printf("Reprovado");
    }

    return 0;
}
