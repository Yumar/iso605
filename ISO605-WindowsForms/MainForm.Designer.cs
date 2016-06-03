namespace ISO605_WindowsForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacantesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosMenu,
            this.candidatosMenu,
            this.vacantesMenu,
            this.mantenimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosMenu
            // 
            this.empleadosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.empleadosMenu.Name = "empleadosMenu";
            this.empleadosMenu.Size = new System.Drawing.Size(77, 20);
            this.empleadosMenu.Text = "Empleados";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.crearToolStripMenuItem.Text = "Nuevo";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.modificarToolStripMenuItem.Text = "Lista";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // candidatosMenu
            // 
            this.candidatosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.candidatosMenu.Name = "candidatosMenu";
            this.candidatosMenu.Size = new System.Drawing.Size(79, 20);
            this.candidatosMenu.Text = "Candidatos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // vacantesMenu
            // 
            this.vacantesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.listaToolStripMenuItem1});
            this.vacantesMenu.Name = "vacantesMenu";
            this.vacantesMenu.Size = new System.Drawing.Size(65, 20);
            this.vacantesMenu.Text = "Vacantes";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.listaToolStripMenuItem1.Text = "Lista";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.competenciasToolStripMenuItem,
            this.idiomasToolStripMenuItem,
            this.capacitacionesToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.departamentosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            this.competenciasToolStripMenuItem.Click += new System.EventHandler(this.competenciasToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // capacitacionesToolStripMenuItem
            // 
            this.capacitacionesToolStripMenuItem.Name = "capacitacionesToolStripMenuItem";
            this.capacitacionesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.capacitacionesToolStripMenuItem.Text = "Capacitaciones";
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.puestosToolStripMenuItem.Text = "Puestos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 401);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosMenu;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosMenu;
        private System.Windows.Forms.ToolStripMenuItem vacantesMenu;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

