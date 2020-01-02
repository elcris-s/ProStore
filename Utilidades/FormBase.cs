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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }



        public void SoloNumeros(KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public virtual void Guardar()
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual void Nuevo()
        {

        }

        public virtual Boolean Guarda ()
        {
            return false;
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            Guarda();
        }
        public class Conexion
        {
            public static DataSet Ejecutar(string cmd)
            {
                SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
                Con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter dp = new SqlDataAdapter(cmd, Con);

                dp.Fill(ds);
                Con.Close();
                return ds;


            }


        }

        public void LlenarCategoria(ComboBox comboBoxCate)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            con.Open();
            SqlCommand sqlc = new SqlCommand("SELECT cate_descripcion FROM Categorias" , con);
            SqlDataAdapter dr = new SqlDataAdapter(sqlc);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row["cate_descripcion"] = "Seleccione una Categoria";
            dt.Rows.InsertAt(row, 0);

            comboBoxCate.ValueMember = "cate_id";
            comboBoxCate.DisplayMember = "cate_descripcion";
            comboBoxCate.DataSource = dt;
        }

        public void LlenarMarca(ComboBox comboBoxMarc)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            con.Open();
            SqlCommand sqlc = new SqlCommand("SELECT marc_descripcion FROM Marcas", con);
            SqlDataAdapter dr = new SqlDataAdapter(sqlc);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row["marc_descripcion"] = "Seleccione una Marca";
            dt.Rows.InsertAt(row, 0);

            comboBoxMarc.ValueMember = "marc_codigo";
            comboBoxMarc.DisplayMember = "marc_descripcion";
            comboBoxMarc.DataSource = dt;
        }

        public void LlenarProveedor(ComboBox comboBoxProve)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProStore;Integrated Security=True");
            con.Open();
            SqlCommand sqlc = new SqlCommand("SELECT prov_nombre FROM Proveedor", con);
            SqlDataAdapter dr = new SqlDataAdapter(sqlc);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();

            DataRow row = dt.NewRow();
            row["prov_nombre"] = "Seleccione un Proveedor";
            dt.Rows.InsertAt(row, 0);

            comboBoxProve.ValueMember = "prov_codigo";
            comboBoxProve.DisplayMember = "prov_nombre";
            comboBoxProve.DataSource = dt;
        }
    }
}
