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
    public partial class PantallaAdminMantenimiento : Form
        
    {
        public PantallaAdminMantenimiento()
        {
            InitializeComponent();
        }

        


        
        private void btnRegistrarEmp_Click(object sender, EventArgs e)
        {
            PantallaRegistrarEmpleado pre = new PantallaRegistrarEmpleado();
            pre.Show();
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
            PantallaRegistroProveedor pp = new PantallaRegistroProveedor();
            pp.Show();
            this.Hide();
        }

        private void txtRegistrarProveedor_Click(object sender, EventArgs e)
        {
            PantallaRegistroProveedor pp = new PantallaRegistroProveedor();
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

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaRegistrarMarCate pmc = new PantallaRegistrarMarCate();
            pmc.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PantallaRegistrarMarCate pmc = new PantallaRegistrarMarCate();
            pmc.Show();
            this.Hide();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            PantallaRegistrarProducto producto = new PantallaRegistrarProducto();
            producto.Show();
            this.Hide();
        }

        private void txtRegistrarProducto_Click(object sender, EventArgs e)
        {
            PantallaRegistrarProducto producto = new PantallaRegistrarProducto();
            producto.Show();
            this.Hide();
        }

        private void PantallaAdminMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaAdmin pa = new PantallaAdmin();
            pa.Show();
        }
    }
}
