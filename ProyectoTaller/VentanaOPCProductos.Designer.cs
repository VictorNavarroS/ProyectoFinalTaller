namespace ProyectoTaller
{
    partial class VentanaOPCProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaOPCProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_prov = new System.Windows.Forms.Button();
            this.btn_saliradm = new System.Windows.Forms.Button();
            this.lbl_NombreUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manteVentas = new System.Windows.Forms.Button();
            this.btn_manteBodega = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_prov);
            this.groupBox1.Controls.Add(this.btn_saliradm);
            this.groupBox1.Controls.Add(this.lbl_NombreUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_manteVentas);
            this.groupBox1.Controls.Add(this.btn_manteBodega);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(556, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btn_prov
            // 
            this.btn_prov.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prov.Location = new System.Drawing.Point(98, 267);
            this.btn_prov.Name = "btn_prov";
            this.btn_prov.Size = new System.Drawing.Size(163, 33);
            this.btn_prov.TabIndex = 10;
            this.btn_prov.Text = "Proveedores";
            this.btn_prov.UseVisualStyleBackColor = true;
            this.btn_prov.Visible = false;
            this.btn_prov.Click += new System.EventHandler(this.btn_prov_Click);
            // 
            // btn_saliradm
            // 
            this.btn_saliradm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_saliradm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saliradm.Location = new System.Drawing.Point(347, 267);
            this.btn_saliradm.Name = "btn_saliradm";
            this.btn_saliradm.Size = new System.Drawing.Size(110, 33);
            this.btn_saliradm.TabIndex = 9;
            this.btn_saliradm.Text = "Salir";
            this.btn_saliradm.UseVisualStyleBackColor = true;
            this.btn_saliradm.Click += new System.EventHandler(this.btn_saliradm_Click);
            // 
            // lbl_NombreUser
            // 
            this.lbl_NombreUser.AutoSize = true;
            this.lbl_NombreUser.Location = new System.Drawing.Point(252, 141);
            this.lbl_NombreUser.Name = "lbl_NombreUser";
            this.lbl_NombreUser.Size = new System.Drawing.Size(147, 21);
            this.lbl_NombreUser.TabIndex = 8;
            this.lbl_NombreUser.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenido(a): ";
            // 
            // btn_manteVentas
            // 
            this.btn_manteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manteVentas.Location = new System.Drawing.Point(98, 181);
            this.btn_manteVentas.Name = "btn_manteVentas";
            this.btn_manteVentas.Size = new System.Drawing.Size(163, 64);
            this.btn_manteVentas.TabIndex = 6;
            this.btn_manteVentas.Text = "Ingreso Productos";
            this.btn_manteVentas.UseVisualStyleBackColor = true;
            this.btn_manteVentas.Click += new System.EventHandler(this.btn_manteVentas_Click);
            // 
            // btn_manteBodega
            // 
            this.btn_manteBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manteBodega.Location = new System.Drawing.Point(295, 181);
            this.btn_manteBodega.Name = "btn_manteBodega";
            this.btn_manteBodega.Size = new System.Drawing.Size(163, 64);
            this.btn_manteBodega.TabIndex = 5;
            this.btn_manteBodega.Text = "Consulta Productos";
            this.btn_manteBodega.UseVisualStyleBackColor = true;
            this.btn_manteBodega.Click += new System.EventHandler(this.btn_manteBodega_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaOPCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(578, 343);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaOPCProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaOPCProductos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prov;
        private System.Windows.Forms.Button btn_saliradm;
        private System.Windows.Forms.Label lbl_NombreUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_manteVentas;
        private System.Windows.Forms.Button btn_manteBodega;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}