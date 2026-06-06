import math
x1 = float(input("Ingrese el valor de x1: "))
x2 = float(input("Ingrese el valor de x2: "))
y1 = float(input("Ingrese el valor de y1: "))
y2 = float(input("Ingrese el valor de y2: "))

dx = x1 - x2
dy = y1 - y2

distancia = math.sqrt(dx**2 + dy**2)

print(f"La distancia entre los puntos es: {distancia:.2f}")



