package campeonatogit.carreras;

public class Equipo {

    private String NombreEquipo;
    private String categoria;
    private Jugador [] jugadores12;

    public Equipo(String NombreEquipo, String categoria, Jugador []jugadores12){
        this.NombreEquipo = NombreEquipo;
        this.categoria = categoria;
        this.jugadores12 = jugadores12;
    }
    //get
    public String getNombreEquipo() {
        return this.NombreEquipo;
    }
    public String getCategoria() {
        return this.categoria;
    }
    public Jugador[] getJugadores12(){
        return this.jugadores12;
    }
    //set

    public void setNombreEquipo(String nuevoNombreEquipo){
        this.NombreEquipo = nuevoNombreEquipo;
    }

    public void setCategoria(String nuevaCategoria) {
        this.categoria = nuevaCategoria;
    }

    public void setjugadores(Jugador [] nuevoJugadores12){
        this.jugadores12=nuevoJugadores12;
    }

    //mostrar
    public void mostrarEquipo(){
        System.out.println("---------------MOSTRAR EQUIPOS-------------------");
        System.out.println("nombre equipo: "+this.getNombreEquipo());
        System.out.println("nombre de la categoria: "+this.getCategoria());


        for(int i=0; i<getJugadores12().length; i++){
            this.getJugadores12()[i].mostrarJugador();
        }
    }
}
