#include <stdio.h>
#include <stdlib.h>
#include <math.h>

//Exercio CAP.03 (Retangulo)

void limpar_entrada(){
	char c;
	while ((c = getchar()) != '\n' && c != EOF) {}
}

int main()
{
    double base, altura, area = 0, perimetro = 0, diagonal = 0;

    printf("Base do retangulo: ");
    scanf("%lf", &base);
    //limpar_entrada();

    printf("Altura do retangulo: ");
    scanf("%lf", &altura);

    area = base * altura;
    perimetro = (base * 2) + (altura * 2);
    //diagonal = sqrt((base * base) + (altura * altura)); //(sqrt)raiz quadrada (pow(potencia)
    diagonal = sqrt(pow(base, 2.0) + pow(altura, 2.0));

    printf("AREA = %.4lf\n", area);
    printf("PERIMETRO = %.4lf\n", perimetro);
    printf("DIAGONAL = %.4lf", diagonal);

    return 0;
}
