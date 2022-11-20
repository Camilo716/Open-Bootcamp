import pickle
# En este segundo ejercicio, tendréis que crear un archivo py y dentro crearéis una clase Vehículo, haréis un objeto
# de ella, lo guardaréis en un archivo y luego lo cargamos.


def main():
    v1 = Vehicle('Familiar', '2002')

    archivo = open('guardado.txt', 'wb')
    pickle.dump(v1, archivo)
    archivo.close()

    recuperar = open('guardado.txt', 'rb')
    recuperado = pickle.load(recuperar)
    recuperar.close()

    print(recuperado)


class Vehicle:
    def __init__(self, model, year):
        self.model = model
        self.year = year

    def __str__(self):
        return f'I am a vehicle of model {self.model} of the year {self.year}'


if __name__ == '__main__':
    main()
