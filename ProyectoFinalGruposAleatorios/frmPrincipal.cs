using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GruposAleatoriosLibreria.GruposAleatorioLibreria;

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

        /// <summary> boton btnGenerarGrupos_Click para generar los grupos aleatoris.</summary>
        /// <param name="sender">Recurso del evento.</param>
        /// <param name="e">La <see cref="EventArgs" /> instacia que contiene la inforamción del evento.</param>
        private void btnGenerarGrupos_Click(object sender, EventArgs e)
        {

            // Obtiene los nombres dentro de un array.
            int num_people = listBox1.Items.Count;
            string[] names = new string[num_people];
            listBox1.Items.CopyTo(names, 0);

            // Llama a la función de Randomize, que coloca de forma aleatoria los nombres.
            Randomizer.Randomize(names);

            frmResultado Resultado = new frmResultado();
            //Obtiene la cantidad de grupos.
            int num_groups = int.Parse(txtGruposCantidad.Text);

            // a, incremental del limite de grupos.
            // i, posicion de los nombres de participantes en el array.
            // limite, resulatdo aproximado de cuantas personas son por grupo.
            int a = 1;
            int i = 0;
            float limite = num_people / num_groups;

            //bucle que genera los grupos en el formulario resultados
            do
            {
                // genera los nombres de los grupos
                ListViewGroup grupos = new ListViewGroup("Grupo N°" + a + ": ", HorizontalAlignment.Left);
                //asigna a los integrantes al grupo 
                for (double b = 0; b < limite; b++)
                {


                    Resultado.listView1.Items.Add(new ListViewItem(names[i], grupos));

                    i++;
                }

                Resultado.listView1.Groups.Add(grupos);
                a++;
                //agregar el participante sobrante al ultimo grupo
                if (num_people % num_groups != 0 && a == num_groups)
                {

                    limite = limite + 1;

                }

            } while (a <= num_groups);


            Resultado.ShowDialog();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
