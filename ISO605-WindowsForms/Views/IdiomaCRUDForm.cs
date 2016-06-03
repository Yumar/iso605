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
    public partial class IdiomaCRUDForm : Form
    {
        private ISO605Entities dbContext;
        private idioma entity;
        public IdiomaCRUDForm()
        {
            InitializeComponent();
            dbContext = new ISO605Entities();
            entity = new idioma();
            loadGridData();
        }

        private void loadGridData() {
            this.dataGridView1.DataSource = this.dbContext.idiomas.ToList<idioma>();
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
            if (this.entity.idioma_id == Guid.Empty)
            {            
                this.entity.idioma_id = Guid.NewGuid();
                dbContext.idiomas.Add(this.entity);
            }
            else {
                idioma c = dbContext.idiomas.Find(this.entity.idioma_id);
                dbContext.Entry(c).CurrentValues.SetValues(this.entity);
            }
            dbContext.SaveChanges();
            
        }
        private void bindFromUI() {
            entity.nombre = textBox1.Text;
            entity.estado = comboBox1.Text;
        }
        private void bindToUI() {
            textBox1.Text = entity.nombre;
            comboBox1.Text = entity.estado;
        }

        private void reset() {
            this.textBox1.ResetText();
            this.comboBox1.ResetText();
            this.entity = new idioma();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (this.entity != null)
            {
                dbContext.idiomas.Remove(this.entity);
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
                this.entity = (idioma)selectedRow.DataBoundItem;
                bindToUI();
            }

        }
    }
}
