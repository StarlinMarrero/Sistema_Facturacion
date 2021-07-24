using Sistema_Facturacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Presentacion
{
    public partial class Frm_Productos : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Productos()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            Cargar_Productos();
        }
        public void OcultarMoverAncharColumns()
        {
            dataGridView_Productos.Columns[11].Visible = false;
            dataGridView_Productos.Columns[12].Visible = false;
            dataGridView_Productos.Columns[10].Visible = false;

            dataGridView_Productos.Columns[0].Width = 50;
            dataGridView_Productos.Columns[1].Width = 50;
            dataGridView_Productos.Columns[2].Width = 50;


            dataGridView_Productos.Columns[0].DisplayIndex = 11;
            dataGridView_Productos.Columns[1].DisplayIndex = 12;

         

        }
        public void BuscarProducto()
        {
            var Nombre_Producto = TextBox_Buscar.Text;

            var producto = db.Productoes.Where(x => x.NombreProducto.Contains(Nombre_Producto)).ToList();

            dataGridView_Productos.DataSource = producto;

        }


        public void Cargar_Productos()
        {
            var lista = db.Productoes.Where(x => x.EstadoProducto == true).ToList();
            dataGridView_Productos.DataSource = lista;
            OcultarMoverAncharColumns();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Prod_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Producto frm_Nuevo_Producto = new Frm_Nuevo_Producto();
            frm_Nuevo_Producto.ShowDialog();
        }

        private void Btn_Buscar_Prod_Click(object sender, EventArgs e)
        {
            if (TextBox_Buscar.Text == null || TextBox_Buscar.Text == "")
            {
                Cargar_Productos();
                Alert_Message.confirmacionForm("Buscar Producto", "Tienes que introducir el nombre del producto", "Info");
                return;
            }
            BuscarProducto();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cargar_Productos();
        }

        private void TablaProductos_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Productos.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {

                if (MessageBox.Show("Estas seguro que quieres eliminar este producto ? ", "Atención",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == System.Windows.Forms.DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(dataGridView_Productos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    var producto = db.Productoes.Find(Id);
                    producto.EstadoProducto = false;
                    db.SaveChanges();
                    Cargar_Productos();
                }
            }
        }
    }
}
