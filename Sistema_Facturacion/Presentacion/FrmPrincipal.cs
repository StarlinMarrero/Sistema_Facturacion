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
            AbrirFormulario(new Frm_Inicio());
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
            AbrirFormulario(new Frm_Inicio());
        }
    }
}
