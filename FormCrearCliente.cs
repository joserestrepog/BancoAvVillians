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
    public partial class FormCrearCliente : Form
    {
        public FormCrearCliente()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\AVV2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public string cedulat;
        private void btnCrearClienteA_Click(object sender, EventArgs e)
        {
            if (this.txbNombreCompletoU.Text == "" || this.txbCedulaU.Text == "" || this.txbDireccionU.Text == "" || this.txbCorreoU.Text == "" || this.txbTelefonoFijoU.Text == "" || this.txbNumeroCelularU.Text == "" || this.txbFechaNacimientoU.Text == "" || this.txbSaldoU.Text == "")
            {
                MessageBox.Show("No ha ingresado información completa.");
            }
            else
            {
                StreamWriter guardar = new StreamWriter("C:\\Users\\Jose Restrepo\\Desktop\\Clientes.csv", true);
                try
                {
                    if(Convert.ToInt32(txbSaldoU.Text)<100000)
                    {
                        MessageBox.Show("El saldo mínimo es $100000");
                    }
                    else
                    {
                        int cuenta, cuenta1,cuenta2,cuenta3;
                        string ncuenta;
                        Random aleatorio = new Random();
                        cuenta = aleatorio.Next(100,999);
                        cuenta1 = aleatorio.Next(100, 999);
                        cuenta2 = aleatorio.Next(100, 999);
                        cuenta3 = aleatorio.Next(10, 99);
                        ncuenta = Convert.ToString(cuenta)+ "-" + Convert.ToString(cuenta1) + "-" + Convert.ToString(cuenta2) + "-" + Convert.ToString(cuenta3);
                        cedulat = Convert.ToString(txbCedulaU.Text) + "," + Convert.ToString(txbCedulaU.Text);
                        guardar.WriteLine(Convert.ToString(txbNombreCompletoU.Text) + "," + Convert.ToString(txbCedulaU.Text) + "," + Convert.ToString(txbDireccionU.Text) + "," + Convert.ToString(txbCorreoU.Text) + "," + Convert.ToString(txbTelefonoFijoU.Text) + "," + Convert.ToString(txbNumeroCelularU.Text) + "," + Convert.ToString(txbFechaNacimientoU.Text) +"," +ncuenta + "," + Convert.ToString(txbSaldoU.Text));
                        guardar.WriteLine();
                        guardar.WriteLine(Convert.ToString(txbCedulaU.Text) + "," + Convert.ToString(txbCedulaU.Text));
                        guardar.WriteLine();
                        MessageBox.Show("El número de cuenta es: " + ncuenta);
                        MessageBox.Show("El usuario y clave para ingresar es: " + txbCedulaU.Text);
                        MessageBox.Show("Cliente creado exitosamente.");
                        this.txbNombreCompletoU.Text = "";
                        this.txbCedulaU.Text = "";
                        this.txbDireccionU.Text = "";
                        this.txbCorreoU.Text = "";
                        this.txbTelefonoFijoU.Text = "";
                        this.txbNumeroCelularU.Text = "";
                        this.txbFechaNacimientoU.Text = "";
                        this.txbSaldoU.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Error:");
                }
                guardar.Close();
            }
            }
    }
}
