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
    public partial class FormModificaciones : Form
    {
        public FormModificaciones()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\AVV2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAceptarM_Click(object sender, EventArgs e)
        {
            if (this.txbNombreCompletoM.Text == "" || txbCedulaM.Text == "")
            {
                MessageBox.Show("No ha ingresado información completa.");
            }
            else
            {

            }
        }
    }
}
