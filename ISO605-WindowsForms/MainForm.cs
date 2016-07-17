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
            //this.menuStrip1.Enabled = false;

            //requestLogin();
        }

        private void requestLogin() {
            LoginForm login = new LoginForm();
            DialogResult result;
            result = login.ShowDialog();

            if (result == DialogResult.OK) {
                menuStrip1.Enabled = true;
            }
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

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetenciaCRUDForm competenciaForm = new CompetenciaCRUDForm();
            competenciaForm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioCRUDForm usuarioForm = new UsuarioCRUDForm();
            usuarioForm.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoCandidatoForm candidatoform = new NuevoCandidatoForm();
            candidatoform.Show();
        }
    }
}
