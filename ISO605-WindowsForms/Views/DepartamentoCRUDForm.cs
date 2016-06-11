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

namespace ISO605_WindowsForms.Views
{    
    public partial class DepartamentoCRUDForm : Form
    {
        private ISO605Entities dbContext;
        private departamento entity;
        private List<departamento> departamentos;
        public DepartamentoCRUDForm()
        {
            InitializeComponent();
            dbContext = new ISO605Entities();
            entity = new departamento();            
            loadGridData();
        }

        private void loadGridData() {
            departamentos = this.dbContext.departamentoes.ToList<departamento>();
            this.dataGridView1.DataSource = departamentos;

            departamentos.Remove(entity);
            comboBox1.DataSource = departamentos;
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
            if (this.entity.departamento_id == Guid.Empty)
            {            
                this.entity.departamento_id = Guid.NewGuid();
                dbContext.departamentoes.Add(this.entity);
            }
            else {
                departamento c = dbContext.departamentoes.Find(this.entity.departamento_id);
                dbContext.Entry(c).CurrentValues.SetValues(this.entity);
            }
            dbContext.SaveChanges();
            
        }
        private void bindFromUI() {
            entity.descripcion = textBox1.Text;

            if(comboBox1.SelectedItem != null)
            {
                entity.dependencia = ((Guid)comboBox1.SelectedItem);
            }
            
        }
        private void bindToUI() {
            textBox1.Text = entity.descripcion;
            comboBox1.SelectedItem = entity.dependencia;
        }

        private void reset() {
            this.textBox1.ResetText();
            this.comboBox1.ResetText();
            this.entity = new departamento();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (this.entity != null)
            {
                dbContext.departamentoes.Remove(this.entity);
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
                this.entity = (departamento)selectedRow.DataBoundItem;
                bindToUI();
            }

        }
    }
}
