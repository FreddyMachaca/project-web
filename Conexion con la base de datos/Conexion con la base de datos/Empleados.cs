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
    public partial class Empleados : Form
    {
        conexioonsqlN cn = new conexioonsqlN();
        public Empleados()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.insertEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text), textBox7.Text, textBox8.Text);
            dataGridView1.DataSource = cn.consultaDT();
            MessageBox.Show("Se registro correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarEmpleado(Convert.ToInt32(textBox9.Text));
            dataGridView1.DataSource = cn.consultaDT();
            MessageBox.Show("Se elimino correctamente");
            textBox9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.modificarEmpleado(Convert.ToInt32(textBox9.Text),textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text), textBox7.Text, textBox8.Text);
            dataGridView1.DataSource = cn.consultaDT();
            MessageBox.Show("Se elimino correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DatosClientes = new Form1();
            DatosClientes.Show();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
            ValidarLetras.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras.SoloLetras(e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text=="")
            {
                MessageBox.Show("Introduzca datos en Apellido y CI");
            }
            else
            {
                string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
                SqlConnection conexion = new SqlConnection(conexionstring);
                string query = "select * from Empleados where apellido_empleado='" + textBox2.Text + "' or CI_empleado='"+Convert.ToInt32(textBox4.Text)+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox2.Text = "";
            textBox4.Text = "";

        }
    }
}
