namespace mejoraTuSalud
{
    partial class Medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medico));
            this.btnVerPago = new System.Windows.Forms.Button();
            this.gbxNuevosDatos = new System.Windows.Forms.GroupBox();
            this.lblAnosExperiencia = new System.Windows.Forms.Label();
            this.lblSalarioCita = new System.Windows.Forms.Label();
            this.btnActualizarEsperiencia = new System.Windows.Forms.Button();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.btnActualizarSalario = new System.Windows.Forms.Button();
            this.txtSalarioCita = new System.Windows.Forms.TextBox();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.gbxNuevosDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerPago
            // 
            resources.ApplyResources(this.btnVerPago, "btnVerPago");
            this.btnVerPago.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPago.Name = "btnVerPago";
            this.btnVerPago.UseVisualStyleBackColor = false;
            this.btnVerPago.Click += new System.EventHandler(this.BtnVerPago_Click);
            // 
            // gbxNuevosDatos
            // 
            resources.ApplyResources(this.gbxNuevosDatos, "gbxNuevosDatos");
            this.gbxNuevosDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbxNuevosDatos.Controls.Add(this.lblAnosExperiencia);
            this.gbxNuevosDatos.Controls.Add(this.lblSalarioCita);
            this.gbxNuevosDatos.Controls.Add(this.btnActualizarEsperiencia);
            this.gbxNuevosDatos.Controls.Add(this.txtExperiencia);
            this.gbxNuevosDatos.Controls.Add(this.btnActualizarSalario);
            this.gbxNuevosDatos.Controls.Add(this.txtSalarioCita);
            this.gbxNuevosDatos.Name = "gbxNuevosDatos";
            this.gbxNuevosDatos.TabStop = false;
            // 
            // lblAnosExperiencia
            // 
            resources.ApplyResources(this.lblAnosExperiencia, "lblAnosExperiencia");
            this.lblAnosExperiencia.Name = "lblAnosExperiencia";
            // 
            // lblSalarioCita
            // 
            resources.ApplyResources(this.lblSalarioCita, "lblSalarioCita");
            this.lblSalarioCita.Name = "lblSalarioCita";
            // 
            // btnActualizarEsperiencia
            // 
            resources.ApplyResources(this.btnActualizarEsperiencia, "btnActualizarEsperiencia");
            this.btnActualizarEsperiencia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizarEsperiencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEsperiencia.Name = "btnActualizarEsperiencia";
            this.btnActualizarEsperiencia.UseVisualStyleBackColor = false;
            this.btnActualizarEsperiencia.Click += new System.EventHandler(this.BtnActualizarEsperiencia_Click);
            // 
            // txtExperiencia
            // 
            resources.ApplyResources(this.txtExperiencia, "txtExperiencia");
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExperiencia_KeyPress);
            // 
            // btnActualizarSalario
            // 
            resources.ApplyResources(this.btnActualizarSalario, "btnActualizarSalario");
            this.btnActualizarSalario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizarSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarSalario.Name = "btnActualizarSalario";
            this.btnActualizarSalario.UseVisualStyleBackColor = false;
            this.btnActualizarSalario.Click += new System.EventHandler(this.BtnActualizarSalario_Click);
            // 
            // txtSalarioCita
            // 
            resources.ApplyResources(this.txtSalarioCita, "txtSalarioCita");
            this.txtSalarioCita.Name = "txtSalarioCita";
            this.txtSalarioCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalarioCita_KeyPress);
            // 
            // lblIdMedico
            // 
            resources.ApplyResources(this.lblIdMedico, "lblIdMedico");
            this.lblIdMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblIdMedico.Name = "lblIdMedico";
            // 
            // txtIdMedico
            // 
            resources.ApplyResources(this.txtIdMedico, "txtIdMedico");
            this.txtIdMedico.Name = "txtIdMedico";
            // 
            // Medico
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(this.gbxNuevosDatos);
            this.Controls.Add(this.btnVerPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Medico";
            this.ShowIcon = false;
            this.gbxNuevosDatos.ResumeLayout(false);
            this.gbxNuevosDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerPago;
        private System.Windows.Forms.GroupBox gbxNuevosDatos;
        private System.Windows.Forms.Label lblAnosExperiencia;
        private System.Windows.Forms.Label lblSalarioCita;
        private System.Windows.Forms.Button btnActualizarEsperiencia;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.Button btnActualizarSalario;
        private System.Windows.Forms.TextBox txtSalarioCita;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
    }
}