namespace Capa_presentacion
{
    partial class txt_descuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txt_descuento));
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.txt_tipoafiliacion = new System.Windows.Forms.TextBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_busuario = new System.Windows.Forms.Button();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idvehiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_bvehiculo = new System.Windows.Forms.Button();
            this.dtp_fechaentrega = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_fechavuelta = new System.Windows.Forms.DateTimePicker();
            this.txt_klrecepcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_klrecorridos = new System.Windows.Forms.TextBox();
            this.txt_valorkl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_totalpagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(885, 79);
            this.dgv_datos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 51;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(744, 420);
            this.dgv_datos.TabIndex = 27;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(885, 516);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(744, 20);
            this.txt_buscar.TabIndex = 26;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Black;
            this.btn_editar.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_editar.ForeColor = System.Drawing.Color.Gold;
            this.btn_editar.Location = new System.Drawing.Point(719, 501);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(124, 41);
            this.btn_editar.TabIndex = 25;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Black;
            this.btn_nuevo.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_nuevo.ForeColor = System.Drawing.Color.Gold;
            this.btn_nuevo.Location = new System.Drawing.Point(579, 501);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(136, 41);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Black;
            this.btn_eliminar.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.Gold;
            this.btn_eliminar.Location = new System.Drawing.Point(450, 501);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(124, 41);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Black;
            this.btn_guardar.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_guardar.ForeColor = System.Drawing.Color.Gold;
            this.btn_guardar.Location = new System.Drawing.Point(579, 443);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(136, 42);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tipo de afiliacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre cliente";
            // 
            // txt_idusuario
            // 
            this.txt_idusuario.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idusuario.Location = new System.Drawing.Point(209, 81);
            this.txt_idusuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idusuario.Name = "txt_idusuario";
            this.txt_idusuario.Size = new System.Drawing.Size(200, 20);
            this.txt_idusuario.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Usuario";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(0, 549);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1642, 63);
            this.label2.TabIndex = 15;
            this.label2.Text = "KSA <-> SYSTEM © 2022";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1642, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "INGRESAR USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreusuario.Location = new System.Drawing.Point(209, 154);
            this.txt_nombreusuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(200, 20);
            this.txt_nombreusuario.TabIndex = 19;
            // 
            // txt_tipoafiliacion
            // 
            this.txt_tipoafiliacion.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoafiliacion.Location = new System.Drawing.Point(209, 199);
            this.txt_tipoafiliacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tipoafiliacion.Name = "txt_tipoafiliacion";
            this.txt_tipoafiliacion.Size = new System.Drawing.Size(200, 20);
            this.txt_tipoafiliacion.TabIndex = 28;
            // 
            // txt_documento
            // 
            this.txt_documento.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento.Location = new System.Drawing.Point(209, 117);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(200, 20);
            this.txt_documento.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Documento";
            // 
            // btn_busuario
            // 
            this.btn_busuario.BackColor = System.Drawing.Color.Black;
            this.btn_busuario.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_busuario.ForeColor = System.Drawing.Color.Gold;
            this.btn_busuario.Location = new System.Drawing.Point(16, 235);
            this.btn_busuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_busuario.Name = "btn_busuario";
            this.btn_busuario.Size = new System.Drawing.Size(395, 42);
            this.btn_busuario.TabIndex = 31;
            this.btn_busuario.Text = "BUSCAR USUARIO";
            this.btn_busuario.UseVisualStyleBackColor = false;
            this.btn_busuario.Click += new System.EventHandler(this.btn_busuario_Click);
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(209, 326);
            this.txt_placa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(200, 20);
            this.txt_placa.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Placa";
            // 
            // txt_idvehiculo
            // 
            this.txt_idvehiculo.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idvehiculo.Location = new System.Drawing.Point(209, 290);
            this.txt_idvehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idvehiculo.Name = "txt_idvehiculo";
            this.txt_idvehiculo.Size = new System.Drawing.Size(200, 20);
            this.txt_idvehiculo.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID Vehiculo";
            // 
            // btn_bvehiculo
            // 
            this.btn_bvehiculo.BackColor = System.Drawing.Color.Black;
            this.btn_bvehiculo.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.btn_bvehiculo.ForeColor = System.Drawing.Color.Gold;
            this.btn_bvehiculo.Location = new System.Drawing.Point(16, 352);
            this.btn_bvehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_bvehiculo.Name = "btn_bvehiculo";
            this.btn_bvehiculo.Size = new System.Drawing.Size(395, 42);
            this.btn_bvehiculo.TabIndex = 36;
            this.btn_bvehiculo.Text = "BUSCAR VEHICULO";
            this.btn_bvehiculo.UseVisualStyleBackColor = false;
            this.btn_bvehiculo.Click += new System.EventHandler(this.btn_bvehiculo_Click);
            // 
            // dtp_fechaentrega
            // 
            this.dtp_fechaentrega.Location = new System.Drawing.Point(16, 441);
            this.dtp_fechaentrega.Name = "dtp_fechaentrega";
            this.dtp_fechaentrega.Size = new System.Drawing.Size(393, 22);
            this.dtp_fechaentrega.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 406);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fecha de entrega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 476);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Fecha de vuelta";
            // 
            // dtp_fechavuelta
            // 
            this.dtp_fechavuelta.Location = new System.Drawing.Point(16, 511);
            this.dtp_fechavuelta.Name = "dtp_fechavuelta";
            this.dtp_fechavuelta.Size = new System.Drawing.Size(393, 22);
            this.dtp_fechavuelta.TabIndex = 39;
            // 
            // txt_klrecepcion
            // 
            this.txt_klrecepcion.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_klrecepcion.Location = new System.Drawing.Point(640, 81);
            this.txt_klrecepcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_klrecepcion.Name = "txt_klrecepcion";
            this.txt_klrecepcion.Size = new System.Drawing.Size(200, 20);
            this.txt_klrecepcion.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 23);
            this.label11.TabIndex = 41;
            this.label11.Text = "KL Recepcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "KL Recorridos";
            // 
            // txt_klrecorridos
            // 
            this.txt_klrecorridos.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_klrecorridos.Location = new System.Drawing.Point(640, 118);
            this.txt_klrecorridos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_klrecorridos.Name = "txt_klrecorridos";
            this.txt_klrecorridos.Size = new System.Drawing.Size(200, 20);
            this.txt_klrecorridos.TabIndex = 44;
            // 
            // txt_valorkl
            // 
            this.txt_valorkl.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorkl.Location = new System.Drawing.Point(640, 155);
            this.txt_valorkl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_valorkl.Name = "txt_valorkl";
            this.txt_valorkl.Size = new System.Drawing.Size(200, 20);
            this.txt_valorkl.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(470, 152);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 23);
            this.label13.TabIndex = 45;
            this.label13.Text = "Valor x KL";
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(640, 193);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(200, 20);
            this.txt_desc.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 190);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 23);
            this.label14.TabIndex = 47;
            this.label14.Text = "Descuento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(470, 245);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 23);
            this.label15.TabIndex = 49;
            this.label15.Text = "TOTAL";
            // 
            // txt_totalpagar
            // 
            this.txt_totalpagar.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalpagar.Location = new System.Drawing.Point(640, 248);
            this.txt_totalpagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_totalpagar.Name = "txt_totalpagar";
            this.txt_totalpagar.Size = new System.Drawing.Size(200, 20);
            this.txt_totalpagar.TabIndex = 50;
            // 
            // txt_descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1642, 612);
            this.Controls.Add(this.txt_totalpagar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_valorkl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_klrecorridos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_klrecepcion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_fechavuelta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fechaentrega);
            this.Controls.Add(this.btn_bvehiculo);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_idvehiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_busuario);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tipoafiliacion);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombreusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "txt_descuento";
            this.Text = "frm_renta";
            this.Load += new System.EventHandler(this.frm_renta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.TextBox txt_tipoafiliacion;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_busuario;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idvehiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_bvehiculo;
        private System.Windows.Forms.DateTimePicker dtp_fechaentrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_fechavuelta;
        private System.Windows.Forms.TextBox txt_klrecepcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_klrecorridos;
        private System.Windows.Forms.TextBox txt_valorkl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_totalpagar;
    }
}