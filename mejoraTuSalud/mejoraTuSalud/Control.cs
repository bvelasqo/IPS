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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }
        string id, nombrepaciente, nombremedico;
        static int multa = 2000;
        Operaciones Operaciones = new Operaciones();
        DataTable DataTable;
        DataRow dataRow;
        Boolean asignar()
        {
            if (txtIdPaciente.Text == "")
            {
                MessageBox.Show("Llene el campo id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                id = txtIdPaciente.Text;
                return true;
            }
        }

        void removerDatos()
        {
            try
            {
                dgvControl.Columns.Remove(dgvControl.Columns["Multas"]);
                dgvControl.Columns.Remove(dgvControl.Columns["Nombres"]);
                dgvControl.Columns.Remove(dgvControl.Columns["Apellidos"]);
                dgvControl.Columns.Remove(dgvControl.Columns["FechaDeNacimiento"]);
                dgvControl.Columns.Remove(dgvControl.Columns["Direccion"]);
                dgvControl.Columns.Remove(dgvControl.Columns["Telefono"]);
                dgvControl.Columns.Remove(dgvControl.Columns["FechaDeRegistro"]);
            }
            catch (System.ArgumentNullException)
            {

            }
           
        }

        //Hacer herencias de clases operaciones
        private void Button2_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mostrar(false);
                    DataTable = Operaciones.CitasPendientes(id);
                    dgvControl.DataSource = DataTable;
                    removerDatos();
                }
            }
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mostrar(false);
                    DataTable = Operaciones.historialDeCitas(id);
                    dgvControl.DataSource = DataTable;
                    removerDatos();
                }
            }
        }

        private void BtnCitasIncumplidas_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
                else
                {
                    try
                    {
                        mostrar(false);
                        DataTable = Operaciones.CitasIncumplidas(id);
                        dgvControl.DataSource = DataTable;
                        removerDatos();
                    }
                    catch (System.ArgumentNullException)
                    {

                    }
                    
                }
            }
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataRow = DataTable.Rows[0];
                    nombrepaciente = dataRow["Nombres"].ToString() + " " + dataRow["Apellidos"].ToString();
                    mostrar(false);
                    DataTable = Operaciones.citashoy(id);
                    if (DataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Este paciente no tiene citas hoy", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dataRow = DataTable.Rows[0];
                        string idmedico = dataRow["idMedico"].ToString();
                        DataTable = Operaciones.Nombremedico(idmedico);
                        dataRow = DataTable.Rows[0];
                        nombremedico = dataRow["Nombres"].ToString() + " " + dataRow["Apellidos"].ToString();
                        if(MessageBox.Show("¿Desea dar la asistencia de "+nombrepaciente+" a la cita con el medico "+ nombremedico +" ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Operaciones.registrarAsistencia(id);
                        }
                    }
                }
            }
        }

        void mostrar(Boolean a)
        {
            lblPesos.Visible = a;
            btnPagar.Visible = a;
            lblValorAPagar.Visible = a;
            lbl.Visible = a;
            lblMultas.Visible = a;
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable = Operaciones.CitasPendientes(id);
                    if (DataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No tiene citas próximas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0; i < DataTable.Rows.Count; i++)
                        {
                            dataRow = DataTable.Rows[i];
                            string idmedico = dataRow["idMedico"].ToString();
                            DataTable = Operaciones.buscarNombreMedico(idmedico);
                            dataRow = DataTable.Rows[0];
                            string nombreMedico = dataRow["Nombres"].ToString() + " " + dataRow["Apellidos"].ToString();
                            if (MessageBox.Show("¿Está seguro de cancelar la cita con " + nombreMedico + " ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Operaciones.CancelarCita(id, idmedico);
                                MessageBox.Show("Cita cancelada", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            DataTable = Operaciones.CitasPendientes(id);
                        }
                    }
                }
            }
        }

        private void BtnMultas_Click(object sender, EventArgs e)
        {
            if (asignar())
            {
                DataTable = Operaciones.buscarPaciente(id);
                if (DataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mostrar(true);
                    DataTable = Operaciones.buscarMultas(id);
                    dataRow = DataTable.Rows[0];
                    lblMultas.Text = dataRow["Multas"].ToString();
                    int multas = Convert.ToInt32(dataRow["Multas"]);
                    int ValorAPagar = multas * multa;
                    lblPesos.Text = ValorAPagar.ToString() + " $";
                }
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está pagando las multas del paciente con id: " + id + "¿Está Seguro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Operaciones.pagarMulta(id);
                dgvControl.DataSource = Operaciones.buscarMultas(id);
                MessageBox.Show("Pagado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPesos.Text = "0 $";
                lblMultas.Text = "0";
            }
        }
    }
}
