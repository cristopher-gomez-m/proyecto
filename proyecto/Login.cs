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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamo formPrestamo = new Prestamo(nombreUsuario.Text))
                formPrestamo.ShowDialog();
            
        }


        private void validateForm()
        {
            Validator validator = new Validator();
            String nombre = nombreUsuario.Text.Trim();
            if (nombre == string.Empty)
            {
                botonPrestamo.Enabled = false;
                errorProvider1.SetError(nombreUsuario, "Debe introducir un nombre");
            }
            else
            {
                Boolean ok = validator.validarTexto(nombre);
                if (!ok)
                {
                    errorProvider1.SetError(nombreUsuario, "Solo se acepta letras y espacios en blanco");
                }
                else if (ok)
                {
                    Console.WriteLine("LLegue ");
                    errorProvider1.SetError(nombreUsuario, "");
                    botonPrestamo.Enabled = true;

                }
            }
        }
        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            botonPrestamo.Enabled = false;
        }
    }
}
