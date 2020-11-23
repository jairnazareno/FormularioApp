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
    public partial class frmMultiplicar : Form
    {
        public frmMultiplicar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse(txtNumero.Text);
            int limite = int.Parse(txtLimite.Text);
            int resultado;

            for(int i=1; i<=limite; i++)
            {
                resultado = tabla * 1;
                ListBox.items.
            }
        }
    }
}
