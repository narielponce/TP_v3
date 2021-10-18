
namespace TP_v3.PresentationLayer
{
    partial class FrmAltaCurso
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
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtDescCurso = new System.Windows.Forms.TextBox();
            this.lblDescCurso = new System.Windows.Forms.Label();
            this.lblFechVig = new System.Windows.Forms.Label();
            this.dtimeFechaVig = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCategBox = new System.Windows.Forms.Label();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(31, 31);
            this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(123, 17);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(185, 31);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(265, 23);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // txtDescCurso
            // 
            this.txtDescCurso.Location = new System.Drawing.Point(185, 65);
            this.txtDescCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescCurso.Name = "txtDescCurso";
            this.txtDescCurso.Size = new System.Drawing.Size(265, 23);
            this.txtDescCurso.TabIndex = 3;
            // 
            // lblDescCurso
            // 
            this.lblDescCurso.AutoSize = true;
            this.lblDescCurso.Location = new System.Drawing.Point(31, 65);
            this.lblDescCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescCurso.Name = "lblDescCurso";
            this.lblDescCurso.Size = new System.Drawing.Size(83, 17);
            this.lblDescCurso.TabIndex = 2;
            this.lblDescCurso.Text = "Descripción";
            // 
            // lblFechVig
            // 
            this.lblFechVig.AutoSize = true;
            this.lblFechVig.Location = new System.Drawing.Point(31, 99);
            this.lblFechVig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechVig.Name = "lblFechVig";
            this.lblFechVig.Size = new System.Drawing.Size(108, 17);
            this.lblFechVig.TabIndex = 4;
            this.lblFechVig.Text = "Fecha Vigencia";
            // 
            // dtimeFechaVig
            // 
            this.dtimeFechaVig.Location = new System.Drawing.Point(185, 99);
            this.dtimeFechaVig.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeFechaVig.Name = "dtimeFechaVig";
            this.dtimeFechaVig.Size = new System.Drawing.Size(265, 23);
            this.dtimeFechaVig.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(183, 172);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 172);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCategBox
            // 
            this.lblCategBox.AutoSize = true;
            this.lblCategBox.Location = new System.Drawing.Point(31, 129);
            this.lblCategBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategBox.Name = "lblCategBox";
            this.lblCategBox.Size = new System.Drawing.Size(75, 17);
            this.lblCategBox.TabIndex = 11;
            this.lblCategBox.Text = "Categoría";
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Location = new System.Drawing.Point(185, 129);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(265, 25);
            this.cboCateg.TabIndex = 12;
            // 
            // FrmAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 229);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.lblCategBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtimeFechaVig);
            this.Controls.Add(this.lblFechVig);
            this.Controls.Add(this.txtDescCurso);
            this.Controls.Add(this.lblDescCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAltaCurso";
            this.Text = "Datos del curso";
            this.Load += new System.EventHandler(this.FrmAltaCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtDescCurso;
        private System.Windows.Forms.Label lblDescCurso;
        private System.Windows.Forms.Label lblFechVig;
        private System.Windows.Forms.DateTimePicker dtimeFechaVig;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCategBox;
        private System.Windows.Forms.ComboBox cboCateg;
    }
}