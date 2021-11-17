
namespace TP_v3.PresentationLayer
{
    partial class FrmCurso
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCursoSearch = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.btnBusqFiltro = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnLimpBusq = new System.Windows.Forms.Button();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbBusqueda.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaVigenciaDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataGridView1.DataSource = this.cursoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.txtCursoSearch);
            this.grbBusqueda.Controls.Add(this.lblBuscar);
            this.grbBusqueda.Location = new System.Drawing.Point(17, 17);
            this.grbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusqueda.Size = new System.Drawing.Size(629, 71);
            this.grbBusqueda.TabIndex = 1;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(510, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCursoSearch
            // 
            this.txtCursoSearch.Location = new System.Drawing.Point(116, 24);
            this.txtCursoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursoSearch.Name = "txtCursoSearch";
            this.txtCursoSearch.Size = new System.Drawing.Size(357, 23);
            this.txtCursoSearch.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 24);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar curso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(785, 104);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 47);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar curso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboCateg);
            this.grpFiltros.Controls.Add(this.btnBusqFiltro);
            this.grpFiltros.Controls.Add(this.lblCategoria);
            this.grpFiltros.Location = new System.Drawing.Point(17, 92);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(629, 71);
            this.grpFiltros.TabIndex = 3;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtrar";
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Location = new System.Drawing.Point(116, 24);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(220, 25);
            this.cboCateg.TabIndex = 3;
            // 
            // btnBusqFiltro
            // 
            this.btnBusqFiltro.Location = new System.Drawing.Point(444, 24);
            this.btnBusqFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqFiltro.Name = "btnBusqFiltro";
            this.btnBusqFiltro.Size = new System.Drawing.Size(166, 30);
            this.btnBusqFiltro.TabIndex = 2;
            this.btnBusqFiltro.Text = "Filtrar por categoría";
            this.btnBusqFiltro.UseVisualStyleBackColor = true;
            this.btnBusqFiltro.Click += new System.EventHandler(this.btnBusqFiltro_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 24);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría";
            // 
            // btnLimpBusq
            // 
            this.btnLimpBusq.Location = new System.Drawing.Point(785, 41);
            this.btnLimpBusq.Name = "btnLimpBusq";
            this.btnLimpBusq.Size = new System.Drawing.Size(149, 23);
            this.btnLimpBusq.TabIndex = 4;
            this.btnLimpBusq.Text = "Limpiar búsqueda";
            this.btnLimpBusq.UseVisualStyleBackColor = true;
            this.btnLimpBusq.Click += new System.EventHandler(this.btnLimpBusq_Click);
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataSource = typeof(TP_v3.Entities.Curso);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(TP_v3.Entities.Curso);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idCurso";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre curso";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion curso";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 204;
            // 
            // fechaVigenciaDataGridViewTextBoxColumn
            // 
            this.fechaVigenciaDataGridViewTextBoxColumn.DataPropertyName = "fechaVigencia";
            this.fechaVigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia hasta";
            this.fechaVigenciaDataGridViewTextBoxColumn.Name = "fechaVigenciaDataGridViewTextBoxColumn";
            this.fechaVigenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.Width = 140;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.Width = 80;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.Width = 80;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 475);
            this.Controls.Add(this.btnLimpBusq);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestión de cursos";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCursoSearch;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cboCateg;
        private System.Windows.Forms.Button btnBusqFiltro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnLimpBusq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}