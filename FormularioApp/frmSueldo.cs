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
    }
}
