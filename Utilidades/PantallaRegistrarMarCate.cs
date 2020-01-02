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
    public partial class PantallaRegistrarMarCate : FormBase
    {
        public PantallaRegistrarMarCate()
        {
            InitializeComponent();
        }

        FormBase fb = new FormBase();

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtNombCate.Text = "";
            txtNombCate.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            PantallaAdminMantenimiento pam = new PantallaAdminMantenimiento();
            pam.Show();
            this.Hide();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Categorias WHERE cate_descripcion='" + txtNombCate.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("La categoria ya esta registrada");
                txtNombCate.Text = "";
                txtNombCate.Focus();
            }
            else
            {
                string cmd = string.Format("Exec RegistrarCategoria '{0}', '{1}'", txtNombCate.Text.Trim(), checkBoxCate.Checked);
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente la categoria");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombreMarc.Text = "";
            txtNombreMarc.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Marcas WHERE marc_descripcion='" + txtNombreMarc.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("La marca ya esta registrada");
                    txtNombreMarc.Text = "";
                    txtNombreMarc.Focus();

                }
                string cmd = string.Format("Exec RegistrarMarca '{0}', '{1}'", txtNombreMarc.Text.Trim(), checkBox1.Checked);
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente la marca");
                   
        }
           
               
         
    }
    }

