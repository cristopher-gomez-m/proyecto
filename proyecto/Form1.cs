using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botonPrestamo.Enabled = false;
        }

        private void validarTexto()
        {
            Regex name = new Regex(@"[A-Za-zÑñÁáÉéÍíÓóÚúÜü\s]+$");
            String nombre = nombreUsuario.Text.Trim();
            Boolean ok = name.IsMatch(nombre); 
            Console.WriteLine("Valgo: " + nombre);
            if(nombre == string.Empty)
            {
                botonPrestamo.Enabled = false;
                errorProvider1.SetError(nombreUsuario, "Debe introducir un nombre");
            }
            else if (!ok)
            {
                errorProvider1.SetError(nombreUsuario, "Solo se acepta letras y espacios en blanco");
            }
            else if(ok)
            {
                Console.WriteLine("LLegue ");
                errorProvider1.SetError(nombreUsuario,"");
                botonPrestamo.Enabled = true;
            }
        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            validarTexto();
        }
    }
}
