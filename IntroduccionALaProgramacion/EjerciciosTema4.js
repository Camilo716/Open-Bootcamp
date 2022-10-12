//Realicé el ejercicio en JavaScript ya que en este momento no cuento los recursos necesarios para tener un entorno de trabajo JAVA

//1.Usando un if, crear una condición que compare si la variable numeroIf es positivo, negativo, o 0.

    let numeroIf= null //Coloque aquí su número

    if (numeroIf>0) {
        console.log("Su número es positivo")
    } else if (numeroIf<0) {
        console.log("Su número es negativo")
    } else if(numeroIf===0){
        console.log("Su número es 0")
    } else{
        console.log("Por favor ingrese un número")
    }


/*2.Crea un bucle While, este bucle tendrá que tener como condición que la variable numeroWhile sea inferior a 3, el bloque de código que tendrá el bucle deberá:
    - Incrementar el valor de la variable en uno cada vez que se ejecute.
    - Mostrarlo por pantalla cada vez que se ejecute. */

    var numeroWhile = 2 //Coloque aquí su número

    while (numeroWhile<3) {
        numeroWhile= numeroWhile + 1
        console.log(numeroWhile);
    }

//Para el bucle Do While, deberás crear la misma estructura que en el While, pero solo se debe ejecutar una vez.

    var numeroDoWhile= 5

    do {
        numeroDoWhile= numeroDoWhile+1
        console.log(numeroDoWhile)
        
    } while (numeroDoWhile<3)

/*Para el bucle For, crea una variable numeroFor, esta variable tendrá como valor 0 y su condición será que la variable sea igual o menor que 3,
 se irá incrementando en 1 su valor cada vez que se ejecute y deberá mostrarse por pantalla.*/

    for (let numeroFor = 0; numeroFor <=3; numeroFor++) {
        console.log(numeroFor)
    }

/*Por último, para el Switch, deberás crear la variable estacion, y distintos case para las cuatro estaciones del año. 
Dependiendo del valor de la variable estacion se deberá mandar un mensaje por consola informando de la estación en la que está.
También habrá que poner un default para cuando el valor de la variable no sea una estación.*/

    var estacion= "primavera" //Coloque aquí la estación del año (primavera, verano, otoño, invierno)

    switch (estacion) {
        case "primavera":
            console.log("Estamos en primavera")
            break;

        case "verano":
            console.log("Estamos en verano")
            break;
    
        case "otoño":
            console.log("Estamos en otoño")
            break;

        case "invierno":
            console.log("Estamos en invierno")
            break;
        
        default:
            "Ingrese una estación válida"
            break;
    }