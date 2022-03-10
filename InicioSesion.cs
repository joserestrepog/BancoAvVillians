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
    public partial class InicioSesion : Form
       
    {
        public InicioSesion()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\img\AVV.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static string credencialesa, usuarioa;
        string[] cadena = new string[1000];
        int contador = 0;

        private void btnISA_Click(object sender, EventArgs e)
        {
            if(this.txbISAU.Text=="" || txbISAC.Text == "")
            {
                MessageBox.Show("No ha ingresado información completa.");
            }
            else
            {
                StreamReader mostrar = new StreamReader("C:\\Users\\Jose Restrepo\\Desktop\\Administradores.csv");
                credencialesa = Convert.ToString(txbISAU.Text)+","+Convert.ToString(txbISAC.Text);
                usuarioa = Convert.ToString(txbISAU.Text);
                try
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        cadena[i] = mostrar.ReadLine();
                    }

                    for (int i = 0; i < cadena.Length ; i++)
                    {
                        if (cadena[i] == credencialesa)
                        {
                            FormAdministrador cambio = new FormAdministrador();
                            this.Hide();
                            cambio.ShowDialog();
                            this.Show();
                            this.txbISAU.Text = "";
                            this.txbISAC.Text = "";
                            contador = 1;
                            return;
                        }
                    }
                    if (contador == 0)
                    {
                        MessageBox.Show("Usuario y/o clave incorrecta.");
                        this.txbISAU.Text = "";
                        this.txbISAC.Text = "";
                        return;
                    }
                    contador = 0;
                }
                catch
                {
                    MessageBox.Show("Error.");
                }
                mostrar.Close();
            }
        }

        private void btnISC_Click(object sender, EventArgs e)
        {
            if (this.txbISCU.Text == "" || txbISCC.Text == "")
            {
                MessageBox.Show("No ha ingresado información.");
            }
            else
            {
                StreamReader mostrar = new StreamReader("C:\\Users\\Jose Restrepo\\Desktop\\Clientes.csv");
                credencialesa = Convert.ToString(txbISCU.Text) + "," + Convert.ToString(txbISCC.Text);
                usuarioa = Convert.ToString(txbISCU.Text);
                try
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        cadena[i] = mostrar.ReadLine();
                    }

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (cadena[i] == credencialesa)
                        {
                            FormCliente cambio = new FormCliente();
                            this.Hide();
                            cambio.ShowDialog();
                            this.Show();
                            this.txbISCU.Text = "";
                            this.txbISCC.Text = "";
                            contador = 1;
                            return;
                        }
                    }
                    if (contador == 0)
                    {
                        MessageBox.Show("Usuario y/o clave incorrecta.");
                        this.txbISCU.Text = "";
                        this.txbISCC.Text = "";
                        return;
                    }
                    contador = 0;
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
