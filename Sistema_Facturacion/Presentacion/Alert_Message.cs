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
    public partial class Alert_Message : Form
    {
        public Alert_Message(string Titulo, string Text, string icon)
        {
            InitializeComponent();
            lbTexto.Text = Text;
            lbTitulo.Text = Titulo;
            Panel_Top.Tag = icon;
            var icono = icon;
        }

        public static void confirmacionForm(string Titulo, string Text, string icon)
        {
            Alert_Message frm = new Alert_Message(Titulo, Text, icon);

            if (icon == "Success")
            {
                frm.Panel_Top.BackColor = ColorTranslator.FromHtml("#2ecc71");
                frm.Icono_Success.Visible = true;
                //frm.btnOK.BackColor = ColorTranslator.FromHtml("#2ecc71");
                frm.btnOK.Normalcolor = ColorTranslator.FromHtml("#2ecc71");
                frm.btnOK.OnHovercolor = ColorTranslator.FromHtml("#27ae60");

                //Panel_Top.BackColor = ColorTranslator.FromHtml("#ffff99");
            }
            else if (icon == "Info")
            {
                frm.Panel_Top.BackColor = ColorTranslator.FromHtml("#3498db");
                frm.Icono_Info.Visible = true;
                frm.btnOK.Normalcolor = ColorTranslator.FromHtml("#3498db");
                frm.btnOK.OnHovercolor = ColorTranslator.FromHtml("#2980b9");

            }
            else if (icon == "Error")
            {
                frm.Panel_Top.BackColor = ColorTranslator.FromHtml("#e74c3c");
                frm.Icono_Error.Visible = true;
                frm.btnOK.Normalcolor = ColorTranslator.FromHtml("#e74c3c");
                frm.btnOK.OnHovercolor = ColorTranslator.FromHtml("#c0392b");

            }


            frm.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
