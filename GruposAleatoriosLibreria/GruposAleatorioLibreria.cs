using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruposAleatoriosLibreria
{
    public class GruposAleatorioLibreria
    {
        /// <summary>
        ///  metodo para cambiar el orden en la cadena <br />
        /// </summary>
        public class Randomizer
        {
            public static void Randomize<T>(T[] items)
            {
                Random rand = new Random();
                //desordena el array de forma aleatoria
                for (int i = 0; i < items.Length - 1; i++)
                {
                    int j = rand.Next(i, items.Length);
                    T temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }

    }
}
