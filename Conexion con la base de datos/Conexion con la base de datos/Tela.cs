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
    public partial class Tela : Form
    {
        conexioonsqlN cn = new conexioonsqlN();
        public Tela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.insertTela(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            dataGridView1.DataSource = cn.consultaTela();
            MessageBox.Show("Se registro correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DatosClientes = new Form1();
            DatosClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarTela(Convert.ToInt32(textBox5.Text));
            dataGridView1.DataSource = cn.consultaTela();
            MessageBox.Show("Se elimino correctamente");
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.modificarTela(Convert.ToInt32(textBox5.Text), textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            dataGridView1.DataSource = cn.consultaTela();
            MessageBox.Show("Se modifico correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultaTela();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.validarCampoDecimal((TextBox)sender);
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            Funciones.validarCampoDecimal((TextBox)sender);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Indroduzca solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (textBox1.Text == "" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Introduzca datos en Tipo, color y tamaño de tela");
            }
            else
            {
                string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
                SqlConnection conexion = new SqlConnection(conexionstring);
                string query = "select * from Tela where tipo_tela='" + textBox1.Text + "' or color_tela='"+textBox2.Text+"' or tamaño_tela='"+textBox3.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
