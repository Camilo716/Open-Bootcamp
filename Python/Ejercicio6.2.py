# Crear un programa que tenga una clase llamada Alumno
# que tenga como atributos su nombre y su nota. Deberéis de definir los métodos para inicializar sus atributos,
# imprimirlos y mostrar un mensaje con el resultado de la nota y si ha aprobado o no.

class Alumno:
    def __init__(self, nombre, nota):
        self.nombre = nombre
        self.nota = nota


def aprobado(nombre, nota):
    miAlumno = Alumno(nombre, nota)
    
    if nota > 5.0 or nota < 0.1:
        return 'Por favor ingrese una nota valida (0.1 - 5.0)'

    if miAlumno.nota >= 3.5:
        return nombre + ' ha aprobado con una nota de: ' + str(nota)
    
    else:
        return nombre + ' no ha aprobado con una nota de: ' + str(nota)


print(aprobado(nombre='Juan', nota=3.5))
