using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGruposAleatorios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            /// <value name="participante">
            ///   nombre del participante <br />
            /// </value>
            String participante;

            participante = textBox1.Text;
            /// validacion de textbox del participante
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Ingrese un participante.", "Aviso");
            }
            else
            {
                listBox1.Items.Add(participante);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
    }
}
