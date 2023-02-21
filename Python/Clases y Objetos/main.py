class auto:
    encendido = False

    def enciende(self):
        self.encendido = True

    def apaga(self):
        self.encendido = False

    def isEncendido(self):
        return self.encendido

d = auto()
d.apaga()
print(d.encendido)