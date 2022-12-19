using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Conexion_con_la_base_de_datos
{
    public partial class Form1 : Form
    {
        static string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexion a la base de datos " + conexion.Database + " ha sido exitosa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Se desconecto correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(textBox2.Text=="")
            {
                string query = "select * from Clientes";
                SqlCommand comando = new SqlCommand(query,conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else
            {
                string query = "select * from Clientes where Nombre='"+textBox2.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox2.Text = "";
            
        }
        public void consulta()
        {
            if (textBox3.Text=="" || textBox4.Text=="")
            {
                MessageBox.Show("Indroduzca datos en apellido y CI");
            }
            else
            {
                string query = "select * from Clientes where apellido_cliente='" + textBox3.Text + "' OR CI_cliente='" + Convert.ToInt32(textBox4.Text) + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
        public void consultatodo()
        {
            string query = "select * from Clientes";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            string cadena = "insert into Clientes(nombre_cliente, apellido_cliente, CI_cliente, Dir_cliente) values('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("El cliente " + textBox2.Text + " se registrocorrectamente");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        
            consultatodo();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int flag = 0;
            string cadena = "Delete Clientes where CI_cliente='"+textBox4.Text+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag=comando.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBox.Show("Se elimino correctamente el registro");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro");
            }
            consultatodo();
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int flag = 0;
            string cadena = "Update Clientes set nombre_cliente='"+textBox2.Text+"',apellido_cliente='"+textBox3.Text+ "',CI_cliente='" + textBox4.Text + "',Dir_cliente='" + textBox5.Text+"' where CI_cliente='"+textBox6.Text+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Se modifico correctamente el registro");
            }
            else
            {
                MessageBox.Show("No se pudo modificar el registro");
            }
            consultatodo();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados v1 = new Empleados();
            this.Hide();
            v1.ShowDialog();
            
        }

        private void telaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela v2 = new Tela();
            this.Hide();
            v2.ShowDialog();
        }

        private void hiloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hilo v3 = new Hilo();
            this.Hide();
            v3.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo v4 = new Cargo();
            this.Hide();
            v4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            consulta();
            
        }

        private void relacionHiloTelaYEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado_hilo_tela v5 = new Empleado_hilo_tela();
            this.Hide();
            v5.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
            Form2 n = new Form2();
            n.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Indroduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Indroduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura v6 = new Factura();
            this.Hide();
            v6.ShowDialog();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras.SoloLetras(e);
        }
    }
}
