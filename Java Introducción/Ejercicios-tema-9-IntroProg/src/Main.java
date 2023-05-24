public class Main {
    public static void main(String[] args) {
        Cliente cliente = new Cliente(17, "Santiago", 261123456, 1000.0);

        System.out.println("Edad: " + cliente.edad);
        System.out.println("Nombre: " + cliente.nombre);
        System.out.println("Teléfono: " + cliente.telefono);
        System.out.println("Crédito: " + cliente.credito);
    }
}
