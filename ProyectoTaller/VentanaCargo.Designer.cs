namespace ProyectoTaller
{
    partial class VentanaCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCargo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscarCargo = new System.Windows.Forms.Button();
            this.txt_buscarCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_permisos = new System.Windows.Forms.ComboBox();
            this.chkbActivo = new System.Windows.Forms.CheckBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscarCargo);
            this.groupBox1.Controls.Add(this.txt_buscarCargo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cargo";
            // 
            // btn_buscarCargo
            // 
            this.btn_buscarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscarCargo.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarCargo.Image")));
            this.btn_buscarCargo.Location = new System.Drawing.Point(247, 25);
            this.btn_buscarCargo.Name = "btn_buscarCargo";
            this.btn_buscarCargo.Size = new System.Drawing.Size(25, 23);
            this.btn_buscarCargo.TabIndex = 28;
            this.btn_buscarCargo.UseVisualStyleBackColor = true;
            this.btn_buscarCargo.Click += new System.EventHandler(this.btn_buscarCargo_Click);
            // 
            // txt_buscarCargo
            // 
            this.txt_buscarCargo.Location = new System.Drawing.Point(57, 25);
            this.txt_buscarCargo.Name = "txt_buscarCargo";
            this.txt_buscarCargo.Size = new System.Drawing.Size(182, 24);
            this.txt_buscarCargo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo:";
            // 
            // btn_volver
            // 
            this.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(90, 268);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(127, 31);
            this.btn_volver.TabIndex = 10;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Location = new System.Drawing.Point(173, 231);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(127, 31);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(9, 231);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(127, 31);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_permisos);
            this.groupBox2.Controls.Add(this.chkbActivo);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cargo";
            // 
            // cmb_permisos
            // 
            this.cmb_permisos.FormattingEnabled = true;
            this.cmb_permisos.Location = new System.Drawing.Point(119, 68);
            this.cmb_permisos.Name = "cmb_permisos";
            this.cmb_permisos.Size = new System.Drawing.Size(153, 24);
            this.cmb_permisos.TabIndex = 8;
            // 
            // chkbActivo
            // 
            this.chkbActivo.AutoSize = true;
            this.chkbActivo.Location = new System.Drawing.Point(119, 98);
            this.chkbActivo.Name = "chkbActivo";
            this.chkbActivo.Size = new System.Drawing.Size(63, 20);
            this.chkbActivo.TabIndex = 7;
            this.chkbActivo.Text = "Activo";
            this.chkbActivo.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(119, 35);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(153, 24);
            this.txt_nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Permisos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Cargo:";
            // 
            // VentanaCargo
            // 
            this.AcceptButton = this.btn_buscarCargo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.CancelButton = this.btn_volver;
            this.ClientSize = new System.Drawing.Size(308, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaCargo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscarCargo;
        private System.Windows.Forms.TextBox txt_buscarCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbActivo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_permisos;
    }
}