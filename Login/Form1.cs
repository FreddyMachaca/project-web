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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login() 
        {
            SqlConnection conexao = new SqlConnection("server =DESKTOP-75N8191; database = login1; integrated security = true");
            conexao.Open();
            SqlCommand consulta = new SqlCommand("select Nombre_Usuario,Contrasena from usuarios where Nombre_Usuario='" + txtUsuario.Text + "' and contrasena='"+txtContrasena.Text+"'",conexao);
            SqlDataReader lectura = consulta.ExecuteReader();
            if (lectura.Read())
            {
                MessageBox.Show("Sea Bienvenido, Login exitoso","sistema");
                
                this.Hide();
                Form2 v1 = new Form2();
                v1.Show();
            }
            else
            {
                MessageBox.Show("Login incorrecto","sistema");

            }
        }
    }
}
