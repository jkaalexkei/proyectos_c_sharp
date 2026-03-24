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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string metodoPago = "";
            List<string> list = new List<string>();
            if(chkMac.Checked == true)  
            {
                list.Add(chkMac.Text);

            }
            if(chkXiami.Checked == true)
            {
                list.Add(chkXiami.Text);
            }

            if (rdbPayPal.Checked == true)
            {
                metodoPago = rdbPayPal.Text;
            }else if(rdbTarjetaCredito.Checked == true)
            {
                metodoPago = rdbTarjetaCredito.Text;
            }
            else
            {
                metodoPago = "No se selecciono metodo de pago";
            }

            MessageBox.Show("Articulos seleccionados: " + string.Join(" , ",list) + " Metodo Pago: " + metodoPago);

            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMac_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
