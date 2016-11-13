namespace Taller
{
    partial class Salida_Inventario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.cbx_descrip = new System.Windows.Forms.ComboBox();
            this.nUd_cantidad = new System.Windows.Forms.NumericUpDown();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.pxb_Cliente = new System.Windows.Forms.PictureBox();
            this.lb_InfoCliente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.dgv_Inventario);
            this.groupBox1.Controls.Add(this.lb_cantidad);
            this.groupBox1.Controls.Add(this.cbx_descrip);
            this.groupBox1.Controls.Add(this.nUd_cantidad);
            this.groupBox1.Controls.Add(this.lb_descripcion);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 279);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Image = global::Taller.Properties.Resources.icono_mas_informacion;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(472, 41);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(105, 35);
            this.btn_Agregar.TabIndex = 71;
            this.btn_Agregar.Text = "      Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.BackgroundImage = global::Taller.Properties.Resources.delete;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.Location = new System.Drawing.Point(548, 184);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(42, 37);
            this.btn_eliminar.TabIndex = 70;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.AllowUserToAddRows = false;
            this.dgv_Inventario.AllowUserToDeleteRows = false;
            this.dgv_Inventario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Inventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripción,
            this.Fecha_hora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Inventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Inventario.GridColor = System.Drawing.Color.White;
            this.dgv_Inventario.Location = new System.Drawing.Point(16, 113);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Inventario.RowHeadersVisible = false;
            this.dgv_Inventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventario.Size = new System.Drawing.Size(526, 160);
            this.dgv_Inventario.TabIndex = 69;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 4;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 200;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 200;
            // 
            // Fecha_hora
            // 
            this.Fecha_hora.HeaderText = "Fecha y Hora";
            this.Fecha_hora.Name = "Fecha_hora";
            this.Fecha_hora.ReadOnly = true;
            this.Fecha_hora.Width = 120;
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.Location = new System.Drawing.Point(22, 78);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(73, 20);
            this.lb_cantidad.TabIndex = 61;
            this.lb_cantidad.Text = "Cantidad";
            // 
            // cbx_descrip
            // 
            this.cbx_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_descrip.FormattingEnabled = true;
            this.cbx_descrip.Location = new System.Drawing.Point(120, 25);
            this.cbx_descrip.Name = "cbx_descrip";
            this.cbx_descrip.Size = new System.Drawing.Size(287, 28);
            this.cbx_descrip.TabIndex = 59;
            // 
            // nUd_cantidad
            // 
            this.nUd_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUd_cantidad.Location = new System.Drawing.Point(120, 76);
            this.nUd_cantidad.Name = "nUd_cantidad";
            this.nUd_cantidad.Size = new System.Drawing.Size(52, 26);
            this.nUd_cantidad.TabIndex = 60;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descripcion.Location = new System.Drawing.Point(12, 28);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(92, 20);
            this.lb_descripcion.TabIndex = 58;
            this.lb_descripcion.Text = "Descripción";
            // 
            // pxb_Cliente
            // 
            this.pxb_Cliente.Image = global::Taller.Properties.Resources.inventory_management_icon;
            this.pxb_Cliente.Location = new System.Drawing.Point(17, 34);
            this.pxb_Cliente.Name = "pxb_Cliente";
            this.pxb_Cliente.Size = new System.Drawing.Size(88, 78);
            this.pxb_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxb_Cliente.TabIndex = 66;
            this.pxb_Cliente.TabStop = false;
            // 
            // lb_InfoCliente
            // 
            this.lb_InfoCliente.AutoSize = true;
            this.lb_InfoCliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InfoCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_InfoCliente.Location = new System.Drawing.Point(111, 62);
            this.lb_InfoCliente.Name = "lb_InfoCliente";
            this.lb_InfoCliente.Size = new System.Drawing.Size(233, 27);
            this.lb_InfoCliente.TabIndex = 65;
            this.lb_InfoCliente.Text = "Salida de Inventario ";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Image = global::Taller.Properties.Resources.Guardar;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(538, 429);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(95, 31);
            this.btn_Guardar.TabIndex = 72;
            this.btn_Guardar.Text = "   Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.Image = global::Taller.Properties.Resources.Salir;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(10, 429);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(95, 31);
            this.btn_Salir.TabIndex = 73;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // Salida_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 472);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pxb_Cliente);
            this.Controls.Add(this.lb_InfoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salida_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida_Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxb_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hora;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.ComboBox cbx_descrip;
        private System.Windows.Forms.NumericUpDown nUd_cantidad;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.PictureBox pxb_Cliente;
        private System.Windows.Forms.Label lb_InfoCliente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
    }
}