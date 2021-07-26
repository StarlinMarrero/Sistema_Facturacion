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
    public partial class Frm_Editar_Proveedor : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Editar_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Editar_Proveedor_Load(object sender, EventArgs e)
        {

        }
        int Id_Actual;
        public void Obtener_Proveedor(int Id)
        {
            Id_Actual = Id;
            var Proveedor = db.Proveedors.Find(Id);

            txtCodigo.Text = Proveedor.idProveedor.ToString();
            txtRazon_Social.Text = Proveedor.nombreProveedor;
            txtRUC_Proveedor.Text = Proveedor.RUCProveedor;
            txtTelefono.Text = Proveedor.TelefonoProveedor;
            txtDireccion.Text = Proveedor.direccionProveedor;
            
            this.ShowDialog();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            
            var Proveedor = db.Proveedors.Find(Id_Actual);

           
            Proveedor.idProveedor = Convert.ToInt32(txtCodigo.Text);
            Proveedor.nombreProveedor = txtRazon_Social.Text;
            Proveedor.RUCProveedor = txtRUC_Proveedor.Text;
            Proveedor.TelefonoProveedor = txtTelefono.Text;
            Proveedor.direccionProveedor = txtDireccion.Text;

            db.SaveChanges();
            this.Close();
            Alert_Message.confirmacionForm("Editar Proveedor", "Proveedor Editado Correctamente", "Success");

        }
    }
}
