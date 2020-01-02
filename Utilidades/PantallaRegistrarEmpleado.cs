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
using Utilidades;

namespace ProStore
{
    public partial class PantallaRegistrarEmpleado : FormBase

    {
        FormBase fb = new FormBase();
        
        public PantallaRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void txtCeduEmp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCeduEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);

        }

        private void txtCelEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);
        }

        private void txtTelEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloNumeros(e);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
        
        }
            public override Boolean Guarda()
        {
            if (txtNombreEmp.Text.Trim() == "" 
                || txtApelli1Emp.Text.Trim() == "" 
                || txtCeduEmp.Text.Trim() == "-       -"
                || txtCelEmp.Text.Trim() == "(   )    -"
                || txtDireEmp.Text.Trim() == "" 
                || txtTelEmp.Text.Trim() == "(   )    -"
                || txtUsuEmp.Text.Trim() == "" 
                || txtContraEmp.Text.Trim() == "")
                {
                    MessageBox.Show("Favor llenar los espacios requeridos (*)");
                    txtNombreEmp.Focus();
                }
            
             
                try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Empleado WHERE emp_cedula='" + txtCeduEmp.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("El empleado ya esta registrado");
                    txtNombreEmp.Text = "";
                    txtApelli1Emp.Text = "";
                    txtApelli2Emp.Text = "";
                    txtCeduEmp.Text = "";
                    txtDireEmp.Text = "";
                    txtCelEmp.Text = "";
                    txtTelEmp.Text = "";
                    txtUsuEmp.Text = "";
                    txtContraEmp.Text = "";
                    checkBox1.Checked = false;
                    txtNombreEmp.Focus();

                }
                string cmd = string.Format("Exec RegistrarEmpleado '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}'", txtNombreEmp.Text.Trim(), txtApelli1Emp.Text.Trim(), txtApelli2Emp.Text.Trim(), dateTimePicker1.Value.ToString(), txtCeduEmp.Text.Trim(), txtDireEmp.Text.Trim(), txtCelEmp.Text.Trim(), txtTelEmp.Text.Trim(), checkBox1.Checked.ToString(), txtUsuEmp.Text.Trim(), txtContraEmp.Text.Trim());
                FormBase.Conexion.Ejecutar(cmd);
                MessageBox.Show("Se ha registrado correctamente al empleado");
                return true;
            }
            catch 
            {
                return false;
            }
            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreEmp.Text = "";
            txtApelli1Emp.Text = "";
            txtApelli2Emp.Text = "";
            txtCeduEmp.Text = "";
            txtDireEmp.Text = "";
            txtCelEmp.Text = "";
            txtTelEmp.Text = "";
            txtUsuEmp.Text = "";
            txtContraEmp.Text = "";
            checkBox1.Checked = false;
            txtNombreEmp.Focus();
            


        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            PantallaAdminMantenimiento pa = new PantallaAdminMantenimiento();
            pa.Show();

        }

        private void txtNombreEmp_TextChanged(object sender, EventArgs e)
        {
            string cod = txtNombreEmp.Text;
            txtUsuEmp.Text = "EMP" + cod.Substring(0, Math.Min(txtNombreEmp.TextLength, 3));
            
        }

        private void txtNombreEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloLetras(e);
        }

        private void txtApelli1Emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloLetras(e);
        }

        private void txtApelli2Emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            fb.SoloLetras(e);
        }
    }
    }

