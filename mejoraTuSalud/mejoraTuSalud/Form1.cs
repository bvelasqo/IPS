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
    public partial class Form1 : Form
    {
        //Este form al ser abierto revisa los pacientes que no asistieron a sus citas y los multa automaticamente

        Acceso acceso;
        public Form1(Acceso acceso)
        {
            this.acceso = acceso;
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        Operaciones operacion = new Operaciones();
        private void MédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.MdiParent = this;
            medico.Show();
        }

        private void EmpleadoIPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCita nuevaCita = new NuevaCita();
            nuevaCita.MdiParent = this;
            nuevaCita.Show();
        }

        private void JasdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            control.MdiParent = this;
            control.Show();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPacientecs rp = new RegistrarPacientecs();
            rp.MdiParent = this;
            rp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable buscarNoAsistidos = new DataTable();
            DataTable buscarMultas = new DataTable();
            buscarNoAsistidos = operacion.buscarNoAsistidos();
            for (int i=0; i < buscarNoAsistidos.Rows.Count; i++)
            {
                DataRow dataRow = buscarNoAsistidos.Rows[i];
                if(dataRow["idPaciente"] == null)
                {
                    break;
                }
                else
                {
                    string id = dataRow["idPaciente"].ToString();
                    buscarMultas = operacion.buscarMultas(id);
                    dataRow = buscarMultas.Rows[0];
                    int multas = Convert.ToInt32(dataRow["Multas"].ToString()) + 1;
                    operacion.multar(id, multas);
                }
                buscarNoAsistidos = operacion.buscarNoAsistidos();
            }
            operacion.revisar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            acceso.Close();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Size= new System.Drawing.Size(904,597);
        }

    }
}
