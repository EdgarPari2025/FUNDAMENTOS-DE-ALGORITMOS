
categoria = input("Ingrese la categoría del producto (A, B o C): ").upper()
horas = int(input("Ingrese el número de horas trabajadas: "))
anios = int(input("Ingrese el número de años trabajados: "))

if categoria == "A":
    tarifa = 33.50
elif categoria == "B":
    tarifa = 29.80
elif categoria == "C":
    tarifa = 25.70
else:
    print("Categoría no válida. Por favor, ingrese A, B o C.")
    exit()

if anios <= 3:
    bono = 0
elif anios <= 10:
    bono = 0.10
elif anios <= 17:
    bono = 0.20
else:
    bono = 0.30

sueldo = tarifa * horas * (1 + bono)

print(f"El sueldo total a pagar es: {sueldo:.2f}")



















