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
    public partial class Frm_Buscar_Cliente_Para_Cobrar : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Frm_Buscar_Cliente_Para_Cobrar()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Cliente_Para_Cobrar_Load(object sender, EventArgs e)
        {
            Tabla_Clientes.DataSource = db.Clientes.Where(x => x.EstadoCliente == true).ToList();
            Tabla_Clientes.Columns[3].Visible = false;
            Tabla_Clientes.Columns[4].Visible = false;
            Tabla_Clientes.Columns[5].Visible = false;
            Tabla_Clientes.Columns[6].Visible = false;
            Tabla_Clientes.Columns[7].Visible = false;
            Tabla_Clientes.Columns[8].Visible = false;
        }

        private void Tabla_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
