using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            
            

            try
            {

                Byte txt = Convert.ToByte(txt_name.Text);
                lb_txt.Text = txt.ToString();

            }
            catch (OverflowException x)a
            {

                MessageBox.Show("Error en el tamaño del numero:  " + x);
            }
            catch (FormatException xx) //cuando escribo con letras en ves de numeros 
            {

                MessageBox.Show("Error en el formato:  " + xx);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
