namespace mejoraTuSalud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jasdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoIPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.médicoToolStripMenuItem,
            this.empleadoIPSToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 10, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(107, 558);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jasdvToolStripMenuItem,
            this.registrarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(104, 54);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // jasdvToolStripMenuItem
            // 
            this.jasdvToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.jasdvToolStripMenuItem.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.jasdvToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jasdvToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.jasdvToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Aqua;
            this.jasdvToolStripMenuItem.Name = "jasdvToolStripMenuItem";
            this.jasdvToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.jasdvToolStripMenuItem.Text = "Control";
            this.jasdvToolStripMenuItem.Click += new System.EventHandler(this.JasdvToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.RegistrarToolStripMenuItem_Click);
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(104, 54);
            this.médicoToolStripMenuItem.Text = "Médico";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.MédicoToolStripMenuItem_Click);
            // 
            // empleadoIPSToolStripMenuItem
            // 
            this.empleadoIPSToolStripMenuItem.Name = "empleadoIPSToolStripMenuItem";
            this.empleadoIPSToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.empleadoIPSToolStripMenuItem.Size = new System.Drawing.Size(104, 54);
            this.empleadoIPSToolStripMenuItem.Text = "Nueva Cita";
            this.empleadoIPSToolStripMenuItem.Click += new System.EventHandler(this.EmpleadoIPSToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::mejoraTuSalud.Properties.Resources.Salud_mundo_G20_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 558);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEJORA TU SALUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoIPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jasdvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

