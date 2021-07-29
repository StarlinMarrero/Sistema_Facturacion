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
    public partial class Frm_Editar_Producto : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Editar_Producto()
        {
            InitializeComponent();
        }
        public void Obtener_Producto(int Id)
        {
            var producto = db.Productoes.Find(Id);


            textBox_Codigo.Text = producto.IdProducto.ToString();
            textBox_Codigo.Enabled = false;
            textBox_Nombre_Producto.Text = producto.NombreProducto;
            textBox_Marca.Text = producto.MarcaProducto;
            textBox_Precio.Text = producto.PCProducto.ToString();
            textBox_Precio_Producto.Text = producto.PVProducto.ToString();
            textBox_Stock.Text = producto.StockProducto.ToString();
            textBox_Medida.Text = producto.UnidMedProducto;

            this.ShowDialog();
            

        }

        private void Btn_Guardar_Producto_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre_Producto.Text == "" || textBox_Marca.Text == "" || textBox_Precio.Text == "" || textBox_Precio_Producto.Text == "" || textBox_Stock.Text == "" || textBox_Medida.Text == "")
            {
                Alert_Message.confirmacionForm("Agregar Producto", "Tienes que completar todos los campos", "Info");
                return;
            }

            var Codigo = Convert.ToInt32(textBox_Codigo.Text);
            var Nombre_Producto = textBox_Nombre_Producto.Text;
            var Marca = textBox_Marca.Text;
            var Precio = Convert.ToDecimal(textBox_Precio.Text);
            var Precio_Venta = Convert.ToDecimal(textBox_Precio_Producto.Text);
            var Stock = Convert.ToInt32(textBox_Stock.Text);
            var Medida = textBox_Medida.Text;

            var producto = db.Productoes.Find(Codigo);

            producto.NombreProducto = Nombre_Producto;
            producto.MarcaProducto = Marca;
            producto.PCProducto = Precio;
            producto.PVProducto = Precio_Venta;
            producto.StockProducto = Stock;
            producto.UnidMedProducto = Medida;

            db.SaveChanges();

            Alert_Message.confirmacionForm("Editar Producto", "Producto editado correctamente, \n Actualizar la lista en el botón de actualización", "Success");

            this.Close();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
