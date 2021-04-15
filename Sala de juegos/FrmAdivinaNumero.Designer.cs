
namespace Sala_de_juegos
{
    partial class FrmAdivinaNumero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIntentos = new System.Windows.Forms.CheckBox();
            this.grpNivel = new System.Windows.Forms.GroupBox();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.grpNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Location = new System.Drawing.Point(12, 102);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroIngresado.TabIndex = 0;
            this.txtNumeroIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIngresado_KeyPress);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(156, 179);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(73, 30);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Visible = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Numero";
            // 
            // chkIntentos
            // 
            this.chkIntentos.AutoSize = true;
            this.chkIntentos.Checked = true;
            this.chkIntentos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntentos.Location = new System.Drawing.Point(15, 12);
            this.chkIntentos.Name = "chkIntentos";
            this.chkIntentos.Size = new System.Drawing.Size(106, 17);
            this.chkIntentos.TabIndex = 3;
            this.chkIntentos.Text = "Contar 5 intentos";
            this.chkIntentos.UseVisualStyleBackColor = true;
            // 
            // grpNivel
            // 
            this.grpNivel.Controls.Add(this.rdo20);
            this.grpNivel.Controls.Add(this.rdo10);
            this.grpNivel.Controls.Add(this.rdo5);
            this.grpNivel.Location = new System.Drawing.Point(15, 35);
            this.grpNivel.Name = "grpNivel";
            this.grpNivel.Size = new System.Drawing.Size(214, 48);
            this.grpNivel.TabIndex = 4;
            this.grpNivel.TabStop = false;
            this.grpNivel.Text = "Nivel (hasta que numero)";
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(147, 25);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(37, 17);
            this.rdo20.TabIndex = 2;
            this.rdo20.TabStop = true;
            this.rdo20.Text = "20";
            this.rdo20.UseVisualStyleBackColor = true;
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.Location = new System.Drawing.Point(69, 25);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(37, 17);
            this.rdo10.TabIndex = 1;
            this.rdo10.TabStop = true;
            this.rdo10.Text = "10";
            this.rdo10.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(6, 25);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(31, 17);
            this.rdo5.TabIndex = 0;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(30, 146);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(81, 28);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmAdivinaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 221);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.grpNivel);
            this.Controls.Add(this.chkIntentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Name = "FrmAdivinaNumero";
            this.Text = "FrmAdivinaNumero";
            this.Load += new System.EventHandler(this.FrmAdivinaNumero_Load);
            this.grpNivel.ResumeLayout(false);
            this.grpNivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIntentos;
        private System.Windows.Forms.GroupBox grpNivel;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.Button btnIniciar;
    }
}