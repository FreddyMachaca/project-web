package campeonatogit.Vehiculo;

public class Vehiculos {

    private String nombre;
    private String color;
    private int placa;
    private int chasis;

    //constructor con  todos los parametros
    public Vehiculos(String nombre,String color, int placa, int chasis){
        this.nombre=nombre;
        this.color=color;
        this.placa=placa;
        this.chasis=chasis;
    }
    //constructor con dos parametris
    public Vehiculos (String nombre,String color){  //  (String nombnre,String apellid, String cumpleañs,)=4 parametros
        this.nombre=nombre;
        this.color=color;
    }
    //constructor sin parametros
    public Vehiculos() {
        this.nombre="";
        this.color="";
        this.placa=0;
        this.chasis=0;
    }
    //get - obtener
    //set - establecer

    //metodos = instrucciones
    public String getNombre(){
        return nombre;
    }

    public String getColor(){
        return this.color;
    }

    public int getPlaca(){
        return this.placa;              //PARAMETROS SIRVE PARA INGRESAR DATOS ()
    }
    public int getchasis(){
        return this.chasis;
    }
        // set-establecer
    public void setNombre(String nuevoNombre){
        this.nombre=nuevoNombre;
    }
    public void setColor (String nuevoColor){
        this.color=nuevoColor;
    }
    public void setPlaca(int nuevaPlaca){
        this.placa=nuevaPlaca;
    }
    public void setChasis(int nuevaChasis){
        this.placa=nuevaChasis;
    }

    public void frenar(){
        System.out.println("Estoy frenando");
    }

    //metodo mostrar
    public void mostrarVehiculo(){
        System.out.println("-----------------Datos del vehiculo----------------");
        System.out.println("Nombre del vehiculo: "+this.getNombre());
        System.out.println("color del vehiculo: "+this.getColor());
        System.out.println("placa: "+this.getPlaca());
        System.out.println("chasis: "+this.getchasis());
    }




}
