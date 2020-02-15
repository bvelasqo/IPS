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
    public partial class Acceso : Form
    {
        Operaciones operacion = new Operaciones();

        public Acceso()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioDado = txtUsuario.Text;
            DataTable dataTable = new DataTable();
            dataTable = operacion.acceso(usuarioDado);
            int datos = dataTable.Rows.Count;
            if (datos == 0)
            {
                MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow dataRow = dataTable.Rows[0];
                string contraseñaEmpleado = dataRow["Contraseña"].ToString();
                if (contraseñaEmpleado == txtContraseña.Text)
                {
                    Form1 f = new Form1(this);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtContraseña.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}
