#include <iostream>
#include <math.h> //Biblioteca de fun��es matematica ou <cmath>
#include <iomanip>

//Execicio Cap.03 (Retangulo)

using namespace std;

int main()
{
    double base, altura, area, perimetro, diagonal;

    cout << "Base do Retangulo:  ";
    cin >> base;

    cout << "Altura do Retangulo: ";
    cin >> altura;

    area = base * altura;
    perimetro = 2 * (base + altura) ;
    diagonal = sqrt(pow(base, 2.0) + pow(altura, 2.0));
    //pow fun��o de exponecia��o (ao quadrado)

    cout << fixed << setprecision(4);
    cout << endl << "AREA = " << area << endl;
    cout << "PERIMETRO = " << perimetro << endl;
    cout << "DIAGONAL = " << diagonal << endl;

    return 0;
}
