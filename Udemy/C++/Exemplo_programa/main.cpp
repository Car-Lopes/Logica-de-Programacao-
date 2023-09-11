#include <iostream> //Biblioteca de entrada e saida
#include <iomanip> //Biblioteca serve para formatação de casas decimais
#include <string> //Biblioteca para usar funções de manipulação de texto
//#include <bits/stdc++.h>//Biblioteca universal (inclui tudo e dispensa bibliotecas individuais)

using namespace std;

int main()
{
    int idade;
    double salario, altura;
    char genero;
    string nome, nome1="Leticia Andrade", sexo="feminino";

    idade = 32;
    salario = 50000.00;
    altura = 1.63;
    genero = 'F';
    //sexo = "feminino";
    nome = "Maria Silva";

    cout << fixed << setprecision(2);
    cout << "IDADE = " << idade << "\n";//<< endl;
    cout << "SALARIO = " << salario << endl;
    cout << "ALTURA = " << altura << endl;
    cout << "GENERO = " << genero << endl;
    cout << "NOME = " << nome << endl << endl;

    //count << "\n\n" <<;

    cout << fixed << setprecision(2);
    cout << "A patroa " << nome1 << ", sexo "
    << sexo << ", ganha " << salario << " e tem "
    << idade << " anos." << endl;


    return 0;
}
