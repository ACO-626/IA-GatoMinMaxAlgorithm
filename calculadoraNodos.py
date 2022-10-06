import math

t = int(input("En qué turno se encuentra [1,9] donde 1 es el primero \n"))
print('El número de posibles desenlaces a partir de este turno es de: ', math.factorial(10-t))

turnA = int(input("Matrices a generar desde turno: \n"))
profundidad = int(input("Indique la profundidad: \n"))

if(profundidad>0):
    sum =int(0)
    for i in range(profundidad):
        sum += (math.factorial(10-turnA))/(math.factorial(9-turnA-i))
    print(sum)

