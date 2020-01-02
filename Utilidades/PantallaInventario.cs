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
    public partial class PantallaInventario : Form
    {
        public PantallaInventario()
        {
            InitializeComponent();
        }

        public void LlenarTablaInventario (DataGridView dg)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.prod_codigo as Codigo_Producto, " +
                "p.prod_nombre as Nombre, " +
                "c.cate_descripcion as Categoria, " +
                "m.marc_descripcion as Marca, " +
                "p.prod_cantidad as Cantidad, " +
                "p.prod_minimo as Cantidad_Minima, " +
                "p.prod_precio as Precio, " +
                "o.prov_nombre as Proveedor " +
                "from Productos p inner join Categorias c on (prod_categoria=cate_id) " +
                "inner join Marcas m on (prod_marca=marc_codigo) " +
                "inner join Proveedor o on (prod_proveedor=prov_codigo) ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dg.DataSource = dt;
        }

        public void LlenarTablaInventarioTelevisor (DataGridView dg)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.prod_codigo as Codigo_Producto, " +
                "p.prod_nombre as Nombre, " +
                "c.cate_descripcion as Categoria " +
                "from Productos p " +
                "inner join Categorias c on (prod_categoria=cate_id) " +
                "where c.cate_id = 1", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dg.DataSource = dt;
        }

        private void PantallaInventario_Load(object sender, EventArgs e)
        {
            PantallaInventario pi = new PantallaInventario();
            pi.LlenarTablaInventario(dataGridView1);
           
        }

        private void PantallaInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            PantallaAdmin pa = new PantallaAdmin();
            pa.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PantallaInventario pi = new PantallaInventario();
            pi.LlenarTablaInventarioTelevisor(dataGridView1);

            if (checkBox1.Checked == false)
                pi.LlenarTablaInventario(dataGridView1);
        }
    }
}
