namespace APP_Comercio
{
    partial class FrmModficarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModficarArticulo));
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.txbCodArticulo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctHome
            // 
            this.pctHome.Image = global::APP_Comercio.Properties.Resources._588a666dd06f6719692a2d18;
            resources.ApplyResources(this.pctHome, "pctHome");
            this.pctHome.Name = "pctHome";
            this.pctHome.TabStop = false;
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = global::APP_Comercio.Properties.Resources.close_icon_13590;
            resources.ApplyResources(this.pctCerrar, "pctCerrar");
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // lblHome
            // 
            resources.ApplyResources(this.lblHome, "lblHome");
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.lblHome.Name = "lblHome";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(242)))));
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.pctHome);
            this.panel7.Controls.Add(this.pctCerrar);
            this.panel7.Controls.Add(this.lblHome);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_Comercio.Properties.Resources.close_icon_13590;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DimGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txbPrecio
            // 
            this.txbPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txbPrecio, "txbPrecio");
            this.txbPrecio.Name = "txbPrecio";
            // 
            // lblPrecio
            // 
            resources.ApplyResources(this.lblPrecio, "lblPrecio");
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Name = "lblPrecio";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.cbxCategoria, "cbxCategoria");
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Name = "cbxCategoria";
            // 
            // lblCategoria
            // 
            resources.ApplyResources(this.lblCategoria, "lblCategoria");
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoria.Name = "lblCategoria";
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.cbxMarca, "cbxMarca");
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Name = "cbxMarca";
            // 
            // lblMarca
            // 
            resources.ApplyResources(this.lblMarca, "lblMarca");
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Name = "lblMarca";
            // 
            // lblDescripcion
            // 
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txbDescripcion, "txbDescripcion");
            this.txbDescripcion.Name = "txbDescripcion";
            // 
            // lblCodArticulo
            // 
            resources.ApplyResources(this.lblCodArticulo, "lblCodArticulo");
            this.lblCodArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodArticulo.Name = "lblCodArticulo";
            // 
            // txbCodArticulo
            // 
            this.txbCodArticulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txbCodArticulo, "txbCodArticulo");
            this.txbCodArticulo.Name = "txbCodArticulo";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Name = "lblNombre";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbxNombre, "tbxNombre");
            this.tbxNombre.Name = "tbxNombre";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.cbxArticulo, "cbxArticulo");
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.SelectedIndexChanged += new System.EventHandler(this.CbxArticulo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxNombre);
            this.panel1.Controls.Add(this.txbPrecio);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txbCodArticulo);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.lblCodArticulo);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.txbDescripcion);
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblMarca);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // FrmModficarArticulo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbxArticulo);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModficarArticulo";
            this.Load += new System.EventHandler(this.FrmModficarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.TextBox txbCodArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}