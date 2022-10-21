//Realicé el ejercicio en JavaScript ya que en este momento no cuento los recursos necesarios para tener un entorno de trabajo JAVA


/* 
- Crear clase Persona.
- Crear variables las privadas edad, nombre y telefono de la clase Persona.
- Crear gets y sets de cada propiedad.
- Crear un objeto persona en el main.
- Utiliza los gets y sets para darle valores a las propiedades edad, nombre y telefono, por último muéstralas por consola.
*/

class Persona{
    constructor(edad, nombre, telefono){
        this.edad=edad               // JavaSript no cuenta con modificadores de visibilidad, aún asi se puede aplicar
        this.nombre=nombre           // el concepto de encapsulación
        this.telefono= telefono     
    }

    setEdad(edad) {
        this.edad=edad
    }
    getEdad(){
        return this.edad
    }

    setNombre(nombre){
        this.nombre=nombre
    }
    getNombre(){
        return this.nombre
    }

    setTelefono(telefono){
        this.telefono=telefono
    }

    getTelefono(){
        return this.telefono
    }
}

const miPersona = new Persona();

miPersona.setEdad(16)
console.log(miPersona.getEdad())

miPersona.setNombre("Camilo")
console.log(miPersona.getNombre())

miPersona.setTelefono(3193297571)
console.log(miPersona.getTelefono())