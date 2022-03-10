using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoAvVillians
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido Administrador "+InicioSesion.usuarioa);
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\AVV2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearCuenta cambio = new FormCrearCuenta();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearCliente cambio = new FormCrearCliente();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaciones cambio = new FormModificaciones();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void inactivarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaciones cambio = new FormModificaciones();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaciones cambio = new FormModificaciones();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void moviminetosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaciones cambio = new FormModificaciones();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificaciones cambio = new FormModificaciones();
            this.Hide();
            cambio.ShowDialog();
            this.Show();
        }
    }
}
