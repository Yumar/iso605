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
    public partial class CompetenciaCRUDForm : Form
    {
        private ISO605Entities dbContext;
        private competencia entity;
        public CompetenciaCRUDForm()
        {
            InitializeComponent();
            dbContext = new ISO605Entities();
            entity = new competencia();
            loadGridData();     
        }

        private void loadGridData() {
            this.dataGridView1.DataSource = this.dbContext.competencias.ToList();
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
            guardarCompetenciaActual();
            reset();
            loadGridData();
        }

        private void guardarCompetenciaActual() {
            bindFromUI();
            if (this.entity.competencia_id == Guid.Empty)
            {            
                this.entity.competencia_id = Guid.NewGuid();
                dbContext.competencias.Add(this.entity);
            }
            else {
                competencia c = dbContext.competencias.Find(this.entity.competencia_id);
                dbContext.Entry(c).CurrentValues.SetValues(this.entity);
            }
            dbContext.SaveChanges();
            
        }

        private void bindFromUI() {
            entity.descripcion = textBox1.Text;
            entity.estado = comboBox1.Text;
        }
        private void bindToUI() {
            textBox1.Text = entity.descripcion;
            comboBox1.Text = entity.estado;
        }

        private void reset() {
            this.textBox1.ResetText();
            this.comboBox1.ResetText();
            this.entity = new competencia();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
