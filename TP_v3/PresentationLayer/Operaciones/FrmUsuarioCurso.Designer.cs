
namespace TP_v3.PresentationLayer
{
    partial class FrmUsuarioCurso
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
            this.cboPuntuacion = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechInicio = new System.Windows.Forms.Label();
            this.txtObserv = new System.Windows.Forms.TextBox();
            this.lblObser = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
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
            this.grbBusqueda.Controls.Add(this.cboPuntuacion);
            this.grbBusqueda.Controls.Add(this.dtpFin);
            this.grbBusqueda.Controls.Add(this.dtpInicio);
            this.grbBusqueda.Controls.Add(this.label1);
            this.grbBusqueda.Controls.Add(this.lblFechInicio);
            this.grbBusqueda.Controls.Add(this.txtObserv);
            this.grbBusqueda.Controls.Add(this.lblObser);
            this.grbBusqueda.Controls.Add(this.lblPuntuacion);
            this.grbBusqueda.Controls.Add(this.cboCurso);
            this.grbBusqueda.Controls.Add(this.lblCurso);
            this.grbBusqueda.Controls.Add(this.cboUsuario);
            this.grbBusqueda.Controls.Add(this.lblUsuario);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(646, 232);
            this.grbBusqueda.TabIndex = 2;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Datos";
            // 
            // cboPuntuacion
            // 
            this.cboPuntuacion.FormattingEnabled = true;
            this.cboPuntuacion.Location = new System.Drawing.Point(133, 85);
            this.cboPuntuacion.Name = "cboPuntuacion";
            this.cboPuntuacion.Size = new System.Drawing.Size(200, 25);
            this.cboPuntuacion.TabIndex = 12;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(133, 186);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 11;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(133, 153);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpInicio.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha inicio";
            // 
            // lblFechInicio
            // 
            this.lblFechInicio.AutoSize = true;
            this.lblFechInicio.Location = new System.Drawing.Point(14, 153);
            this.lblFechInicio.Name = "lblFechInicio";
            this.lblFechInicio.Size = new System.Drawing.Size(85, 17);
            this.lblFechInicio.TabIndex = 8;
            this.lblFechInicio.Text = "Fecha inicio";
            // 
            // txtObserv
            // 
            this.txtObserv.Location = new System.Drawing.Point(466, 25);
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Size = new System.Drawing.Size(162, 85);
            this.txtObserv.TabIndex = 7;
            // 
            // lblObser
            // 
            this.lblObser.AutoSize = true;
            this.lblObser.Location = new System.Drawing.Point(347, 25);
            this.lblObser.Name = "lblObser";
            this.lblObser.Size = new System.Drawing.Size(103, 17);
            this.lblObser.TabIndex = 6;
            this.lblObser.Text = "Observaciones";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(14, 87);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(82, 17);
            this.lblPuntuacion.TabIndex = 4;
            this.lblPuntuacion.Text = "Puntuación";
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
            this.btnCancelar.Location = new System.Drawing.Point(478, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(573, 259);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 312);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbBusqueda);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion a cursado";
            this.Load += new System.EventHandler(this.FrmUsuarioCurso_Load);
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
        private System.Windows.Forms.TextBox txtObserv;
        private System.Windows.Forms.Label lblObser;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboPuntuacion;
    }
}