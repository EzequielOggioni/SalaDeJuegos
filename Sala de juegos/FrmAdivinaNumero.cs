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
    public partial class FrmAdivinaNumero : Form
    {


        int numeroSecreto;
        int intentos;

        Random random;
        public FrmAdivinaNumero()
        {
            InitializeComponent();
            random = new Random();
            intentos = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numeroIngresado;
            int numeroAValidar = 0;

            numeroIngresado = this.txtNumeroIngresado.Text;
            if (int.TryParse(numeroIngresado, out numeroAValidar))
            {
                if (numeroAValidar == numeroSecreto)
                {
                    if (MessageBox.Show("Felicitaciones ¿Desea jugar de nuevo?", "Gano", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        btnIniciar_Click(this.btnIniciar, e);
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Intente otro");
                    if (this.chkIntentos.Checked)
                        this.intentos++;

                    if (this.intentos == 5)
                        this.Close();

                }
            }

        }

        private void FrmAdivinaNumero_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.intentos = 0;

            this.chkIntentos.Enabled = false;
            this.grpNivel.Enabled = false;


            int maximo = 0;
            foreach (Control item in this.grpNivel.Controls)
                if (item is RadioButton && ((RadioButton)item).Checked)
                    maximo = int.Parse(((RadioButton)item).Text);


            if (maximo == 0)
                MessageBox.Show("Seleccione un nivel");
            else
            {

                numeroSecreto = random.Next(1, maximo);

                ((Button)sender).Visible = false;
                this.btnVerificar.Visible = true;
            }

        }

        private void txtNumeroIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtNumeroIngresado.Text.Length > 0
    && e.KeyChar == (char)Keys.Enter)
                button1_Click(sender, e);


        }

    }
}
