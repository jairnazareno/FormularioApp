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
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar el nombre");
                this.txtNombre.Focus();
                return;
            }
            if (this.txtHorasTrabajadas.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar las Horas Trabajadas");
                this.txtHorasTrabajadas.Focus();
                return;
            }
            if (this.txtValorHora.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar las Horas de su valor");
                this.txtValorHora.Focus();
                return;
            }
            if (this.txtBono.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar los Bonos recibidos");
                this.txtBono.Focus();
                return;
            }
            if (this.txtAsoTrabajadores.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar el egreso de asociacion de Trabajador");
                this.txtAsoTrabajadores.Focus();
                return;
            }
            if (this.txtBar.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar el egreso del Bar");
                this.txtBar.Focus();
                return;
            }
            if (this.txtCuentaPorPagar.Text.Length == 0)
            {
                MessageBox.Show("Por Favor debes ingresar el egreso de cuentas por pagar");
                this.txtCuentaPorPagar.Focus();
                return;
            }

            double horasTrabajadas = double.Parse(this.txtHorasTrabajadas.Text);
                double valorHora = double.Parse(this.txtValorHora.Text);
                double bono = double.Parse(this.txtBono.Text);
                double totIng = horasTrabajadas * valorHora + bono;
              

                //Mostrar total de ingresos en el cuadro de texto

                this.txtTotalIng.Text = totIng.ToString();

                //sumar egresos

                double asoTrabajadores = double.Parse(this.txtAsoTrabajadores.Text);
                double bar = double.Parse(this.txtBar.Text);
                double cuentaPorPagar = double.Parse(this.txtCuentaPorPagar.Text);
                double totEgresos = asoTrabajadores + bar + cuentaPorPagar;
                this.txtTotalEgresos.Text = totEgresos.ToString();

                double liquidoRecibir = totIng - totEgresos;

                lblResultados.Text = "Estimado, " + this.txtNombre.Text + ", tu sueldo es: " + liquidoRecibir.ToString();
             
           
        }
      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHorasTrabajadas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmSueldo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }

        private void txtHorasTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <=47) || (e.KeyChar >=58 && e.KeyChar<=255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAsoTrabajadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuentaPorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
