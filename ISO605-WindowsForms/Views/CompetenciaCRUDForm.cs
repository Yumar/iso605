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
        public CompetenciaCRUDForm()
        {
            InitializeComponent();
            dbContext = new ISO605Entities();
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
            this.textBox1.ResetText();
            this.comboBox1.ResetText();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            competencia c = new competencia();
            c.competencia_id = new Guid();
            c.descripcion = textBox1.Text;
            c.estado = comboBox1.Text;
            dbContext.competencias.Add(c);
            dbContext.SaveChanges();
            loadGridData();
        }
    }
}
