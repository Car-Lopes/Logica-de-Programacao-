#include <stdio.h>
#include <stdlib.h>

//Exercio CAP.03 (Idade)

void limpar_entrada() {
 char c;
 while ((c = getchar()) != '\n' && c != EOF) {}
}

void ler_texto(char *buffer, int length) {
 fgets(buffer, length, stdin);
 strtok(buffer, "\n");
}

int main()
{
    int idade1, idade2;
    double mediaIdade;
    char nome1[50], nome2[50];

    printf("Dados da primeira pessoa: \n");
    printf("Nome: ");
   // ler_texto(nome1, 50);
    gets(nome1);
    printf("Idade: ");
    scanf("%d", &idade1);
    limpar_entrada();

    printf("Dados da segunda pessoa: \n");
    printf("Nome: ");
    fseek(stdin, 0, SEEK_END);
   // ler_texto(nome2, 50);
    gets(nome2);
    printf("Idade: ");
    scanf("%d", &idade2);
  //  limpar_entrada();

    mediaIdade = (double)(idade1 + idade2) / 2;

    printf("A idade media de %s e %s eh de %.1lf anos", nome1, nome2, mediaIdade);


    return 0;
}
