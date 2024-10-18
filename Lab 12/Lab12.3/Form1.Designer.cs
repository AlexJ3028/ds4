namespace Triangulo
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
            this.btnSemiperimetro = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblSemiperimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSemiperimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSemiperimetro
            // 
            this.btnSemiperimetro.Location = new System.Drawing.Point(51, 206);
            this.btnSemiperimetro.Name = "btnSemiperimetro";
            this.btnSemiperimetro.Size = new System.Drawing.Size(130, 23);
            this.btnSemiperimetro.TabIndex = 0;
            this.btnSemiperimetro.Text = "Semiperimetro";
            this.btnSemiperimetro.UseVisualStyleBackColor = true;
            this.btnSemiperimetro.Click += new System.EventHandler(this.btnSemiperimetro_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(309, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(198, 206);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(100, 23);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(48, 28);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(146, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Ingresa la longitud del lado A ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(48, 92);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(143, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Ingresa la longitud del lado B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(48, 155);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(143, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "Ingresa la longitud del lado C";
            // 
            // lblSemiperimetro
            // 
            this.lblSemiperimetro.AutoSize = true;
            this.lblSemiperimetro.Location = new System.Drawing.Point(48, 258);
            this.lblSemiperimetro.Name = "lblSemiperimetro";
            this.lblSemiperimetro.Size = new System.Drawing.Size(73, 13);
            this.lblSemiperimetro.TabIndex = 7;
            this.lblSemiperimetro.Text = "Semiperimetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(48, 313);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(198, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 9;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(198, 85);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 10;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(198, 152);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 11;
            // 
            // txtSemiperimetro
            // 
            this.txtSemiperimetro.Location = new System.Drawing.Point(135, 258);
            this.txtSemiperimetro.Name = "txtSemiperimetro";
            this.txtSemiperimetro.ReadOnly = true;
            this.txtSemiperimetro.Size = new System.Drawing.Size(100, 20);
            this.txtSemiperimetro.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(135, 313);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSemiperimetro);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSemiperimetro);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSemiperimetro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSemiperimetro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblSemiperimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtSemiperimetro;
        private System.Windows.Forms.TextBox txtArea;
    }
}

