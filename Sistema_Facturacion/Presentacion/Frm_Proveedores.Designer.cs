
namespace Sistema_Facturacion.Presentacion
{
    partial class Frm_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedores));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Wrapper = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Btn_Actualizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel_Card_Compras = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Label_Compras = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Eliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Editar = new Bunifu.Framework.UI.BunifuTileButton();
            this.Btn_Registrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.TablaProveedor = new System.Windows.Forms.DataGridView();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUCProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Label_Cantidad_Proveedor = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.Panel_Wrapper.SuspendLayout();
            this.Panel_Card_Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedor)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel5.Location = new System.Drawing.Point(8, 12);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(283, 25);
            this.bunifuLabel5.TabIndex = 4;
            this.bunifuLabel5.Text = "Mantenimiento De Proveedores";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.bunifuLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 50);
            this.panel2.TabIndex = 33;
            // 
            // Panel_Wrapper
            // 
            this.Panel_Wrapper.BackgroundColor = System.Drawing.Color.Transparent;
            this.Panel_Wrapper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Wrapper.BackgroundImage")));
            this.Panel_Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Wrapper.BorderColor = System.Drawing.Color.Transparent;
            this.Panel_Wrapper.BorderRadius = 3;
            this.Panel_Wrapper.BorderThickness = 1;
            this.Panel_Wrapper.Controls.Add(this.bunifuLabel4);
            this.Panel_Wrapper.Controls.Add(this.Btn_Actualizar);
            this.Panel_Wrapper.Controls.Add(this.textBox_Buscar);
            this.Panel_Wrapper.Controls.Add(this.Btn_Buscar);
            this.Panel_Wrapper.Controls.Add(this.Panel_Card_Compras);
            this.Panel_Wrapper.Controls.Add(this.Btn_Eliminar);
            this.Panel_Wrapper.Controls.Add(this.Btn_Editar);
            this.Panel_Wrapper.Controls.Add(this.Btn_Registrar);
            this.Panel_Wrapper.Controls.Add(this.TablaProveedor);
            this.Panel_Wrapper.Controls.Add(this.bunifuShadowPanel1);
            this.Panel_Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Wrapper.Location = new System.Drawing.Point(0, 50);
            this.Panel_Wrapper.Name = "Panel_Wrapper";
            this.Panel_Wrapper.ShowBorders = true;
            this.Panel_Wrapper.Size = new System.Drawing.Size(879, 558);
            this.Panel_Wrapper.TabIndex = 34;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(13, 124);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(92, 15);
            this.bunifuLabel4.TabIndex = 40;
            this.bunifuLabel4.Text = "Buscar Proveedor";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.AllowAnimations = true;
            this.Btn_Actualizar.AllowMouseEffects = true;
            this.Btn_Actualizar.AllowToggling = false;
            this.Btn_Actualizar.AnimationSpeed = 200;
            this.Btn_Actualizar.AutoGenerateColors = false;
            this.Btn_Actualizar.AutoRoundBorders = false;
            this.Btn_Actualizar.AutoSizeLeftIcon = true;
            this.Btn_Actualizar.AutoSizeRightIcon = true;
            this.Btn_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Actualizar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.BackgroundImage")));
            this.Btn_Actualizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Actualizar.ButtonText = "Actualizar";
            this.Btn_Actualizar.ButtonTextMarginLeft = 0;
            this.Btn_Actualizar.ColorContrastOnClick = 45;
            this.Btn_Actualizar.ColorContrastOnHover = 45;
            this.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Btn_Actualizar.CustomizableEdges = borderEdges3;
            this.Btn_Actualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Actualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Actualizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Actualizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Actualizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Actualizar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Actualizar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Actualizar.IconMarginLeft = 11;
            this.Btn_Actualizar.IconPadding = 10;
            this.Btn_Actualizar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Actualizar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Actualizar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Actualizar.IconSize = 25;
            this.Btn_Actualizar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Actualizar.IdleBorderRadius = 1;
            this.Btn_Actualizar.IdleBorderThickness = 1;
            this.Btn_Actualizar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Actualizar.IdleIconLeftImage = null;
            this.Btn_Actualizar.IdleIconRightImage = null;
            this.Btn_Actualizar.IndicateFocus = false;
            this.Btn_Actualizar.Location = new System.Drawing.Point(357, 145);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Actualizar.OnDisabledState.BorderRadius = 1;
            this.Btn_Actualizar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Actualizar.OnDisabledState.BorderThickness = 1;
            this.Btn_Actualizar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Actualizar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Actualizar.OnDisabledState.IconLeftImage = null;
            this.Btn_Actualizar.OnDisabledState.IconRightImage = null;
            this.Btn_Actualizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Actualizar.onHoverState.BorderRadius = 1;
            this.Btn_Actualizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Actualizar.onHoverState.BorderThickness = 1;
            this.Btn_Actualizar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Actualizar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.onHoverState.IconLeftImage = null;
            this.Btn_Actualizar.onHoverState.IconRightImage = null;
            this.Btn_Actualizar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Actualizar.OnIdleState.BorderRadius = 1;
            this.Btn_Actualizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Actualizar.OnIdleState.BorderThickness = 1;
            this.Btn_Actualizar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Actualizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.OnIdleState.IconLeftImage = null;
            this.Btn_Actualizar.OnIdleState.IconRightImage = null;
            this.Btn_Actualizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Actualizar.OnPressedState.BorderRadius = 1;
            this.Btn_Actualizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Actualizar.OnPressedState.BorderThickness = 1;
            this.Btn_Actualizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Actualizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.OnPressedState.IconLeftImage = null;
            this.Btn_Actualizar.OnPressedState.IconRightImage = null;
            this.Btn_Actualizar.Size = new System.Drawing.Size(106, 20);
            this.Btn_Actualizar.TabIndex = 39;
            this.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Actualizar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Actualizar.TextMarginLeft = 0;
            this.Btn_Actualizar.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Actualizar.UseDefaultRadiusAndThickness = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(8, 145);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(222, 20);
            this.textBox_Buscar.TabIndex = 38;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.AllowAnimations = true;
            this.Btn_Buscar.AllowMouseEffects = true;
            this.Btn_Buscar.AllowToggling = false;
            this.Btn_Buscar.AnimationSpeed = 200;
            this.Btn_Buscar.AutoGenerateColors = false;
            this.Btn_Buscar.AutoRoundBorders = false;
            this.Btn_Buscar.AutoSizeLeftIcon = true;
            this.Btn_Buscar.AutoSizeRightIcon = true;
            this.Btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Buscar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Buscar.ButtonText = "Buscar";
            this.Btn_Buscar.ButtonTextMarginLeft = 0;
            this.Btn_Buscar.ColorContrastOnClick = 45;
            this.Btn_Buscar.ColorContrastOnHover = 45;
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Btn_Buscar.CustomizableEdges = borderEdges4;
            this.Btn_Buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Buscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Buscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Buscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Buscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Buscar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Buscar.IconMarginLeft = 11;
            this.Btn_Buscar.IconPadding = 10;
            this.Btn_Buscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Buscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Buscar.IconSize = 25;
            this.Btn_Buscar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Buscar.IdleBorderRadius = 1;
            this.Btn_Buscar.IdleBorderThickness = 1;
            this.Btn_Buscar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Buscar.IdleIconLeftImage = null;
            this.Btn_Buscar.IdleIconRightImage = null;
            this.Btn_Buscar.IndicateFocus = false;
            this.Btn_Buscar.Location = new System.Drawing.Point(242, 145);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Buscar.OnDisabledState.BorderRadius = 1;
            this.Btn_Buscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Buscar.OnDisabledState.BorderThickness = 1;
            this.Btn_Buscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Buscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Buscar.OnDisabledState.IconLeftImage = null;
            this.Btn_Buscar.OnDisabledState.IconRightImage = null;
            this.Btn_Buscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Buscar.onHoverState.BorderRadius = 1;
            this.Btn_Buscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Buscar.onHoverState.BorderThickness = 1;
            this.Btn_Buscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Buscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.onHoverState.IconLeftImage = null;
            this.Btn_Buscar.onHoverState.IconRightImage = null;
            this.Btn_Buscar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Buscar.OnIdleState.BorderRadius = 1;
            this.Btn_Buscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Buscar.OnIdleState.BorderThickness = 1;
            this.Btn_Buscar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Buscar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.OnIdleState.IconLeftImage = null;
            this.Btn_Buscar.OnIdleState.IconRightImage = null;
            this.Btn_Buscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Buscar.OnPressedState.BorderRadius = 1;
            this.Btn_Buscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Buscar.OnPressedState.BorderThickness = 1;
            this.Btn_Buscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Buscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.OnPressedState.IconLeftImage = null;
            this.Btn_Buscar.OnPressedState.IconRightImage = null;
            this.Btn_Buscar.Size = new System.Drawing.Size(106, 20);
            this.Btn_Buscar.TabIndex = 37;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Buscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Buscar.TextMarginLeft = 0;
            this.Btn_Buscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Buscar.UseDefaultRadiusAndThickness = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Panel_Card_Compras
            // 
            this.Panel_Card_Compras.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Card_Compras.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Card_Compras.BorderRadius = 1;
            this.Panel_Card_Compras.BorderThickness = 1;
            this.Panel_Card_Compras.Controls.Add(this.bunifuLabel1);
            this.Panel_Card_Compras.Controls.Add(this.Label_Compras);
            this.Panel_Card_Compras.Controls.Add(this.pictureBox2);
            this.Panel_Card_Compras.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.Panel_Card_Compras.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.Panel_Card_Compras.Location = new System.Drawing.Point(642, 9);
            this.Panel_Card_Compras.Name = "Panel_Card_Compras";
            this.Panel_Card_Compras.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Card_Compras.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.Panel_Card_Compras.ShadowColor = System.Drawing.Color.DarkGray;
            this.Panel_Card_Compras.ShadowDept = 2;
            this.Panel_Card_Compras.ShadowDepth = 5;
            this.Panel_Card_Compras.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.Panel_Card_Compras.ShadowTopLeftVisible = false;
            this.Panel_Card_Compras.Size = new System.Drawing.Size(234, 109);
            this.Panel_Card_Compras.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.Panel_Card_Compras.TabIndex = 36;
            this.Panel_Card_Compras.Visible = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel1.Location = new System.Drawing.Point(91, 44);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(75, 25);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Compras";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Label_Compras
            // 
            this.Label_Compras.AllowParentOverrides = false;
            this.Label_Compras.AutoEllipsis = false;
            this.Label_Compras.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Compras.CursorType = System.Windows.Forms.Cursors.Default;
            this.Label_Compras.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Label_Compras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Compras.Location = new System.Drawing.Point(172, 21);
            this.Label_Compras.Name = "Label_Compras";
            this.Label_Compras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Compras.Size = new System.Drawing.Size(56, 65);
            this.Label_Compras.TabIndex = 1;
            this.Label_Compras.Text = "10";
            this.Label_Compras.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label_Compras.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistema_Facturacion.Properties.Resources.icons8_buy_for_change_48;
            this.pictureBox2.Location = new System.Drawing.Point(15, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Eliminar.color = System.Drawing.Color.SeaGreen;
            this.Btn_Eliminar.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = global::Sistema_Facturacion.Properties.Resources.icons8_delete_bin_48;
            this.Btn_Eliminar.ImagePosition = 20;
            this.Btn_Eliminar.ImageZoom = 50;
            this.Btn_Eliminar.LabelPosition = 41;
            this.Btn_Eliminar.LabelText = "Eliminar";
            this.Btn_Eliminar.Location = new System.Drawing.Point(242, 6);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(106, 112);
            this.Btn_Eliminar.TabIndex = 34;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.Gold;
            this.Btn_Editar.color = System.Drawing.Color.Gold;
            this.Btn_Editar.colorActive = System.Drawing.Color.Goldenrod;
            this.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Editar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Image = global::Sistema_Facturacion.Properties.Resources.icons8_edit_96;
            this.Btn_Editar.ImagePosition = 20;
            this.Btn_Editar.ImageZoom = 50;
            this.Btn_Editar.LabelPosition = 41;
            this.Btn_Editar.LabelText = "Editar";
            this.Btn_Editar.Location = new System.Drawing.Point(124, 6);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(106, 112);
            this.Btn_Editar.TabIndex = 33;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_Registrar.color = System.Drawing.Color.DarkTurquoise;
            this.Btn_Registrar.colorActive = System.Drawing.Color.DarkTurquoise;
            this.Btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Registrar.Image = global::Sistema_Facturacion.Properties.Resources.new_contact_48;
            this.Btn_Registrar.ImagePosition = 20;
            this.Btn_Registrar.ImageZoom = 50;
            this.Btn_Registrar.LabelPosition = 41;
            this.Btn_Registrar.LabelText = "Nuevo";
            this.Btn_Registrar.Location = new System.Drawing.Point(6, 6);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(106, 112);
            this.Btn_Registrar.TabIndex = 32;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // TablaProveedor
            // 
            this.TablaProveedor.AllowUserToAddRows = false;
            this.TablaProveedor.AllowUserToDeleteRows = false;
            this.TablaProveedor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TablaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.nombreProveedor,
            this.RUCProveedor,
            this.direccionProveedor,
            this.TelefonoProveedor,
            this.FechaRegistro,
            this.EstadoProveedor});
            this.TablaProveedor.Location = new System.Drawing.Point(0, 181);
            this.TablaProveedor.MultiSelect = false;
            this.TablaProveedor.Name = "TablaProveedor";
            this.TablaProveedor.ReadOnly = true;
            this.TablaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProveedor.Size = new System.Drawing.Size(879, 377);
            this.TablaProveedor.TabIndex = 31;
            this.TablaProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProveedor_CellClick);
            // 
            // idProveedor
            // 
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.HeaderText = "Codigo";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.DataPropertyName = "nombreProveedor";
            this.nombreProveedor.HeaderText = "Razon Social";
            this.nombreProveedor.Name = "nombreProveedor";
            this.nombreProveedor.ReadOnly = true;
            // 
            // RUCProveedor
            // 
            this.RUCProveedor.DataPropertyName = "RUCProveedor";
            this.RUCProveedor.HeaderText = "RUC";
            this.RUCProveedor.Name = "RUCProveedor";
            this.RUCProveedor.ReadOnly = true;
            // 
            // direccionProveedor
            // 
            this.direccionProveedor.DataPropertyName = "direccionProveedor";
            this.direccionProveedor.HeaderText = "Dirección";
            this.direccionProveedor.Name = "direccionProveedor";
            this.direccionProveedor.ReadOnly = true;
            // 
            // TelefonoProveedor
            // 
            this.TelefonoProveedor.DataPropertyName = "TelefonoProveedor";
            this.TelefonoProveedor.HeaderText = "Teléfono";
            this.TelefonoProveedor.Name = "TelefonoProveedor";
            this.TelefonoProveedor.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // EstadoProveedor
            // 
            this.EstadoProveedor.DataPropertyName = "EstadoProveedor";
            this.EstadoProveedor.HeaderText = "EstadoProveedor";
            this.EstadoProveedor.Name = "EstadoProveedor";
            this.EstadoProveedor.ReadOnly = true;
            this.EstadoProveedor.Visible = false;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuShadowPanel1.Controls.Add(this.Label_Cantidad_Proveedor);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(357, 6);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(279, 112);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 35;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel2.Location = new System.Drawing.Point(91, 44);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(105, 25);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Proveedores";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Label_Cantidad_Proveedor
            // 
            this.Label_Cantidad_Proveedor.AllowParentOverrides = false;
            this.Label_Cantidad_Proveedor.AutoEllipsis = false;
            this.Label_Cantidad_Proveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Cantidad_Proveedor.CursorType = System.Windows.Forms.Cursors.Default;
            this.Label_Cantidad_Proveedor.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Label_Cantidad_Proveedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Cantidad_Proveedor.Location = new System.Drawing.Point(202, 21);
            this.Label_Cantidad_Proveedor.Name = "Label_Cantidad_Proveedor";
            this.Label_Cantidad_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Cantidad_Proveedor.Size = new System.Drawing.Size(56, 65);
            this.Label_Cantidad_Proveedor.TabIndex = 1;
            this.Label_Cantidad_Proveedor.Text = "10";
            this.Label_Cantidad_Proveedor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label_Cantidad_Proveedor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 608);
            this.Controls.Add(this.Panel_Wrapper);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Proveedores";
            this.Text = "Frm_Proveedores";
            this.Load += new System.EventHandler(this.Frm_Proveedores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel_Wrapper.ResumeLayout(false);
            this.Panel_Wrapper.PerformLayout();
            this.Panel_Card_Compras.ResumeLayout(false);
            this.Panel_Card_Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedor)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPanel Panel_Wrapper;
        private System.Windows.Forms.DataGridView TablaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUCProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProveedor;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Eliminar;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Editar;
        private Bunifu.Framework.UI.BunifuTileButton Btn_Registrar;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel Label_Cantidad_Proveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuShadowPanel Panel_Card_Compras;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel Label_Compras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Actualizar;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Buscar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}