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
    public partial class NuevoDonante : Form
    {
        public NuevoDonante()
        {
            InitializeComponent();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Close();

            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = ""; 
            cmbGrupoS.ResetText();
            cmbFactorRH.ResetText();
            txtTelef.Text = "";
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            Enviar1();
        }
            
        private void Enviar1()
            {
                NuevoDonante donante = new NuevoDonante();
                try
                {
                    Conexion conexion = new Conexion();
                    string query = "insert into Donantes (Nombre, Apellido, [Grupo Sanguíneo], [Factor RH], [Teléfono]) values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + cmbGrupoS.SelectedItem + "','" + cmbFactorRH.SelectedItem + "','" + txtTelef.Text + "')";

                    conexion.Iniciar(query);
                    MessageBox.Show("Haz sido registrado, ¡Gracias por tu donación!");

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    cmbGrupoS.ResetText();
                    cmbFactorRH.ResetText();
                    txtTelef.Text = "";
                }
                catch (Exception fallo)
                {
                    MessageBox.Show("Ha ocurrido un fallo: " + fallo.Message);
                }
            }
        }
    }
