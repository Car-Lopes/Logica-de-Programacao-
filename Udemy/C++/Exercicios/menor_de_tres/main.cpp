#include <iostream>

//Exercicio CAP 04 (menor de tres)

using namespace std;

int main()
{
    int a, b, c;

    cout << "Primeiro valor: ";
    cin >> a ;

    cout << "Segundo valor: ";
    cin >> b;

    cout << "Terceiro valor ";
    cin >> c;

    cout << "\n";

    if (a < b && a < c ){
        cout << "MENOR = " << a;
    } else if (b < c ){
        cout << "MENOR = " << b;
    } else {
        cout << "MENOR = " << c;
    }


    return 0;
}
