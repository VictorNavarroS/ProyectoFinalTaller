namespace ProyectoTaller
{
    partial class ConsultaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbx_buscarSerie = new System.Windows.Forms.GroupBox();
            this.lbl_buscarProveedor = new System.Windows.Forms.Label();
            this.txt_buscarSerie2 = new System.Windows.Forms.TextBox();
            this.btn_buscaseriee = new System.Windows.Forms.Button();
            this.gbx_detalle_productos = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_ConsultaProductos = new System.Windows.Forms.DataGridView();
            this.btm_todos = new System.Windows.Forms.Button();
            this.gbx_consulta_productos = new System.Windows.Forms.GroupBox();
            this.check_activo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nombredg = new System.Windows.Forms.Button();
            this.btn_seriedg = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cbx_proveedorConsu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_serieCons = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreConsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_buscarSerie.SuspendLayout();
            this.gbx_detalle_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaProductos)).BeginInit();
            this.gbx_consulta_productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_buscarSerie
            // 
            this.gbx_buscarSerie.Controls.Add(this.lbl_buscarProveedor);
            this.gbx_buscarSerie.Controls.Add(this.txt_buscarSerie2);
            this.gbx_buscarSerie.Controls.Add(this.btn_buscaseriee);
            this.gbx_buscarSerie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_buscarSerie.Location = new System.Drawing.Point(12, 12);
            this.gbx_buscarSerie.Name = "gbx_buscarSerie";
            this.gbx_buscarSerie.Size = new System.Drawing.Size(189, 78);
            this.gbx_buscarSerie.TabIndex = 30;
            this.gbx_buscarSerie.TabStop = false;
            this.gbx_buscarSerie.Text = "Buscar producto";
            // 
            // lbl_buscarProveedor
            // 
            this.lbl_buscarProveedor.AutoSize = true;
            this.lbl_buscarProveedor.Location = new System.Drawing.Point(7, 24);
            this.lbl_buscarProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscarProveedor.Name = "lbl_buscarProveedor";
            this.lbl_buscarProveedor.Size = new System.Drawing.Size(54, 19);
            this.lbl_buscarProveedor.TabIndex = 45;
            this.lbl_buscarProveedor.Text = "Serie :";
            // 
            // txt_buscarSerie2
            // 
            this.txt_buscarSerie2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarSerie2.Location = new System.Drawing.Point(6, 45);
            this.txt_buscarSerie2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_buscarSerie2.Name = "txt_buscarSerie2";
            this.txt_buscarSerie2.Size = new System.Drawing.Size(141, 22);
            this.txt_buscarSerie2.TabIndex = 44;
            // 
            // btn_buscaseriee
            // 
            this.btn_buscaseriee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscaseriee.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscaseriee.Image")));
            this.btn_buscaseriee.Location = new System.Drawing.Point(155, 45);
            this.btn_buscaseriee.Name = "btn_buscaseriee";
            this.btn_buscaseriee.Size = new System.Drawing.Size(25, 23);
            this.btn_buscaseriee.TabIndex = 43;
            this.btn_buscaseriee.UseVisualStyleBackColor = true;
            this.btn_buscaseriee.Click += new System.EventHandler(this.btn_buscaseriee_Click);
            // 
            // gbx_detalle_productos
            // 
            this.gbx_detalle_productos.Controls.Add(this.button3);
            this.gbx_detalle_productos.Controls.Add(this.button5);
            this.gbx_detalle_productos.Controls.Add(this.dgv_ConsultaProductos);
            this.gbx_detalle_productos.Controls.Add(this.btm_todos);
            this.gbx_detalle_productos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_detalle_productos.Location = new System.Drawing.Point(207, 12);
            this.gbx_detalle_productos.Name = "gbx_detalle_productos";
            this.gbx_detalle_productos.Size = new System.Drawing.Size(677, 403);
            this.gbx_detalle_productos.TabIndex = 31;
            this.gbx_detalle_productos.TabStop = false;
            this.gbx_detalle_productos.Text = "Lista de Productos";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(315, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 40;
            this.button3.Text = "Limpiar Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(240, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 39);
            this.button5.TabIndex = 39;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_ConsultaProductos
            // 
            this.dgv_ConsultaProductos.AllowUserToAddRows = false;
            this.dgv_ConsultaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ConsultaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ConsultaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Nivel_Stock,
            this.Column7,
            this.Column9});
            this.dgv_ConsultaProductos.Location = new System.Drawing.Point(6, 25);
            this.dgv_ConsultaProductos.Name = "dgv_ConsultaProductos";
            this.dgv_ConsultaProductos.Size = new System.Drawing.Size(665, 248);
            this.dgv_ConsultaProductos.TabIndex = 0;
            // 
            // btm_todos
            // 
            this.btm_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_todos.Location = new System.Drawing.Point(157, 288);
            this.btm_todos.Name = "btm_todos";
            this.btm_todos.Size = new System.Drawing.Size(117, 39);
            this.btm_todos.TabIndex = 8;
            this.btm_todos.Text = "Mostrar Todo";
            this.btm_todos.UseVisualStyleBackColor = true;
            this.btm_todos.Click += new System.EventHandler(this.btm_todos_Click);
            // 
            // gbx_consulta_productos
            // 
            this.gbx_consulta_productos.Controls.Add(this.check_activo);
            this.gbx_consulta_productos.Controls.Add(this.button2);
            this.gbx_consulta_productos.Controls.Add(this.button1);
            this.gbx_consulta_productos.Controls.Add(this.btn_nombredg);
            this.gbx_consulta_productos.Controls.Add(this.btn_seriedg);
            this.gbx_consulta_productos.Controls.Add(this.btn_limpiar);
            this.gbx_consulta_productos.Controls.Add(this.cbx_proveedorConsu);
            this.gbx_consulta_productos.Controls.Add(this.label6);
            this.gbx_consulta_productos.Controls.Add(this.label10);
            this.gbx_consulta_productos.Controls.Add(this.txt_serieCons);
            this.gbx_consulta_productos.Controls.Add(this.label2);
            this.gbx_consulta_productos.Controls.Add(this.txt_nombreConsu);
            this.gbx_consulta_productos.Controls.Add(this.label1);
            this.gbx_consulta_productos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_consulta_productos.Location = new System.Drawing.Point(12, 96);
            this.gbx_consulta_productos.Name = "gbx_consulta_productos";
            this.gbx_consulta_productos.Size = new System.Drawing.Size(189, 319);
            this.gbx_consulta_productos.TabIndex = 41;
            this.gbx_consulta_productos.TabStop = false;
            this.gbx_consulta_productos.Text = "Buscar Producto";
            // 
            // check_activo
            // 
            this.check_activo.AutoSize = true;
            this.check_activo.Location = new System.Drawing.Point(77, 213);
            this.check_activo.Name = "check_activo";
            this.check_activo.Size = new System.Drawing.Size(68, 23);
            this.check_activo.TabIndex = 53;
            this.check_activo.Text = "Activo";
            this.check_activo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(155, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(151, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_nombredg
            // 
            this.btn_nombredg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nombredg.Image = ((System.Drawing.Image)(resources.GetObject("btn_nombredg.Image")));
            this.btn_nombredg.Location = new System.Drawing.Point(155, 101);
            this.btn_nombredg.Name = "btn_nombredg";
            this.btn_nombredg.Size = new System.Drawing.Size(25, 23);
            this.btn_nombredg.TabIndex = 50;
            this.btn_nombredg.UseVisualStyleBackColor = true;
            this.btn_nombredg.Click += new System.EventHandler(this.btn_nombredg_Click);
            // 
            // btn_seriedg
            // 
            this.btn_seriedg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seriedg.Image = ((System.Drawing.Image)(resources.GetObject("btn_seriedg.Image")));
            this.btn_seriedg.Location = new System.Drawing.Point(154, 152);
            this.btn_seriedg.Name = "btn_seriedg";
            this.btn_seriedg.Size = new System.Drawing.Size(25, 23);
            this.btn_seriedg.TabIndex = 46;
            this.btn_seriedg.UseVisualStyleBackColor = true;
            this.btn_seriedg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Location = new System.Drawing.Point(48, 269);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(84, 29);
            this.btn_limpiar.TabIndex = 41;
            this.btn_limpiar.Text = "Limpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // cbx_proveedorConsu
            // 
            this.cbx_proveedorConsu.FormattingEnabled = true;
            this.cbx_proveedorConsu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_proveedorConsu.Location = new System.Drawing.Point(6, 151);
            this.cbx_proveedorConsu.Name = "cbx_proveedorConsu";
            this.cbx_proveedorConsu.Size = new System.Drawing.Size(142, 27);
            this.cbx_proveedorConsu.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Estado :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Proveedor :";
            // 
            // txt_serieCons
            // 
            this.txt_serieCons.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serieCons.Location = new System.Drawing.Point(7, 46);
            this.txt_serieCons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_serieCons.Name = "txt_serieCons";
            this.txt_serieCons.Size = new System.Drawing.Size(141, 22);
            this.txt_serieCons.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre :";
            // 
            // txt_nombreConsu
            // 
            this.txt_nombreConsu.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreConsu.Location = new System.Drawing.Point(6, 102);
            this.txt_nombreConsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombreConsu.Name = "txt_nombreConsu";
            this.txt_nombreConsu.Size = new System.Drawing.Size(141, 22);
            this.txt_nombreConsu.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Serie :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serie";
            this.Column1.Name = "Column1";
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Nivel_Stock
            // 
            this.Nivel_Stock.HeaderText = "Nivel_Stock";
            this.Nivel_Stock.Name = "Nivel_Stock";
            this.Nivel_Stock.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ubicacion";
            this.Column7.Name = "Column7";
            this.Column7.Width = 95;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Proveedor";
            this.Column9.Name = "Column9";
            this.Column9.Width = 95;
            // 
            // ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(896, 424);
            this.Controls.Add(this.gbx_consulta_productos);
            this.Controls.Add(this.gbx_detalle_productos);
            this.Controls.Add(this.gbx_buscarSerie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaProductos";
            this.gbx_buscarSerie.ResumeLayout(false);
            this.gbx_buscarSerie.PerformLayout();
            this.gbx_detalle_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaProductos)).EndInit();
            this.gbx_consulta_productos.ResumeLayout(false);
            this.gbx_consulta_productos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_buscarSerie;
        private System.Windows.Forms.Label lbl_buscarProveedor;
        private System.Windows.Forms.TextBox txt_buscarSerie2;
        private System.Windows.Forms.Button btn_buscaseriee;
        private System.Windows.Forms.GroupBox gbx_detalle_productos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgv_ConsultaProductos;
        private System.Windows.Forms.Button btm_todos;
        private System.Windows.Forms.GroupBox gbx_consulta_productos;
        private System.Windows.Forms.CheckBox check_activo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nombredg;
        private System.Windows.Forms.Button btn_seriedg;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ComboBox cbx_proveedorConsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_serieCons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreConsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}