namespace ISO605_WindowsForms.Views
{
    partial class UsuarioCRUDForm
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
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idiomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contrasenaText = new System.Windows.Forms.TextBox();
            this.contrasenaText2 = new System.Windows.Forms.TextBox();
            this.usuarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empladoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmacionError = new System.Windows.Forms.Label();
            this.empleadorError = new System.Windows.Forms.Label();
            this.codigoError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigoError);
            this.groupBox1.Controls.Add(this.empleadorError);
            this.groupBox1.Controls.Add(this.confirmacionError);
            this.groupBox1.Controls.Add(this.contrasenaText2);
            this.groupBox1.Controls.Add(this.contrasenaText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.empleadoCombo);
            this.groupBox1.Controls.Add(this.EliminarBtn);
            this.groupBox1.Controls.Add(this.DescripcionLbl);
            this.groupBox1.Controls.Add(this.codigoText);
            this.groupBox1.Controls.Add(this.LimpiarBtn);
            this.groupBox1.Controls.Add(this.GuardarBtn);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(511, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(181, 176);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(100, 28);
            this.EliminarBtn.TabIndex = 6;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(9, 27);
            this.DescripcionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(52, 17);
            this.DescripcionLbl.TabIndex = 3;
            this.DescripcionLbl.Text = "Código";
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(9, 50);
            this.codigoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(216, 22);
            this.codigoText.TabIndex = 2;
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(289, 176);
            this.LimpiarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(100, 28);
            this.LimpiarBtn.TabIndex = 1;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(397, 176);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(100, 28);
            this.GuardarBtn.TabIndex = 0;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(511, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Recargar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioidDataGridViewTextBoxColumn,
            this.codigousuarioDataGridViewTextBoxColumn,
            this.empladoidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idiomaBindingSource
            // 
            this.idiomaBindingSource.DataSource = typeof(ISO605_WindowsForms.Models.idioma);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ISO605_WindowsForms.Models.usuario);
            // 
            // empleadoCombo
            // 
            this.empleadoCombo.FormattingEnabled = true;
            this.empleadoCombo.Location = new System.Drawing.Point(243, 49);
            this.empleadoCombo.Name = "empleadoCombo";
            this.empleadoCombo.Size = new System.Drawing.Size(254, 24);
            this.empleadoCombo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirmación Contraseña";
            // 
            // contrasenaText
            // 
            this.contrasenaText.Location = new System.Drawing.Point(12, 120);
            this.contrasenaText.Name = "contrasenaText";
            this.contrasenaText.PasswordChar = '*';
            this.contrasenaText.Size = new System.Drawing.Size(213, 22);
            this.contrasenaText.TabIndex = 11;
            // 
            // contrasenaText2
            // 
            this.contrasenaText2.Location = new System.Drawing.Point(246, 119);
            this.contrasenaText2.Name = "contrasenaText2";
            this.contrasenaText2.PasswordChar = '*';
            this.contrasenaText2.Size = new System.Drawing.Size(251, 22);
            this.contrasenaText2.TabIndex = 12;
            // 
            // usuarioidDataGridViewTextBoxColumn
            // 
            this.usuarioidDataGridViewTextBoxColumn.DataPropertyName = "usuario_id";
            this.usuarioidDataGridViewTextBoxColumn.FillWeight = 80F;
            this.usuarioidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.usuarioidDataGridViewTextBoxColumn.Name = "usuarioidDataGridViewTextBoxColumn";
            this.usuarioidDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioidDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigousuarioDataGridViewTextBoxColumn
            // 
            this.codigousuarioDataGridViewTextBoxColumn.DataPropertyName = "codigo_usuario";
            this.codigousuarioDataGridViewTextBoxColumn.FillWeight = 80F;
            this.codigousuarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigousuarioDataGridViewTextBoxColumn.Name = "codigousuarioDataGridViewTextBoxColumn";
            this.codigousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigousuarioDataGridViewTextBoxColumn.Width = 80;
            // 
            // empladoidDataGridViewTextBoxColumn
            // 
            this.empladoidDataGridViewTextBoxColumn.DataPropertyName = "empleado.Nombre";
            this.empladoidDataGridViewTextBoxColumn.FillWeight = 250F;
            this.empladoidDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empladoidDataGridViewTextBoxColumn.Name = "empladoidDataGridViewTextBoxColumn";
            this.empladoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.empladoidDataGridViewTextBoxColumn.Width = 250;
            // 
            // confirmacionError
            // 
            this.confirmacionError.AutoSize = true;
            this.confirmacionError.ForeColor = System.Drawing.Color.Maroon;
            this.confirmacionError.Location = new System.Drawing.Point(12, 155);
            this.confirmacionError.Name = "confirmacionError";
            this.confirmacionError.Size = new System.Drawing.Size(301, 17);
            this.confirmacionError.TabIndex = 13;
            this.confirmacionError.Text = "La contraseña no coincide con la confirmación";
            // 
            // empleadorError
            // 
            this.empleadorError.AutoSize = true;
            this.empleadorError.ForeColor = System.Drawing.Color.Maroon;
            this.empleadorError.Location = new System.Drawing.Point(13, 155);
            this.empleadorError.Name = "empleadorError";
            this.empleadorError.Size = new System.Drawing.Size(321, 17);
            this.empleadorError.TabIndex = 14;
            this.empleadorError.Text = "Necesita seleccionar un empleado para continuar";
            // 
            // codigoError
            // 
            this.codigoError.AutoSize = true;
            this.codigoError.ForeColor = System.Drawing.Color.Maroon;
            this.codigoError.Location = new System.Drawing.Point(13, 155);
            this.codigoError.Name = "codigoError";
            this.codigoError.Size = new System.Drawing.Size(181, 17);
            this.codigoError.TabIndex = 15;
            this.codigoError.Text = "Necesita insertar un código";
            // 
            // UsuarioCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsuarioCRUDForm";
            this.Text = "CompetenciaCRUDForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.BindingSource idiomaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox empleadoCombo;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox contrasenaText2;
        private System.Windows.Forms.TextBox contrasenaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empladoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label codigoError;
        private System.Windows.Forms.Label empleadorError;
        private System.Windows.Forms.Label confirmacionError;
    }
}