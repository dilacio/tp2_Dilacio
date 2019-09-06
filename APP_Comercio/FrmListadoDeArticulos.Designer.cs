namespace APP_Comercio
{
    partial class frmListadoDeArticulos
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(673, 290);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(270, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE ARTICULOS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(242)))));
            this.panel7.Controls.Add(this.pctHome);
            this.panel7.Controls.Add(this.pctCerrar);
            this.panel7.Controls.Add(this.lblHome);
            this.panel7.Location = new System.Drawing.Point(-35, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(851, 35);
            this.panel7.TabIndex = 27;
            // 
            // pctHome
            // 
            this.pctHome.Image = global::APP_Comercio.Properties.Resources._588a666dd06f6719692a2d18;
            this.pctHome.Location = new System.Drawing.Point(39, 12);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(21, 20);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 13;
            this.pctHome.TabStop = false;
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = global::APP_Comercio.Properties.Resources.close_icon_13590;
            this.pctCerrar.Location = new System.Drawing.Point(800, 3);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(30, 29);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 13;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.lblHome.Location = new System.Drawing.Point(71, 14);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(113, 15);
            this.lblHome.TabIndex = 13;
            this.lblHome.Text = "Eliminar articulo";
            // 
            // frmListadoDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoDeArticulos";
            this.Text = "ListadoDeArticulos";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.Label lblHome;
    }
}