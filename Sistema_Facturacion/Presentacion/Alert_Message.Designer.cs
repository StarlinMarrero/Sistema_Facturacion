
namespace Sistema_Facturacion.Presentacion
{
    partial class Alert_Message
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert_Message));
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Icono_Info = new System.Windows.Forms.PictureBox();
            this.Icono_Success = new System.Windows.Forms.PictureBox();
            this.Icono_Error = new System.Windows.Forms.PictureBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Error)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Panel_Top.Controls.Add(this.Icono_Info);
            this.Panel_Top.Controls.Add(this.Icono_Success);
            this.Panel_Top.Controls.Add(this.Icono_Error);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(284, 130);
            this.Panel_Top.TabIndex = 2;
            // 
            // Icono_Info
            // 
            this.Icono_Info.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Info.Image")));
            this.Icono_Info.Location = new System.Drawing.Point(93, 12);
            this.Icono_Info.Name = "Icono_Info";
            this.Icono_Info.Size = new System.Drawing.Size(98, 100);
            this.Icono_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icono_Info.TabIndex = 2;
            this.Icono_Info.TabStop = false;
            this.Icono_Info.Visible = false;
            // 
            // Icono_Success
            // 
            this.Icono_Success.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Success.Image")));
            this.Icono_Success.Location = new System.Drawing.Point(90, 12);
            this.Icono_Success.Name = "Icono_Success";
            this.Icono_Success.Size = new System.Drawing.Size(98, 100);
            this.Icono_Success.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icono_Success.TabIndex = 0;
            this.Icono_Success.TabStop = false;
            this.Icono_Success.Visible = false;
            // 
            // Icono_Error
            // 
            this.Icono_Error.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Error.Image")));
            this.Icono_Error.Location = new System.Drawing.Point(90, 12);
            this.Icono_Error.Name = "Icono_Error";
            this.Icono_Error.Size = new System.Drawing.Size(98, 100);
            this.Icono_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icono_Error.TabIndex = 1;
            this.Icono_Error.TabStop = false;
            this.Icono_Error.Visible = false;
            // 
            // lbTexto
            // 
            this.lbTexto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTexto.Location = new System.Drawing.Point(11, 218);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(262, 71);
            this.lbTexto.TabIndex = 7;
            this.lbTexto.Text = "Lorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostracio" +
    "nes de tipografías o de borradores de diseño para probar el diseño visual antes " +
    "de insertar el texto final. ";
            this.lbTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(11, 133);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(262, 50);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Mensaje";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Active = false;
            this.btnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderRadius = 7;
            this.btnOK.ButtonText = "Aceptar";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DisabledColor = System.Drawing.Color.Gray;
            this.btnOK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOK.Iconimage = null;
            this.btnOK.Iconimage_right = null;
            this.btnOK.Iconimage_right_Selected = null;
            this.btnOK.Iconimage_Selected = null;
            this.btnOK.IconMarginLeft = 0;
            this.btnOK.IconMarginRight = 0;
            this.btnOK.IconRightVisible = true;
            this.btnOK.IconRightZoom = 0D;
            this.btnOK.IconVisible = true;
            this.btnOK.IconZoom = 90D;
            this.btnOK.IsTab = false;
            this.btnOK.Location = new System.Drawing.Point(58, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.selected = false;
            this.btnOK.Size = new System.Drawing.Size(168, 48);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Aceptar";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Textcolor = System.Drawing.Color.White;
            this.btnOK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.lbTexto);
            this.bunifuShadowPanel1.Controls.Add(this.lbTitulo);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(284, 409);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 9;
            // 
            // Alert_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 409);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert_Message";
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Error)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.PictureBox Icono_Info;
        private System.Windows.Forms.PictureBox Icono_Error;
        private System.Windows.Forms.PictureBox Icono_Success;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Label lbTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnOK;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
    }
}