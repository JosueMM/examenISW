namespace Examen
{
    partial class FrmArticulo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbCancion = new System.Windows.Forms.RadioButton();
            this.rdbPeli = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 298);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 42);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(15, 260);
            this.lblLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(108, 17);
            this.lblLista.TabIndex = 31;
            this.lblLista.Text = "Lista Canciones";
            this.lblLista.Visible = false;
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(132, 251);
            this.txtLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(289, 22);
            this.txtLista.TabIndex = 30;
            this.txtLista.Visible = false;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(132, 219);
            this.txtCant.Margin = new System.Windows.Forms.Padding(4);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(289, 22);
            this.txtCant.TabIndex = 29;
            this.txtCant.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cantidad Disp.:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 178);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(289, 22);
            this.txtPrecio.TabIndex = 27;
            this.txtPrecio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio:";
            // 
            // rdbCancion
            // 
            this.rdbCancion.AutoSize = true;
            this.rdbCancion.Location = new System.Drawing.Point(156, 38);
            this.rdbCancion.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCancion.Name = "rdbCancion";
            this.rdbCancion.Size = new System.Drawing.Size(80, 21);
            this.rdbCancion.TabIndex = 25;
            this.rdbCancion.Text = "Cancion";
            this.rdbCancion.UseVisualStyleBackColor = true;
            this.rdbCancion.CheckedChanged += new System.EventHandler(this.rdbPeli_CheckedChanged);
            // 
            // rdbPeli
            // 
            this.rdbPeli.AutoSize = true;
            this.rdbPeli.Checked = true;
            this.rdbPeli.Location = new System.Drawing.Point(34, 38);
            this.rdbPeli.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPeli.Name = "rdbPeli";
            this.rdbPeli.Size = new System.Drawing.Size(78, 21);
            this.rdbPeli.TabIndex = 24;
            this.rdbPeli.TabStop = true;
            this.rdbPeli.Text = "Pelicula";
            this.rdbPeli.UseVisualStyleBackColor = true;
            this.rdbPeli.CheckedChanged += new System.EventHandler(this.rdbPeli_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(128, 143);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(289, 22);
            this.txtCategoria.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(128, 111);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(289, 22);
            this.txtAutor.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Crear Articulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 22);
            this.txtNombre.TabIndex = 17;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 356);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbCancion);
            this.Controls.Add(this.rdbPeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmArticulo";
            this.Text = "FrmArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.MaskedTextBox txtCant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbCancion;
        private System.Windows.Forms.RadioButton rdbPeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}