using Sistema_Facturacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Presentacion
{
    public partial class Frm_Clientes : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Clientes()
        {
            InitializeComponent();
        }
        //public class DTO_Clientes : Cliente { }
        public void Cargar_Clientes()
        {
            var lista = db.Clientes.Include(x => x.Facturas).Where(x => x.EstadoCliente == true).ToList();

            TablaClientes.DataSource = lista;
            Label_Cantidad_Clientes.Text = lista.Count().ToString();
            TablaClientes.Columns[8].Visible = false;
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            Cargar_Clientes();
           
        }
        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //habilitarbotones(true, false, true, true, true, true, true);
        }

        private void TablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Panel_Card_Factura.Visible = true;
                DataGridViewRow row = this.TablaClientes.Rows[e.RowIndex];
                var IdCliente = Convert.ToInt32(row.Cells["IdCliente"].Value.ToString());
                var facturas = db.Facturas.Where(x => x.IdCliente == IdCliente).ToList();

                Label_Cant_Facturas.Text = facturas.Count.ToString();


            }
            else
            {
                Panel_Card_Factura.Visible = false;
            }
        }


        private void Btn_Buscar_Cliente_Click(object sender, EventArgs e)
        {
            Buscar_Cliente();
        }

        private void textBox_buscar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                Buscar_Cliente();
               
            }
            if (e.KeyChar == 27)
            {
                if (textBox_buscar_cliente.Text.Length == 0)
                {
                    Cargar_Clientes();
                }
               

            }
            //MessageBox.Show(Convert.ToInt32(e.KeyChar).ToString());
        }

        private void Buscar_Cliente()
        {
            if (textBox_buscar_cliente.Text.Length == 0)
            {
                Alert_Message.confirmacionForm("Buscar Cliente", "Introduce el nombre o el apellido de un cliente", "Info");
                return;
            }

            var Campo_Buscar = textBox_buscar_cliente.Text;

            var clientes = db.Clientes.Where(x => x.NombreCliente.Contains(Campo_Buscar) || x.ApellidoCliente.Contains(Campo_Buscar)).ToList();

            TablaClientes.DataSource = clientes;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
           var NumeroDeFilaSeleccionada = TablaClientes.CurrentRow.Index;
            DataGridViewRow row = this.TablaClientes.Rows[NumeroDeFilaSeleccionada];
            var IdCliente = Convert.ToInt32(row.Cells["IdCliente"].Value.ToString());
            Frm_Editar_Cliente frm_Editar_Cliente = new Frm_Editar_Cliente();
            frm_Editar_Cliente.Obtener_Cliente(IdCliente);


            //MessageBox.Show(IdCliente.ToString());
        }

        private Form formActivado = null;
        private void AbrirFormulario(Form FormHijo)
        {
            if (formActivado != null)
            {
                formActivado.Close();

            }

            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            //FormHijo.Dock = DockStyle.Fill;
            //Wrapper.Controls.Add(FormHijo);
            //Wrapper.Tag = FormHijo;
            //FormHijo.BringToFront();
            FormHijo.ShowDialog();

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cargar_Clientes();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
           

            if (MessageBox.Show("Está seguro de eliminar este cliente?", "Atención",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == System.Windows.Forms.DialogResult.Yes)
            {
                var NumeroDeFilaSeleccionada = TablaClientes.CurrentRow.Index;
                DataGridViewRow row = this.TablaClientes.Rows[NumeroDeFilaSeleccionada];
                var IdCliente = Convert.ToInt32(row.Cells["IdCliente"].Value.ToString());

                var cliente = db.Clientes.Find(IdCliente);
                cliente.EstadoCliente = false;
                db.SaveChanges();
                Cargar_Clientes();
                Alert_Message.confirmacionForm("Eliminar Cliente", "Cliente eliminado", "Info");
            }


        }

        private void Btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Cliente frm_Nuevo_Cliente = new Frm_Nuevo_Cliente();
            frm_Nuevo_Cliente.ShowDialog();
        }
    }
}
