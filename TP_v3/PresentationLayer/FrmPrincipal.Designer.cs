
namespace TP_v3
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónACursadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEstadosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasVariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.pboxUser = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.objetivosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.consultaToolStripMenuItem.Text = "ABM\'s";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            this.objetivosToolStripMenuItem.Click += new System.EventHandler(this.objetivosToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripciónACursadoToolStripMenuItem,
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem,
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.transaccionesToolStripMenuItem.Text = "Operaciones";
            // 
            // inscripciónACursadoToolStripMenuItem
            // 
            this.inscripciónACursadoToolStripMenuItem.Name = "inscripciónACursadoToolStripMenuItem";
            this.inscripciónACursadoToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.inscripciónACursadoToolStripMenuItem.Text = "Inscripción a cursado";
            this.inscripciónACursadoToolStripMenuItem.Click += new System.EventHandler(this.inscripciónACursadoToolStripMenuItem_Click);
            // 
            // registroDeAvanceCursadoPorUsuarioToolStripMenuItem
            // 
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem.Name = "registroDeAvanceCursadoPorUsuarioToolStripMenuItem";
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem.Text = "Registro de avance cursado por usuario";
            this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroDeAvanceCursadoPorUsuarioToolStripMenuItem_Click);
            // 
            // actualizaciónDeAvanceDeUsuariosToolStripMenuItem
            // 
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem.Name = "actualizaciónDeAvanceDeUsuariosToolStripMenuItem";
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem.Text = "Actualización de avance de usuarios";
            this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónDeAvanceDeUsuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeEstadosPorCursoToolStripMenuItem,
            this.estadisticasVariasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeEstadosPorCursoToolStripMenuItem
            // 
            this.listadoDeEstadosPorCursoToolStripMenuItem.Name = "listadoDeEstadosPorCursoToolStripMenuItem";
            this.listadoDeEstadosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.listadoDeEstadosPorCursoToolStripMenuItem.Text = "Listado de usuarios por curso";
            this.listadoDeEstadosPorCursoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEstadosPorCursoToolStripMenuItem_Click);
            // 
            // estadisticasVariasToolStripMenuItem
            // 
            this.estadisticasVariasToolStripMenuItem.Name = "estadisticasVariasToolStripMenuItem";
            this.estadisticasVariasToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.estadisticasVariasToolStripMenuItem.Text = "Estadisticas varias";
            this.estadisticasVariasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasVariasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblUser.Location = new System.Drawing.Point(770, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            this.lblUser.TabIndex = 1;
            // 
            // pboxUser
            // 
            this.pboxUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxUser.Image = ((System.Drawing.Image)(resources.GetObject("pboxUser.Image")));
            this.pboxUser.Location = new System.Drawing.Point(949, 0);
            this.pboxUser.Name = "pboxUser";
            this.pboxUser.Size = new System.Drawing.Size(62, 27);
            this.pboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxUser.TabIndex = 2;
            this.pboxUser.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 588);
            this.Controls.Add(this.pboxUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pboxUser;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDeAvanceDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónACursadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAvanceCursadoPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEstadosPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasVariasToolStripMenuItem;
    }
}

