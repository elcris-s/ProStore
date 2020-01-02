using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using System.Data.SqlClient;


namespace ProStore
{

    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }


        private void txtContraLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True"); // conexion a la bd   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Empleado WHERE emp_usuario='" + txtUsuLogin.Text + "' AND emp_contra='" + txtContraLogin.Text + "'", con);
            SqlDataAdapter rol = new SqlDataAdapter("select Count(*) from Empleado where emp_usuario='" + txtUsuLogin.Text + "' and emp_rol=1", con);
            /* query para seleccionar datos ingresados */

            DataTable dt = new DataTable(); //crea una tabla virtual para comprobar datos 
            DataTable ro = new DataTable();
            sda.Fill(dt);
            rol.Fill(ro);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                if (ro.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Inicio de sesión correcto");
                    this.Hide();
                    new PantallaAdmin().Show();
                    con.Close();
                }

                
                else
                {
                    MessageBox.Show("Inicio de sesión correcto");
                    this.Hide();
                    new PantallaEmpleado().Show();
                    con.Close();
                }

                               
                                          
             }
                else
                    MessageBox.Show("Usuario/contraseña incorrectos");
            txtUsuLogin.Text = "";
            txtContraLogin.Text = "";
            txtUsuLogin.Focus();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True"); // conexion a la bd   
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Empleado WHERE emp_usuario='" + txtUsuLogin.Text + "' AND emp_contra='" + txtContraLogin.Text + "'", con);
                SqlDataAdapter rol = new SqlDataAdapter("select Count(*) from Empleado where emp_usuario='" + txtUsuLogin.Text + "' and emp_rol=1", con);
                /* query para seleccionar datos ingresados */

                DataTable dt = new DataTable(); //crea una tabla virtual para comprobar datos 
                DataTable ro = new DataTable();
                sda.Fill(dt);
                rol.Fill(ro);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    if (ro.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Inicio de sesión correcto");
                        this.Hide();
                        new PantallaAdmin().Show();
                        con.Close();
                    }


                    else
                    {
                        MessageBox.Show("Inicio de sesión correcto");
                        this.Hide();
                        new PantallaEmpleado().Show();
                        con.Close();
                    }



                }
                else
                    MessageBox.Show("Usuario/contraseña incorrectos");
                txtUsuLogin.Text = "";
                txtContraLogin.Text = "";
                txtUsuLogin.Focus();


            }
        }

        private void PantallaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
    }
