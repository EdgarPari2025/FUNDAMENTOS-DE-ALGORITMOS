
peso = float(input("Ingrese su peso en kg: "))
altura = float(input("Ingrese su altura en metros: "))

imc = peso / (altura ** 2)

print("Su indice de masa corporal es:", imc)

if imc < 18.5:
    print("Usted tiene bajo peso")

elif imc < 25:
    print("Usted tiene un peso normal")
elif imc < 30:
    print("Usted tiene sobrepeso")
else:
    print("Usted tiene obesidad")
















