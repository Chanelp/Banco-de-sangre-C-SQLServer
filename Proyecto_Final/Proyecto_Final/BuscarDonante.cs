using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public partial class BuscarDonante : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=CHANEL;Initial Catalog=BD_20211120;Integrated Security=True");

        public BuscarDonante()
        {
            InitializeComponent();
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Close();

            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbGrupoS.ResetText();
            cmbFactorRH.ResetText();
            txtTelef.Text = "";
        }      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Donantes WHERE ID= @ID", conexion);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            conexion.Open();

            SqlDataReader donante = comando.ExecuteReader();

            if (donante.Read())
            {
                txtNombre.Text = donante["Nombre"].ToString();
                txtApellido.Text = donante["Apellido"].ToString();
                cmbGrupoS.SelectedItem = donante["Grupo Sanguíneo"].ToString();
                cmbFactorRH.SelectedItem = donante["Factor RH"].ToString();
                txtTelef.Text = donante["Teléfono"].ToString();
            }
            conexion.Close();
        }
    }
}
