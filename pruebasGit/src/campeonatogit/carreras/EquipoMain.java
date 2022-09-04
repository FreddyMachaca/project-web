package campeonatogit.carreras;

public class EquipoMain {
    public static void main(String[] args) {

        Jugador j1 = new Jugador("joel", "condori tumiri", 343434, 23);
        Jugador j2 = new Jugador("henry", "apellido", 34554, 27);

        Jugador[] jugadores12 = new Jugador[2];
        jugadores12[0] = j1;
        jugadores12[1] = j2;


        Equipo eq1 = new Equipo("Bolivar", "varones", jugadores12);
        eq1.mostrarEquipo();
    }
}
