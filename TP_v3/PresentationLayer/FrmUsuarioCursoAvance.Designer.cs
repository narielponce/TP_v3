
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechInicio = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboPorcAvan = new System.Windows.Forms.ComboBox();
            this.lblPorcAvance = new System.Windows.Forms.Label();
            this.grbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(133, 22);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(200, 25);
            this.cboUsuario.TabIndex = 1;
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.cboPorcAvan);
            this.grbBusqueda.Controls.Add(this.lblPorcAvance);
            this.grbBusqueda.Controls.Add(this.dtpFin);
            this.grbBusqueda.Controls.Add(this.dtpInicio);
            this.grbBusqueda.Controls.Add(this.label1);
            this.grbBusqueda.Controls.Add(this.lblFechInicio);
            this.grbBusqueda.Controls.Add(this.cboCurso);
            this.grbBusqueda.Controls.Add(this.lblCurso);
            this.grbBusqueda.Controls.Add(this.cboUsuario);
            this.grbBusqueda.Controls.Add(this.lblUsuario);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(347, 192);
            this.grbBusqueda.TabIndex = 2;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Datos";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(133, 117);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 11;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(133, 84);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpInicio.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha inicio";
            // 
            // lblFechInicio
            // 
            this.lblFechInicio.AutoSize = true;
            this.lblFechInicio.Location = new System.Drawing.Point(14, 84);
            this.lblFechInicio.Name = "lblFechInicio";
            this.lblFechInicio.Size = new System.Drawing.Size(85, 17);
            this.lblFechInicio.TabIndex = 8;
            this.lblFechInicio.Text = "Fecha inicio";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(133, 53);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(200, 25);
            this.cboCurso.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(14, 56);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(145, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(260, 222);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cboPorcAvan
            // 
            this.cboPorcAvan.FormattingEnabled = true;
            this.cboPorcAvan.Location = new System.Drawing.Point(133, 146);
            this.cboPorcAvan.Name = "cboPorcAvan";
            this.cboPorcAvan.Size = new System.Drawing.Size(200, 25);
            this.cboPorcAvan.TabIndex = 13;
            // 
            // lblPorcAvance
            // 
            this.lblPorcAvance.AutoSize = true;
            this.lblPorcAvance.Location = new System.Drawing.Point(14, 149);
            this.lblPorcAvance.Name = "lblPorcAvance";
            this.lblPorcAvance.Size = new System.Drawing.Size(72, 17);
            this.lblPorcAvance.TabIndex = 12;
            this.lblPorcAvance.Text = "% Avance";
            // 
            // FrmUsuarioCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 279);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbBusqueda);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarioCursoAvance";
            this.Text = "Registrar avance cursado por usuario";
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechInicio;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboPorcAvan;
        private System.Windows.Forms.Label lblPorcAvance;
    }
}