using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_con_la_base_de_datos
{
    public class Funciones
    {
        public static bool validarCampoDecimal(TextBox CajaDeTexto)
        {
            try
            {
                double d = Convert.ToDouble(CajaDeTexto.Text);
                return true;
            }
            catch(Exception ex)
            {
                CajaDeTexto.Text = "0";
                CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
                return false;
            }
        }

    }
}
