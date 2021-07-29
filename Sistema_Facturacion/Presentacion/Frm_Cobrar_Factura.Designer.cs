
namespace Sistema_Facturacion.Presentacion
{
    partial class Frm_Cobrar_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cobrar_Factura));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBox_monto = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Label_Monto = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_Cancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn_Cobrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.bunifuLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 50);
            this.panel2.TabIndex = 34;
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
            this.bunifuLabel5.Size = new System.Drawing.Size(62, 25);
            this.bunifuLabel5.TabIndex = 4;
            this.bunifuLabel5.Text = "Cobrar";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBox_monto
            // 
            this.textBox_monto.Location = new System.Drawing.Point(144, 119);
            this.textBox_monto.Name = "textBox_monto";
            this.textBox_monto.Size = new System.Drawing.Size(182, 20);
            this.textBox_monto.TabIndex = 38;
            this.textBox_monto.Text = "0";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(144, 98);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(78, 15);
            this.bunifuLabel1.TabIndex = 39;
            this.bunifuLabel1.Text = "Monto a Pagar";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Label_Monto
            // 
            this.Label_Monto.AllowParentOverrides = false;
            this.Label_Monto.AutoEllipsis = false;
            this.Label_Monto.CursorType = null;
            this.Label_Monto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_Monto.Location = new System.Drawing.Point(144, 77);
            this.Label_Monto.Name = "Label_Monto";
            this.Label_Monto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Monto.Size = new System.Drawing.Size(127, 15);
            this.Label_Monto.TabIndex = 40;
            this.Label_Monto.Text = "El monto a cobrar es de:";
            this.Label_Monto.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label_Monto.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AllowAnimations = true;
            this.btn_Cancelar.AllowMouseEffects = true;
            this.btn_Cancelar.AllowToggling = false;
            this.btn_Cancelar.AnimationSpeed = 200;
            this.btn_Cancelar.AutoGenerateColors = false;
            this.btn_Cancelar.AutoRoundBorders = false;
            this.btn_Cancelar.AutoSizeLeftIcon = true;
            this.btn_Cancelar.AutoSizeRightIcon = true;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.ButtonTextMarginLeft = 0;
            this.btn_Cancelar.ColorContrastOnClick = 45;
            this.btn_Cancelar.ColorContrastOnHover = 45;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Cancelar.CustomizableEdges = borderEdges1;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Cancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Cancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Cancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Cancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Cancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Cancelar.IconMarginLeft = 11;
            this.btn_Cancelar.IconPadding = 10;
            this.btn_Cancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Cancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Cancelar.IconSize = 25;
            this.btn_Cancelar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.IdleBorderRadius = 1;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.IdleIconLeftImage = global::Sistema_Facturacion.Properties.Resources.icons8_cancel_96;
            this.btn_Cancelar.IdleIconRightImage = null;
            this.btn_Cancelar.IndicateFocus = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(256, 166);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Cancelar.OnDisabledState.BorderRadius = 1;
            this.btn_Cancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cancelar.OnDisabledState.BorderThickness = 1;
            this.btn_Cancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Cancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Cancelar.OnDisabledState.IconLeftImage = null;
            this.btn_Cancelar.OnDisabledState.IconRightImage = null;
            this.btn_Cancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Cancelar.onHoverState.BorderRadius = 1;
            this.btn_Cancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cancelar.onHoverState.BorderThickness = 1;
            this.btn_Cancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Cancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.onHoverState.IconLeftImage = null;
            this.btn_Cancelar.onHoverState.IconRightImage = null;
            this.btn_Cancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.OnIdleState.BorderRadius = 1;
            this.btn_Cancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cancelar.OnIdleState.BorderThickness = 1;
            this.btn_Cancelar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.OnIdleState.IconLeftImage = global::Sistema_Facturacion.Properties.Resources.icons8_cancel_96;
            this.btn_Cancelar.OnIdleState.IconRightImage = null;
            this.btn_Cancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Cancelar.OnPressedState.BorderRadius = 1;
            this.btn_Cancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Cancelar.OnPressedState.BorderThickness = 1;
            this.btn_Cancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Cancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.OnPressedState.IconLeftImage = null;
            this.btn_Cancelar.OnPressedState.IconRightImage = null;
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 40);
            this.btn_Cancelar.TabIndex = 36;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Cancelar.TextMarginLeft = 0;
            this.btn_Cancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Cancelar.UseDefaultRadiusAndThickness = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Btn_Cobrar
            // 
            this.Btn_Cobrar.AllowAnimations = true;
            this.Btn_Cobrar.AllowMouseEffects = true;
            this.Btn_Cobrar.AllowToggling = false;
            this.Btn_Cobrar.AnimationSpeed = 200;
            this.Btn_Cobrar.AutoGenerateColors = false;
            this.Btn_Cobrar.AutoRoundBorders = false;
            this.Btn_Cobrar.AutoSizeLeftIcon = true;
            this.Btn_Cobrar.AutoSizeRightIcon = true;
            this.Btn_Cobrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cobrar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Btn_Cobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cobrar.BackgroundImage")));
            this.Btn_Cobrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cobrar.ButtonText = "Cobrar";
            this.Btn_Cobrar.ButtonTextMarginLeft = 0;
            this.Btn_Cobrar.ColorContrastOnClick = 45;
            this.Btn_Cobrar.ColorContrastOnHover = 45;
            this.Btn_Cobrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Btn_Cobrar.CustomizableEdges = borderEdges2;
            this.Btn_Cobrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Cobrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Cobrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Cobrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Cobrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Cobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Cobrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cobrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cobrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Cobrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Cobrar.IconMarginLeft = 11;
            this.Btn_Cobrar.IconPadding = 10;
            this.Btn_Cobrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cobrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Cobrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Cobrar.IconSize = 25;
            this.Btn_Cobrar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cobrar.IdleBorderRadius = 1;
            this.Btn_Cobrar.IdleBorderThickness = 1;
            this.Btn_Cobrar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cobrar.IdleIconLeftImage = global::Sistema_Facturacion.Properties.Resources.icons8_add_dollar_96;
            this.Btn_Cobrar.IdleIconRightImage = null;
            this.Btn_Cobrar.IndicateFocus = false;
            this.Btn_Cobrar.Location = new System.Drawing.Point(378, 166);
            this.Btn_Cobrar.Name = "Btn_Cobrar";
            this.Btn_Cobrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Cobrar.OnDisabledState.BorderRadius = 1;
            this.Btn_Cobrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cobrar.OnDisabledState.BorderThickness = 1;
            this.Btn_Cobrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Cobrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Cobrar.OnDisabledState.IconLeftImage = null;
            this.Btn_Cobrar.OnDisabledState.IconRightImage = null;
            this.Btn_Cobrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Cobrar.onHoverState.BorderRadius = 1;
            this.Btn_Cobrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cobrar.onHoverState.BorderThickness = 1;
            this.Btn_Cobrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Cobrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Cobrar.onHoverState.IconLeftImage = null;
            this.Btn_Cobrar.onHoverState.IconRightImage = null;
            this.Btn_Cobrar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cobrar.OnIdleState.BorderRadius = 1;
            this.Btn_Cobrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cobrar.OnIdleState.BorderThickness = 1;
            this.Btn_Cobrar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cobrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn_Cobrar.OnIdleState.IconLeftImage = global::Sistema_Facturacion.Properties.Resources.icons8_add_dollar_96;
            this.Btn_Cobrar.OnIdleState.IconRightImage = null;
            this.Btn_Cobrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Cobrar.OnPressedState.BorderRadius = 1;
            this.Btn_Cobrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Cobrar.OnPressedState.BorderThickness = 1;
            this.Btn_Cobrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Cobrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Cobrar.OnPressedState.IconLeftImage = null;
            this.Btn_Cobrar.OnPressedState.IconRightImage = null;
            this.Btn_Cobrar.Size = new System.Drawing.Size(116, 40);
            this.Btn_Cobrar.TabIndex = 35;
            this.Btn_Cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cobrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Cobrar.TextMarginLeft = 0;
            this.Btn_Cobrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Cobrar.UseDefaultRadiusAndThickness = true;
            this.Btn_Cobrar.Click += new System.EventHandler(this.Btn_Cobrar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            this.bunifuShadowPanel1.Controls.Add(this.Label_Monto);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.Controls.Add(this.textBox_monto);
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
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(505, 218);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Facturacion.Properties.Resources.icons8_add_dollar_96;
            this.pictureBox1.Location = new System.Drawing.Point(28, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Cobrar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 218);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.Btn_Cobrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cobrar_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cobrar_Factura";
            this.Load += new System.EventHandler(this.Frm_Cobrar_Factura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Cobrar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Cancelar;
        private System.Windows.Forms.TextBox textBox_monto;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel Label_Monto;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}