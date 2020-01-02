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
    public partial class PantallaRegistrarCliente : FormBase
    {
        FormBase fb = new FormBase();
        int cont = 1;
        public PantallaRegistrarCliente()
        {
            InitializeComponent();
        }

        private void txtCedCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void txtNombreClie_TextChanged(object sender, EventArgs e)
        {
            string cod = txtNombreClie.Text;
            txtCodClie.Text = "CLI" + "0" + cont;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
         
        }
        public override bool Guarda()
        {
            if (txtNombreClie.Text.Trim() == "" || txtApeClie.Text.Trim() == "" || txtCedCliente.Text.Trim() == "" || txtTelClie.Text.Trim() == "" || txtCelClie.Text.Trim() == "" || txtDirecClie.Text.Trim() == "")
            {
                MessageBox.Show("Favor llenar los espacios requeridos (*)");
                txtNombreClie.Focus();
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Cliente WHERE cli_rnc='" + txtCedCliente.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("El cliente ya esta registrado");
                    txtNombreClie.Text = "";
                    txtApeClie.Text = "";
                    txtCedCliente.Text = "";
                    txtDirecClie.Text = "";
                    txtTelClie.Text = "";
                    txtCelClie.Text = "";
                    txtCodClie.Text = "";
                    txtNombreClie.Focus();
                    
                }

                string cmd = string.Format("Exec RegistroCliente '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", txtNombreClie.Text.Trim(), txtApeClie.Text.Trim(), txtCedCliente.Text.Trim(), txtCelClie.Text.Trim(), txtTelClie.Text.Trim(), txtDirecClie.Text.Trim(), txtCodClie.Text.Trim());
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente al cliente");
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
            txtNombreClie.Text = "";
            txtApeClie.Text = "";
            txtCedCliente.Text = "";
            txtTelClie.Text = "";
            txtCelClie.Text = "";
            txtDirecClie.Text = "";
            txtCodClie.Text = "";
            txtNombreClie.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PantallaAdminMantenimiento pa = new PantallaAdminMantenimiento();
            pa.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
            


           
        }
    
        
    
    

