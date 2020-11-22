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
    public partial class frmEdadNombre : Form
    {
        public frmEdadNombre()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Condiciones 
            int edad = int.Parse(txtEdadIn.Text);
            if(!(edad>=15 && edad <= 80)) 
            {
                MessageBox.Show("Ingresa una edad entre 15 y 80 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdadIn.Focus();
                return;
            }
            else if(edad>=15 && edad <= 17)
            {
                txtEdad.Text = "Eres menor de edad";
            }else if(edad >=18 && edad<=25)
            {
                txtEdad.Text = "Puedes votar en las elecciones 2021";
            }else if(edad >=26 && edad <= 30)
            {
                txtEdad.Text = "Ya debes casarte";
            }else if(edad >=31 && edad <= 50)
            {
                txtEdad.Text = "Trabaja, duerme y disfruta";
            }else if(edad > 50)
            {
                txtEdad.Text = "Ya casi llegas a la tercera edad";
            }
        }
    }
}
