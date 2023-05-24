public class Main {
    public static void main(String[] args) {

        int numeroif = -68;
        int numeroWhile = 0;
        String estacion = "VERANO";

        if (numeroif < 0){
            System.out.println("El número es negativo");
        }
        else{System.out.println("El número es positivo");};

        while (numeroWhile < 3) {
            numeroWhile++;
            System.out.println("El valor de numeroWhile es: " + numeroWhile);
        }

        do {
            numeroWhile++;
            System.out.println("El valor de numero es: " + numeroWhile);
        } while (numeroWhile < 3);

        switch (estacion){
            case "VERANO":
                System.out.println("Es verano");
                break;
            case "INVIERNO":
                System.out.println("Es verano");
                break;
            case "OTOÑO":
                System.out.println("Es verano");
                break;
            case "PRIMAVERA":
                System.out.println("Es verano");
                break;

            default:
                System.out.println("El dato ingresado no es una estación");
        }



    }
}
