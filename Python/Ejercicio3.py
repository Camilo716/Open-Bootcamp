def indiceDeMasa(pesoEnKg, estaturaEnM):
    IndiceDeMC= round(pesoEnKg/estaturaEnM**2,2)

    print('Tu índice de masa corporal es: ' + str(IndiceDeMC))

indiceDeMasa(70, 1.75)