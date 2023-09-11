#include <iostream>
#include <iomanip>

//Exercicio CAP 07 (soma_linhas)

using namespace std;

int main()
{
    int m,n,soma=0;

    cout << "Qual a quantidade de linhas da matriz? ";
    cin >> m;
    cout << "Qual a quantidade de colunas da matriz? ";
    cin >> n;

    double mat [m][n];

    for(int i = 0; i < m; i++){
     cout << "Digite os elementos da " << i+1 << "a. linha: " << endl;
        for(int j = 0; j < n; j++){
            cin >> mat[i][j];
        }
    }

    double vet[m];

    cout << "VETOR GERADO:" << endl;

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            soma = soma + mat[i][j];
            vet[i] = soma;
        }
        cout << fixed << setprecision(1) << endl;
        cout << vet[i] << endl;
    }

    return 0;
}
