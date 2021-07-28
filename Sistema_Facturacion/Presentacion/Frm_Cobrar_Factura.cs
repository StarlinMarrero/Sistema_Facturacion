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
    public partial class Frm_Cobrar_Factura : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Cobrar_Factura()
        {
            InitializeComponent();
        }

        public void ObtenerCliente(int IdCLiente, string Nombre_Cliente)
        {
            label_Cliente_ID.Text = IdCLiente.ToString();
            Label_Cliente.Text = Nombre_Cliente;

            label_Cliente_ID.Visible = true;
            Label_Cliente.Visible = true;

            this.Focus();
        }
        public void Datos_Factura()
        {

            textBox_monto.Text = Datos_Factura_Cache.Monto_Cobrar.ToString();
            Label_Monto.Text = $"El Monto a cobrar es: ${Datos_Factura_Cache.Monto_Cobrar}";
            //MessageBox.Show(Datos_Factura_Cache.List_articulos_Vendidos.FirstOrDefault().Nombre_Articulo);

        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cobrar_Y_Guardar()
        {
            Factura factura = new Factura();

            var cantidad_factura = db.Facturas.Count();

            factura = new Factura
            {
                num_fact = cantidad_factura++,
                Fecha = DateTime.Now,
                Total = Datos_Factura_Cache.Monto_Cobrar,
                Igv = Convert.ToDecimal(textBox_monto.Text),
                IdCliente = 0,
                IdVendedor = UserLoginCache.IdUsuario,



            };
            db.Facturas.Add(factura);
            db.SaveChanges();


            foreach (var item in Datos_Factura_Cache.List_articulos_Vendidos)
            {
                var producto = db.Productoes.Find(item.Id_Producto);

                if (producto != null)
                {
                    producto.StockProducto -= (int)item.Cantidad;

                    if (producto.StockProducto <= 0)
                    {
                        producto.StockProducto = 0;
                    }

                }


                var model = new Articulos_Vendidos
                {
                    Cantidad = item.Cantidad,
                    Id_Factura = factura.num_fact,
                    Nombre_Articulo = item.Nombre_Articulo,
                    Precio_Total = item.Precio_Total,
                    Precio_Unitario = item.Precio_Unitario,
                    Id_Producto = item.Id_Producto

                };

                db.Articulos_Vendidos.Add(model);
                db.SaveChanges();
            }


            Alert_Message.confirmacionForm("Cobrar", "La factura se ha cobrado correctamente.", "Success");
            this.Close();

            Datos_Factura_Cache.Monto_Cobrar = 0;
            Datos_Factura_Cache.List_articulos_Vendidos = new List<Articulos_Vendidos>();

           


        }

        private void Btn_Cobrar_Click(object sender, EventArgs e)
        {

            Cobrar_Y_Guardar();


        }

        private void Frm_Cobrar_Factura_Load(object sender, EventArgs e)
        {
            Datos_Factura();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Cliente_Para_Cobrar frm_Buscar_Cliente_Para_Cobrar = new Frm_Buscar_Cliente_Para_Cobrar();
            frm_Buscar_Cliente_Para_Cobrar.ShowDialog();
        }
    }
}
