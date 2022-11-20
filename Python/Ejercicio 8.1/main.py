# En este ejercicio, tendréis que crear un archivo py donde creéis un archivo txt, lo abráis y escribáis dentro del
# archivo. Para ello, tendréis que acceder dos veces al archivo creado.
import pickle
modify = open('archivo.txt', 'w')
modify.writelines('Este es el mensaje de mi fichero')

modify.close()


