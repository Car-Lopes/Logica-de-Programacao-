#include <iostream>

//Exercicio CAP 05 (Crecente)

using namespace std;

int main()
{
    int a, b ;

    cout << "Digite dois numeros: \n";
    cin >> a >> b;

    while (a!= b){
        if (a < b){
            cout << "CRESCENTE!" << endl;
        }
        else{
            cout << "DECRESCENTE!" << endl;
        }

        cout << "Digite outros dois numero:" << endl;
        cin >> a >> b;
    }


    return 0;
}
