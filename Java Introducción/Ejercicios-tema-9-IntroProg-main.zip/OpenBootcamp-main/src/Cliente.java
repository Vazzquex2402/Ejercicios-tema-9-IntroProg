public class Cliente extends Persona {
    double credito;
    public Cliente(int edad, String nombre, int telefono, double credito) {
        super(edad, nombre, telefono);
        this.credito = credito;
    }
}
