namespace mejoraTuSalud
{
    partial class RegistrarPacientecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPacientecs));
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.FHN = new System.Windows.Forms.DateTimePicker();
            this.btnRegsitrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Name = "lblID";
            // 
            // lblNombres
            // 
            resources.ApplyResources(this.lblNombres, "lblNombres");
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Name = "lblNombres";
            // 
            // lblApellidos
            // 
            resources.ApplyResources(this.lblApellidos, "lblApellidos");
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Name = "lblApellidos";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // lblDireccion
            // 
            resources.ApplyResources(this.lblDireccion, "lblDireccion");
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Name = "lblDireccion";
            // 
            // lblTelefono
            // 
            resources.ApplyResources(this.lblTelefono, "lblTelefono");
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Name = "lblTelefono";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // txtNombres
            // 
            resources.ApplyResources(this.txtNombres, "txtNombres");
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            resources.ApplyResources(this.txtApellidos, "txtApellidos");
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress);
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // txtTelefono
            // 
            resources.ApplyResources(this.txtTelefono, "txtTelefono");
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // FHN
            // 
            resources.ApplyResources(this.FHN, "FHN");
            this.FHN.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.FHN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FHN.Name = "FHN";
            // 
            // btnRegsitrar
            // 
            resources.ApplyResources(this.btnRegsitrar, "btnRegsitrar");
            this.btnRegsitrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegsitrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegsitrar.Name = "btnRegsitrar";
            this.btnRegsitrar.UseVisualStyleBackColor = false;
            this.btnRegsitrar.Click += new System.EventHandler(this.BtnRegsitrar_Click);
            // 
            // RegistrarPacientecs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.Controls.Add(this.btnRegsitrar);
            this.Controls.Add(this.FHN);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegistrarPacientecs";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker FHN;
        private System.Windows.Forms.Button btnRegsitrar;
    }
}