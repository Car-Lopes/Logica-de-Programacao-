print("Matrizes(Lista)")
print()

m: int; n: int

m = int(input("quantas linhas vai ter a matriz? "))
n = int(input("quantas colunas vai ter a matriz? "))

matriz: [[int]] = [[0 for x in range(n)] for x in range(m)]

for i in range (0,m):
    for j in range(0,n):
        matriz[i][j] = int(input(f"Elemento [{i},{j}]: "))


print()
print("Matriz Digitada:")
for i in range(0,m):
    for j in range(0,n):
        print(f"{matriz[i][j]} ", end=" ")
    print()