
# Nomina-Quincenal# Nómina Quincenal

Aplicación de Windows Forms en C# que calcula el pago quincenal de los empleados, los agrega a una lista y muestra un resumen con los totales de la nómina.

- **Estudiante:** Fausto Junior Moreno Santana
- **Matrícula:** 2025-1582

## Descripción

El usuario escribe el nombre del empleado, elige el tipo de contrato (Fijo o Temporal) y el cargo, escribe las horas trabajadas en la quincena e indica si recibe incentivo de transporte. Al registrar, la aplicación calcula el pago neto y lo agrega a la lista. Al final, **Mostrar resumen** presenta la cantidad de empleados y los totales de bruto, deducciones y neto.

## Tarifas por hora

| Cargo      | Tarifa (RD$) |
|------------|-------------:|
| Auxiliar   | 180          |
| Técnico    | 250          |
| Supervisor | 350          |
| Gerente    | 500          |

## Reglas del cálculo

1. **Salario regular** = horas (hasta 88) × tarifa.
2. **Horas extra:** las horas por encima de 88 se pagan con 35 % adicional: horas extra × tarifa × 1.35.
3. **Incentivo de transporte:** RD$ 1,500 si está marcado.
4. **Bruto** = salario regular + horas extra + incentivo.
5. **Deducciones:**
   - Contrato **Fijo:** AFP 2.87 % + SFS 3.04 % sobre (regular + extra), sin incluir el incentivo.
   - Contrato **Temporal:** sin deducciones.
6. **Neto** = bruto − deducciones.

### Ejemplo

Ana Gómez, Técnico, Fijo, 88 horas, con transporte:

- Salario regular: 88 × 250 = 22,000.00
- Horas extra: 0.00
- Incentivo: 1,500.00
- Bruto: 23,500.00
- Deducciones: 22,000 × (0.0287 + 0.0304) = 1,300.20
- **Neto: RD$ 22,199.80**

## Interfaz

| Grupo (GroupBox)     | Controles |
|----------------------|-----------|
| Datos del empleado   | `txtEmpleado`, `rdbFijo`, `rdbTemporal` |
| Registro de pago     | `cmbCargo`, `txtHoras`, `chkTransporte`, `btnRegistrar` |
| Nómina registrada    | `lstNomina` |
| Resumen              | `lblEmpleados`, `lblBruto`, `lblDeducciones`, `lblNeto` |
| (abajo del formulario) | `btnResumen`, `btnLimpiar`, `btnSalir` |

## Botones

- **Registrar empleado:** valida los datos, calcula el neto, agrega la línea a la lista y actualiza los acumuladores.
- **Mostrar resumen:** muestra la cantidad de empleados y los totales con formato `RD$` y dos decimales.
- **Limpiar:** deja el formulario como al iniciar (vacía la lista y reinicia los totales).
- **Salir:** cierra la aplicación.

## Validaciones

Se muestran con `MessageBox`:

- El nombre no puede estar vacío.
- Debe estar seleccionado el tipo de contrato.
- Debe estar seleccionado el cargo.
- Las horas deben ser un número entero de 1 a 120 (`int.TryParse`).
- No se muestra el resumen si no hay empleados registrados.

## Constantes usadas

| Constante              | Valor  |
|------------------------|--------|
| `HORAS_REGULARES`      | 88     |
| `RECARGO_EXTRA`        | 1.35   |
| `INCENTIVO_TRANSPORTE` | 1500   |
| `TASA_AFP`             | 0.0287 |
| `TASA_SFS`             | 0.0304 |
| `HORAS_MINIMAS`        | 1      |
| `HORAS_MAXIMAS`        | 120    |
| `TARIFA_AUXILIAR`      | 180    |
| `TARIFA_TECNICO`       | 250    |
| `TARIFA_SUPERVISOR`    | 350    |
| `TARIFA_GERENTE`       | 500    |



## Restricciones cumplidas

- Todo el código está en `Form1.cs`, sin clases adicionales.
- Sin DataGridView, bases de datos, archivos ni librerías externas.
- Sin valores fijos repetidos y sin `Console`.
