namespace ProyectoTaller
{
    partial class RecuperacionContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperacionContraseña));
            this.gbx_olvideContraseña = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_enviarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.txt_ingresoCorreo = new System.Windows.Forms.TextBox();
            this.txt_ingreseRut = new System.Windows.Forms.TextBox();
            this.gbx_olvideContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_olvideContraseña
            // 
            this.gbx_olvideContraseña.Controls.Add(this.btn_salir);
            this.gbx_olvideContraseña.Controls.Add(this.btn_enviarDatos);
            this.gbx_olvideContraseña.Controls.Add(this.label2);
            this.gbx_olvideContraseña.Controls.Add(this.lbl_rut);
            this.gbx_olvideContraseña.Controls.Add(this.txt_ingresoCorreo);
            this.gbx_olvideContraseña.Controls.Add(this.txt_ingreseRut);
            this.gbx_olvideContraseña.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_olvideContraseña.Location = new System.Drawing.Point(12, 6);
            this.gbx_olvideContraseña.Name = "gbx_olvideContraseña";
            this.gbx_olvideContraseña.Size = new System.Drawing.Size(279, 275);
            this.gbx_olvideContraseña.TabIndex = 2;
            this.gbx_olvideContraseña.TabStop = false;
            this.gbx_olvideContraseña.Text = "Olvide contraseña";
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(52, 218);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(157, 31);
            this.btn_salir.TabIndex = 26;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_enviarDatos
            // 
            this.btn_enviarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviarDatos.Location = new System.Drawing.Point(52, 171);
            this.btn_enviarDatos.Name = "btn_enviarDatos";
            this.btn_enviarDatos.Size = new System.Drawing.Size(157, 31);
            this.btn_enviarDatos.TabIndex = 10;
            this.btn_enviarDatos.Text = "Enviar Datos";
            this.btn_enviarDatos.UseVisualStyleBackColor = true;
            this.btn_enviarDatos.Click += new System.EventHandler(this.btn_enviarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ingrese Correo";
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(89, 40);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(83, 19);
            this.lbl_rut.TabIndex = 1;
            this.lbl_rut.Text = "Ingrese Rut";
            // 
            // txt_ingresoCorreo
            // 
            this.txt_ingresoCorreo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingresoCorreo.Location = new System.Drawing.Point(37, 128);
            this.txt_ingresoCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ingresoCorreo.Name = "txt_ingresoCorreo";
            this.txt_ingresoCorreo.Size = new System.Drawing.Size(186, 22);
            this.txt_ingresoCorreo.TabIndex = 18;
            // 
            // txt_ingreseRut
            // 
            this.txt_ingreseRut.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingreseRut.Location = new System.Drawing.Point(37, 62);
            this.txt_ingreseRut.Name = "txt_ingreseRut";
            this.txt_ingreseRut.Size = new System.Drawing.Size(186, 22);
            this.txt_ingreseRut.TabIndex = 0;
            // 
            // RecuperacionContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(298, 286);
            this.Controls.Add(this.gbx_olvideContraseña);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecuperacionContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperacionContraseña";
            this.gbx_olvideContraseña.ResumeLayout(false);
            this.gbx_olvideContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_olvideContraseña;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_enviarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.TextBox txt_ingresoCorreo;
        private System.Windows.Forms.TextBox txt_ingreseRut;
    }
}