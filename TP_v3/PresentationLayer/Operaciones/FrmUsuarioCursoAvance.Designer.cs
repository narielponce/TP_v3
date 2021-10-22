
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
            this.dgvUsuarioCursos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboPorcAvan = new System.Windows.Forms.ComboBox();
            this.lblPorcAvance = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursos)).BeginInit();
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
            this.cboUsuario.Location = new System.Drawing.Point(88, 22);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(245, 25);
            this.cboUsuario.TabIndex = 1;
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.dgvUsuarioCursos);
            this.grbBusqueda.Controls.Add(this.btnConsultar);
            this.grbBusqueda.Controls.Add(this.cboUsuario);
            this.grbBusqueda.Controls.Add(this.lblUsuario);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(608, 235);
            this.grbBusqueda.TabIndex = 2;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Datos";
            // 
            // dgvUsuarioCursos
            // 
            this.dgvUsuarioCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCursos.Location = new System.Drawing.Point(6, 66);
            this.dgvUsuarioCursos.Name = "dgvUsuarioCursos";
            this.dgvUsuarioCursos.Size = new System.Drawing.Size(602, 163);
            this.dgvUsuarioCursos.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(507, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 25);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboPorcAvan
            // 
            this.cboPorcAvan.FormattingEnabled = true;
            this.cboPorcAvan.Location = new System.Drawing.Point(106, 302);
            this.cboPorcAvan.Name = "cboPorcAvan";
            this.cboPorcAvan.Size = new System.Drawing.Size(264, 25);
            this.cboPorcAvan.TabIndex = 13;
            // 
            // lblPorcAvance
            // 
            this.lblPorcAvance.AutoSize = true;
            this.lblPorcAvance.Location = new System.Drawing.Point(15, 302);
            this.lblPorcAvance.Name = "lblPorcAvance";
            this.lblPorcAvance.Size = new System.Drawing.Size(72, 17);
            this.lblPorcAvance.TabIndex = 12;
            this.lblPorcAvance.Text = "% Avance";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(106, 273);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(264, 23);
            this.dtpInicio.TabIndex = 11;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 273);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(66, 17);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha fin";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(429, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(529, 287);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarioCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 343);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboPorcAvan);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPorcAvance);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarioCursoAvance";
            this.Text = "Registrar avance cursado por usuario";
            this.Load += new System.EventHandler(this.FrmUsuarioCurso_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboPorcAvan;
        private System.Windows.Forms.Label lblPorcAvance;
        private System.Windows.Forms.DataGridView dgvUsuarioCursos;
        private System.Windows.Forms.Button btnConsultar;
    }
}