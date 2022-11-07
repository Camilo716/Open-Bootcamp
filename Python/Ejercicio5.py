def bisiesto(year):
    esBis = str(year) + ' es año bisiesto'
    noEsBis = str(year) + ' no es año bisiesto'

    if year % 4 == 0:
        if year % 100 == 0:
            if year % 400 == 0:
                return esBis
            else:
                return noEsBis
        else:
            return esBis
    else:
        return noEsBis


print(bisiesto(1800))
