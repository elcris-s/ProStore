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

    public partial class PantallaRegistrarProducto : FormBase
    {
        public PantallaRegistrarProducto()
        {
            InitializeComponent();
            fb.LlenarCategoria(comboBoxCate);
            fb.LlenarMarca(comboBoxMarc);
            fb.LlenarProveedor(comboBoxProve);
        }
        FormBase fb = new FormBase();
        int cont = 1;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtNombProd.Text = "";
            this.comboBoxCate.Text = "Seleccione una Categoria";
            this.comboBoxMarc.Text = "Seleccione una Marca";
            txtCantiPro.Text = "";
            txtCantMin.Text = "";
            txtPrecio.Text = "";
            this.comboBoxProve.Text = "Seleccione un Proveedor";
            txtNombProd.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            PantallaAdminMantenimiento pam = new PantallaAdminMantenimiento();
            pam.Show();
            this.Hide();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombProd.Text.Trim() == "" || comboBoxCate.Text.Trim() == "Seleccione una Categoria" || comboBoxMarc.Text.Trim() == "Seleccione una Marca" || txtCantiPro.Text.Trim() == "" || txtCantMin.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || comboBoxProve.Text.Trim() == "Seleccione un Proveedor")
            {
                MessageBox.Show("Favor llenar los espacios requeridos (*)");
                txtNombProd.Focus();
            }

            else
            {

                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Productos WHERE prod_nombre='" + txtNombProd.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("El Producto ya esta Registrado");
                    txtNombProd.Text = "";
                    this.comboBoxCate.Text = "Seleccione una Categoria";
                    this.comboBoxMarc.Text = "Seleccione una Marca";
                    txtCantiPro.Text = "";
                    txtCantMin.Text = "";
                    txtPrecio.Text = "";
                    this.comboBoxProve.Text = "Seleccione un Proveedor";
                    txtNombProd.Focus();

                }
            }
            try
            {
                string cmd = string.Format("Exec RegistrarProducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}'",txtCodprod.Text.Trim(),txtNombProd.Text.Trim(), comboBoxCate.SelectedIndex.ToString(), comboBoxMarc.SelectedIndex.ToString(), txtCantiPro.Text.Trim(), txtCantMin.Text.Trim(), txtPrecio.Text.Trim(), comboBoxProve.SelectedIndex.ToString());
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente el producto");
                cont = cont + 1;
            }
            catch 
            {
                
            }
        }

        private void txtNombProd_TextChanged(object sender, EventArgs e)
        {
            
            txtCodprod.Text = "PROD-" + "0" + cont;
        }

        private void txtCantMin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PantallaRegistrarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaAdminMantenimiento pam = new PantallaAdminMantenimiento();
            pam.Show();
            this.Hide();
        }
    }

    
}
