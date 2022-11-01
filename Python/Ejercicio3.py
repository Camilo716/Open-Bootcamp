#Escribe un programa en la consola de python que pida al usuario su peso (en kg) y estatura (en metros),
#calcule el índice de masa corporal y lo almacene en una variable, e imprima por pantalla la frase
#Tu índice de masa corporal es donde es el índice de masa corporal calculado redondeado con dos decimales. 
# Tienes que subir capturas de pantalla en una carpeta comprimida zip.


def indiceDeMasa(pesoEnKg, estaturaEnM):
    IndiceDeMC= round(pesoEnKg/estaturaEnM**2,2)

    print('Tu índice de masa corporal es: ' + str(IndiceDeMC))

indiceDeMasa(70, 1.75)