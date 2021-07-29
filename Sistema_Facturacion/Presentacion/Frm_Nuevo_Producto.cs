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
    public partial class Frm_Nuevo_Producto : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Nuevo_Producto()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Producto_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre_Producto.Text == "" || textBox_Marca.Text == "" || textBox_Precio.Text == "" || textBox_Precio_Producto.Text == "" || textBox_Stock.Text == "" || textBox_Medida.Text == "")
            {
                Alert_Message.confirmacionForm("Agregar Producto","Tienes que completar todos los campos","Info");
                return;
            }

            var Codigo = Convert.ToInt32(textBox_Codigo.Text);
            var Nombre_Producto = textBox_Nombre_Producto.Text;
            var Marca = textBox_Marca.Text;
            var Precio = Convert.ToInt32(textBox_Precio.Text);
            var Precio_Venta = Convert.ToInt32(textBox_Precio_Producto.Text);
            var Stock = Convert.ToInt32(textBox_Stock.Text);
            var Medida = textBox_Medida.Text;

            var validar_Codigo = db.Productoes.Find(Codigo);
            if (validar_Codigo != null)
            {
                Alert_Message.confirmacionForm("Código de Producto Existente", "Tienes que introducir un código único.", "Info");
                return;
            }


            var model = new Producto
            {
                IdProducto = Codigo,
                NombreProducto = Nombre_Producto,
                EstadoProducto = true,
                FechaActProducto = DateTime.Now,
                MarcaProducto = Marca,
                PCProducto = Precio,
                PVProducto = Precio_Venta,
                StockProducto = Stock,
                UnidMedProducto = Medida
            };
            db.Productoes.Add(model);
            db.SaveChanges();

            Alert_Message.confirmacionForm("Agregar Producto", "Producto Agregado Exitosamente", "Success");

            this.Close();
        
            //textBox_Codigo.Text = "";
            //textBox_Nombre_Producto.Text = "";
            //textBox_Marca.Text = "";
            //textBox_Precio.Text = "";
            //textBox_Precio_Producto.Text = "";
            //textBox_Stock.Text = "";
            //textBox_Medida.Text = "";


        }
    }
}
