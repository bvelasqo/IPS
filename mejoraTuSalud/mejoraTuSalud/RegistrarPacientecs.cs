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
    public partial class RegistrarPacientecs : Form
    {
        public RegistrarPacientecs()
        {
            InitializeComponent();
            FHN.MaxDate = DateTime.Today;
        }

        string id, nombres, apellidos, direccion, tel;
        DateTime fecha;

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        Boolean asignacion()
        {
            if (!(txtId.Text == ""))
            {
                if (!(txtNombres.Text == ""))
                {
                    if (!(txtApellidos.Text == ""))
                    {
                        if (!(txtDireccion.Text == ""))
                        {
                            if (!(txtTelefono.Text == ""))
                            {
                                id = txtId.Text;
                                nombres = txtNombres.Text;
                                apellidos = txtApellidos.Text;
                                direccion = txtDireccion.Text;
                                tel = txtTelefono.Text;
                                fecha = FHN.Value;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Ingrese su Telefono", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese su Direccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese su(s) Apellido(s)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su(s) Nombre(s)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void limpiar()
        {
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
        }

        private void BtnRegsitrar_Click(object sender, EventArgs e)
        {
            Boolean validacion = asignacion();
            if (validacion)
            {
                Operaciones operaciones = new Operaciones();
                if(operaciones.RegistrarPaciente(id, nombres, apellidos, fecha, direccion, tel))
                {
                    MessageBox.Show("Registrado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ese id ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiar();
        }
    }
}
