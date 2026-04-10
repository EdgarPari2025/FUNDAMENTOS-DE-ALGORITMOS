
precio = float(input("Ingrese el precio del producto: "))
cantidad = int(input("Ingrese la cantidad de productos: "))

sub_total = precio * cantidad
igv = sub_total * 0.18
total = sub_total + igv

print(f"El sub total es: {sub_total}")
print(f"El IGV es: {igv}")
print(f"El total a pagar es: {total}")











