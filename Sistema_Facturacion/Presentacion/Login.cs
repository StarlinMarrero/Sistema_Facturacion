using Sistema_Facturacion.Cache;
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
    public partial class Login_Form : Form
    {
        private SistemaFacturacionEntities db = new SistemaFacturacionEntities();
        public Login_Form()
        {
            InitializeComponent();
            //this.db = entities;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {



            var usuario = db.Usuarios.Where(x => x.login == Tbox_User.Text).FirstOrDefault();

            if (usuario == null)
            {
                Alert_Message.confirmacionForm("Login", $"Usuario no Registrado", "Error");
                return;
            }

            if (usuario.password != TBox_Pass.Text)
            {
                Alert_Message.confirmacionForm("Login", $"Contraseña Incorrecta", "Info");
                return;
            }
            else if (usuario.password == TBox_Pass.Text)
            {
                UserLoginCache.IdUsuario = usuario.IdUsuario;
                UserLoginCache.login = usuario.login;


                Alert_Message.confirmacionForm("Login", $"Bienvenido {usuario.login}", "Success");
                Console.WriteLine("Inicio Ok");
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                //FrmPrincipal.Abrir_Frm_Principal(usuario.login);

                //MDILayout mDILayout = new MDILayout();
                //mDILayout.Show();
            }


        }
    }
}
