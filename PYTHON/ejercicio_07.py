p1 = float(input("Ingrese la nota de la práctica 1 (nota de 0 a 20): "))
p2 = float(input("Ingrese la nota de la práctica 2 (nota de 0 a 20): "))
p3 = float(input("Ingrese la nota de la práctica 3 (nota de 0 a 20): "))
examen_parcial = float(input("Ingrese la nota del examen parcial (nota de 0 a 20): "))
examen_final = float(input("Ingrese la nota del examen final (nota de 0 a 20): "))

if p1 < 0 or p1 > 20 or p2 < 0 or p2 > 20 or p3 < 0 or p3 > 20 or examen_final < 0 or examen_final > 20 or examen_parcial < 0 or examen_parcial > 20:
    print("Nota no válida. Por favor, ingrese notas entre 0 y 20.")
else:
    promedio_practicas = (p1 + p2 + p3 - min(p1, p2, p3)) / 2
    promedio_final = (examen_final + examen_parcial + promedio_practicas) / 3

    if promedio_final >= 18:
        print("El estudiante es EXCELENTE.")
    elif promedio_final >= 14:
        print("El estudiante es BUENO.")
    elif promedio_final >= 10:
        print("El estudiante es REGULAR.")
    else:
        print("El estudiante es DEFICIENTE.")


























