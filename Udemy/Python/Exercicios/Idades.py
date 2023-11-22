import math

idade: int

print("Dados da primeira pessoa: ")
nome = input("Nome: ")
idade = int(input("Idade: "))

print()
print("Dados da segunda pessoa: ")
nome1 = input("Nome: ")
idade1 = int(input("Idade: "))

media = (idade + idade1) / 2

print()
print(f"A idade media de {nome} e {nome1} é de {media:.1f} anos")