namespace Taller
{
    partial class Nuevo_Cliente
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
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lb_InfoCliente = new System.Windows.Forms.Label();
            this.rdb_Mujer = new System.Windows.Forms.RadioButton();
            this.lb_Sexo = new System.Windows.Forms.Label();
            this.rdb_Hombre = new System.Windows.Forms.RadioButton();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Telefono = new System.Windows.Forms.Label();
            this.txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.lb_Apellido2 = new System.Windows.Forms.Label();
            this.txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.lb_Apellido1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.txt_Identif = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.pxb_Cliente = new System.Windows.Forms.PictureBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(143, 269);
            this.txt_Telefono.MaxLength = 8;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(191, 26);
            this.txt_Telefono.TabIndex = 28;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            // 
            // lb_InfoCliente
            // 
            this.lb_InfoCliente.AutoSize = true;
            this.lb_InfoCliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InfoCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_InfoCliente.Location = new System.Drawing.Point(449, 22);
            this.lb_InfoCliente.Name = "lb_InfoCliente";
            this.lb_InfoCliente.Size = new System.Drawing.Size(263, 27);
            this.lb_InfoCliente.TabIndex = 35;
            this.lb_InfoCliente.Text = "Información del Cliente";
            this.lb_InfoCliente.Click += new System.EventHandler(this.lb_InfoCliente_Click);
            // 
            // rdb_Mujer
            // 
            this.rdb_Mujer.AutoSize = true;
            this.rdb_Mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Mujer.Location = new System.Drawing.Point(260, 230);
            this.rdb_Mujer.Name = "rdb_Mujer";
            this.rdb_Mujer.Size = new System.Drawing.Size(73, 20);
            this.rdb_Mujer.TabIndex = 27;
            this.rdb_Mujer.TabStop = true;
            this.rdb_Mujer.Text = "MUJER";
            this.rdb_Mujer.UseVisualStyleBackColor = true;
            this.rdb_Mujer.CheckedChanged += new System.EventHandler(this.rdb_Mujer_CheckedChanged);
            // 
            // lb_Sexo
            // 
            this.lb_Sexo.AutoSize = true;
            this.lb_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sexo.Location = new System.Drawing.Point(25, 228);
            this.lb_Sexo.Name = "lb_Sexo";
            this.lb_Sexo.Size = new System.Drawing.Size(45, 20);
            this.lb_Sexo.TabIndex = 34;
            this.lb_Sexo.Text = "Sexo";
            this.lb_Sexo.Click += new System.EventHandler(this.lb_Sexo_Click);
            // 
            // rdb_Hombre
            // 
            this.rdb_Hombre.AutoSize = true;
            this.rdb_Hombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Hombre.Location = new System.Drawing.Point(152, 228);
            this.rdb_Hombre.Name = "rdb_Hombre";
            this.rdb_Hombre.Size = new System.Drawing.Size(85, 20);
            this.rdb_Hombre.TabIndex = 26;
            this.rdb_Hombre.TabStop = true;
            this.rdb_Hombre.Text = "HOMBRE";
            this.rdb_Hombre.UseVisualStyleBackColor = true;
            this.rdb_Hombre.CheckedChanged += new System.EventHandler(this.rdb_Hombre_CheckedChanged);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(143, 406);
            this.txt_Direccion.MaxLength = 350;
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(191, 47);
            this.txt_Direccion.TabIndex = 30;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.txt_Direccion_TextChanged);
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Direccion.Location = new System.Drawing.Point(26, 422);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(75, 20);
            this.lb_Direccion.TabIndex = 33;
            this.lb_Direccion.Text = "Dirección";
            this.lb_Direccion.Click += new System.EventHandler(this.lb_Direccion_Click);
            // 
            // lb_Telefono
            // 
            this.lb_Telefono.AutoSize = true;
            this.lb_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefono.Location = new System.Drawing.Point(25, 269);
            this.lb_Telefono.Name = "lb_Telefono";
            this.lb_Telefono.Size = new System.Drawing.Size(71, 20);
            this.lb_Telefono.TabIndex = 32;
            this.lb_Telefono.Text = "Teléfono";
            this.lb_Telefono.Click += new System.EventHandler(this.lb_Telefono_Click);
            // 
            // txt_Apellido2
            // 
            this.txt_Apellido2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido2.Location = new System.Drawing.Point(143, 182);
            this.txt_Apellido2.MaxLength = 250;
            this.txt_Apellido2.Name = "txt_Apellido2";
            this.txt_Apellido2.Size = new System.Drawing.Size(191, 26);
            this.txt_Apellido2.TabIndex = 24;
            this.txt_Apellido2.TextChanged += new System.EventHandler(this.txt_Apellido2_TextChanged);
            // 
            // lb_Apellido2
            // 
            this.lb_Apellido2.AutoSize = true;
            this.lb_Apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Apellido2.Location = new System.Drawing.Point(25, 185);
            this.lb_Apellido2.Name = "lb_Apellido2";
            this.lb_Apellido2.Size = new System.Drawing.Size(83, 20);
            this.lb_Apellido2.TabIndex = 29;
            this.lb_Apellido2.Text = "2° Apellido";
            this.lb_Apellido2.Click += new System.EventHandler(this.lb_Apellido2_Click);
            // 
            // txt_Apellido1
            // 
            this.txt_Apellido1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido1.Location = new System.Drawing.Point(143, 126);
            this.txt_Apellido1.MaxLength = 250;
            this.txt_Apellido1.Name = "txt_Apellido1";
            this.txt_Apellido1.Size = new System.Drawing.Size(191, 26);
            this.txt_Apellido1.TabIndex = 23;
            this.txt_Apellido1.TextChanged += new System.EventHandler(this.txt_Apellido1_TextChanged);
            // 
            // lb_Apellido1
            // 
            this.lb_Apellido1.AutoSize = true;
            this.lb_Apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Apellido1.Location = new System.Drawing.Point(25, 129);
            this.lb_Apellido1.Name = "lb_Apellido1";
            this.lb_Apellido1.Size = new System.Drawing.Size(83, 20);
            this.lb_Apellido1.TabIndex = 25;
            this.lb_Apellido1.Text = "1° Apellido";
            this.lb_Apellido1.Click += new System.EventHandler(this.lb_Apellido1_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(143, 77);
            this.txt_Nombre.MaxLength = 250;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(191, 26);
            this.txt_Nombre.TabIndex = 21;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre.Location = new System.Drawing.Point(25, 80);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(65, 20);
            this.lb_Nombre.TabIndex = 22;
            this.lb_Nombre.Text = "Nombre";
            this.lb_Nombre.Click += new System.EventHandler(this.lb_Nombre_Click);
            // 
            // txt_Identif
            // 
            this.txt_Identif.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Identif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identif.Location = new System.Drawing.Point(143, 29);
            this.txt_Identif.MaxLength = 9;
            this.txt_Identif.Name = "txt_Identif";
            this.txt_Identif.Size = new System.Drawing.Size(191, 26);
            this.txt_Identif.TabIndex = 20;
            this.txt_Identif.TextChanged += new System.EventHandler(this.txt_Identif_TextChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(25, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(112, 20);
            this.lb_id.TabIndex = 19;
            this.lb_id.Text = "Indentificación";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // pxb_Cliente
            // 
            this.pxb_Cliente.Image = global::Taller.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.pxb_Cliente.Location = new System.Drawing.Point(523, 120);
            this.pxb_Cliente.Name = "pxb_Cliente";
            this.pxb_Cliente.Size = new System.Drawing.Size(128, 128);
            this.pxb_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxb_Cliente.TabIndex = 36;
            this.pxb_Cliente.TabStop = false;
            this.pxb_Cliente.Click += new System.EventHandler(this.pxb_Cliente_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(143, 356);
            this.txt_Email.MaxLength = 8;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(191, 26);
            this.txt_Email.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "E-mail";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Image = global::Taller.Properties.Resources.Salir;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(12, 468);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(95, 31);
            this.btn_Salir.TabIndex = 75;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Image = global::Taller.Properties.Resources.Guardar;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(714, 468);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(95, 31);
            this.btn_Guardar.TabIndex = 74;
            this.btn_Guardar.Text = "   Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // txt_Celular
            // 
            this.txt_Celular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.Location = new System.Drawing.Point(142, 315);
            this.txt_Celular.MaxLength = 8;
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(191, 26);
            this.txt_Celular.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Celular";
            // 
            // Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 511);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.pxb_Cliente);
            this.Controls.Add(this.lb_InfoCliente);
            this.Controls.Add(this.rdb_Mujer);
            this.Controls.Add(this.lb_Sexo);
            this.Controls.Add(this.rdb_Hombre);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lb_Direccion);
            this.Controls.Add(this.lb_Telefono);
            this.Controls.Add(this.txt_Apellido2);
            this.Controls.Add(this.lb_Apellido2);
            this.Controls.Add(this.txt_Apellido1);
            this.Controls.Add(this.lb_Apellido1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.txt_Identif);
            this.Controls.Add(this.lb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nuevo_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.PictureBox pxb_Cliente;
        private System.Windows.Forms.Label lb_InfoCliente;
        private System.Windows.Forms.RadioButton rdb_Mujer;
        private System.Windows.Forms.Label lb_Sexo;
        private System.Windows.Forms.RadioButton rdb_Hombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.Label lb_Telefono;
        private System.Windows.Forms.TextBox txt_Apellido2;
        private System.Windows.Forms.Label lb_Apellido2;
        private System.Windows.Forms.TextBox txt_Apellido1;
        private System.Windows.Forms.Label lb_Apellido1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.TextBox txt_Identif;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Celular;
        private System.Windows.Forms.Label label2;

    }
}