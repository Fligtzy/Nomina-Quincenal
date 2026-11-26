namespace NominaQuincenal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.rdbFijo = new System.Windows.Forms.RadioButton();
            this.rdbTemporal = new System.Windows.Forms.RadioButton();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.chkTransporte = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpNomina = new System.Windows.Forms.GroupBox();
            this.lstNomina = new System.Windows.Forms.ListBox();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.lblTituloEmpleados = new System.Windows.Forms.Label();
            this.lblTituloBruto = new System.Windows.Forms.Label();
            this.lblTituloDeducciones = new System.Windows.Forms.Label();
            this.lblTituloNeto = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpEmpleado.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.grpNomina.SuspendLayout();
            this.grpResumen.SuspendLayout();
            this.SuspendLayout();
           
            this.grpEmpleado.Controls.Add(this.lblNombre);
            this.grpEmpleado.Controls.Add(this.txtEmpleado);
            this.grpEmpleado.Controls.Add(this.lblContrato);
            this.grpEmpleado.Controls.Add(this.rdbFijo);
            this.grpEmpleado.Controls.Add(this.rdbTemporal);
            this.grpEmpleado.Location = new System.Drawing.Point(12, 12);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(360, 100);
            this.grpEmpleado.TabIndex = 0;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Datos del empleado";
       
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre:";
        
            this.txtEmpleado.Location = new System.Drawing.Point(90, 27);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(250, 20);
            this.txtEmpleado.TabIndex = 0;
          
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(15, 65);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Text = "Contrato:";
           
            this.rdbFijo.AutoSize = true;
            this.rdbFijo.Location = new System.Drawing.Point(90, 63);
            this.rdbFijo.Name = "rdbFijo";
            this.rdbFijo.TabIndex = 1;
            this.rdbFijo.Text = "Fijo";
            this.rdbFijo.UseVisualStyleBackColor = true;
          
            this.rdbTemporal.AutoSize = true;
            this.rdbTemporal.Location = new System.Drawing.Point(200, 63);
            this.rdbTemporal.Name = "rdbTemporal";
            this.rdbTemporal.TabIndex = 2;
            this.rdbTemporal.Text = "Temporal";
            this.rdbTemporal.UseVisualStyleBackColor = true;
         
            this.grpPago.Controls.Add(this.lblCargo);
            this.grpPago.Controls.Add(this.cmbCargo);
            this.grpPago.Controls.Add(this.lblHoras);
            this.grpPago.Controls.Add(this.txtHoras);
            this.grpPago.Controls.Add(this.chkTransporte);
            this.grpPago.Controls.Add(this.btnRegistrar);
            this.grpPago.Location = new System.Drawing.Point(12, 120);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(360, 230);
            this.grpPago.TabIndex = 1;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Registro de pago";
           
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(15, 30);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Text = "Cargo:";
          
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Auxiliar",
            "Técnico",
            "Supervisor",
            "Gerente"});
            this.cmbCargo.Location = new System.Drawing.Point(90, 27);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(250, 21);
            this.cmbCargo.TabIndex = 0;
            
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(15, 70);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Text = "Horas trabajadas en la quincena:";
         
            this.txtHoras.Location = new System.Drawing.Point(15, 92);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(110, 20);
            this.txtHoras.TabIndex = 1;
          
            this.chkTransporte.AutoSize = true;
            this.chkTransporte.Location = new System.Drawing.Point(15, 135);
            this.chkTransporte.Name = "chkTransporte";
            this.chkTransporte.TabIndex = 2;
            this.chkTransporte.Text = "Recibe incentivo de transporte";
            this.chkTransporte.UseVisualStyleBackColor = true;
          
            this.btnRegistrar.Location = new System.Drawing.Point(15, 175);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(325, 35);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar empleado";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
           
            this.grpNomina.Controls.Add(this.lstNomina);
            this.grpNomina.Location = new System.Drawing.Point(385, 12);
            this.grpNomina.Name = "grpNomina";
            this.grpNomina.Size = new System.Drawing.Size(360, 190);
            this.grpNomina.TabIndex = 2;
            this.grpNomina.TabStop = false;
            this.grpNomina.Text = "Nómina registrada";
           
            this.lstNomina.FormattingEnabled = true;
            this.lstNomina.Location = new System.Drawing.Point(15, 25);
            this.lstNomina.Name = "lstNomina";
            this.lstNomina.Size = new System.Drawing.Size(330, 147);
            this.lstNomina.TabIndex = 0;
           
            this.grpResumen.Controls.Add(this.lblTituloEmpleados);
            this.grpResumen.Controls.Add(this.lblTituloBruto);
            this.grpResumen.Controls.Add(this.lblTituloDeducciones);
            this.grpResumen.Controls.Add(this.lblTituloNeto);
            this.grpResumen.Controls.Add(this.lblEmpleados);
            this.grpResumen.Controls.Add(this.lblBruto);
            this.grpResumen.Controls.Add(this.lblDeducciones);
            this.grpResumen.Controls.Add(this.lblNeto);
            this.grpResumen.Location = new System.Drawing.Point(385, 210);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(360, 140);
            this.grpResumen.TabIndex = 3;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen";
          
            this.lblTituloEmpleados.AutoSize = true;
            this.lblTituloEmpleados.Location = new System.Drawing.Point(15, 28);
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Text = "Empleados registrados:";
         
            this.lblTituloBruto.AutoSize = true;
            this.lblTituloBruto.Location = new System.Drawing.Point(15, 55);
            this.lblTituloBruto.Name = "lblTituloBruto";
            this.lblTituloBruto.Text = "Total bruto:";
           
            this.lblTituloDeducciones.AutoSize = true;
            this.lblTituloDeducciones.Location = new System.Drawing.Point(15, 82);
            this.lblTituloDeducciones.Name = "lblTituloDeducciones";
            this.lblTituloDeducciones.Text = "Total deducciones:";
          
            this.lblTituloNeto.AutoSize = true;
            this.lblTituloNeto.Location = new System.Drawing.Point(15, 109);
            this.lblTituloNeto.Name = "lblTituloNeto";
            this.lblTituloNeto.Text = "Total neto:";
          
            this.lblEmpleados.Location = new System.Drawing.Point(195, 28);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(150, 15);
            this.lblEmpleados.Text = "0";
            this.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          
            this.lblBruto.Location = new System.Drawing.Point(195, 55);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(150, 15);
            this.lblBruto.Text = "RD$ 0.00";
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         
            this.lblDeducciones.Location = new System.Drawing.Point(195, 82);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(150, 15);
            this.lblDeducciones.Text = "RD$ 0.00";
            this.lblDeducciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.lblNeto.Location = new System.Drawing.Point(195, 109);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(150, 15);
            this.lblNeto.Text = "RD$ 0.00";
            this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          
            this.btnResumen.Location = new System.Drawing.Point(12, 365);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(230, 35);
            this.btnResumen.TabIndex = 4;
            this.btnResumen.Text = "Mostrar resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(264, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(230, 35);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
          
            this.btnSalir.Location = new System.Drawing.Point(515, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 415);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.grpNomina);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nómina Quincenal";
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.grpNomina.ResumeLayout(false);
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.RadioButton rdbFijo;
        private System.Windows.Forms.RadioButton rdbTemporal;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.CheckBox chkTransporte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpNomina;
        private System.Windows.Forms.ListBox lstNomina;
        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lblTituloEmpleados;
        private System.Windows.Forms.Label lblTituloBruto;
        private System.Windows.Forms.Label lblTituloDeducciones;
        private System.Windows.Forms.Label lblTituloNeto;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}
