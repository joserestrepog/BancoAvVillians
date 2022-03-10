using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BancoAvVillians
{
    public partial class FormCrearCuenta : Form
    {
        public FormCrearCuenta()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\AVV2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static string cliente;
        string[] cadena = new string[1000];
        private void btnCC_Click(object sender, EventArgs e)
        {
            if (this.txbCCUsuario.Text == "" || this.txbCCUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado información completa.");
            }
            else
            {
                StreamReader mostrar = new StreamReader("C:\\Users\\Jose Restrepo\\Desktop\\Clientes.csv");
                cliente = Convert.ToString(txbCCUsuario.Text) + "," + Convert.ToString(txbCCCedula.Text);
                try
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        cadena[i] = mostrar.ReadLine();
                    }
                }
                catch
                {
                    MessageBox.Show("Error.");
                }
                mostrar.Close();
            }
        }
    }
}
