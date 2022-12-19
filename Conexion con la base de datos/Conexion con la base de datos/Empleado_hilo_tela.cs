using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using System.Data.SqlClient;

namespace Conexion_con_la_base_de_datos
{
    public partial class Empleado_hilo_tela : Form
    {
        conexioonsqlN cn = new conexioonsqlN();
        public Empleado_hilo_tela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.insertEHT(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cn.consultaEHT();
            MessageBox.Show("Se registro correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarEHT(Convert.ToInt32(textBox4.Text));
            dataGridView1.DataSource = cn.consultaEHT();
            MessageBox.Show("Se elimino correctamente");
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.modificarEHT(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cn.consultaEHT();
            MessageBox.Show("Se modifico correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultaEHT();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DatosClientes = new Form1();
            DatosClientes.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Introduzca datos en id Empleado");
            }
            else
            {
                string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
                SqlConnection conexion = new SqlConnection(conexionstring);
                string query = "select * from empleado_hilo_tela where FK_id_empleado='" + Convert.ToInt32(textBox3.Text) + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox3.Text = "";
        }
    }
}
