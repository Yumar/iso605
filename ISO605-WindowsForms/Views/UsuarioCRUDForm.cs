using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISO605_WindowsForms.Models;
using System.Security.Cryptography;

namespace ISO605_WindowsForms.Views
{    
    public partial class UsuarioCRUDForm : Form
    {
        private ISO605Entities dbContext;
        private usuario entity;
        private SHA1CryptoServiceProvider sha1;
        public UsuarioCRUDForm()
        {
            InitializeComponent();

            this.codigoError.Visible = false;
            this.confirmacionError.Visible = false;
            this.empleadorError.Visible = false;

            dbContext = new ISO605Entities();
            entity = new usuario();
            sha1 = new SHA1CryptoServiceProvider();
            loadGridData();
        }

        private void loadGridData() {
            this.dataGridView1.DataSource = this.dbContext.usuarios.ToList<usuario>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadGridData();
        }
        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            guardarActual();
            reset();
            loadGridData();
        }
        private void guardarActual() {
            bindFromUI();
            if (this.entity.usuario_id == Guid.Empty)
            {            
                this.entity.usuario_id = Guid.NewGuid();
                dbContext.usuarios.Add(this.entity);
            }
            else {
                usuario c = dbContext.usuarios.Find(this.entity.usuario_id);
                dbContext.Entry(c).CurrentValues.SetValues(this.entity);
            }
            dbContext.SaveChanges();
            
        }
        private void bindFromUI() {
            if (validate())
            {
                entity.codigo_usuario = codigoText.Text;
                entity.emplado_id = ((empleado)empleadoCombo.SelectedItem).empleado_id;
                var data = sha1.ComputeHash(Encoding.ASCII.GetBytes(contrasenaText.Text));
                entity.contrasena = data;
            }
            
        }
        private void bindToUI() {
            codigoText.Text = entity.codigo_usuario;
            empleadoCombo.SelectedItem = entity.empleado;
        }

        private Boolean validate() {
            this.codigoError.Visible = false;
            this.confirmacionError.Visible = false;
            this.empleadorError.Visible = false;

            if (contrasenaText.Text!= null && contrasenaText.Text != contrasenaText2.Text) {
                confirmacionError.Visible = true;
                return false;
            }

            if(codigoText.Text == null || codigoText.Text == String.Empty)
            {
                codigoError.Visible = true;
                return false;
            }

            if(empleadoCombo.SelectedItem == null)
            {
                empleadorError.Visible = true;
                return false;
            }

            return true;
        }

        private void reset() {
            this.codigoText.ResetText();
            this.contrasenaText.ResetText();
            this.contrasenaText2.ResetText();
            this.empleadoCombo.ResetText();

            this.entity = new usuario();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (this.entity != null)
            {
                dbContext.usuarios.Remove(this.entity);
                dbContext.SaveChanges();
                reset();
                loadGridData();
            }
            else {
                MessageBox.Show("Debe seleccionar un registro para ser eliminado", "No registro seleccionado");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = this.dataGridView1.SelectedRows[0];
                this.entity = (usuario)selectedRow.DataBoundItem;
                bindToUI();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
