using System;
using System.Windows.Forms;

namespace NominaQuincenal
{
    public partial class Form1 : Form
    {
        // Constantes del cálculo
        const int HORAS_REGULARES = 88;
        const double RECARGO_EXTRA = 1.35;
        const double INCENTIVO_TRANSPORTE = 1500;
        const double TASA_AFP = 0.0287;
        const double TASA_SFS = 0.0304;

        // Límites de horas
        const int HORAS_MINIMAS = 1;
        const int HORAS_MAXIMAS = 120;

        // Tarifas por hora (RD$)
        const double TARIFA_AUXILIAR = 180;
        const double TARIFA_TECNICO = 250;
        const double TARIFA_SUPERVISOR = 350;
        const double TARIFA_GERENTE = 500;

        // Acumuladores (nivel de formulario)
        int cantidadEmpleados = 0;
        double totalBruto = 0;
        double totalDeducciones = 0;
        double totalNeto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Evento Click de "Registrar empleado": valida, calcula el neto,
        // agrega la línea al ListBox y actualiza los acumuladores
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar nombre
            if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del empleado.", "Validación");
                txtEmpleado.Focus();
                return;
            }

            // Validar contrato
            if (!rdbFijo.Checked && !rdbTemporal.Checked)
            {
                MessageBox.Show("Seleccione el tipo de contrato.", "Validación");
                return;
            }

            // Validar cargo
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.", "Validación");
                cmbCargo.Focus();
                return;
            }

            // Validar horas
            int horas;
            if (!int.TryParse(txtHoras.Text, out horas) || horas < HORAS_MINIMAS || horas > HORAS_MAXIMAS)
            {
                MessageBox.Show("Las horas deben ser un número entero de 1 a 120.", "Validación");
                txtHoras.Focus();
                return;
            }

            // Tarifa según el cargo
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

            // Salario regular y horas extra
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

            // Incentivo de transporte
            double incentivo = 0;
            if (chkTransporte.Checked)
            {
                incentivo = INCENTIVO_TRANSPORTE;
            }

            // Bruto
            double bruto = salarioRegular + pagoExtra + incentivo;

            // Deducciones (solo contrato Fijo, sin incluir el incentivo)
            double deducciones = 0;
            if (rdbFijo.Checked)
            {
                deducciones = (salarioRegular + pagoExtra) * (TASA_AFP + TASA_SFS);
            }

            // Neto
            double neto = bruto - deducciones;

            // Actualizar acumuladores
            cantidadEmpleados++;
            totalBruto += bruto;
            totalDeducciones += deducciones;
            totalNeto += neto;

            // Agregar a la nómina
            lstNomina.Items.Add(txtEmpleado.Text.Trim() + " · " + cmbCargo.Text + " · RD$ " + neto.ToString("N2"));

            // Preparar para el siguiente empleado
            txtEmpleado.Clear();
            rdbFijo.Checked = false;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            txtHoras.Clear();
            chkTransporte.Checked = false;
            txtEmpleado.Focus();
        }

        // Evento Click de "Mostrar resumen": muestra la cantidad de empleados y los totales
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

        // Evento Click de "Limpiar": deja el formulario como al iniciar
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

        // Evento Click de "Salir": cierra la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
