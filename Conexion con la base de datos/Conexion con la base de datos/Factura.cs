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
    public partial class Factura : Form
    {
        conexioonsqlN cn = new conexioonsqlN();
        public Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.insertFactura(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text),textBox4.Text,Convert.ToInt32(textBox5.Text));
            dataGridView1.DataSource = cn.consultaFactura();
            MessageBox.Show("Se registro correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.modificarFactura(Convert.ToInt32(textBox6.Text),Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
            dataGridView1.DataSource = cn.consultaFactura();
            MessageBox.Show("Se modifico correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarFactura(Convert.ToInt32(textBox6.Text));
            dataGridView1.DataSource = cn.consultaFactura();
            MessageBox.Show("Se elimino correctamente");
            textBox6.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultaFactura();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DatosClientes = new Form1();
            DatosClientes.Show();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("debe ingresar solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("debe ingresar solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("debe ingresar solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("debe ingresar solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("debe ingresar solo numeros", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="")
            {
                MessageBox.Show("Introduzca datos en id tela, id cliente, id Empleado y fecha de entrega");
            }
            else
            {
                string conexionstring = "server=DESKTOP-MO1VV97; database=Textileria; integrated security=true";
                SqlConnection conexion = new SqlConnection(conexionstring);
                string query = "select * from Factura where FK_id_tela='" + textBox1.Text + "' or FK_id_cliente='"+textBox2.Text+"' or FK_id_empleado='"+textBox3.Text+"' or fecha_entrega='"+textBox4.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
