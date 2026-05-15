
cargo_fijo = 5

kwhora = float(input("Ingrese el número de kWh por hora: "))

sub_total = cargo_fijo + kwhora * 0.55
igv = sub_total * 0.18
total = sub_total + igv

print(f"El sub total es: {sub_total:.2f}")
print(f"El IGV es: {igv:.2f}")
print(f"El total es: {total:.2f}")










