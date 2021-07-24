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
    public partial class Frm_Editar_Cliente : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Editar_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Editar_Cliente_Load(object sender, EventArgs e)
        {
            //Obtener_Cliente();
        }
        int Id_Actual;
        public void Obtener_Cliente(int Id)
        {
            Id_Actual = Id;
            var cliente = db.Clientes.Find(Id);
            this.txtCodigo.Text = cliente.IdCliente.ToString();
            this.txtNombres.Text = cliente.NombreCliente;
            this.txtApellidos.Text = cliente.ApellidoCliente;
            this.txtDNI.Text = cliente.DNICliente;
            this.txtRUC.Text = cliente.RUCCliente;
            this.txtTelefono.Text = cliente.TelefonoCliente;
            this.txtDireccion.Text = cliente.DireccionCliente;

            this.ShowDialog();
            //MessageBox.Show(Id.ToString());
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
       
            var cliente = db.Clientes.Find(Id_Actual);

            cliente.IdCliente = Convert.ToInt32(this.txtCodigo.Text);

            cliente.NombreCliente = this.txtNombres.Text;
            cliente.ApellidoCliente = this.txtApellidos.Text;
            cliente.DNICliente = this.txtDNI.Text;
            cliente.RUCCliente = this.txtRUC.Text;
            cliente.TelefonoCliente = this.txtTelefono.Text;
            cliente.DireccionCliente = this.txtDireccion.Text;

            db.SaveChanges();
            this.Close();
            Alert_Message.confirmacionForm("Editar Cliente", "Cliente Editado Correctamente", "Success");
            //MessageBox.Show(Id_Actual.ToString());

        }
    }
}
