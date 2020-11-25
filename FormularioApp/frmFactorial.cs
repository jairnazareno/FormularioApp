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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
			int num, i;
			double result = 1;
		
			num = int.Parse(txtNumero.Text);
			for (i = 2; i <= num; i++)
			{
				result = result * i;
			}
			
			txtRespuesta.Text = "El factorial del numero es :  " + result;

		}
    }
}
