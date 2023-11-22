print("Ola mundo!")
print()

idade: int
salario: float
altura: float
genero: str
nome: str

idade = 20
salario = 5800.5
altura = 1.63
genero = 'F'
nome = "Maria Silva"

print(f"Idade = {idade}")
print(f"Salario = {salario:.2f}")
print(f"Altura = {altura:.2f}")
print(f"Genero = {genero}")
print(f"Nome = {nome}")

print()
print(f"A Funcionaria {nome}, sexo {genero}, ganha {salario:.2f} e tem {idade} anos")
print()
print("A funcionaria {:s}, sexo {:s}, ganha {:.2f} e tem {:d} anos".format(nome, genero, salario, idade))


print()
print()
print("Entrada de dados")

salario1: float; salario2: float
nome1: str; nome2: str
idade: int
sexo: str

nome1 = input("Nome da primeira pessoa: ")
salario1 = float(input("Salario da 1° Pessoa: "))

print()
nome2 = input("Nome da segunda pessoa: ")
salario2 = float(input("Salario da 2° Pessoa: "))

idade = int(input("Digite uma idade: "))
sexo = input("Digite um sexo (F/M): ")

print()
print(f"Nome : {nome1} , Salario: {salario1:.2f}")
print(f"Nome : {nome2} , Salario: {salario2:.2f}")
print(f"Idade: {idade}")
print(f"Sexo: {sexo}")

print()



