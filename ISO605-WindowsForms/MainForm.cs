using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISO605_WindowsForms.Views;

namespace ISO605_WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetenciaCRUDForm competenciaForm = new CompetenciaCRUDForm();
            competenciaForm.Show();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaCRUDForm idiomaForm = new IdiomaCRUDForm();
            idiomaForm.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentoCRUDForm departamentoForm = new DepartamentoCRUDForm();
            departamentoForm.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuestoCRUDForm puestoForm = new PuestoCRUDForm();
            puestoForm.Show();
        }
    }
}
