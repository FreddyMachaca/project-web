using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos1
{
    public class Conexionsql
    {
        static string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        
        public int consultalogin(string usuario, string contraseña)
        {
            int count;
            conexion.Open();
            string query = "Select Count(*) from Empleados where usuario='" + usuario +"'and contraseña='" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public DataTable consultaUsuarioDG()
        {
            string query = "select * from Empleados";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable consultaTela()
        {
            string query = "select * from Tela";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable consultaHilo()
        {
            string query = "select * from Hilo";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable consultaCargo()
        {
            string query = "select * from Cargo";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable consultaEHT()
        {
            string query = "select * from empleado_hilo_tela";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable consultaFactura()
        {
            string query = "select * from Factura";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public int insertEmpleado(string nombre_empleado,string apellido_empleado,string fechaNaci_empleado, int CI_empleado, string Dir_empleado, int FK_id_cargo, string usuario, string contraseña)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Empleados(nombre_empleado,apellido_empleado,fechaNaci_empleado,CI_empleado,Dir_empleado,FK_id_cargo,usuario,contraseña) values ('" + nombre_empleado + "','" + apellido_empleado + "','" + fechaNaci_empleado + "','" + CI_empleado + "','" + Dir_empleado + "','" + FK_id_cargo + "','" + usuario + "','" + contraseña + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int insertTela(string tipo_tela,string color_tela,double tamaño_tela,double precio_tela)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Tela(tipo_tela,color_tela,tamaño_tela,precio_tela) values ('" + tipo_tela + "','" + color_tela + "','" + tamaño_tela + "','" + precio_tela + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int insertHilo(string tipo_hilo,string Color_hilo)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Hilo(tipo_hilo,Color_hilo) values ('" + tipo_hilo + "','" + Color_hilo + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int insertCargo(string nombre_cargo,string hora_entrada,string hora_salida)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Cargo(nombre_cargo,hora_entrada,hora_salida) values ('" +nombre_cargo+ "','" +hora_entrada+"','"+hora_salida+"')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int insertEHT(int FK_id_hilo,int FK_id_tela,int FK_id_empleado)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into empleado_hilo_tela(FK_id_hilo,FK_id_tela,FK_id_empleado) values ('" + FK_id_hilo + "','" + FK_id_tela + "','" + FK_id_empleado + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int insertFactura(int FK_id_tela,int FK_id_cliente,int FK_id_empleado,string fecha_entrega,int precio_total)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Factura(FK_id_tela,FK_id_cliente,FK_id_empleado,fecha_entrega,precio_total) values ('" + FK_id_tela + "','" + FK_id_cliente + "','" + FK_id_empleado + "','"+fecha_entrega+"','"+precio_total+"')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarEmpleado(int id_empleado,string nombre_empleado, string apellido_empleado, string fechaNaci_empleado, int CI_empleado, string Dir_empleado, int FK_id_cargo, string usuario, string contraseña)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Empleados set nombre_empleado='" + nombre_empleado + "',apellido_empleado='" + apellido_empleado + "',fechaNaci_empleado='" + fechaNaci_empleado + "',CI_empleado='" + CI_empleado + "',Dir_empleado='" + Dir_empleado + "',FK_id_cargo='" + FK_id_cargo + "',usuario='" + usuario + "',contraseña='" + contraseña + "' where id_empleado='"+id_empleado+"'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarTela(int id_tela,string tipo_tela,string color_tela,double tamaño_tela,double precio_tela)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Tela set tipo_tela='" + tipo_tela + "',color_tela='" + color_tela + "',tamaño_tela=" + tamaño_tela + ",precio_tela=" + precio_tela + " where id_tela='" + id_tela + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarHilo(int id_hilo,string tipo_hilo,string Color_hilo)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Hilo set tipo_hilo='" + tipo_hilo + "',color_hilo='" + Color_hilo + "' where id_hilo='" + id_hilo + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarCargo(int id_cargo,string nombre_cargo,string hora_entrada,string hora_salida)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Cargo set nombre_cargo='" +nombre_cargo+ "',hora_entrada='" +hora_entrada+ "',hora_salida='"+hora_salida+"' where id_cargo='" + id_cargo + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarEHT(int id_eht,int FK_id_hilo, int FK_id_tela, int FK_id_empleado)
        {
            int flag = 0;
            conexion.Open();
            string query = "update empleado_hilo_tela set FK_id_hilo='" + FK_id_hilo + "',FK_id_tela='" + FK_id_tela + "',FK_id_empleado='" + FK_id_empleado + "' where id_eht='" + id_eht + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificarFactura(int id_factura,int FK_id_tela, int FK_id_cliente, int FK_id_empleado, string fecha_entrega, int precio_total)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Factura set FK_id_tela='" +FK_id_tela+ "',FK_id_cliente='" + FK_id_cliente + "',FK_id_empleado='" + FK_id_empleado + "',fecha_entrega='"+fecha_entrega+"',precio_total='"+precio_total+"' where id_factura='" + id_factura + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarEmpleado(int id_empleado)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Empleados where id_empleado='" + id_empleado + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarTela(int id_tela)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Tela where id_tela='" + id_tela + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarHilo(int id_hilo)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Hilo where id_hilo='" + id_hilo + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarCargo(int id_cargo)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Cargo where id_cargo='" + id_cargo + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarEHT(int id_eht)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from empleado_hilo_tela where id_eht='" + id_eht + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int EliminarFactura(int id_factura)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Factura where id_factura='" + id_factura + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
    }
}
