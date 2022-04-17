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
    public partial class ReporteDonantes : Form
    {
            SqlConnection conexion = new SqlConnection("Data Source=CHANEL;Initial Catalog=BD_20211120;Integrated Security=True");

        public ReporteDonantes()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * from Donantes", conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            dgvReporte.DataSource = tabla;

            conexion.Close();


        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Close();

            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Donantes SET Nombre = @Nombre, Apellido = @Apellido, [Grupo Sanguíneo] = @[Grupo Sanguíneo], [Factor RH] = @[Factor RH], [Teléfono] = @[Teléfono] WHERE ID = @ID";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("@[Grupo Sanguíneo]", cmbGrupoS.SelectedItem);
            comando.Parameters.AddWithValue("@[Factor RH]", cmbFactorRH.SelectedItem);
            comando.Parameters.AddWithValue("[Teléfono]", txtTelef.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Información Actualizada");
            }
            catch (Exception fallo)
            {
                MessageBox.Show("Ha ocurrido un fallo: " + fallo.Message);
            }
        }
    }
}
