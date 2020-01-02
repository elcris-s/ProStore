using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProStore
{
    public partial class PantallaAdmin : Form
        
    {
        public PantallaAdmin()
        {
            InitializeComponent();
        }

        
        

        
        private void btnRegistrarEmp_Click(object sender, EventArgs e)
        {
            PantallaAdminMantenimiento pam = new PantallaAdminMantenimiento();
            pam.Show();
            this.Hide();
        }

        private void txtRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            PantallaRegistrarEmpleado pre = new PantallaRegistrarEmpleado();
            pre.Show();
            this.Hide();
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            PantallaInventario pp = new PantallaInventario();
            pp.Show();
            this.Hide();
        }

        private void txtRegistrarProveedor_Click(object sender, EventArgs e)
        {
            PantallaInventario pp = new PantallaInventario();
            pp.Show();
            this.Hide();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            PantallaRegistrarCliente clie = new PantallaRegistrarCliente();
            this.Hide();
            clie.Show();
        }

        private void txtRegistrarCliente_Click(object sender, EventArgs e)
        {
            PantallaRegistrarCliente clie = new PantallaRegistrarCliente();
            this.Hide();
            clie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaLogin pl = new PantallaLogin();
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pl.Show();
                this.Hide();
            }
        }

        private void PantallaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            
        }
    }
}
