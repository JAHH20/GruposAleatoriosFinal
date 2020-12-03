using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GruposAleatoriosLibreria.GruposAleatorioLibreria;

namespace Pruebas_unitarias_Grupos_Aleatorios
{
    [TestClass]
    public class TestGruposAleatoriosFinal
    {
        [TestMethod]
        public void TestGruposRandom()
        {
            string[] cadena1 = { "1", "2", "3", "4", "5", "6", "7", "8","9" };
            string[] cadenaTransformada = { "1", "2", "3", "4", "5", "6", "7", "8","9" };

            //Randomizer.Randomize(cadenaTransformada);

            for (int i=0; i<9;i++) {
                Randomizer.Randomize(cadenaTransformada);
                Console.WriteLine(cadenaTransformada[0]+" ");
            }
       
                      

           
            Assert.AreNotEqual(cadena1,cadenaTransformada);
        }


        [TestMethod]
        public void TestNumeroExcel()
        {
            NumeroExcel num = new NumeroExcel();
            int Columna = 5;
            string numeroConvertido;
            string resultadoEsperado = "E";

            numeroConvertido = num.GetExcelColumnName(Columna);
            

            Console.Write(numeroConvertido);
            Console.Write(" ");
            Console.Write(resultadoEsperado);

            Assert.AreEqual(resultadoEsperado, numeroConvertido);
              
        }

    }
}
