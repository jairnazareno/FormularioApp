using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class frmNumeroPrimo : Form
    {
        public frmNumeroPrimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar un numero");
                this.txtNumero.Focus();
                return;
            }
            int numero = int.Parse(this.txtNumero.Text);
            comprobacion(numero);
        }
        void comprobacion(int numero)
        {
            int a = 0;
            for (int i = 1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                    a = a + 1;
            }
            if (a > 2)
                this.lblRespuesta.Text = "El numero no es Primo";
            else
                this.lblRespuesta.Text = "El numero es Primo";
        }

    }
}
