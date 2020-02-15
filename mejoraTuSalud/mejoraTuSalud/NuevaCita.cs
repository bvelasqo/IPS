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
    public partial class NuevaCita : Form
    {
        public NuevaCita()
        {
            InitializeComponent();
            dtpFechaDeLaCita.MinDate = DateTime.Today;
            dtpFechaDeLaCita.CustomFormat = "MM/dd/yyy";
        }
        Operaciones Operaciones = new Operaciones();
        string id, tipoCita, medico, fecha, ValorCita, nombreMedico, hora;

        Boolean asignar()
        {
            if (!(txtIdPaciente.Text == ""))
            {
                if (!(cbxTipoCita.Text == ""))
                {
                    if (!(cbxMedico.Text == ""))
                    {
                        id = txtIdPaciente.Text;
                        tipoCita = cbxTipoCita.Text;
                        medico = cbxMedico.Text;
                        fecha = dtpFechaDeLaCita.Text;
                        hora = nudHora.Value.ToString() + ":" + nudMinuto.Value.ToString() + cbxAmPm.Text;
                        DataRow dataRow = Operaciones.buscarNombreMedico(medico).Rows[0];
                        ValorCita = dataRow["SalarioPorCita"].ToString();
                        nombreMedico = txtIdMedico.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Escoja el medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Escoja el tipo de cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("ingrese el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean citasDelPaciente()
        {
            DataTable dataTable = new DataTable();
            dataTable = Operaciones.CitasPendientes(id);
            if (dataTable.Rows.Count == 2)
            {
                MessageBox.Show("El paciente ya tiene 2 citas asignadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                dataTable = Operaciones.CitasRepetidasMismoEspecialista(id, medico);
                if (dataTable.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ya tiene una cita con este medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void CbxTipoCita_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (cbxTipoCita.Text == "Médico General")
            {
                dataTable = Operaciones.buscarMedico("Médico General");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No hay medicos disponibles en esa especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cbxMedico.Items.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable.Rows[i];
                        cbxMedico.Items.Add(dataRow["idMedico"].ToString());
                        mostrar(true);
                    }
                }
            }
            if (cbxTipoCita.Text == "Optometría")
            {
                dataTable = Operaciones.buscarMedico("Optometría");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No hay medicos disponibles en esa especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cbxMedico.Items.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable.Rows[i];
                        cbxMedico.Items.Add(dataRow["idMedico"].ToString());
                        mostrar(true);
                    }
                }
            }
            if (cbxTipoCita.Text == "Pediatría")
            {
                dataTable = Operaciones.buscarMedico("Pediatría");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No hay medicos disponibles en esa especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cbxMedico.Items.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable.Rows[i];
                        cbxMedico.Items.Add(dataRow["idMedico"].ToString());
                        mostrar(true);
                    }
                }
            }
        }

        Boolean existeCitaFecha()
        {
            DataTable dataTable = new DataTable();
            dataTable = Operaciones.FechaCitaRepetida(fecha,id);
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Ese día el paciente tiene una cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        Boolean citaRepetida()
        {
            DataTable dataTable = new DataTable();
            dataTable = Operaciones.CitasRepetidas(id, medico, fecha);
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Esta cita ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        void mostrar(Boolean a)
        {
            lblMedico.Visible = a;
            cbxMedico.Visible = a;
            lblIdMedico.Visible = a;
            txtIdMedico.Visible = a;
            btnAsignar.Visible = a;
            lblFechaDeCita.Visible = a;
            dtpFechaDeLaCita.Visible = a;
            lblHoraDeLaCita.Visible = a;
            lblDospuntos.Visible = a;
            nudHora.Visible = a;
            nudMinuto.Visible = a;
            cbxAmPm.Visible = a;
        }

        private void CbxMedico_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Operaciones.buscarNombreMedico(cbxMedico.Text);
                DataRow dataRow = dataTable.Rows[0];
                txtIdMedico.Text = dataRow["Nombres"].ToString() + " " + dataRow["Apellidos"].ToString();
            }
            catch
            {

            }
        }

        Boolean multado()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Operaciones.buscarMultas(id);
                DataRow dataRow = dataTable.Rows[0];
                int multas = Convert.ToInt32(dataRow["Multas"].ToString());
                if (multas > 0)
                {
                    MessageBox.Show("No se le puede asignar una cita a un paciente multado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Ese id no está registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                return true;
            }
        }

        void limpiar()
        {
            txtIdPaciente.Text = "";
            cbxTipoCita.Text = "";
            cbxMedico.Items.Clear();
            cbxTipoCita.Text = " ";
            mostrar(false);
            dtpFechaDeLaCita.Value = DateTime.Today;
            nudHora.Value = 0;
            nudMinuto.Value = 0;
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                if (!multado())
                {
                    if (!citaRepetida())
                    {
                        if (citasDelPaciente())
                        {
                            if (!existeCitaFecha())
                            {

                                DataRow dataRow = Operaciones.buscarPaciente(id).Rows[0];
                                string nombrePaciente = dataRow["Nombres"].ToString() + " " + dataRow["Apellidos"].ToString();
                                fecha = dtpFechaDeLaCita.Value.ToShortDateString();
                                Operaciones.insertarCita(id, medico, fecha, hora);
                                MessageBox.Show(@"Médico: " + nombreMedico + @"
"
                                                + "Paciente: " + nombrePaciente + @"
"
                                                + "Fecha: " + fecha + @"
"
                                                + "Hora: " + hora + @"
"
                                                + "Valor a pagar: " + ValorCita, "Cita Asignada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                limpiar();
            }
        }
    }
}
