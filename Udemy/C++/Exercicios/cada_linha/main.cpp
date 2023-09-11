#include <iostream>

//Exercicio CAP 07 (cada_linha)

using namespace std;

int main()
{
    int n, maior ;

    cout << "Qual a ordem da matriz? ";
    cin >> n;

    int mat[n][n];

    for (int i = 0; i < n; i++){
        for (int j =0; j < n; j++){
            cout << "Elemento [" << i << "," << j << "]:" ;
            cin >> mat[i][j];
        }
    }

    cout << "MAIOR ELEMENTO DE CADA LINHA: "<< endl;

    for (int i = 0; i < n; i++){
        maior = mat[0][0];
        for (int j =0; j < n; j++){
            if (mat[i][j] > maior){
               maior = mat[i][j];
            }

        }
        cout << maior << endl;
    }

    return 0;
}
