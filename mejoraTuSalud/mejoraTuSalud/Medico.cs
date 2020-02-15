using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mejoraTuSalud
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        Operaciones Operaciones = new Operaciones();
        DataTable DataTable;
        DataRow DataRow;
        string id, salarioNuevo, añosExperienciaNuevos, nombre;

        private void BtnActualizarSalario_Click(object sender, EventArgs e)
        {
            if (asignar(1))
            {
                Operaciones.actualizarSalario(id, salarioNuevo);
                MessageBox.Show("Salario por cita actualizado","Estado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiar(false);
            }
        }

        private void BtnActualizarEsperiencia_Click(object sender, EventArgs e)
        {
            if (asignar(2))
            {
                Operaciones.actualizarAnios(id, añosExperienciaNuevos);
                MessageBox.Show("Años de experiencia actualizado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar(true);
            }
        }

        private void TxtSalarioCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void BtnVerPago_Click(object sender, EventArgs e)
        {
            if (asignar(0))
            {
                int salario = Convert.ToInt32(DataRow["SalarioPorCita"]);
                DataTable = Operaciones.buscarCitasSinPagar(id);
                salario *= DataTable.Rows.Count;
                if (MessageBox.Show("El pago del médico " +nombre+" es "+salario+" $ ¿Desea pagárselos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Operaciones.pagarCitas(id);
                    MessageBox.Show("Pagado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void limpiar(Boolean a)
        {
            if (a)
            {
                txtExperiencia.Text = "";
            }
            else
            {
                txtSalarioCita.Text = "";
            }
        }

        Boolean asignar(int a)
        {
            if (!(txtIdMedico.Text == ""))
            {
                DataTable = Operaciones.buscarNombreMedico(txtIdMedico.Text);
                
                if (DataTable.Rows.Count != 0)
                {
                    DataRow = DataTable.Rows[0];
                    nombre = DataRow["Nombres"].ToString() + " " + DataRow["Apellidos"].ToString();
                    id = txtIdMedico.Text;
                    if (a==1)
                    {
                        if (txtSalarioCita.Text == "")
                        {
                            MessageBox.Show("Llene el campo salario por cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            salarioNuevo = txtSalarioCita.Text;
                            return true;
                        }
                    }
                    else if(a==2)
                    {
                        if (txtExperiencia.Text == "")
                        {
                            MessageBox.Show("Llene el campo años de experiencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            añosExperienciaNuevos = txtExperiencia.Text;
                            return true;
                        }
                    }
                    return true;

                }
                else
                {
                    MessageBox.Show("Cedula no registrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Llene el campo cedula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
