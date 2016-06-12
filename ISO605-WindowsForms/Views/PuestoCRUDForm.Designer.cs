namespace ISO605_WindowsForms.Views
{
    partial class PuestoCRUDForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.riesgoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salarioMinimoField = new System.Windows.Forms.TextBox();
            this.salarioMaximoField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departamentoCombo = new System.Windows.Forms.ComboBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puestosTable = new System.Windows.Forms.DataGridView();
            this.posicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riesgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariominimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariomaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eliminarBtn);
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.guardarBtn);
            this.groupBox1.Controls.Add(this.departamentoCombo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.salarioMaximoField);
            this.groupBox1.Controls.Add(this.salarioMinimoField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.estadoCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.riesgoCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puesto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.puestosTable);
            this.groupBox2.Location = new System.Drawing.Point(13, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Puestos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreField
            // 
            this.nombreField.Location = new System.Drawing.Point(10, 37);
            this.nombreField.Name = "nombreField";
            this.nombreField.Size = new System.Drawing.Size(263, 20);
            this.nombreField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nivel de Riesgo";
            // 
            // riesgoCombo
            // 
            this.riesgoCombo.FormattingEnabled = true;
            this.riesgoCombo.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.riesgoCombo.Location = new System.Drawing.Point(279, 37);
            this.riesgoCombo.Name = "riesgoCombo";
            this.riesgoCombo.Size = new System.Drawing.Size(121, 21);
            this.riesgoCombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // estadoCombo
            // 
            this.estadoCombo.FormattingEnabled = true;
            this.estadoCombo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estadoCombo.Location = new System.Drawing.Point(406, 37);
            this.estadoCombo.Name = "estadoCombo";
            this.estadoCombo.Size = new System.Drawing.Size(128, 21);
            this.estadoCombo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salario Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salario Maximo";
            // 
            // salarioMinimoField
            // 
            this.salarioMinimoField.Location = new System.Drawing.Point(13, 90);
            this.salarioMinimoField.Name = "salarioMinimoField";
            this.salarioMinimoField.Size = new System.Drawing.Size(156, 20);
            this.salarioMinimoField.TabIndex = 8;
            // 
            // salarioMaximoField
            // 
            this.salarioMaximoField.Location = new System.Drawing.Point(175, 89);
            this.salarioMaximoField.Name = "salarioMaximoField";
            this.salarioMaximoField.Size = new System.Drawing.Size(152, 20);
            this.salarioMaximoField.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departamento";
            // 
            // departamentoCombo
            // 
            this.departamentoCombo.DataSource = this.departamentoBindingSource;
            this.departamentoCombo.DisplayMember = "descripcion";
            this.departamentoCombo.FormattingEnabled = true;
            this.departamentoCombo.Location = new System.Drawing.Point(333, 89);
            this.departamentoCombo.Name = "departamentoCombo";
            this.departamentoCombo.Size = new System.Drawing.Size(201, 21);
            this.departamentoCombo.TabIndex = 11;
            this.departamentoCombo.ValueMember = "departamento_id";
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(459, 130);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 12;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(378, 130);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 13;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(297, 130);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 14;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataSource = typeof(ISO605_WindowsForms.Models.departamento);
            // 
            // puestosTable
            // 
            this.puestosTable.AllowUserToAddRows = false;
            this.puestosTable.AllowUserToDeleteRows = false;
            this.puestosTable.AutoGenerateColumns = false;
            this.puestosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puestosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.riesgoDataGridViewTextBoxColumn,
            this.salariominimoDataGridViewTextBoxColumn,
            this.salariomaximoDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.puestosTable.DataSource = this.posicionBindingSource;
            this.puestosTable.Location = new System.Drawing.Point(7, 20);
            this.puestosTable.Name = "puestosTable";
            this.puestosTable.ReadOnly = true;
            this.puestosTable.Size = new System.Drawing.Size(526, 245);
            this.puestosTable.TabIndex = 0;
            // 
            // posicionBindingSource
            // 
            this.posicionBindingSource.DataSource = typeof(ISO605_WindowsForms.Models.posicion);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // riesgoDataGridViewTextBoxColumn
            // 
            this.riesgoDataGridViewTextBoxColumn.DataPropertyName = "riesgo";
            this.riesgoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.riesgoDataGridViewTextBoxColumn.HeaderText = "Nivel Riesgo";
            this.riesgoDataGridViewTextBoxColumn.Name = "riesgoDataGridViewTextBoxColumn";
            this.riesgoDataGridViewTextBoxColumn.ReadOnly = true;
            this.riesgoDataGridViewTextBoxColumn.Width = 70;
            // 
            // salariominimoDataGridViewTextBoxColumn
            // 
            this.salariominimoDataGridViewTextBoxColumn.DataPropertyName = "salario_minimo";
            this.salariominimoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.salariominimoDataGridViewTextBoxColumn.HeaderText = "Salario Minimo";
            this.salariominimoDataGridViewTextBoxColumn.Name = "salariominimoDataGridViewTextBoxColumn";
            this.salariominimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.salariominimoDataGridViewTextBoxColumn.Width = 70;
            // 
            // salariomaximoDataGridViewTextBoxColumn
            // 
            this.salariomaximoDataGridViewTextBoxColumn.DataPropertyName = "salario_maximo";
            this.salariomaximoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.salariomaximoDataGridViewTextBoxColumn.HeaderText = "Salario Maximo";
            this.salariomaximoDataGridViewTextBoxColumn.Name = "salariomaximoDataGridViewTextBoxColumn";
            this.salariomaximoDataGridViewTextBoxColumn.ReadOnly = true;
            this.salariomaximoDataGridViewTextBoxColumn.Width = 70;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "departamento";
            this.departamentoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoDataGridViewTextBoxColumn.Width = 120;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.FillWeight = 55F;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 55;
            // 
            // PuestoCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PuestoCRUDForm";
            this.Text = "Puestos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.ComboBox departamentoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salarioMaximoField;
        private System.Windows.Forms.TextBox salarioMinimoField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox estadoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox riesgoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private System.Windows.Forms.DataGridView puestosTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riesgoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariominimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariomaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource posicionBindingSource;
    }
}