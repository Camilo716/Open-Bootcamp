//Realicé el ejercicio en JavaScript ya que en este momento no cuento los recursos necesarios para tener un entorno de trabajo JAVA


/*Primera parte:
Crear una función con tres parámetros que sean números que se suman entre sí.
Llamar a la función en el main y darle valores.
*/

function suma(a, b, c) {
    return a+b+c
}

suma(10,20,6)


/*Segunda parte:
Crear una clase coche.
Dentro de la clase coche, una variable numérica que almacene el número de puertas que tiene.
Una función que incremente el número de puertas que tiene el coche.
Crear un objeto miCoche en el main y añadirle una puerta.
Mostrar el número de puertas que tiene el objeto.
*/


class Coche{
    constructor(numeroDePuertas){
        this.numeroDePuertas=numeroDePuertas
    }
}

Coche.prototype.incrementarPuertas= function() {
    this.numeroDePuertas= this.numeroDePuertas+1
}

const miCoche= new Coche(2)

miCoche.incrementarPuertas()

console.log(miCoche.numeroDePuertas)