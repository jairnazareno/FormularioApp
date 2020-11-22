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
    public partial class  frmDeBinarioADecimal : Form
    {
        public frmDeBinarioADecimal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
          
            double residuo = 0;
            double sumar = 0;
            if (chk8.Checked == true)
            {
                residuo = Math.Pow(2, 0);
                sumar += residuo;
            }
            if (chk7.Checked == true)
            {
                residuo = Math.Pow(2, 1);
                sumar += residuo;
            }
            if (chk6.Checked == true)
            {
                residuo = Math.Pow(2, 2);
                sumar += residuo;
            }
            if (chk5.Checked == true)
            {
                residuo = Math.Pow(2, 3);
                sumar += residuo;
            }
            if (chk4.Checked == true)
            {
                residuo = Math.Pow(2, 4);
                sumar += residuo;
            }
            if (chk3.Checked == true)
            {
                residuo = Math.Pow(2, 5);
                sumar += residuo;
            }
            if (chk2.Checked == true)
            {
                residuo = Math.Pow(2, 6);
                sumar += residuo;
            }
            if (chk1.Checked == true)
            {
                residuo = Math.Pow(2, 7);
                sumar += residuo;
            }
            txtNumero.Text = sumar.ToString();
        }
     
}
}
