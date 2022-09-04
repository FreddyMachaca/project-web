package campeonatogit.carreras;

public class MainJugador {
    public static void main(String[] args) {
        Jugador j1 = new Jugador("Joel","condori tumiri",489513, 30);
        j1.mostrarJugador();
        j1.setEdad(25);
        j1.mostrarJugador();
        j1.getNombre();

    }
}
