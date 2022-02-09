using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Prestamo : Form
    {
        string nombreCliente;
        int[] cuotasDisponiblesList = { 1, 2, 3, 4, 5 };

        public Prestamo(string nombreCliente)
        {
            this.nombreCliente = nombreCliente;
            InitializeComponent();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            llenarCuotas();
            saludo.Text += ", ";
            saludo.Text += nombreCliente;
        }

        private void llenarCuotas()
        {
            for(int i=0; i < cuotasDisponiblesList.Length; i++)
            {
                cuotas.Items.Add(cuotasDisponiblesList[i]);
            }
        }

        private void validateForm()
        {
            Validator validator = new Validator();
            String number = valor.Text.Trim();
            if (number == string.Empty)
            {
                botonPedirPrestamo.Enabled = false;
                errorProvider1.SetError(valor, "Debe introducir un monto");
            }
            else
            {
                Boolean ok = validator.validarNumero(number);
                if (!ok)
                {
                    errorProvider1.SetError(valor, "Solo se acepta numeros");
                }
                else if (ok)
                {
                    errorProvider1.SetError(valor, "");
                    botonPedirPrestamo.Enabled = true;

                }
            }
        }


        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void botonPedirPrestamo_Click(object sender, EventArgs e)
        {

        }
    }
}
