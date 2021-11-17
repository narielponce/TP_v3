
namespace TP_v3.PresentationLayer
{
    partial class FrmUsuarioCursoAvance
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
            this.lblUsuarioSearch = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvUsuarioCursos = new System.Windows.Forms.DataGridView();
            this.lblPorcAvance = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.chkAllCourses = new System.Windows.Forms.CheckBox();
            this.txtAvance = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.grpCursosSel = new System.Windows.Forms.GroupBox();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursos)).BeginInit();
            this.grpRegistrar.SuspendLayout();
            this.grpCursosSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioSearch
            // 
            this.lblUsuarioSearch.AutoSize = true;
            this.lblUsuarioSearch.Location = new System.Drawing.Point(14, 25);
            this.lblUsuarioSearch.Name = "lblUsuarioSearch";
            this.lblUsuarioSearch.Size = new System.Drawing.Size(54, 17);
            this.lblUsuarioSearch.TabIndex = 0;
            this.lblUsuarioSearch.Text = "Usuario";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(88, 22);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(245, 25);
            this.cboUsuario.TabIndex = 1;
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnConsultar);
            this.grbBusqueda.Controls.Add(this.cboUsuario);
            this.grbBusqueda.Controls.Add(this.lblUsuarioSearch);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(496, 71);
            this.grbBusqueda.TabIndex = 2;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Buscar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(374, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 25);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvUsuarioCursos
            // 
            this.dgvUsuarioCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCursos.Location = new System.Drawing.Point(9, 22);
            this.dgvUsuarioCursos.Name = "dgvUsuarioCursos";
            this.dgvUsuarioCursos.Size = new System.Drawing.Size(683, 147);
            this.dgvUsuarioCursos.TabIndex = 15;
            // 
            // lblPorcAvance
            // 
            this.lblPorcAvance.AutoSize = true;
            this.lblPorcAvance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcAvance.Location = new System.Drawing.Point(6, 177);
            this.lblPorcAvance.Name = "lblPorcAvance";
            this.lblPorcAvance.Size = new System.Drawing.Size(72, 17);
            this.lblPorcAvance.TabIndex = 12;
            this.lblPorcAvance.Text = "% Avance";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(114, 148);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(264, 21);
            this.dtpInicio.TabIndex = 11;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(6, 148);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(66, 17);
            this.lblFechaFin.TabIndex = 9;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(467, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(592, 161);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(604, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 43);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.chkAllCourses);
            this.grpRegistrar.Controls.Add(this.txtAvance);
            this.grpRegistrar.Controls.Add(this.txtUsuario);
            this.grpRegistrar.Controls.Add(this.lblUsuario);
            this.grpRegistrar.Controls.Add(this.btnCancelar);
            this.grpRegistrar.Controls.Add(this.txtCurso);
            this.grpRegistrar.Controls.Add(this.lblCurso);
            this.grpRegistrar.Controls.Add(this.btnRegistrar);
            this.grpRegistrar.Controls.Add(this.txtPuntuacion);
            this.grpRegistrar.Controls.Add(this.lblPuntuacion);
            this.grpRegistrar.Controls.Add(this.dateTimePicker1);
            this.grpRegistrar.Controls.Add(this.lblFechaInicio);
            this.grpRegistrar.Controls.Add(this.lblFechaFin);
            this.grpRegistrar.Controls.Add(this.dtpInicio);
            this.grpRegistrar.Controls.Add(this.lblPorcAvance);
            this.grpRegistrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistrar.Location = new System.Drawing.Point(12, 274);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(698, 212);
            this.grpRegistrar.TabIndex = 15;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Actualización de avance";
            // 
            // chkAllCourses
            // 
            this.chkAllCourses.AutoSize = true;
            this.chkAllCourses.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllCourses.Location = new System.Drawing.Point(397, 57);
            this.chkAllCourses.Name = "chkAllCourses";
            this.chkAllCourses.Size = new System.Drawing.Size(182, 21);
            this.chkAllCourses.TabIndex = 23;
            this.chkAllCourses.Text = "Aplicar a todo el curso?";
            this.chkAllCourses.UseVisualStyleBackColor = true;
            // 
            // txtAvance
            // 
            this.txtAvance.Location = new System.Drawing.Point(114, 180);
            this.txtAvance.Name = "txtAvance";
            this.txtAvance.Size = new System.Drawing.Size(100, 21);
            this.txtAvance.TabIndex = 22;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(114, 22);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(264, 21);
            this.txtUsuario.TabIndex = 21;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(114, 56);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(264, 21);
            this.txtCurso.TabIndex = 19;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(6, 56);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 18;
            this.lblCurso.Text = "Curso";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(114, 85);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(264, 21);
            this.txtPuntuacion.TabIndex = 17;
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.Location = new System.Drawing.Point(6, 85);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(82, 17);
            this.lblPuntuacion.TabIndex = 16;
            this.lblPuntuacion.Text = "Puntuación";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 21);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 118);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(85, 17);
            this.lblFechaInicio.TabIndex = 14;
            this.lblFechaInicio.Text = "Fecha inicio";
            // 
            // grpCursosSel
            // 
            this.grpCursosSel.Controls.Add(this.dgvUsuarioCursos);
            this.grpCursosSel.Location = new System.Drawing.Point(12, 89);
            this.grpCursosSel.Name = "grpCursosSel";
            this.grpCursosSel.Size = new System.Drawing.Size(698, 179);
            this.grpCursosSel.TabIndex = 16;
            this.grpCursosSel.TabStop = false;
            this.grpCursosSel.Text = "Cursos seleccionados";
            // 
            // FrmUsuarioCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 498);
            this.Controls.Add(this.grpCursosSel);
            this.Controls.Add(this.grpRegistrar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.grbBusqueda);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarioCursoAvance";
            this.Text = "Registrar avance cursado por usuario";
            this.Load += new System.EventHandler(this.FrmUsuarioCurso_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursos)).EndInit();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.grpCursosSel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioSearch;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPorcAvance;
        private System.Windows.Forms.DataGridView dgvUsuarioCursos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.GroupBox grpCursosSel;
        private System.Windows.Forms.TextBox txtAvance;
        private System.Windows.Forms.CheckBox chkAllCourses;
    }
}