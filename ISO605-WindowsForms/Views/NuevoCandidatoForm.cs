using ISO605_WindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO605_WindowsForms.Views
{
    public partial class NuevoCandidatoForm : Form
    {
        private class CompetenciaCheck
        {
            public Guid id { get; set; }
            public String descripcion { get; set; }
            public bool isChecked { get; set; }
        }

        private candidato entity;
        private ISO605Entities dbContext;
        public NuevoCandidatoForm()
        {
            InitializeComponent();

            dbContext = new ISO605Entities();
            this.entity = new candidato();
            initCheckList();

            recomendadoCombo.DataSource = dbContext.empleadoes.ToList<empleado>();
            posicionCombo.DataSource = dbContext.posicions.ToList<posicion>();

        }

        private void initCheckList()
        {
            List<competencia> competencias = dbContext.competencias.ToList<competencia>();
            List<CompetenciaCheck> competenciasChek = new List<CompetenciaCheck>();
            foreach(competencia c in competencias)
            {
                CompetenciaCheck comp = new CompetenciaCheck();
                comp.descripcion = c.descripcion;
                comp.id = c.competencia_id;
                comp.isChecked = false;
                competenciasChek.Add(comp);
            }

            ((ListBox)competenciasList).DataSource = competenciasChek;
            ((ListBox)this.competenciasList).DisplayMember = "descripcion";
            ((ListBox)this.competenciasList).ValueMember = "isChecked";
        }

        private List<competencia> getCompetenciasChecked()
        {
            List<competencia> result = new List<competencia>();

            foreach (object itemChecked in competenciasList.CheckedItems)
            {
                competencia c = new competencia();
                c.competencia_id = ((CompetenciaCheck)itemChecked).id;
                result.Add(c);
            }

            return result;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindFromUI()
        {
            this.entity.cedula = cedulaText.Text;
            entity.nombre = nombreText.Text;
            entity.salario_aspira = Decimal.Parse(salarioText.Text);
            entity.posicion_aspira = (Guid)posicionCombo.SelectedValue;
            entity.empleado_recomienda = (Guid)recomendadoCombo.SelectedValue;

            //agregados
            entity.experiencia_laboral = (List<experiencia_laboral>)experienciaGrid.DataSource;
            entity.competencias = com

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
