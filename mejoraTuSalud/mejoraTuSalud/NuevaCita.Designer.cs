namespace mejoraTuSalud
{
    partial class NuevaCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCita));
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblTipoDeCita = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.cbxTipoCita = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblFechaDeCita = new System.Windows.Forms.Label();
            this.dtpFechaDeLaCita = new System.Windows.Forms.DateTimePicker();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.cbxAmPm = new System.Windows.Forms.ComboBox();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.nudMinuto = new System.Windows.Forms.NumericUpDown();
            this.lblDospuntos = new System.Windows.Forms.Label();
            this.lblHoraDeLaCita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPaciente
            // 
            resources.ApplyResources(this.lblIdPaciente, "lblIdPaciente");
            this.lblIdPaciente.Name = "lblIdPaciente";
            // 
            // lblTipoDeCita
            // 
            resources.ApplyResources(this.lblTipoDeCita, "lblTipoDeCita");
            this.lblTipoDeCita.Name = "lblTipoDeCita";
            // 
            // txtIdPaciente
            // 
            resources.ApplyResources(this.txtIdPaciente, "txtIdPaciente");
            this.txtIdPaciente.Name = "txtIdPaciente";
            // 
            // cbxTipoCita
            // 
            resources.ApplyResources(this.cbxTipoCita, "cbxTipoCita");
            this.cbxTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCita.FormattingEnabled = true;
            this.cbxTipoCita.Items.AddRange(new object[] {
            resources.GetString("cbxTipoCita.Items"),
            resources.GetString("cbxTipoCita.Items1"),
            resources.GetString("cbxTipoCita.Items2"),
            resources.GetString("cbxTipoCita.Items3")});
            this.cbxTipoCita.Name = "cbxTipoCita";
            this.cbxTipoCita.TextChanged += new System.EventHandler(this.CbxTipoCita_TextChanged);
            // 
            // lblMedico
            // 
            resources.ApplyResources(this.lblMedico, "lblMedico");
            this.lblMedico.Name = "lblMedico";
            // 
            // cbxMedico
            // 
            resources.ApplyResources(this.cbxMedico, "cbxMedico");
            this.cbxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.TextChanged += new System.EventHandler(this.CbxMedico_TextChanged);
            // 
            // btnAsignar
            // 
            resources.ApplyResources(this.btnAsignar, "btnAsignar");
            this.btnAsignar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // lblFechaDeCita
            // 
            resources.ApplyResources(this.lblFechaDeCita, "lblFechaDeCita");
            this.lblFechaDeCita.Name = "lblFechaDeCita";
            // 
            // dtpFechaDeLaCita
            // 
            resources.ApplyResources(this.dtpFechaDeLaCita, "dtpFechaDeLaCita");
            this.dtpFechaDeLaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeLaCita.MinDate = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            this.dtpFechaDeLaCita.Name = "dtpFechaDeLaCita";
            this.dtpFechaDeLaCita.Value = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            // 
            // lblIdMedico
            // 
            resources.ApplyResources(this.lblIdMedico, "lblIdMedico");
            this.lblIdMedico.Name = "lblIdMedico";
            // 
            // txtIdMedico
            // 
            resources.ApplyResources(this.txtIdMedico, "txtIdMedico");
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            // 
            // cbxAmPm
            // 
            resources.ApplyResources(this.cbxAmPm, "cbxAmPm");
            this.cbxAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAmPm.FormattingEnabled = true;
            this.cbxAmPm.Items.AddRange(new object[] {
            resources.GetString("cbxAmPm.Items"),
            resources.GetString("cbxAmPm.Items1")});
            this.cbxAmPm.Name = "cbxAmPm";
            // 
            // nudHora
            // 
            resources.ApplyResources(this.nudHora, "nudHora");
            this.nudHora.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            // 
            // nudMinuto
            // 
            resources.ApplyResources(this.nudMinuto, "nudMinuto");
            this.nudMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuto.Name = "nudMinuto";
            // 
            // lblDospuntos
            // 
            resources.ApplyResources(this.lblDospuntos, "lblDospuntos");
            this.lblDospuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblDospuntos.Name = "lblDospuntos";
            // 
            // lblHoraDeLaCita
            // 
            resources.ApplyResources(this.lblHoraDeLaCita, "lblHoraDeLaCita");
            this.lblHoraDeLaCita.Name = "lblHoraDeLaCita";
            // 
            // NuevaCita
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.Controls.Add(this.lblHoraDeLaCita);
            this.Controls.Add(this.lblDospuntos);
            this.Controls.Add(this.nudMinuto);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.cbxAmPm);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(this.dtpFechaDeLaCita);
            this.Controls.Add(this.lblFechaDeCita);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cbxMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.cbxTipoCita);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lblTipoDeCita);
            this.Controls.Add(this.lblIdPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NuevaCita";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label lblTipoDeCita;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.ComboBox cbxTipoCita;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblFechaDeCita;
        private System.Windows.Forms.DateTimePicker dtpFechaDeLaCita;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.ComboBox cbxAmPm;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.NumericUpDown nudMinuto;
        private System.Windows.Forms.Label lblDospuntos;
        private System.Windows.Forms.Label lblHoraDeLaCita;
    }
}