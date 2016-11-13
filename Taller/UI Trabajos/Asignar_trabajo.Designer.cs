namespace Taller
{
    partial class Asignar_trabajo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_trabajo = new System.Windows.Forms.DateTimePicker();
            this.panel_ColabDisponibl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgw_ColabDisponib = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.lb_InfoCliente = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.btn_VerDisponi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Propietario = new System.Windows.Forms.TextBox();
            this.lb_Propierario = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_Clase = new System.Windows.Forms.ComboBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.lb_Placa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbx_Baul = new System.Windows.Forms.CheckBox();
            this.ckbx_Estribo = new System.Windows.Forms.CheckBox();
            this.ckbx_BumTra = new System.Windows.Forms.CheckBox();
            this.ckbx_PuertaIzTra = new System.Windows.Forms.CheckBox();
            this.ckbx_Techo = new System.Windows.Forms.CheckBox();
            this.ckbx_Taps = new System.Windows.Forms.CheckBox();
            this.ckbx_BumDel = new System.Windows.Forms.CheckBox();
            this.ckbx_PuertaIzDe = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Gaurdar = new System.Windows.Forms.Button();
            this.panel_ColabDisponibl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ColabDisponib)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_trabajo
            // 
            this.dtp_trabajo.Location = new System.Drawing.Point(51, 290);
            this.dtp_trabajo.Name = "dtp_trabajo";
            this.dtp_trabajo.Size = new System.Drawing.Size(208, 20);
            this.dtp_trabajo.TabIndex = 87;
            // 
            // panel_ColabDisponibl
            // 
            this.panel_ColabDisponibl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ColabDisponibl.Controls.Add(this.label4);
            this.panel_ColabDisponibl.Controls.Add(this.dgw_ColabDisponib);
            this.panel_ColabDisponibl.Location = new System.Drawing.Point(24, 74);
            this.panel_ColabDisponibl.Name = "panel_ColabDisponibl";
            this.panel_ColabDisponibl.Size = new System.Drawing.Size(416, 206);
            this.panel_ColabDisponibl.TabIndex = 86;
            this.panel_ColabDisponibl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(99, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Colaboradores Disponibles";
            // 
            // dgw_ColabDisponib
            // 
            this.dgw_ColabDisponib.AllowUserToAddRows = false;
            this.dgw_ColabDisponib.AllowUserToDeleteRows = false;
            this.dgw_ColabDisponib.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgw_ColabDisponib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_ColabDisponib.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgw_ColabDisponib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_ColabDisponib.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_ColabDisponib.GridColor = System.Drawing.Color.Gainsboro;
            this.dgw_ColabDisponib.Location = new System.Drawing.Point(55, 30);
            this.dgw_ColabDisponib.Name = "dgw_ColabDisponib";
            this.dgw_ColabDisponib.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_ColabDisponib.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_ColabDisponib.RowHeadersVisible = false;
            this.dgw_ColabDisponib.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw_ColabDisponib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_ColabDisponib.Size = new System.Drawing.Size(315, 159);
            this.dgw_ColabDisponib.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Observaciones";
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observaciones.Location = new System.Drawing.Point(51, 185);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(345, 95);
            this.txt_Observaciones.TabIndex = 84;
            // 
            // lb_InfoCliente
            // 
            this.lb_InfoCliente.AutoSize = true;
            this.lb_InfoCliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InfoCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_InfoCliente.Location = new System.Drawing.Point(114, 28);
            this.lb_InfoCliente.Name = "lb_InfoCliente";
            this.lb_InfoCliente.Size = new System.Drawing.Size(217, 27);
            this.lb_InfoCliente.TabIndex = 83;
            this.lb_InfoCliente.Text = "Asignación Trabajo";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Verificar.Location = new System.Drawing.Point(324, 98);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(76, 27);
            this.btn_Verificar.TabIndex = 81;
            this.btn_Verificar.Text = "Verificar ";
            this.btn_Verificar.UseVisualStyleBackColor = false;
            // 
            // btn_VerDisponi
            // 
            this.btn_VerDisponi.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_VerDisponi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerDisponi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VerDisponi.Location = new System.Drawing.Point(265, 287);
            this.btn_VerDisponi.Name = "btn_VerDisponi";
            this.btn_VerDisponi.Size = new System.Drawing.Size(131, 29);
            this.btn_VerDisponi.TabIndex = 80;
            this.btn_VerDisponi.Text = "Disponibilidad";
            this.btn_VerDisponi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(668, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Estilo del Vehículo";
            // 
            // txt_Propietario
            // 
            this.txt_Propietario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Propietario.Enabled = false;
            this.txt_Propietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Propietario.Location = new System.Drawing.Point(137, 137);
            this.txt_Propietario.MaxLength = 6;
            this.txt_Propietario.Name = "txt_Propietario";
            this.txt_Propietario.Size = new System.Drawing.Size(259, 24);
            this.txt_Propietario.TabIndex = 78;
            // 
            // lb_Propierario
            // 
            this.lb_Propierario.AutoSize = true;
            this.lb_Propierario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Propierario.Location = new System.Drawing.Point(47, 136);
            this.lb_Propierario.Name = "lb_Propierario";
            this.lb_Propierario.Size = new System.Drawing.Size(85, 20);
            this.lb_Propierario.TabIndex = 77;
            this.lb_Propierario.Text = "Propietario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Clase";
            // 
            // cbx_Clase
            // 
            this.cbx_Clase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_Clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Clase.FormattingEnabled = true;
            this.cbx_Clase.Items.AddRange(new object[] {
            "PART",
            "CL",
            "C",
            "EE",
            "AB",
            "SJB",
            "TA"});
            this.cbx_Clase.Location = new System.Drawing.Point(121, 97);
            this.cbx_Clase.Name = "cbx_Clase";
            this.cbx_Clase.Size = new System.Drawing.Size(74, 26);
            this.cbx_Clase.TabIndex = 74;
            // 
            // txt_Placa
            // 
            this.txt_Placa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placa.Location = new System.Drawing.Point(213, 99);
            this.txt_Placa.MaxLength = 6;
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(105, 26);
            this.txt_Placa.TabIndex = 73;
            // 
            // lb_Placa
            // 
            this.lb_Placa.AutoSize = true;
            this.lb_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Placa.Location = new System.Drawing.Point(47, 102);
            this.lb_Placa.Name = "lb_Placa";
            this.lb_Placa.Size = new System.Drawing.Size(48, 20);
            this.lb_Placa.TabIndex = 72;
            this.lb_Placa.Text = "Placa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbx_Baul);
            this.panel1.Controls.Add(this.ckbx_Estribo);
            this.panel1.Controls.Add(this.ckbx_BumTra);
            this.panel1.Controls.Add(this.ckbx_PuertaIzTra);
            this.panel1.Controls.Add(this.ckbx_Techo);
            this.panel1.Controls.Add(this.ckbx_Taps);
            this.panel1.Controls.Add(this.ckbx_BumDel);
            this.panel1.Controls.Add(this.ckbx_PuertaIzDe);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(455, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 327);
            this.panel1.TabIndex = 90;
            // 
            // ckbx_Baul
            // 
            this.ckbx_Baul.AutoSize = true;
            this.ckbx_Baul.Location = new System.Drawing.Point(450, 98);
            this.ckbx_Baul.Name = "ckbx_Baul";
            this.ckbx_Baul.Size = new System.Drawing.Size(47, 17);
            this.ckbx_Baul.TabIndex = 8;
            this.ckbx_Baul.Text = "Baul";
            this.ckbx_Baul.UseVisualStyleBackColor = true;
            // 
            // ckbx_Estribo
            // 
            this.ckbx_Estribo.AutoSize = true;
            this.ckbx_Estribo.BackColor = System.Drawing.Color.Transparent;
            this.ckbx_Estribo.Location = new System.Drawing.Point(246, 217);
            this.ckbx_Estribo.Name = "ckbx_Estribo";
            this.ckbx_Estribo.Size = new System.Drawing.Size(58, 17);
            this.ckbx_Estribo.TabIndex = 7;
            this.ckbx_Estribo.Text = "Estribo";
            this.ckbx_Estribo.UseVisualStyleBackColor = false;
            // 
            // ckbx_BumTra
            // 
            this.ckbx_BumTra.AutoSize = true;
            this.ckbx_BumTra.Location = new System.Drawing.Point(442, 191);
            this.ckbx_BumTra.Name = "ckbx_BumTra";
            this.ckbx_BumTra.Size = new System.Drawing.Size(98, 17);
            this.ckbx_BumTra.TabIndex = 6;
            this.ckbx_BumTra.Text = "Bumper tracero";
            this.ckbx_BumTra.UseVisualStyleBackColor = true;
            // 
            // ckbx_PuertaIzTra
            // 
            this.ckbx_PuertaIzTra.AutoSize = true;
            this.ckbx_PuertaIzTra.Location = new System.Drawing.Point(298, 144);
            this.ckbx_PuertaIzTra.Name = "ckbx_PuertaIzTra";
            this.ckbx_PuertaIzTra.Size = new System.Drawing.Size(109, 17);
            this.ckbx_PuertaIzTra.TabIndex = 5;
            this.ckbx_PuertaIzTra.Text = "Puerta izq tracera";
            this.ckbx_PuertaIzTra.UseVisualStyleBackColor = true;
            // 
            // ckbx_Techo
            // 
            this.ckbx_Techo.AutoSize = true;
            this.ckbx_Techo.BackColor = System.Drawing.Color.White;
            this.ckbx_Techo.Location = new System.Drawing.Point(282, 49);
            this.ckbx_Techo.Name = "ckbx_Techo";
            this.ckbx_Techo.Size = new System.Drawing.Size(57, 17);
            this.ckbx_Techo.TabIndex = 4;
            this.ckbx_Techo.Text = "Techo";
            this.ckbx_Techo.UseVisualStyleBackColor = false;
            // 
            // ckbx_Taps
            // 
            this.ckbx_Taps.AutoSize = true;
            this.ckbx_Taps.BackColor = System.Drawing.Color.Transparent;
            this.ckbx_Taps.Location = new System.Drawing.Point(75, 107);
            this.ckbx_Taps.Name = "ckbx_Taps";
            this.ckbx_Taps.Size = new System.Drawing.Size(51, 17);
            this.ckbx_Taps.TabIndex = 3;
            this.ckbx_Taps.Text = "Tapa";
            this.ckbx_Taps.UseVisualStyleBackColor = false;
            // 
            // ckbx_BumDel
            // 
            this.ckbx_BumDel.AutoSize = true;
            this.ckbx_BumDel.Location = new System.Drawing.Point(48, 185);
            this.ckbx_BumDel.Name = "ckbx_BumDel";
            this.ckbx_BumDel.Size = new System.Drawing.Size(94, 17);
            this.ckbx_BumDel.TabIndex = 2;
            this.ckbx_BumDel.Text = "Bumper delant";
            this.ckbx_BumDel.UseVisualStyleBackColor = true;
            // 
            // ckbx_PuertaIzDe
            // 
            this.ckbx_PuertaIzDe.AutoSize = true;
            this.ckbx_PuertaIzDe.Location = new System.Drawing.Point(172, 144);
            this.ckbx_PuertaIzDe.Name = "ckbx_PuertaIzDe";
            this.ckbx_PuertaIzDe.Size = new System.Drawing.Size(105, 17);
            this.ckbx_PuertaIzDe.TabIndex = 1;
            this.ckbx_PuertaIzDe.Text = "Puerta izq delant";
            this.ckbx_PuertaIzDe.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Taller.Properties.Resources.SEDAN;
            this.pictureBox2.Location = new System.Drawing.Point(31, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(484, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller.Properties.Resources.le_asigna_una_tarea_a_icono_4480_128;
            this.pictureBox1.Location = new System.Drawing.Point(155, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 126);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Image = global::Taller.Properties.Resources.Salir;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(12, 474);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(95, 31);
            this.btn_Salir.TabIndex = 92;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Gaurdar
            // 
            this.btn_Gaurdar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Gaurdar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gaurdar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Gaurdar.Image = global::Taller.Properties.Resources.Guardar;
            this.btn_Gaurdar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Gaurdar.Location = new System.Drawing.Point(897, 474);
            this.btn_Gaurdar.Name = "btn_Gaurdar";
            this.btn_Gaurdar.Size = new System.Drawing.Size(95, 31);
            this.btn_Gaurdar.TabIndex = 91;
            this.btn_Gaurdar.Text = "   Guardar";
            this.btn_Gaurdar.UseVisualStyleBackColor = false;
            // 
            // Asignar_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 508);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Gaurdar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_trabajo);
            this.Controls.Add(this.panel_ColabDisponibl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Observaciones);
            this.Controls.Add(this.lb_InfoCliente);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.btn_VerDisponi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Propietario);
            this.Controls.Add(this.lb_Propierario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_Clase);
            this.Controls.Add(this.txt_Placa);
            this.Controls.Add(this.lb_Placa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asignar_trabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar_trabajo";
            this.panel_ColabDisponibl.ResumeLayout(false);
            this.panel_ColabDisponibl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ColabDisponib)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_trabajo;
        private System.Windows.Forms.Panel panel_ColabDisponibl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgw_ColabDisponib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label lb_InfoCliente;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.Button btn_VerDisponi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Propietario;
        private System.Windows.Forms.Label lb_Propierario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_Clase;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.Label lb_Placa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ckbx_Baul;
        private System.Windows.Forms.CheckBox ckbx_Estribo;
        private System.Windows.Forms.CheckBox ckbx_BumTra;
        private System.Windows.Forms.CheckBox ckbx_PuertaIzTra;
        private System.Windows.Forms.CheckBox ckbx_Techo;
        private System.Windows.Forms.CheckBox ckbx_Taps;
        private System.Windows.Forms.CheckBox ckbx_BumDel;
        private System.Windows.Forms.CheckBox ckbx_PuertaIzDe;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Gaurdar;
    }
}