namespace Lab_11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnClickThis = new Button();
            HelloWorld = new Label();  // Cambiado de label1 a HelloWorld
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(276, 192);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(75, 23);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click this";
            btnClickThis.UseVisualStyleBackColor = true;
            // 
            // HelloWorld
            // 
            HelloWorld.AutoSize = true;  // Cambiado de label1 a HelloWorld
            HelloWorld.Location = new Point(297, 251);
            HelloWorld.Name = "HelloWorld";  // Nombre actualizado a HelloWorld
            HelloWorld.Size = new Size(65, 15);  // Ajusta según el texto que necesites mostrar
            HelloWorld.TabIndex = 1;
            HelloWorld.Text = "Hello World";  // Actualizar el texto del label
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(HelloWorld);  // Cambiado de label1 a HelloWorld
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label HelloWorld;  // Cambiado de label1 a HelloWorld
        private CheckBox checkBox1;
    }
}
