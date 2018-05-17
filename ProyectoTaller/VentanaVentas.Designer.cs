namespace ProyectoTaller
{
    partial class VentanaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaVentas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btm_todos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_vender = new System.Windows.Forms.TextBox();
            this.lbl_vender = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_nuevaVenta = new System.Windows.Forms.Button();
            this.btn_buscarNombre = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_valorVenta = new System.Windows.Forms.TextBox();
            this.lbl_disponible = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_numVenta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totalVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_finalizarVenta = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(990, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.archivoToolStripMenuItem.Text = "Administrador";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.dgv_listaProductos);
            this.groupBox2.Controls.Add(this.btm_todos);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 390);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Productos";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Location = new System.Drawing.Point(162, 349);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(94, 31);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AllowUserToAddRows = false;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_listaProductos.Location = new System.Drawing.Point(6, 23);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.Size = new System.Drawing.Size(242, 318);
            this.dgv_listaProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serie";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // btm_todos
            // 
            this.btm_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_todos.Location = new System.Drawing.Point(6, 349);
            this.btm_todos.Name = "btm_todos";
            this.btm_todos.Size = new System.Drawing.Size(94, 31);
            this.btm_todos.TabIndex = 8;
            this.btm_todos.Text = "Todos";
            this.btm_todos.UseVisualStyleBackColor = true;
            this.btm_todos.Click += new System.EventHandler(this.btm_todos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_vender);
            this.groupBox1.Controls.Add(this.lbl_vender);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_nuevaVenta);
            this.groupBox1.Controls.Add(this.btn_buscarNombre);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.txt_valorVenta);
            this.groupBox1.Controls.Add(this.lbl_disponible);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_serie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(280, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 390);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txt_vender
            // 
            this.txt_vender.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vender.Location = new System.Drawing.Point(157, 206);
            this.txt_vender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vender.Name = "txt_vender";
            this.txt_vender.Size = new System.Drawing.Size(75, 22);
            this.txt_vender.TabIndex = 29;
            // 
            // lbl_vender
            // 
            this.lbl_vender.AutoSize = true;
            this.lbl_vender.Location = new System.Drawing.Point(154, 185);
            this.lbl_vender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vender.Name = "lbl_vender";
            this.lbl_vender.Size = new System.Drawing.Size(61, 16);
            this.lbl_vender.TabIndex = 28;
            this.lbl_vender.Text = "A vender";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(209, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 27;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_nuevaVenta
            // 
            this.btn_nuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevaVenta.Location = new System.Drawing.Point(16, 349);
            this.btn_nuevaVenta.Name = "btn_nuevaVenta";
            this.btn_nuevaVenta.Size = new System.Drawing.Size(209, 31);
            this.btn_nuevaVenta.TabIndex = 26;
            this.btn_nuevaVenta.Text = "Nueva Venta";
            this.btn_nuevaVenta.UseVisualStyleBackColor = true;
            this.btn_nuevaVenta.Click += new System.EventHandler(this.btn_nuevaVenta_Click);
            // 
            // btn_buscarNombre
            // 
            this.btn_buscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarNombre.Image")));
            this.btn_buscarNombre.Location = new System.Drawing.Point(209, 102);
            this.btn_buscarNombre.Name = "btn_buscarNombre";
            this.btn_buscarNombre.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarNombre.TabIndex = 25;
            this.btn_buscarNombre.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(16, 312);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(209, 31);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Agregar Producto";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_valorVenta
            // 
            this.txt_valorVenta.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorVenta.Location = new System.Drawing.Point(15, 261);
            this.txt_valorVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_valorVenta.Name = "txt_valorVenta";
            this.txt_valorVenta.Size = new System.Drawing.Size(219, 22);
            this.txt_valorVenta.TabIndex = 18;
            // 
            // lbl_disponible
            // 
            this.lbl_disponible.AutoSize = true;
            this.lbl_disponible.ForeColor = System.Drawing.Color.Blue;
            this.lbl_disponible.Location = new System.Drawing.Point(107, 288);
            this.lbl_disponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_disponible.Name = "lbl_disponible";
            this.lbl_disponible.Size = new System.Drawing.Size(64, 16);
            this.lbl_disponible.TabIndex = 24;
            this.lbl_disponible.Text = "Disponible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Serie Producto";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(16, 206);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(75, 22);
            this.txt_stock.TabIndex = 22;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(15, 149);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(219, 22);
            this.txt_descripcion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(16, 104);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(186, 22);
            this.txt_nombre.TabIndex = 18;
            // 
            // txt_serie
            // 
            this.txt_serie.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(15, 46);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(186, 22);
            this.txt_serie.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "En Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_numVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_totalVenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.dgv_ventas);
            this.groupBox3.Controls.Add(this.btn_finalizarVenta);
            this.groupBox3.Location = new System.Drawing.Point(526, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 390);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Venta";
            // 
            // lbl_numVenta
            // 
            this.lbl_numVenta.AutoSize = true;
            this.lbl_numVenta.Location = new System.Drawing.Point(384, 315);
            this.lbl_numVenta.Name = "lbl_numVenta";
            this.lbl_numVenta.Size = new System.Drawing.Size(26, 16);
            this.lbl_numVenta.TabIndex = 16;
            this.lbl_numVenta.Text = "nro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nro de Venta: ";
            // 
            // txt_totalVenta
            // 
            this.txt_totalVenta.Location = new System.Drawing.Point(104, 312);
            this.txt_totalVenta.Name = "txt_totalVenta";
            this.txt_totalVenta.Size = new System.Drawing.Size(144, 24);
            this.txt_totalVenta.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Venta";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10});
            this.dgv_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_ventas.Location = new System.Drawing.Point(4, 19);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.Size = new System.Drawing.Size(445, 270);
            this.dgv_ventas.TabIndex = 11;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Serie";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cantidad";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Valor Un";
            this.Column10.Name = "Column10";
            // 
            // btn_finalizarVenta
            // 
            this.btn_finalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizarVenta.Location = new System.Drawing.Point(106, 349);
            this.btn_finalizarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_finalizarVenta.Name = "btn_finalizarVenta";
            this.btn_finalizarVenta.Size = new System.Drawing.Size(142, 31);
            this.btn_finalizarVenta.TabIndex = 10;
            this.btn_finalizarVenta.Text = "Finalizar Venta";
            this.btn_finalizarVenta.UseVisualStyleBackColor = true;
            this.btn_finalizarVenta.Click += new System.EventHandler(this.btn_finalizarVenta_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(855, 427);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(129, 31);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // VentanaVentas
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(990, 462);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVentas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgv_listaProductos;
        private System.Windows.Forms.Button btm_todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_vender;
        private System.Windows.Forms.Label lbl_vender;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_nuevaVenta;
        private System.Windows.Forms.Button btn_buscarNombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_valorVenta;
        private System.Windows.Forms.Label lbl_disponible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_totalVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Button btn_finalizarVenta;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label lbl_numVenta;
        private System.Windows.Forms.Label label9;
    }
}