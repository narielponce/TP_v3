
namespace TP_v3.PresentationLayer
{
    partial class FrmAltaCategoria
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
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCateg = new System.Windows.Forms.TextBox();
            this.txtDescCateg = new System.Windows.Forms.TextBox();
            this.lblDescCateg = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(13, 21);
            this.lblNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(129, 17);
            this.lblNombreCategoria.TabIndex = 0;
            this.lblNombreCategoria.Text = "Nombre categoría";
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.Location = new System.Drawing.Point(167, 21);
            this.txtNombreCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(207, 23);
            this.txtNombreCateg.TabIndex = 1;
            // 
            // txtDescCateg
            // 
            this.txtDescCateg.Location = new System.Drawing.Point(167, 55);
            this.txtDescCateg.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescCateg.Name = "txtDescCateg";
            this.txtDescCateg.Size = new System.Drawing.Size(207, 23);
            this.txtDescCateg.TabIndex = 3;
            // 
            // lblDescCateg
            // 
            this.lblDescCateg.AutoSize = true;
            this.lblDescCateg.Location = new System.Drawing.Point(13, 55);
            this.lblDescCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescCateg.Name = "lblDescCateg";
            this.lblDescCateg.Size = new System.Drawing.Size(83, 17);
            this.lblDescCateg.TabIndex = 2;
            this.lblDescCateg.Text = "Descripción";
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
            // FrmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDescCateg);
            this.Controls.Add(this.lblDescCateg);
            this.Controls.Add(this.txtNombreCateg);
            this.Controls.Add(this.lblNombreCategoria);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAltaCategoria";
            this.Text = "Datos de categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCateg;
        private System.Windows.Forms.TextBox txtDescCateg;
        private System.Windows.Forms.Label lblDescCateg;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}