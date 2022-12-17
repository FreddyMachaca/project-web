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

namespace Conexion_con_la_base_de_datos
{
    public partial class Form2 : Form
    {
        conexioonsqlN cn = new conexioonsqlN();

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.consql(textBox2.Text, textBox1.Text) == 1)
            {
                MessageBox.Show("El usuario ha sido encontrado");
                this.Hide();
                Form1 DatosClientes=new Form1();
                DatosClientes.Show();
                
            }
            else
            {
                MessageBox.Show("El usuario NO ha sido encontrado");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
