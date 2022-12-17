using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos1;
using System.Data;

namespace Negocios
{
    public class conexioonsqlN
    {
        Conexionsql cn = new Conexionsql();
        public int consql(string user, string pass)
        {

            return cn.consultalogin(user,pass);
        }
        public DataTable consultaDT()
        {
            return cn.consultaUsuarioDG();
        }
        public DataTable consultaTela()
        {
            return cn.consultaTela();
        }
        public DataTable conltaHilo()
        {
            return cn.consultaHilo();
        }
        public DataTable consultaCargo()
        {
            return cn.consultaCargo();
        }
        public DataTable consultaEHT()
        {
            return cn.consultaEHT();
        }
        public DataTable consultaFactura()
        {
            return cn.consultaFactura();
        }
        public int insertEmpleado(string nombre_empleado, string apellido_empleado, string fechaNaci_empleado, int CI_empleado, string Dir_empleado, int FK_id_cargo, string usuario, string contraseña)
        {
            return cn.insertEmpleado(nombre_empleado,apellido_empleado,fechaNaci_empleado,CI_empleado,Dir_empleado,FK_id_cargo,usuario,contraseña);
        }
        public int insertTela(string tipo_tela, string color_tela, double tamaño_tela, double precio_tela)
        {
            return cn.insertTela(tipo_tela,color_tela,tamaño_tela,precio_tela);
        }
        public int insertHilo(string tipo_hilo,string Color_hilo)
        {
            return cn.insertHilo(tipo_hilo, Color_hilo);
        }
        public int insertCargo(string nombre_cargo,string hora_entrada,string hora_salida)
        {
            return cn.insertCargo(nombre_cargo, hora_entrada, hora_salida);
        }
        public int insertEHT(int FK_id_hilo, int FK_id_tela, int FK_id_empleado)
        {
            return cn.insertEHT(FK_id_hilo, FK_id_tela, FK_id_empleado);
        }
        public int insertFactura(int FK_id_tela, int FK_id_cliente, int FK_id_empleado, string fecha_entrega, int precio_total)
        {
            return cn.insertFactura(FK_id_tela,FK_id_cliente,FK_id_empleado,fecha_entrega,precio_total);
        }
        public int modificarEmpleado(int id_empleado, string nombre_empleado, string apellido_empleado, string fechaNaci_empleado, int CI_empleado, string Dir_empleado, int FK_id_cargo, string usuario, string contraseña)
        {
            return cn.modificarEmpleado(id_empleado,nombre_empleado, apellido_empleado, fechaNaci_empleado, CI_empleado, Dir_empleado, FK_id_cargo, usuario, contraseña);
        }
        public int modificarTela(int id_tela, string tipo_tela, string color_tela, double tamaño_tela, double precio_tela)
        {
            return cn.modificarTela(id_tela,tipo_tela,color_tela,tamaño_tela,precio_tela);
        }
        public int modificarHilo(int id_hilo,string tipo_hilo,string Color_hilo)
        {
            return cn.modificarHilo(id_hilo,tipo_hilo,Color_hilo);
        }
        public int modificarCargo(int id_cargo,string nombre_cargo,string hora_entrada,string hora_salida)
        {
            return cn.modificarCargo(id_cargo,nombre_cargo,hora_entrada,hora_salida);
        }
        public int modificarEHT(int id_eht, int FK_id_hilo, int FK_id_tela, int FK_id_empleado)
        {
            return cn.modificarEHT(id_eht,FK_id_hilo,FK_id_tela,FK_id_empleado);
        }
        public int modificarFactura(int id_factura, int FK_id_tela, int FK_id_cliente, int FK_id_empleado, string fecha_entrega, int precio_total)
        {
            return cn.modificarFactura(id_factura,FK_id_tela,FK_id_cliente,FK_id_empleado,fecha_entrega,precio_total);
        }
        public int EliminarEmpleado(int id_empleado)
        {
            return cn.EliminarEmpleado(id_empleado);
        }
        public int EliminarTela(int id_tela)
        {
            return cn.EliminarTela(id_tela);
        }
        public int EliminarHilo(int id_hilo)
        {
            return cn.EliminarHilo(id_hilo);
        }
        public int EliminarCargo(int id_cargo)
        {
            return cn.EliminarCargo(id_cargo);
        }
        public int EliminarEHT(int id_eht)
        {
            return cn.EliminarEHT(id_eht);
        }
        public int EliminarFactura(int id_factura)
        {
            return cn.EliminarFactura(id_factura);
        }
    }
}
