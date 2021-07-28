using Sistema_Facturacion.Cache;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
           
            InitializeComponent();
        }

       
    

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Productos());
        }
        private void LoadDataUser()
        {
            Label_Nombre_Usuario.Text = UserLoginCache.login;
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
                FormHijo.Dock = DockStyle.Fill;
                Wrapper.Controls.Add(FormHijo);
                Wrapper.Tag = FormHijo;
                FormHijo.BringToFront();
                FormHijo.Show();
         
        }

        private void Wrapper_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            AbrirFormulario(new Frm_Inicio());
         
        }

        private void Frm_Principal_Closing(object sender, FormClosingEventArgs e)
        {
           


            if (MessageBox.Show("Está seguro de Cerrar aplicación?", "Atención",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Ventas());
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Lb_Nombre_Negocio_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Inicio());
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Clientes());
        }

        private void Btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Proveedores());
        }
    }
}
