#include <stdio.h>
#include <stdlib.h>
#include <math.h>

//Exercio CAP.04 (Baskara)

int main()
{
    double a, b, c, x1, x2, delta ;

    printf("Coeficiente A: ");
    scanf("%lf", &a);
   // fseek(stdin, 0, SEEK_END);

    printf("Coeficiente B: ");
    scanf("%lf", &b);
   // fseek(stdin, 0, SEEK_END);

    printf("Coeficiente C: ");
    scanf("%lf", &c);
  //  fseek(stdin, 0, SEEK_END);

    delta = b * b - 4 * a * c;

    if (a == 0 || delta < 0) {
        printf("Esta equacao nao possui raizes reais");
    } else {
        x1 = (-b + sqrt(delta)) / (2 * a);
        x2 = (-b - sqrt(delta)) / (2 * a);
        printf("X1 = %.4lf\n", x1);
        printf("X2 = %.4lf\n", x2);
    }

    return 0;
}
