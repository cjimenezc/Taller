namespace Taller
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajosPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeDescripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bucarToolStripMenuItem.Image = global::Taller.Properties.Resources.buscar_buscar_ampliar_icono_9048_48;
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.bucarToolStripMenuItem.Text = "Buscar";
            this.bucarToolStripMenuItem.Click += new System.EventHandler(this.bucarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mantenimientoToolStripMenuItem,
            this.bucarToolStripMenuItem,
            this.inventarioToolStripMenuItem1,
            this.facturaciónToolStripMenuItem,
            this.administarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(981, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.trabajoToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Image = global::Taller.Properties.Resources.naranja_nuevo_archivo_de_icono_9603_128;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 28);
            this.toolStripMenuItem1.Text = "Nuevo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem2.Image = global::Taller.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 28);
            this.toolStripMenuItem2.Text = "Cliente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // trabajoToolStripMenuItem
            // 
            this.trabajoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.trabajoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trabajoToolStripMenuItem.Image = global::Taller.Properties.Resources.Car_Repair_icon2;
            this.trabajoToolStripMenuItem.Name = "trabajoToolStripMenuItem";
            this.trabajoToolStripMenuItem.Size = new System.Drawing.Size(163, 28);
            this.trabajoToolStripMenuItem.Text = "Vehiculo";
            this.trabajoToolStripMenuItem.Click += new System.EventHandler(this.trabajoToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarTrabajoToolStripMenuItem,
            this.trabajosPendientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mantenimientoToolStripMenuItem.Image = global::Taller.Properties.Resources.iconos_02;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.mantenimientoToolStripMenuItem.Text = "Trabajos";
            // 
            // asignarTrabajoToolStripMenuItem
            // 
            this.asignarTrabajoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.asignarTrabajoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asignarTrabajoToolStripMenuItem.Image = global::Taller.Properties.Resources.Mantenimiento;
            this.asignarTrabajoToolStripMenuItem.Name = "asignarTrabajoToolStripMenuItem";
            this.asignarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.asignarTrabajoToolStripMenuItem.Text = "Asignar ";
            this.asignarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.asignarTrabajoToolStripMenuItem_Click);
            // 
            // trabajosPendientesToolStripMenuItem
            // 
            this.trabajosPendientesToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.trabajosPendientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trabajosPendientesToolStripMenuItem.Image = global::Taller.Properties.Resources.Icon_warning;
            this.trabajosPendientesToolStripMenuItem.Name = "trabajosPendientesToolStripMenuItem";
            this.trabajosPendientesToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.trabajosPendientesToolStripMenuItem.Text = " Pendientes";
            this.trabajosPendientesToolStripMenuItem.Click += new System.EventHandler(this.trabajosPendientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem1});
            this.inventarioToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventarioToolStripMenuItem1.Image = global::Taller.Properties.Resources.inventory_management_icon;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(129, 28);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.ingresoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ingresoToolStripMenuItem.Image = global::Taller.Properties.Resources.flecha_derecha;
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.salidaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salidaToolStripMenuItem.Image = global::Taller.Properties.Resources.flecha_atras1;
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.mantenimientoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDeDescripcionesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mantenimientoToolStripMenuItem1.Image = global::Taller.Properties.Resources.control_panel;
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(217, 28);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // tablaDeDescripcionesToolStripMenuItem
            // 
            this.tablaDeDescripcionesToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.tablaDeDescripcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaDeDescripcionesToolStripMenuItem.Image = global::Taller.Properties.Resources.Dar_formato_numérico_a_una_columna_en_una_tabla_dinámica_ppal_thumb_1_1;
            this.tablaDeDescripcionesToolStripMenuItem.Name = "tablaDeDescripcionesToolStripMenuItem";
            this.tablaDeDescripcionesToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.tablaDeDescripcionesToolStripMenuItem.Text = "Tabla de productos";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturaciónToolStripMenuItem.Image = global::Taller.Properties.Resources.icon175x175;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // administarToolStripMenuItem
            // 
            this.administarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.administarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administarToolStripMenuItem.Image = global::Taller.Properties.Resources.administrador_de_conexion_de_red_icono_4584_128;
            this.administarToolStripMenuItem.Name = "administarToolStripMenuItem";
            this.administarToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.administarToolStripMenuItem.Text = "Administar";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.nuevoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradorToolStripMenuItem1});
            this.nuevoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoToolStripMenuItem1.Image = global::Taller.Properties.Resources.naranja_nuevo_archivo_de_icono_9603_128;
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(165, 28);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // colaboradorToolStripMenuItem1
            // 
            this.colaboradorToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.colaboradorToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.colaboradorToolStripMenuItem1.Image = global::Taller.Properties.Resources._6360767688234471221;
            this.colaboradorToolStripMenuItem1.Name = "colaboradorToolStripMenuItem1";
            this.colaboradorToolStripMenuItem1.Size = new System.Drawing.Size(195, 28);
            this.colaboradorToolStripMenuItem1.Text = "Colaborador";
            this.colaboradorToolStripMenuItem1.Click += new System.EventHandler(this.colaboradorToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.colaboradorToolStripMenuItem2,
            this.trabajoToolStripMenuItem1});
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modificarToolStripMenuItem.Image = global::Taller.Properties.Resources.modificar_el_icono_de_informe_14125;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clienteToolStripMenuItem.Image = global::Taller.Properties.Resources.edit_male_user_256;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.vehiculoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vehiculoToolStripMenuItem.Image = global::Taller.Properties.Resources.vehiculo_modificar;
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            // 
            // colaboradorToolStripMenuItem2
            // 
            this.colaboradorToolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.colaboradorToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colaboradorToolStripMenuItem2.Image = global::Taller.Properties.Resources._636076768823447122;
            this.colaboradorToolStripMenuItem2.Name = "colaboradorToolStripMenuItem2";
            this.colaboradorToolStripMenuItem2.Size = new System.Drawing.Size(195, 28);
            this.colaboradorToolStripMenuItem2.Text = "Colaborador";
            // 
            // trabajoToolStripMenuItem1
            // 
            this.trabajoToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.trabajoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trabajoToolStripMenuItem1.Image = global::Taller.Properties.Resources.Mantenimiento;
            this.trabajoToolStripMenuItem1.Name = "trabajoToolStripMenuItem1";
            this.trabajoToolStripMenuItem1.Size = new System.Drawing.Size(195, 28);
            this.trabajoToolStripMenuItem1.Text = "Trabajo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Taller.Properties.Resources.neox_piston;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(981, 453);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem trabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajosPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tablaDeDescripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem trabajoToolStripMenuItem1;
    }
}



