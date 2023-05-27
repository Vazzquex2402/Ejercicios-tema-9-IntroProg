from pickle import *

class Vehiculo:

    def __init__(self, modelo, color):
        self.modelo = modelo
        self.color = color

    def __str__(self):
        return self.modelo + " " + self.color


auto1 = Vehiculo("ferrari", "rojo")
print(auto1)

file = open('vehiculo_objeto', 'w+b')

dump(auto1, file)

file.seek(0)
nuevo_corsa = load(file)

print(nuevo_corsa)
file.close()