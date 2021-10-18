
namespace TP_v3.PresentationLayer
{
    partial class FrmAltaObjetivo
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
            this.lblNombObjCorto = new System.Windows.Forms.Label();
            this.txtNombObjCorto = new System.Windows.Forms.TextBox();
            this.txtNombObjLargo = new System.Windows.Forms.TextBox();
            this.lblNombObjLargo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombObjCorto
            // 
            this.lblNombObjCorto.AutoSize = true;
            this.lblNombObjCorto.Location = new System.Drawing.Point(13, 21);
            this.lblNombObjCorto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombObjCorto.Name = "lblNombObjCorto";
            this.lblNombObjCorto.Size = new System.Drawing.Size(100, 17);
            this.lblNombObjCorto.TabIndex = 0;
            this.lblNombObjCorto.Text = "Nombre corto";
            // 
            // txtNombObjCorto
            // 
            this.txtNombObjCorto.Location = new System.Drawing.Point(167, 21);
            this.txtNombObjCorto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombObjCorto.Name = "txtNombObjCorto";
            this.txtNombObjCorto.Size = new System.Drawing.Size(207, 23);
            this.txtNombObjCorto.TabIndex = 1;
            // 
            // txtNombObjLargo
            // 
            this.txtNombObjLargo.Location = new System.Drawing.Point(167, 55);
            this.txtNombObjLargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombObjLargo.Name = "txtNombObjLargo";
            this.txtNombObjLargo.Size = new System.Drawing.Size(207, 23);
            this.txtNombObjLargo.TabIndex = 3;
            // 
            // lblNombObjLargo
            // 
            this.lblNombObjLargo.AutoSize = true;
            this.lblNombObjLargo.Location = new System.Drawing.Point(13, 55);
            this.lblNombObjLargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombObjLargo.Name = "lblNombObjLargo";
            this.lblNombObjLargo.Size = new System.Drawing.Size(99, 17);
            this.lblNombObjLargo.TabIndex = 2;
            this.lblNombObjLargo.Text = "Nombre largo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(167, 98);
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
            this.btnCancelar.Location = new System.Drawing.Point(275, 98);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombObjLargo);
            this.Controls.Add(this.lblNombObjLargo);
            this.Controls.Add(this.txtNombObjCorto);
            this.Controls.Add(this.lblNombObjCorto);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAltaObjetivo";
            this.Text = "Datos de objetivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombObjCorto;
        private System.Windows.Forms.TextBox txtNombObjCorto;
        private System.Windows.Forms.TextBox txtNombObjLargo;
        private System.Windows.Forms.Label lblNombObjLargo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}