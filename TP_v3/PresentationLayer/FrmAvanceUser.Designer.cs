
namespace TP_v3.PresentationLayer
{
    partial class FrmAvanceUser
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
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFinaliz = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechInicio = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboPorc = new System.Windows.Forms.ComboBox();
            this.usuariosCursoAvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcAvanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.cboPorc);
            this.grpSeleccion.Controls.Add(this.lblPorcent);
            this.grpSeleccion.Controls.Add(this.dateTimePicker2);
            this.grpSeleccion.Controls.Add(this.lblFinaliz);
            this.grpSeleccion.Controls.Add(this.dateTimePicker1);
            this.grpSeleccion.Controls.Add(this.lblFechInicio);
            this.grpSeleccion.Controls.Add(this.cboCurso);
            this.grpSeleccion.Controls.Add(this.lblCurso);
            this.grpSeleccion.Controls.Add(this.cboUsuario);
            this.grpSeleccion.Controls.Add(this.lblUsuario);
            this.grpSeleccion.Location = new System.Drawing.Point(17, 31);
            this.grpSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Padding = new System.Windows.Forms.Padding(4);
            this.grpSeleccion.Size = new System.Drawing.Size(777, 89);
            this.grpSeleccion.TabIndex = 0;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Datos";
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.Location = new System.Drawing.Point(597, 28);
            this.lblPorcent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(72, 17);
            this.lblPorcent.TabIndex = 8;
            this.lblPorcent.Text = "% Avance";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(384, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // lblFinaliz
            // 
            this.lblFinaliz.AutoSize = true;
            this.lblFinaliz.Location = new System.Drawing.Point(251, 55);
            this.lblFinaliz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinaliz.Name = "lblFinaliz";
            this.lblFinaliz.Size = new System.Drawing.Size(124, 17);
            this.lblFinaliz.TabIndex = 6;
            this.lblFinaliz.Text = "Fecha finalización";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblFechInicio
            // 
            this.lblFechInicio.AutoSize = true;
            this.lblFechInicio.Location = new System.Drawing.Point(251, 27);
            this.lblFechInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechInicio.Name = "lblFechInicio";
            this.lblFechInicio.Size = new System.Drawing.Size(85, 17);
            this.lblFechInicio.TabIndex = 4;
            this.lblFechInicio.Text = "Fecha inicio";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(93, 55);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(145, 25);
            this.cboCurso.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(9, 59);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(93, 22);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(145, 25);
            this.cboUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 26);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idCursoDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.finDataGridViewTextBoxColumn,
            this.porcAvanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosCursoAvanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 309);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(810, 43);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 68);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Actualizar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cboPorc
            // 
            this.cboPorc.FormattingEnabled = true;
            this.cboPorc.Location = new System.Drawing.Point(676, 26);
            this.cboPorc.Name = "cboPorc";
            this.cboPorc.Size = new System.Drawing.Size(50, 25);
            this.cboPorc.TabIndex = 10;
            // 
            // usuariosCursoAvanceBindingSource
            // 
            this.usuariosCursoAvanceBindingSource.DataSource = typeof(TP_v3.Entities.UsuariosCursoAvance);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 220;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.Width = 220;
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "inicio";
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.Width = 150;
            // 
            // finDataGridViewTextBoxColumn
            // 
            this.finDataGridViewTextBoxColumn.DataPropertyName = "fin";
            this.finDataGridViewTextBoxColumn.HeaderText = "Fecha fin";
            this.finDataGridViewTextBoxColumn.Name = "finDataGridViewTextBoxColumn";
            this.finDataGridViewTextBoxColumn.Width = 150;
            // 
            // porcAvanceDataGridViewTextBoxColumn
            // 
            this.porcAvanceDataGridViewTextBoxColumn.DataPropertyName = "porcAvance";
            this.porcAvanceDataGridViewTextBoxColumn.HeaderText = "% Avance";
            this.porcAvanceDataGridViewTextBoxColumn.Name = "porcAvanceDataGridViewTextBoxColumn";
            // 
            // FrmAvanceUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 448);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpSeleccion);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAvanceUser";
            this.Text = "Actualización avance usuarios";
            this.Load += new System.EventHandler(this.FrmAvanceUser_Load);
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeleccion;
        private System.Windows.Forms.Label lblPorcent;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblFinaliz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechInicio;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboPorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcAvanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuariosCursoAvanceBindingSource;
    }
}