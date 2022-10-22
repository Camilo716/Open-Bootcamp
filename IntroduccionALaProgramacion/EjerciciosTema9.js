//Realicé el ejercicio en JavaScript ya que en este momento no cuento los recursos necesarios para tener un entorno de trabajo JAVA

/*
Crea una clase Persona con las siguientes variables:

    -La edad
    -El nombre
    -El teléfono

Una vez creada la clase, crea una nueva clase Cliente que herede de Persona, esta nueva clase tendrá la variable credito solo para esa clase.
Crea ahora un objeto de la clase Cliente que debe tener como propiedades la edad, el telefono, el nombre y el credito, tienes que darles valor
y mostrarlas por pantalla. Una vez hecho esto, haz lo mismo con la clase Trabajador que herede de Persona, y con una variable salario que solo 
tenga la clase Trabajador.
*/

class Persona{
    constructor(edad, nombre, telefono){
        this.edad=edad;
        this.nombre=nombre;
        this.telefono=telefono;
    }
}

class Cliente extends Persona{
    constructor(edad,nombre, telefono, credito){ 
        super(edad, nombre, telefono);
        this.credito=credito;
    }
}

class Trabajador extends Persona{
    constructor(edad, nombre, telefono, salario){
        super(edad, nombre, telefono);
        this.salario=salario;
    }
}

const objeto= new Cliente(16,"Camilo", 4654621, 846216 );
console.log(objeto);

const trabajador1 = new Trabajador(26, "Juan", 54543216 ,1500000);
console.log(trabajador1);

