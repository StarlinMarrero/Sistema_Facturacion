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
    public partial class Frm_Proveedores : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Proveedores()
        {
            InitializeComponent();
           
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            Cargar_Proveedores();
        }
        public void Cargar_Proveedores()
        {
            var lista = db.Proveedors.Where(e => e.EstadoProveedor == true).ToList();
            TablaProveedor.DataSource = lista;
            TablaProveedor.Columns[7].Visible = false;
            Label_Cantidad_Proveedor.Text = lista.Count().ToString();
            Get_Count_Compras();
        }

        private void TablaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Get_Count_Compras();

            }
            else
            {
                Panel_Card_Compras.Visible = false;
            }
        }
        public void Get_Count_Compras()
        {
            Panel_Card_Compras.Visible = true;
            var NumeroDeFilaSeleccionada = TablaProveedor.CurrentRow.Index;
            DataGridViewRow row = this.TablaProveedor.Rows[NumeroDeFilaSeleccionada];
            var IdProveedor = Convert.ToInt32(row.Cells["idProveedor"].Value.ToString());
            var Compras = db.Compras.Where(x => x.idProveedor == IdProveedor).ToList();

            Label_Compras.Text = Compras.Count.ToString();

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar_Cliente();

        }
        public void Buscar_Cliente()
        {
            if (textBox_Buscar.Text.Length == 0)
            {
                Alert_Message.confirmacionForm("Buscar Provedor", "Introduce el nombre o el RUC Proveedor", "Info");
                return;
            }


            var Datos = textBox_Buscar.Text;

            var Proveedor = db.Proveedors.Where(x => x.nombreProveedor.Contains(Datos) || x.RUCProveedor.Contains(Datos)).ToList();

            TablaProveedor.DataSource = Proveedor;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cargar_Proveedores();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            var NumeroDeFilaSeleccionada = TablaProveedor.CurrentRow.Index;
            DataGridViewRow row = this.TablaProveedor.Rows[NumeroDeFilaSeleccionada];
            var Id_Proveedor = Convert.ToInt32(row.Cells["idProveedor"].Value.ToString());

            Frm_Editar_Proveedor frm_Editar_Proveedor = new Frm_Editar_Proveedor();
            frm_Editar_Proveedor.Obtener_Proveedor(Id_Proveedor);
         
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Proveedor frm_Nuevo_Proveedor = new Frm_Nuevo_Proveedor();
            frm_Nuevo_Proveedor.ShowDialog();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Está seguro de eliminar este Proveedor?", "Atención",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == System.Windows.Forms.DialogResult.Yes)
            {
                var NumeroDeFilaSeleccionada = TablaProveedor.CurrentRow.Index;
                DataGridViewRow row = this.TablaProveedor.Rows[NumeroDeFilaSeleccionada];
                var idProveedor = Convert.ToInt32(row.Cells["idProveedor"].Value.ToString());

                var Proveedor = db.Proveedors.Find(idProveedor);
                Proveedor.EstadoProveedor = false;
                db.SaveChanges();
                Cargar_Proveedores();
                Alert_Message.confirmacionForm("Eliminar Proveedor", "Proveedor eliminado", "Info");
            }
        }
    }
}
