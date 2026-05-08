
print("===MENU DE OPERACIONES===")
print("1. Calcular el area de un circulo")
print("2. Calcular el area de un cuadrado")
print("3. Calcular el area de un triangulo")
print("4. Salir")
print("Seleccione una opcion del 1 al 4")

opcion = int(input("Ingrese su opcion: "))

match (opcion):
    case 1:
        print("El area de un circulo es pi * r²")
        
    case 2:
        print("El area de un cuadrado es lado²")
        
    case 3:
        print("El area de un triangulo es base * altura / 2")
        
    case 4:
        print("Salir del programa...")
        
    case _:
        print("Seleccione una opcion del 1 al 4")
        










