import math

base: float
altura: float
area: float
perimetro: float
diagonal: float

base = float(input("Base do retangulo: "))
altura = float(input("Altura do retangulo: "))

area = base * altura
perimetro = 2 * (base + altura)
diagonal = math.sqrt(base ** 2 + altura ** 2)

print(f"AREA = {area:.4f}")
print(f"PERIMENTRO = {perimetro:.4f}")
print(f"DIAGONAL = {diagonal:.4f}")

