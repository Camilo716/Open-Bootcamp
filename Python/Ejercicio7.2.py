import time


def main():

    def horaDeIrACasa():
        date = time.localtime(time.time())

        if date.tm_hour >= 19:
            return 'Es tiempo de ir a casa'
        else:
            return 19 - date.tm_hour

    print(horaDeIrACasa())


if __name__ == '__main__':
    main()
