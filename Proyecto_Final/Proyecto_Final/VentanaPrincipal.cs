using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnNdonate_Click(object sender, EventArgs e)
        {
            this.Hide();

            NuevoDonante nd = new NuevoDonante();
            nd.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();

            BuscarDonante bdnt = new BuscarDonante();
            bdnt.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReporteDonantes rd = new ReporteDonantes();
            rd.Show();
        }
    }
}
