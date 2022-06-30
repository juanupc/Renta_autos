namespace Capa_presentacion.Fromularios
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_vehiculos = new System.Windows.Forms.Button();
            this.btn_renta = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Black;
            this.btn_usuarios.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.Gold;
            this.btn_usuarios.Location = new System.Drawing.Point(419, 12);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(369, 59);
            this.btn_usuarios.TabIndex = 0;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_vehiculos
            // 
            this.btn_vehiculos.BackColor = System.Drawing.Color.Black;
            this.btn_vehiculos.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehiculos.ForeColor = System.Drawing.Color.Gold;
            this.btn_vehiculos.Location = new System.Drawing.Point(419, 77);
            this.btn_vehiculos.Name = "btn_vehiculos";
            this.btn_vehiculos.Size = new System.Drawing.Size(369, 59);
            this.btn_vehiculos.TabIndex = 1;
            this.btn_vehiculos.Text = "Vehiculos";
            this.btn_vehiculos.UseVisualStyleBackColor = false;
            this.btn_vehiculos.Click += new System.EventHandler(this.btn_vehiculos_Click);
            // 
            // btn_renta
            // 
            this.btn_renta.BackColor = System.Drawing.Color.Black;
            this.btn_renta.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renta.ForeColor = System.Drawing.Color.Gold;
            this.btn_renta.Location = new System.Drawing.Point(419, 142);
            this.btn_renta.Name = "btn_renta";
            this.btn_renta.Size = new System.Drawing.Size(369, 59);
            this.btn_renta.TabIndex = 2;
            this.btn_renta.Text = "Rentas";
            this.btn_renta.UseVisualStyleBackColor = false;
            this.btn_renta.Click += new System.EventHandler(this.btn_renta_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Gold;
            this.btn_salir.Location = new System.Drawing.Point(419, 207);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(369, 59);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "¡Salir!";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 282);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE RENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_renta);
            this.Controls.Add(this.btn_vehiculos);
            this.Controls.Add(this.btn_usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_vehiculos;
        private System.Windows.Forms.Button btn_renta;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
    }
}