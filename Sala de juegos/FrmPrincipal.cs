using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala_de_juegos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            this.InitializeComponent();


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)

        {
            MessageBox.Show("¿esta seguro?", "Titulo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿esta seguro?", "Titulo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {


            // this.txtNombre.Text
            //this.Close();
        }

        private void btnAdivinaNumero_Click(object sender, EventArgs e)
        {
            bool inicio = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmAdivinaNumero)
                    inicio = true;

            }
            if (!inicio)
            {

                FrmAdivinaNumero frmAdivinaNumero = new FrmAdivinaNumero();
                frmAdivinaNumero.MdiParent = this;
                frmAdivinaNumero.Show();

            }
        }
    }
}
