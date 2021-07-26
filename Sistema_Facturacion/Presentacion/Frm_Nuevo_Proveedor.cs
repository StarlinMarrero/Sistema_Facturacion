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
    public partial class Frm_Nuevo_Proveedor : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Nuevo_Proveedor()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtRazon_Social.Text == "" || txtRUC_Proveedor.Text == "" || txtDireccion.Text == "")
            {
                Alert_Message.confirmacionForm("Campos del Proveedor", "Favor de completar los campos requeridos", "Success");

                return;
            }


            var model = new Proveedor
            {
                idProveedor = Convert.ToInt32(txtCodigo.Text),
                nombreProveedor = txtRazon_Social.Text,
                RUCProveedor = txtRUC_Proveedor.Text,
                TelefonoProveedor = txtTelefono.Text,
                direccionProveedor = txtDireccion.Text,
                FechaRegistro = DateTime.Now,
                EstadoProveedor = true

            };

            db.Proveedors.Add(model);
            db.SaveChanges();

            this.Close();
            Alert_Message.confirmacionForm("Nuevo Proveedor", "Nuevo proveedor registrado correctamente.", "Success");
        }
    }
}
