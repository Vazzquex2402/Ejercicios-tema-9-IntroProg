import os

# Crear archivo txt y escribir dentro
archivo = open("./text.txt", "w")
archivo.write("Hello world desde python")
archivo.close()

# Abrir archivo y añadir más texto
archivo = open("./text2.txt", "a")
archivo.write("Hello World 2 desde python")
archivo.close()