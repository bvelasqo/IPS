namespace mejoraTuSalud
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCitasIncumplidas = new System.Windows.Forms.Button();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.lblMultas = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelarCita);
            this.splitContainer1.Panel1.Controls.Add(this.btnAsistencia);
            this.splitContainer1.Panel1.Controls.Add(this.btnCitasIncumplidas);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdPaciente);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.btnHistorial);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnMultas);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.lblMultas);
            this.splitContainer1.Panel2.Controls.Add(this.lbl);
            this.splitContainer1.Panel2.Controls.Add(this.lblPesos);
            this.splitContainer1.Panel2.Controls.Add(this.lblValorAPagar);
            this.splitContainer1.Panel2.Controls.Add(this.btnPagar);
            this.splitContainer1.Panel2.Controls.Add(this.dgvControl);
            // 
            // btnCancelarCita
            // 
            resources.ApplyResources(this.btnCancelarCita, "btnCancelarCita");
            this.btnCancelarCita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            this.btnCancelarCita.Click += new System.EventHandler(this.BtnCancelarCita_Click);
            // 
            // btnAsistencia
            // 
            resources.ApplyResources(this.btnAsistencia, "btnAsistencia");
            this.btnAsistencia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // btnCitasIncumplidas
            // 
            resources.ApplyResources(this.btnCitasIncumplidas, "btnCitasIncumplidas");
            this.btnCitasIncumplidas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCitasIncumplidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasIncumplidas.Name = "btnCitasIncumplidas";
            this.btnCitasIncumplidas.UseVisualStyleBackColor = false;
            this.btnCitasIncumplidas.Click += new System.EventHandler(this.BtnCitasIncumplidas_Click);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.AcceptsReturn = true;
            this.txtIdPaciente.AcceptsTab = true;
            resources.ApplyResources(this.txtIdPaciente, "txtIdPaciente");
            this.txtIdPaciente.Name = "txtIdPaciente";
            // 
            // lblIdUsuario
            // 
            resources.ApplyResources(this.lblIdUsuario, "lblIdUsuario");
            this.lblIdUsuario.AllowDrop = true;
            this.lblIdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblIdUsuario.Name = "lblIdUsuario";
            // 
            // btnHistorial
            // 
            resources.ApplyResources(this.btnHistorial, "btnHistorial");
            this.btnHistorial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnMultas
            // 
            resources.ApplyResources(this.btnMultas, "btnMultas");
            this.btnMultas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.UseVisualStyleBackColor = false;
            this.btnMultas.Click += new System.EventHandler(this.BtnMultas_Click);
            // 
            // lblMultas
            // 
            resources.ApplyResources(this.lblMultas, "lblMultas");
            this.lblMultas.Name = "lblMultas";
            // 
            // lbl
            // 
            resources.ApplyResources(this.lbl, "lbl");
            this.lbl.Name = "lbl";
            // 
            // lblPesos
            // 
            resources.ApplyResources(this.lblPesos, "lblPesos");
            this.lblPesos.Name = "lblPesos";
            // 
            // lblValorAPagar
            // 
            resources.ApplyResources(this.lblValorAPagar, "lblValorAPagar");
            this.lblValorAPagar.Name = "lblValorAPagar";
            // 
            // btnPagar
            // 
            resources.ApplyResources(this.btnPagar, "btnPagar");
            this.btnPagar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // dgvControl
            // 
            resources.ApplyResources(this.dgvControl, "dgvControl");
            this.dgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControl.GridColor = System.Drawing.Color.White;
            this.dgvControl.Name = "dgvControl";
            this.dgvControl.ReadOnly = true;
            // 
            // Control
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Control";
            this.ShowIcon = false;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCitasIncumplidas;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvControl;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblMultas;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCancelarCita;
    }
}