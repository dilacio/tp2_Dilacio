namespace APP_Comercio
{
    partial class FrmEliminarArticulo
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
            this.lblHome = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvDetalleArticulo = new System.Windows.Forms.DataGridView();
            this.lblEliminarArticulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.lblHome.Location = new System.Drawing.Point(98, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(113, 15);
            this.lblHome.TabIndex = 13;
            this.lblHome.Text = "Eliminar articulo";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(242)))));
            this.panel7.Controls.Add(this.pctHome);
            this.panel7.Controls.Add(this.pctCerrar);
            this.panel7.Controls.Add(this.lblHome);
            this.panel7.Location = new System.Drawing.Point(-61, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(905, 35);
            this.panel7.TabIndex = 26;
            // 
            // pctHome
            // 
            this.pctHome.Image = global::APP_Comercio.Properties.Resources._588a666dd06f6719692a2d18;
            this.pctHome.Location = new System.Drawing.Point(66, 10);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(21, 20);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 13;
            this.pctHome.TabStop = false;
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = global::APP_Comercio.Properties.Resources.close_icon_13590;
            this.pctCerrar.Location = new System.Drawing.Point(858, 4);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(30, 29);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 13;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DimGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(440, 427);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(397, 29);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "Sistema de gestion comercial";
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(31, 143);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(769, 179);
            this.dgvDetalleArticulo.TabIndex = 24;
            // 
            // lblEliminarArticulo
            // 
            this.lblEliminarArticulo.AutoSize = true;
            this.lblEliminarArticulo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarArticulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEliminarArticulo.Location = new System.Drawing.Point(28, 68);
            this.lblEliminarArticulo.Name = "lblEliminarArticulo";
            this.lblEliminarArticulo.Size = new System.Drawing.Size(183, 18);
            this.lblEliminarArticulo.TabIndex = 23;
            this.lblEliminarArticulo.Text = "Ingrese el articulo a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(335, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(241, 65);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(559, 21);
            this.cbxArticulo.TabIndex = 29;
            this.cbxArticulo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // FrmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.cbxArticulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.Controls.Add(this.lblEliminarArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarArticulo";
            this.Text = "FrmEliminarArticulo";
            this.Load += new System.EventHandler(this.FrmEliminarArticulo_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
        private System.Windows.Forms.Label lblEliminarArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxArticulo;
    }
}