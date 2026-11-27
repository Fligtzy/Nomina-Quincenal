using System;
using System.Windows.Forms;

namespace NominaQuincenal
{
    public partial class Form1 : Form
    {
        
        const int HORAS_REGULARES = 88;
        const double RECARGO_EXTRA = 1.35;
        const double INCENTIVO_TRANSPORTE = 1500;
        const double TASA_AFP = 0.0287;
        const double TASA_SFS = 0.0304;

       
        const int HORAS_MINIMAS = 1;
        const int HORAS_MAXIMAS = 120;

        
        const double TARIFA_AUXILIAR = 180;
        const double TARIFA_TECNICO = 250;
        const double TARIFA_SUPERVISOR = 350;
        const double TARIFA_GERENTE = 500;

        
        int cantidadEmpleados = 0;
        double totalBruto = 0;
        double totalDeducciones = 0;
        double totalNeto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del empleado.", "Validación");
                txtEmpleado.Focus();
                return;
            }

            
            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Seleccione el tipo de contrato.", "Validación");
                return;
            }

           
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.", "Validación");
                cmbCargo.Focus();
                return;
            }

           
            int horas;
            if (!int.TryParse(txtHoras.Text, out horas) || horas < HORAS_MINIMAS || horas > HORAS_MAXIMAS)
            {
                MessageBox.Show("Las horas deben ser un número entero de 1 a 120.", "Validación");
                txtHoras.Focus();
                return;
            }

            
            double tarifa;
            if (cmbCargo.Text == "Auxiliar")
            {
                tarifa = TARIFA_AUXILIAR;
            }
            else if (cmbCargo.Text == "Técnico")
            {
                tarifa = TARIFA_TECNICO;
            }
            else if (cmbCargo.Text == "Supervisor")
            {
                tarifa = TARIFA_SUPERVISOR;
            }
            else
            {
                tarifa = TARIFA_GERENTE;
            }

            
            double salarioRegular;
            double pagoExtra;
            if (horas > HORAS_REGULARES)
            {
                salarioRegular = HORAS_REGULARES * tarifa;
                pagoExtra = (horas - HORAS_REGULARES) * tarifa * RECARGO_EXTRA;
            }
            else
            {
                salarioRegular = horas * tarifa;
                pagoExtra = 0;
            }

           
            double incentivo = 0;
            if (chkTransporte.Checked)
            {
                incentivo = INCENTIVO_TRANSPORTE;
            }

            
            double bruto = salarioRegular + pagoExtra + incentivo;

            
            double deducciones = 0;
            if (rdbFijo.Checked)
            {
                deducciones = (salarioRegular + pagoExtra) * (TASA_AFP + TASA_SFS);
            }

           
            double neto = bruto - deducciones;

           
            cantidadEmpleados++;
            totalBruto += bruto;
            totalDeducciones += deducciones;
            totalNeto += neto;

           
            lstNomina.Items.Add(txtEmpleado.Text.Trim() + " · " + cmbCargo.Text + " · RD$ " + neto.ToString("N2"));

            
            txtEmpleado.Clear();
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            txtHoras.Clear();
            chkTransporte.Checked = false;
            txtEmpleado.Focus();
        }

        
        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (cantidadEmpleados == 0)
            {
                MessageBox.Show("Debe registrar al menos un empleado.", "Validación");
                return;
            }

            lblEmpleados.Text = cantidadEmpleados.ToString();
            lblBruto.Text = "RD$ " + totalBruto.ToString("N2");
            lblDeducciones.Text = "RD$ " + totalDeducciones.ToString("N2");
            lblNeto.Text = "RD$ " + totalNeto.ToString("N2");
        }

      
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            txtHoras.Clear();
            chkTransporte.Checked = false;
            lstNomina.Items.Clear();

            cantidadEmpleados = 0;
            totalBruto = 0;
            totalDeducciones = 0;
            totalNeto = 0;

            lblEmpleados.Text = "0";
            lblBruto.Text = "RD$ 0.00";
            lblDeducciones.Text = "RD$ 0.00";
            lblNeto.Text = "RD$ 0.00";

            txtEmpleado.Focus();
        }

      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
