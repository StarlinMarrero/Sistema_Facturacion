using Sistema_Facturacion.Cache;
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
    public partial class Frm_Ventas : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            Add_Producto_A_Lista();
        }
        public void Add_Producto_A_Lista()
        {
            var Codigo = Convert.ToInt32(textBox_Codigo.Text);
            var producto = db.Productoes.Find(Codigo);

            if (producto == null)
            {
                Alert_Message.confirmacionForm("Articulo", "El Código de barras del producto no existe.", "Info");
                return;
            }
            if (textBox_Cantidad.Text != null)
            {
                var cantidad = Convert.ToInt32(textBox_Cantidad.Text);
                if (cantidad <= 0)
                {
                    Alert_Message.confirmacionForm("Cantidad", "Tienes que ingresar una cantidad de articulos", "Info");
                    return;
                }
            }
         

            int n = Tabla_Articulos.Rows.Add();

            var precio_total = producto.PVProducto * Convert.ToDecimal(textBox_Cantidad.Text);


            Tabla_Articulos.Rows[n].Cells[0].Value = producto.NombreProducto.ToString();
            Tabla_Articulos.Rows[n].Cells[1].Value = textBox_Cantidad.Text;
            Tabla_Articulos.Rows[n].Cells[2].Value = producto.PVProducto.ToString();
            Tabla_Articulos.Rows[n].Cells[3].Value = $"${precio_total}";
            Tabla_Articulos.Rows[n].Cells[3].Style.ForeColor = Color.Green;

            


           var total_Actual = Convert.ToDecimal(Label_Total.Text);
           var precio_pantalla = total_Actual + precio_total;
            Label_Total.Visible = true;
            Label_Total.Text = precio_pantalla.ToString();

            //Factura factura = new Factura();

            //factura = new Factura
            //{
            //    Fecha = DateTime.Now,
            //    IdVendedor = UserLoginCache.IdUsuario,
            //    Total = precio_pantalla,


            //};
            // db.Facturas.Add(factura);
            //db.SaveChanges();



            var total_Articulos = Convert.ToInt32(Label_Cant_Articulos.Text);
            var cant_Arti_total = total_Articulos + Convert.ToInt32(textBox_Cantidad.Text);
            Label_Cant_Articulos.Text = cant_Arti_total.ToString();
            //MessageBox.Show(n.ToString());



            textBox_Codigo.Focus();
            textBox_Codigo.Text = "";
            textBox_Cantidad.Text = "1";


            var Articulos = new Articulos_Vendidos
            {
                Nombre_Articulo = producto.NombreProducto,
                Cantidad = Convert.ToInt32(textBox_Cantidad.Text),
                Precio_Unitario = Convert.ToDouble(producto.PVProducto),
                Precio_Total = Convert.ToDouble(precio_total),
                Id_Producto = producto.IdProducto,
                Id_Factura = 0,
                Id_Articulo = 0

            };


            //Datos_Factura_Cache.Agregar(Articulos, precio_pantalla);
         

            Datos_Factura_Cache.List_articulos_Vendidos.Add(Articulos);
            Datos_Factura_Cache.Monto_Cobrar = precio_pantalla;

        }

        private void textBox_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox_Cantidad.Focus();

            }
            //if (e.KeyChar == 27)
            //{
            //    if (textBox_buscar_cliente.Text.Length == 0)
            //    {
            //        Cargar_Clientes();
            //    }


            //}
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                Add_Producto_A_Lista();

            }
        }

        private void Tabla_Articulos_RowsRemoved()
        {
           
            //MessageBox.Show(numero_de_filas);


            var NumeroDeFilaSeleccionada = Tabla_Articulos.CurrentRow.Index;
            DataGridViewRow row = this.Tabla_Articulos.Rows[NumeroDeFilaSeleccionada];

            var Precio = row.Cells["Total"].Value.ToString();
            string String_Precio = Precio;
            char[] MyChar = {'$', ' '};
            string Precio_Limpio = String_Precio.TrimStart(MyChar);
            var Precio_definitivo = Convert.ToDecimal(Precio_Limpio);
            var total_Actual = Convert.ToDecimal(Label_Total.Text);
            var precio_pantalla = total_Actual - Precio_definitivo;
            Label_Total.Text = precio_pantalla.ToString();


            var cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
            var total_Art = Convert.ToInt32(Label_Cant_Articulos.Text);
            var total_articulos = total_Art - cantidad;
            Label_Cant_Articulos.Text = total_articulos.ToString();


            Tabla_Articulos.Rows.RemoveAt(NumeroDeFilaSeleccionada);

            var numero_de_filas = Tabla_Articulos.RowCount;
            if (numero_de_filas == 0)
            {
                Btn_Eliminar.Visible = false;
                return;
            }

        }

        private void Tabla_Articulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(Convert.ToInt32(e.KeyChar).ToString());
            if (e.KeyChar == 8)
            {


                Tabla_Articulos_RowsRemoved();

            }
        }

        private void Tabla_Articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var NumeroDeFilaSeleccionada = Tabla_Articulos.CurrentRow.Index.ToString();
            if (NumeroDeFilaSeleccionada != null)
            {
                Btn_Eliminar.Visible = true;
            }
            else
            {
                Btn_Eliminar.Visible = false;
            }

         
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Tabla_Articulos_RowsRemoved();
        }

        private void Btn_Cobrar_Click(object sender, EventArgs e)
        {
            //var total = Convert.ToDecimal(Label_Total.ToString());
            //Datos_Factura_Cache.Agregar((List<Factura>)Tabla_Articulos.DataSource, Convert.ToDecimal(Label_Total.Text));


            Limpiar();
            Frm_Cobrar_Factura frm_Cobrar_Factura = new Frm_Cobrar_Factura();
            frm_Cobrar_Factura.ShowDialog();
        }

        public void Limpiar()
        {
            Tabla_Articulos.Rows.Clear();
            Label_Cant_Articulos.Text = "0";

            textBox_Codigo.Focus();
            textBox_Codigo.Text = "";
            textBox_Cantidad.Text = "1";

            Label_Total.Text = "0";
        }

    }
}
