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
    public partial class Frm_Nuevo_Cliente : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Nuevo_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            var model = new Cliente
            {
                IdCliente = Convert.ToInt32(this.txtCodigo.Text),
                NombreCliente = this.txtNombres.Text,
            ApellidoCliente = this.txtApellidos.Text,
            DNICliente = this.txtDNI.Text,
            RUCCliente = this.txtRUC.Text,
            TelefonoCliente = this.txtTelefono.Text,
            DireccionCliente = this.txtDireccion.Text,
            EstadoCliente = true



        };

            db.Clientes.Add(model);
            db.SaveChanges();
            this.Close();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
