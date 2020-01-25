using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1
{
    static class Program
    {
        
        //save josue rojas

        /*josue 
         * 
         */
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ////variables
            //string nombre = "josue sandi";
            //int num1 = 450; //entero
            //uint num2 = 500; //entero solo +
            //float num3 = 35.5f; //flotante
            //double num4 = 45.50; //decimales
            //decimal num5 = 502005.45454845m; //numeros grandes con decimales
            //byte num6 = 255; //maximo 255
            //bool acceso = true; //true and false
            ////prueba 

            //DateTime date = DateTime.Today;
             

            ////MessageBox.Show(nombre);
            /////MessageBox.Show(nombre,num5.ToString());
            //MessageBox.Show(date.ToShortDateString().ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
