package campeonatogit.carreras;

public class Jugador {
    private String nombre;
    private String apellido;
    private int ci;
    private int edad;


    //constructor con  todos los parametros
    public Jugador(String nombre, String apellido, int ci, int edad) {

        this.nombre = nombre;
        this.apellido = apellido;
        this.ci = ci;
        this.edad = edad;
    }

    //get
    public String getNombre() {
        return this.nombre;
    }

    public String getApellido() {
        return this.apellido;
    }

    public int getCi() {
        return this.ci;
    }

    public int getEdad() {
        return this.edad;
    }

    //set
    public void setNombre(String nuevoNombre) {
        this.nombre = nuevoNombre;
    }

    public void setApellido(String nuevoApellido) {
        this.apellido = nuevoApellido;
    }

    public void setci(int NuevoCi) {
        this.ci = NuevoCi;
    }

    public void setEdad(int Nuevaedad){
        this.edad = Nuevaedad;
    }
    //mostrar jugador
    public void mostrarJugador(){
        System.out.println("--------------MOSTRAR DATOS DEL JUGADOR-------------------");
        System.out.println("Nombre del jugador: "+this.getNombre());
        System.out.println("Apellido del jugador:"+this.getApellido());
        System.out.println("Ci: "+this.getCi());
        System.out.println("Edad del jugador: "+this.getEdad());
    }

}
