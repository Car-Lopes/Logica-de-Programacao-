#include <iostream>
#include <iomanip>
//#include <string>
#include <climits>

//Exercicio CAP 06 (alturas)

using namespace std;

int main()
{
    int n;
    double soma, media, cont, percentual;

    cout << "Quantas pessoas serao digitadas? ";
    cin >> n;

    string nomes[n];
    int idades[n];
    double alturas[n];

    for (int i = 0; i < n; i++){
       cout << "Dados da " << i+1 << "a pessoa:" << endl;
       cout << "Nome: ";
       cin.ignore(INT_MAX, '\n');
       getline(cin,nomes[i]);

       cout << "Idade: ";
       cin >> idades[i];

       cout << "Alturas: ";
       cin >> alturas[i];

    }

    soma = 0;
    for (int i = 0; i < n; i++){
        soma = soma + alturas[i];
    }

    media = soma / n;

    cout << fixed << setprecision(2) << endl;
    cout << "Altura media: " << media ;


    cont = 0;
    for (int i = 0; i < n; i++){
        if (idades[i] < 16){
            cont++;
        }
    }
    percentual = (double)cont * 100 / n;

    cout << fixed << setprecision(1) << endl;
    cout << "Pessoas com menos de 16 Anos: " << percentual << "%";

    for (int i = 0; i < n; i++){
        if (idades[i] < 16){
            cout << endl << nomes[i];
        }
    }


    return 0;
}
