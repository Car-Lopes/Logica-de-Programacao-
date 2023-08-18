#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.03 (Terreno)

void limpar_entrada()
{
    char c;
    while ((c = getchar()) != '\n' && c != EOF) {}
}

int main()
{
    float largura,comprimento,metroQuadadro,area =0, preco=0;

    printf("Digite a largura do terreno: ");
    scanf("%f", &largura );
   // limpar_entrada();

    printf("Digite o comprimento do terreno: ");
    scanf("%f", &comprimento );
   // limpar_entrada();

    printf("Digite o valor do metro quadrado: ");
    scanf("%f", &metroQuadadro );
    printf("\n");

    area = largura * comprimento;
    preco = area * metroQuadadro;

    printf("Area do Terreno = %.2f\n",area);
    printf("Preco do Terreno = %.2f\n",preco);

    return 0;
}
