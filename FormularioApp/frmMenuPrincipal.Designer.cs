namespace FormularioApp
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.btnEnteroBin = new System.Windows.Forms.Button();
            this.btnFormularioNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(309, 83);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(105, 48);
            this.btnCalcularSueldo.TabIndex = 0;
            this.btnCalcularSueldo.Text = "CALCULAR SUELDO";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // btnEnteroBin
            // 
            this.btnEnteroBin.Location = new System.Drawing.Point(309, 165);
            this.btnEnteroBin.Name = "btnEnteroBin";
            this.btnEnteroBin.Size = new System.Drawing.Size(105, 50);
            this.btnEnteroBin.TabIndex = 1;
            this.btnEnteroBin.Text = "ENTERO  EN BINARIO";
            this.btnEnteroBin.UseVisualStyleBackColor = true;
            this.btnEnteroBin.Click += new System.EventHandler(this.btnEnteroBin_Click);
            // 
            // btnFormularioNuevo
            // 
            this.btnFormularioNuevo.Location = new System.Drawing.Point(309, 249);
            this.btnFormularioNuevo.Name = "btnFormularioNuevo";
            this.btnFormularioNuevo.Size = new System.Drawing.Size(105, 53);
            this.btnFormularioNuevo.TabIndex = 2;
            this.btnFormularioNuevo.Text = "FORMULARIO NUEVO";
            this.btnFormularioNuevo.UseVisualStyleBackColor = true;
            this.btnFormularioNuevo.Click += new System.EventHandler(this.btnFormularioNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 56);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFormularioNuevo);
            this.Controls.Add(this.btnEnteroBin);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Button btnEnteroBin;
        private System.Windows.Forms.Button btnFormularioNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}