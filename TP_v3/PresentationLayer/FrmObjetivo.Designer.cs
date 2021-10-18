
namespace TP_v3.PresentationLayer
{
    partial class FrmObjetivo
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
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCursoSearch = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idObjetivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCortoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjetivoDataGridViewTextBoxColumn,
            this.nombreCortoDataGridViewTextBoxColumn,
            this.nombreLargoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataGridView1.DataSource = this.objetivoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(TP_v3.Entities.Categoria);
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
            this.grbBusqueda.Size = new System.Drawing.Size(476, 92);
            this.grbBusqueda.TabIndex = 1;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(359, 31);
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
            this.txtCursoSearch.Location = new System.Drawing.Point(140, 35);
            this.txtCursoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursoSearch.Name = "txtCursoSearch";
            this.txtCursoSearch.Size = new System.Drawing.Size(211, 23);
            this.txtCursoSearch.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 38);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(107, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar objetivo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(510, 46);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar objetivo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataSource = typeof(TP_v3.Entities.Curso);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(TP_v3.Entities.Curso);
            // 
            // objetivoBindingSource
            // 
            this.objetivoBindingSource.DataSource = typeof(TP_v3.Entities.Objetivo);
            // 
            // idObjetivoDataGridViewTextBoxColumn
            // 
            this.idObjetivoDataGridViewTextBoxColumn.DataPropertyName = "idObjetivo";
            this.idObjetivoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idObjetivoDataGridViewTextBoxColumn.Name = "idObjetivoDataGridViewTextBoxColumn";
            this.idObjetivoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreCortoDataGridViewTextBoxColumn
            // 
            this.nombreCortoDataGridViewTextBoxColumn.DataPropertyName = "nombreCorto";
            this.nombreCortoDataGridViewTextBoxColumn.HeaderText = "Nombre corto";
            this.nombreCortoDataGridViewTextBoxColumn.Name = "nombreCortoDataGridViewTextBoxColumn";
            this.nombreCortoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreLargoDataGridViewTextBoxColumn
            // 
            this.nombreLargoDataGridViewTextBoxColumn.DataPropertyName = "nombreLargo";
            this.nombreLargoDataGridViewTextBoxColumn.HeaderText = "Nombre largo";
            this.nombreLargoDataGridViewTextBoxColumn.Name = "nombreLargoDataGridViewTextBoxColumn";
            this.nombreLargoDataGridViewTextBoxColumn.Width = 150;
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
            // FrmObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 433);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmObjetivo";
            this.Text = "Gestión de objetivos";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCortoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
    }
}