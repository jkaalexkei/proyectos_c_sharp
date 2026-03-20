using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="Admin" && txtClave.Text=="123" )
            {
                //MessageBox.Show("Bienvenido al sistema");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
