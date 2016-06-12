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
    public partial class PuestoCRUDForm : Form
    {
        private posicion entity;
        private ISO605Entities dbContext;
        public PuestoCRUDForm()
        {
            InitializeComponent();
            dbContext = new ISO605Entities();
            entity = new posicion();
            loadList();
            departamentoCombo.DataSource = dbContext.departamentoes.ToList<departamento>();
        }

        private void loadList() {
            puestosTable.DataSource = dbContext.posicions.ToList<posicion>();
        }
        private void bindFromUI() {
            entity.departamento = (Guid)this.departamentoCombo.SelectedValue;
            entity.estado = this.estadoCombo.Text;
            entity.nombre = this.nombreField.Text;
            entity.riesgo = this.riesgoCombo.SelectedIndex;
            entity.salario_maximo = Decimal.Parse(this.salarioMaximoField.Text);
            entity.salario_minimo = Decimal.Parse(this.salarioMinimoField.Text);
        }

        private void bindToUI() {
            this.departamentoCombo.SelectedValue = entity.departamento;
            this.estadoCombo.SelectedText = entity.estado;
            this.nombreField.Text = entity.nombre;
            this.riesgoCombo.SelectedIndex = int.Parse(entity.riesgo.ToString());
            this.salarioMaximoField.Text = entity.salario_maximo.ToString();
            this.salarioMinimoField.Text = entity.salario_minimo.ToString();
        }

        private void reset() {
            entity = new posicion();
            this.departamentoCombo.ResetText();
            this.estadoCombo.ResetText();
            this.nombreField.ResetText();
            this.riesgoCombo.ResetText();
            this.salarioMaximoField.ResetText();
            this.salarioMinimoField.ResetText();
        }

        private void guardar() {
            bindFromUI();
            if (entity.posicion_id == Guid.Empty)
            {
                entity.posicion_id = Guid.NewGuid();
                dbContext.posicions.Add(entity);
            }
            else {
                posicion c = dbContext.posicions.Find(this.entity.posicion_id);
                dbContext.Entry(c).CurrentValues.SetValues(this.entity);
            }
            dbContext.SaveChanges();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // toy jarto de borrar esto cada vez que le doy click a la pantalla!!
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            guardar();
            reset();
            loadList();
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (this.entity != null)
            {
                dbContext.posicions.Remove(this.entity);
                dbContext.SaveChanges();
                reset();
                loadList();
            }
            else {
                MessageBox.Show("Debe seleccionar un registro para ser eliminado", "No registro seleccionado");
            }
        }
    }
}
