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
                MessageBox.Show("DEBES INGRESAR UN NUMERO");
                this.txtNumero.Focus();
                return;
            }
            int numero = int.Parse(this.txtNumero.Text);
            primo(numero);
        }
        void primo(int numero)
        {
            int n = 0;
            for (int j = 1; j <= numero; j++)
            {
                if ((numero % j) == 0)
                    n = n + 1;
            }
            if (n > 2)
                this.lblRespuesta.Text = "El numero no es Primo";
            else
                this.lblRespuesta.Text = "El numero es Primo";
        }

    }
}
