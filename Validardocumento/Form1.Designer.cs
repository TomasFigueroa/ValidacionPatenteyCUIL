namespace Validardocumento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txt_Patente = new System.Windows.Forms.TextBox();
            this.Txt_CUIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lb_texto = new System.Windows.Forms.Label();
            this.Bt_limpiar = new System.Windows.Forms.Button();
            this.Lb_Dni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Patente
            // 
            this.Txt_Patente.Location = new System.Drawing.Point(82, 67);
            this.Txt_Patente.MaxLength = 8;
            this.Txt_Patente.Name = "Txt_Patente";
            this.Txt_Patente.Size = new System.Drawing.Size(100, 22);
            this.Txt_Patente.TabIndex = 0;
            // 
            // Txt_CUIL
            // 
            this.Txt_CUIL.Location = new System.Drawing.Point(82, 120);
            this.Txt_CUIL.MaxLength = 11;
            this.Txt_CUIL.Name = "Txt_CUIL";
            this.Txt_CUIL.Size = new System.Drawing.Size(100, 22);
            this.Txt_CUIL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CARGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lb_texto
            // 
            this.Lb_texto.AutoSize = true;
            this.Lb_texto.Location = new System.Drawing.Point(238, 96);
            this.Lb_texto.Name = "Lb_texto";
            this.Lb_texto.Size = new System.Drawing.Size(0, 16);
            this.Lb_texto.TabIndex = 5;
            // 
            // Bt_limpiar
            // 
            this.Bt_limpiar.Location = new System.Drawing.Point(82, 215);
            this.Bt_limpiar.Name = "Bt_limpiar";
            this.Bt_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Bt_limpiar.TabIndex = 6;
            this.Bt_limpiar.Text = "LIMPIAR";
            this.Bt_limpiar.UseVisualStyleBackColor = true;
            this.Bt_limpiar.Click += new System.EventHandler(this.Bt_limpiar_Click);
            // 
            // Lb_Dni
            // 
            this.Lb_Dni.AutoSize = true;
            this.Lb_Dni.Location = new System.Drawing.Point(241, 132);
            this.Lb_Dni.Name = "Lb_Dni";
            this.Lb_Dni.Size = new System.Drawing.Size(0, 16);
            this.Lb_Dni.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_Dni);
            this.Controls.Add(this.Bt_limpiar);
            this.Controls.Add(this.Lb_texto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_CUIL);
            this.Controls.Add(this.Txt_Patente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Patente;
        private System.Windows.Forms.TextBox Txt_CUIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lb_texto;
        private System.Windows.Forms.Button Bt_limpiar;
        private System.Windows.Forms.Label Lb_Dni;
    }
}

