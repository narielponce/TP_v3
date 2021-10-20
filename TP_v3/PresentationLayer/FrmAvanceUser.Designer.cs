
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
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cboPorc = new System.Windows.Forms.ComboBox();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.usuariosCursoAvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.grpSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.txtObs);
            this.grpSeleccion.Controls.Add(this.lblObs);
            this.grpSeleccion.Controls.Add(this.txtPuntuacion);
            this.grpSeleccion.Controls.Add(this.lblPuntuacion);
            this.grpSeleccion.Controls.Add(this.dtpFin);
            this.grpSeleccion.Controls.Add(this.dtpInicio);
            this.grpSeleccion.Controls.Add(this.lblFin);
            this.grpSeleccion.Controls.Add(this.lblInicio);
            this.grpSeleccion.Controls.Add(this.cboUsuario);
            this.grpSeleccion.Controls.Add(this.lblAlumno);
            this.grpSeleccion.Controls.Add(this.cboPorc);
            this.grpSeleccion.Controls.Add(this.lblPorcent);
            this.grpSeleccion.Controls.Add(this.cboCurso);
            this.grpSeleccion.Controls.Add(this.lblCurso);
            this.grpSeleccion.Location = new System.Drawing.Point(17, 13);
            this.grpSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Padding = new System.Windows.Forms.Padding(4);
            this.grpSeleccion.Size = new System.Drawing.Size(621, 156);
            this.grpSeleccion.TabIndex = 0;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Datos";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(112, 114);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 17;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(112, 86);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpInicio.TabIndex = 16;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(11, 119);
            this.lblFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(63, 17);
            this.lblFin.TabIndex = 15;
            this.lblFin.Text = "Fin curso";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(11, 86);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 17);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "Inicio curso";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(112, 55);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(200, 25);
            this.cboUsuario.TabIndex = 13;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(6, 58);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumno";
            // 
            // cboPorc
            // 
            this.cboPorc.FormattingEnabled = true;
            this.cboPorc.Location = new System.Drawing.Point(465, 112);
            this.cboPorc.Name = "cboPorc";
            this.cboPorc.Size = new System.Drawing.Size(50, 25);
            this.cboPorc.TabIndex = 10;
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.Location = new System.Drawing.Point(345, 116);
            this.lblPorcent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(72, 17);
            this.lblPorcent.TabIndex = 8;
            this.lblPorcent.Text = "% Avance";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(112, 22);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(200, 25);
            this.cboCurso.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(6, 25);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(12, 241);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.Size = new System.Drawing.Size(757, 195);
            this.dgvAlumno.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(658, 87);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 82);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // usuariosCursoAvanceBindingSource
            // 
            this.usuariosCursoAvanceBindingSource.DataSource = typeof(TP_v3.Entities.UsuariosCursoAvance);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(342, 25);
            this.lblPuntuacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(82, 17);
            this.lblPuntuacion.TabIndex = 18;
            this.lblPuntuacion.Text = "Puntuacion";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(465, 22);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(100, 23);
            this.txtPuntuacion.TabIndex = 19;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(465, 55);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(100, 48);
            this.txtObs.TabIndex = 21;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(342, 58);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(103, 17);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Observaciones";
            // 
            // FrmAvanceUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 448);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.grpSeleccion);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAvanceUser";
            this.Text = "Actualización avance usuarios";
            this.Load += new System.EventHandler(this.FrmAvanceUser_Load);
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeleccion;
        private System.Windows.Forms.Label lblPorcent;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cboPorc;
        private System.Windows.Forms.BindingSource usuariosCursoAvanceBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label lblPuntuacion;
    }
}