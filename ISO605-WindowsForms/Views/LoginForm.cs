using ISO605_WindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO605_WindowsForms.Views
{
    public partial class LoginForm : Form
    {
        private ISO605Entities dbContext;
        private SHA1CryptoServiceProvider sha1;
        public LoginForm()
        {
            InitializeComponent();
            sha1 = new SHA1CryptoServiceProvider();
            dbContext = new ISO605Entities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            String codigo = codigoText.Text;

            if (autenticar(codigoText.Text, sha1.ComputeHash(Encoding.ASCII.GetBytes(contrasenaText.Text))))
            {
                DialogResult = DialogResult.OK;
            }
            else {
                label4.Text = "Código o contraseña incorrectos";
            }
        }

        private Boolean autenticar(String codigo, byte[] contrasena) {
            var user = dbContext.usuarios
                       .Where(u => u.codigo_usuario.Equals(codigo))
                       .FirstOrDefault();

            return user != null && user.contrasena.Equals(contrasena);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
