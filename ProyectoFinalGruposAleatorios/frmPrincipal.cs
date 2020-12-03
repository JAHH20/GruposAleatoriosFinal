using System;
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
            int limite = num_people / num_groups;

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

        /// <summary>>boton btnEliminar_Click elemina un participante de la listbox.</summary>
        /// <param name="sender">Recurso del evento.</param>
        /// <param name="e">La <see cref="EventArgs" /> instacia que contiene la inforamción del evento.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /// validacion para eliminar elementos
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }

        }

        /// <summary>boton pegar, para pegar en el listbox el contenido copiado.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            
            //valida si existe datos en la memoria para copiar
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                //convierte en cadena la informacion copiada
                string[] clipboardText = Clipboard.GetText(TextDataFormat.Text).Split(Environment.NewLine.ToCharArray());
                //por cada palabra copiada, lo agrega al listbox
                foreach (string clipboard in clipboardText)
                {
                    listBox1.Items.Add(clipboard.Trim());
                    //validacion de filas vacias.
                    if (clipboard.ToString().Length == 0)
                    {
                        listBox1.Items.Remove(clipboard);
                    }


                }

            }
        }

        /// <summary>boton btnEliminarTodo_Click elemina todos los participantes de la listbox.</summary>
        /// <param name="sender">Recurso del evento.</param>
        /// <param name="e">La <see cref="EventArgs" /> instacia que contiene la inforamción del evento.</param>
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            /// limpia el lixtBox
            listBox1.Items.Clear();
        }

        /// <summary> Método de agregar participante al presionar enter de forma automatica.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAgregarParticipante_Click(sender, e);
            }
        }
        //salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //minimizar
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

   
    }
}
