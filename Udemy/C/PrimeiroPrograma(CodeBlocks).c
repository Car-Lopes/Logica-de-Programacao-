#include <stdio.h> //Comandos de Entrada e Saida
#include <string.h> //Funções de String

int main (){

    int idade = 20 ;
    double salario = 5800.5, altura = 1.63;
    char genero = 'F';
    char nome[50] = "Maria Silva";

  //  idade = 20;
  //  salario = 5800.5;
  //  altura = 1,63;
  //  genero = 'F';
  //  strcpy(nome, "Maria Silva");

    printf("IDADE = %d\n", idade);
    printf("SALARIO = %.2lf\n", salario);
    printf("ALTURA = %.2lf\n", altura);
    printf("GENERO = %c\n", genero);
    printf("NOME = %s\n", nome);

    return 0;
}

