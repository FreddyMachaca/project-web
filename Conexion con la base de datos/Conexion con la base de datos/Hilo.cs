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
    public partial class Hilo : Form
    {
        conexioonsqlN cn = new conexioonsqlN();
        public Hilo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.insertHilo(textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = cn.conltaHilo();
            MessageBox.Show("Se registro correctamente");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarHilo(Convert.ToInt32(textBox3.Text));
            dataGridView1.DataSource = cn.conltaHilo();
            MessageBox.Show("Se elimino correctamente");
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.modificarHilo(Convert.ToInt32(textBox3.Text), textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = cn.conltaHilo();
            MessageBox.Show("Se modifico correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.conltaHilo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DatosClientes = new Form1();
            DatosClientes.Show();
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
            if (textBox1.Text == "" || textBox2.Text=="")
            {
                MessageBox.Show("Introduzca datos en tipo de hilo y color de hilo");
            }
            else
            {
                string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
                SqlConnection conexion = new SqlConnection(conexionstring);
                string query = "select * from Hilo where tipo_hilo='" + textBox1.Text + "' or Color_hilo='"+textBox2.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
