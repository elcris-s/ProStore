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

namespace ProStore
{
    public partial class PantallaRegistroProveedor : FormBase
    {
        FormBase fb = new FormBase();
        int cont = 1;

        public PantallaRegistroProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            
        }
             public override Boolean Guarda()
        {
            if (txtNombrePro.Text.Trim() == "" || txtDirecProv.Text.Trim() == "" || txtTelProv.Text.Trim() == "")
            {
                MessageBox.Show("Favor llenar los espacios requeridos (*)");
                txtNombrePro.Focus();
            }



            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Proveedor WHERE prov_nombre='" + txtNombrePro.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("El Proveedor ya esta registrado");
                    txtNombrePro.Text = "";
                    txtDirecProv.Text = "";
                    txtTelProv.Text = "";
                    
                    txtNombrePro.Focus();

                }
                string cmd = string.Format("Exec RegistrarProveedor '{0}', '{1}', '{2}'", txtNombrePro.Text.Trim(), txtDirecProv.Text.Trim(), txtTelProv.Text.Trim());
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente el proveedor");
                cont += cont + 1;

                return true;
            }
            catch
            {
                return false;
            }


        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
            txtNombrePro.Text = "";
            txtDirecProv.Text = "";
            txtTelProv.Text = "";
            
            
            
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            PantallaAdminMantenimiento pa = new PantallaAdminMantenimiento();
            pa.Show();
        }

        private void txtTelProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void txtCodProve_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
    }

