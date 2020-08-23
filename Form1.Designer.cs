namespace taller2Condicionales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PbxDescuentos = new System.Windows.Forms.PictureBox();
            this.PbxNotas = new System.Windows.Forms.PictureBox();
            this.PbxEdad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ PRINCIPAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click en imagen para validar edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click en imagen para validar notas: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Click en imagen para validar descuentos: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(603, 157);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PbxDescuentos
            // 
            this.PbxDescuentos.Image = global::taller2Condicionales.Properties.Resources.descuento;
            this.PbxDescuentos.Location = new System.Drawing.Point(354, 273);
            this.PbxDescuentos.Name = "PbxDescuentos";
            this.PbxDescuentos.Size = new System.Drawing.Size(93, 85);
            this.PbxDescuentos.TabIndex = 7;
            this.PbxDescuentos.TabStop = false;
            this.PbxDescuentos.Click += new System.EventHandler(this.PbxDescuentos_Click);
            // 
            // PbxNotas
            // 
            this.PbxNotas.Image = global::taller2Condicionales.Properties.Resources.cero;
            this.PbxNotas.Location = new System.Drawing.Point(354, 157);
            this.PbxNotas.Name = "PbxNotas";
            this.PbxNotas.Size = new System.Drawing.Size(93, 85);
            this.PbxNotas.TabIndex = 6;
            this.PbxNotas.TabStop = false;
            this.PbxNotas.Click += new System.EventHandler(this.PbxNotas_Click);
            // 
            // PbxEdad
            // 
            this.PbxEdad.Image = global::taller2Condicionales.Properties.Resources.edad;
            this.PbxEdad.Location = new System.Drawing.Point(354, 54);
            this.PbxEdad.Name = "PbxEdad";
            this.PbxEdad.Size = new System.Drawing.Size(93, 85);
            this.PbxEdad.TabIndex = 5;
            this.PbxEdad.TabStop = false;
            this.PbxEdad.Click += new System.EventHandler(this.PbxEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PbxDescuentos);
            this.Controls.Add(this.PbxNotas);
            this.Controls.Add(this.PbxEdad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TALLER DE CONDICIONALES EN .NET";
            ((System.ComponentModel.ISupportInitialize)(this.PbxDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox PbxEdad;
        private System.Windows.Forms.PictureBox PbxNotas;
        private System.Windows.Forms.PictureBox PbxDescuentos;
    }
}

