
import math as Math
monto = float(input("Ingrese el monto original: "))

hacia_arriba = Math.ceil(monto)
hacia_abajo = Math.floor(monto)
truncado = Math.trunc(monto)
redondeado = round(monto, 2)

print(f"Monto original: {monto}")
print(f"Hacia arriba: {hacia_arriba}")
print(f"Hacia abajo: {hacia_abajo}")
print(f"Truncado: {truncado}")
print(f"Redondeado a 2 decimales: {redondeado}")














