a: int
b: int

print("Digite dois numeros: ")
a = int(input())
b = int(input())

while a != b:
    if a < b:
        print("Crescente")
    else:
        print("Decrescente")

    print("Digite outros dois numeros: ")
    a = int(input())
    b = int(input())