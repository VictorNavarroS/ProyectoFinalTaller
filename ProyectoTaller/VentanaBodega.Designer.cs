namespace ProyectoTaller
{
    partial class VentanaBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBodega));
            this.gbx_buscarSerie = new System.Windows.Forms.GroupBox();
            this.lbl_buscarSerie = new System.Windows.Forms.Label();
            this.txt_buscarSerie = new System.Windows.Forms.TextBox();
            this.btn_buscarSerie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkb_activo = new System.Windows.Forms.CheckBox();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stockMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Compra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modificarProd = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.gbx_buscarSerie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_buscarSerie
            // 
            this.gbx_buscarSerie.Controls.Add(this.lbl_buscarSerie);
            this.gbx_buscarSerie.Controls.Add(this.txt_buscarSerie);
            this.gbx_buscarSerie.Controls.Add(this.btn_buscarSerie);
            this.gbx_buscarSerie.Location = new System.Drawing.Point(12, 12);
            this.gbx_buscarSerie.Name = "gbx_buscarSerie";
            this.gbx_buscarSerie.Size = new System.Drawing.Size(517, 58);
            this.gbx_buscarSerie.TabIndex = 28;
            this.gbx_buscarSerie.TabStop = false;
            this.gbx_buscarSerie.Text = "Buscar Serie";
            // 
            // lbl_buscarSerie
            // 
            this.lbl_buscarSerie.AutoSize = true;
            this.lbl_buscarSerie.Location = new System.Drawing.Point(88, 28);
            this.lbl_buscarSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscarSerie.Name = "lbl_buscarSerie";
            this.lbl_buscarSerie.Size = new System.Drawing.Size(47, 21);
            this.lbl_buscarSerie.TabIndex = 34;
            this.lbl_buscarSerie.Text = "Serie";
            // 
            // txt_buscarSerie
            // 
            this.txt_buscarSerie.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarSerie.Location = new System.Drawing.Point(143, 24);
            this.txt_buscarSerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_buscarSerie.Name = "txt_buscarSerie";
            this.txt_buscarSerie.Size = new System.Drawing.Size(213, 26);
            this.txt_buscarSerie.TabIndex = 33;
            // 
            // btn_buscarSerie
            // 
            this.btn_buscarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarSerie.Image")));
            this.btn_buscarSerie.Location = new System.Drawing.Point(397, 27);
            this.btn_buscarSerie.Name = "btn_buscarSerie";
            this.btn_buscarSerie.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarSerie.TabIndex = 29;
            this.btn_buscarSerie.UseVisualStyleBackColor = true;
            this.btn_buscarSerie.Click += new System.EventHandler(this.btn_buscarSerie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkb_activo);
            this.groupBox1.Controls.Add(this.cmb_proveedor);
            this.groupBox1.Controls.Add(this.txt_ubicacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_serie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_stockMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Compra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 230);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // chkb_activo
            // 
            this.chkb_activo.AutoSize = true;
            this.chkb_activo.Location = new System.Drawing.Point(109, 180);
            this.chkb_activo.Name = "chkb_activo";
            this.chkb_activo.Size = new System.Drawing.Size(77, 25);
            this.chkb_activo.TabIndex = 50;
            this.chkb_activo.Text = "Activo";
            this.chkb_activo.UseVisualStyleBackColor = true;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_proveedor.Location = new System.Drawing.Point(109, 143);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(168, 29);
            this.cmb_proveedor.TabIndex = 49;
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion.Location = new System.Drawing.Point(382, 73);
            this.txt_ubicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(118, 26);
            this.txt_ubicacion.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Proveedor";
            // 
            // txt_serie
            // 
            this.txt_serie.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(109, 37);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(147, 26);
            this.txt_serie.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // txt_stockMin
            // 
            this.txt_stockMin.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockMin.Location = new System.Drawing.Point(382, 175);
            this.txt_stockMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stockMin.Name = "txt_stockMin";
            this.txt_stockMin.Size = new System.Drawing.Size(118, 26);
            this.txt_stockMin.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ubicacion";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(109, 73);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(147, 26);
            this.txt_nombre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Serie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stock Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock";
            // 
            // txt_Compra
            // 
            this.txt_Compra.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Compra.Location = new System.Drawing.Point(382, 37);
            this.txt_Compra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Compra.Name = "txt_Compra";
            this.txt_Compra.Size = new System.Drawing.Size(118, 26);
            this.txt_Compra.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor Compra";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(382, 143);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(118, 26);
            this.txt_stock.TabIndex = 22;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(109, 109);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(391, 26);
            this.txt_descripcion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descripcion";
            // 
            // btn_volver
            // 
            this.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(300, 379);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(146, 36);
            this.btn_volver.TabIndex = 51;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_modificarProd
            // 
            this.btn_modificarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarProd.Location = new System.Drawing.Point(300, 324);
            this.btn_modificarProd.Name = "btn_modificarProd";
            this.btn_modificarProd.Size = new System.Drawing.Size(146, 36);
            this.btn_modificarProd.TabIndex = 50;
            this.btn_modificarProd.Text = "Modificar Producto";
            this.btn_modificarProd.UseVisualStyleBackColor = true;
            this.btn_modificarProd.Click += new System.EventHandler(this.btn_modificarProd_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(67, 324);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(157, 36);
            this.btn_agregar.TabIndex = 39;
            this.btn_agregar.Text = "Agregar Producto";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Location = new System.Drawing.Point(67, 379);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(157, 36);
            this.btn_limpiar.TabIndex = 41;
            this.btn_limpiar.Text = "Limpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // VentanaBodega
            // 
            this.AcceptButton = this.btn_buscarSerie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.CancelButton = this.btn_volver;
            this.ClientSize = new System.Drawing.Size(537, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarProd);
            this.Controls.Add(this.gbx_buscarSerie);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_limpiar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaBodega";
            this.gbx_buscarSerie.ResumeLayout(false);
            this.gbx_buscarSerie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_buscarSerie;
        private System.Windows.Forms.Label lbl_buscarSerie;
        private System.Windows.Forms.TextBox txt_buscarSerie;
        private System.Windows.Forms.Button btn_buscarSerie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_modificarProd;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_stockMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Compra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkb_activo;
    }
}