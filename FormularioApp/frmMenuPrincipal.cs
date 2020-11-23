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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            //ABRIR EL FORMULARIO DE CALCULAR SUELDO
            frmSueldo frm1 = new frmSueldo();
            frm1.ShowDialog();//MOSTRAR EL FORMULARIO

        }

        private void btnEnteroBin_Click(object sender, EventArgs e)
        {
            //ABRIR EL FORMULARIO DE CALCULAR SUELDO
            frmNumEnBin frm1 = new frmNumEnBin();
            frm1.ShowDialog();//MOSTRAR EL FORMULARIO
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFormularioNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
