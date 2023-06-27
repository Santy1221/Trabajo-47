namespace trabajo47_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Num1 = new TextBox();
            suma = new Button();
            Reset = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 163);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el primer digito";
            // 
            // Num1
            // 
            Num1.Location = new Point(464, 160);
            Num1.Name = "Num1";
            Num1.Size = new Size(135, 23);
            Num1.TabIndex = 2;
            // 
            // suma
            // 
            suma.Location = new Point(605, 139);
            suma.Name = "suma";
            suma.Size = new Size(69, 62);
            suma.TabIndex = 4;
            suma.Text = "Sumar";
            suma.UseVisualStyleBackColor = true;
            suma.UseWaitCursor = true;
            suma.Click += suma_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(605, 207);
            Reset.Name = "Reset";
            Reset.Size = new Size(69, 62);
            Reset.TabIndex = 5;
            Reset.Text = "Resetear";
            Reset.UseVisualStyleBackColor = true;
            Reset.UseWaitCursor = true;
            Reset.Click += Reset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(421, 79);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 6;
            label2.Text = "Ingrese 10 numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 541);
            Controls.Add(label2);
            Controls.Add(Reset);
            Controls.Add(suma);
            Controls.Add(Num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Trabajo 47";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Num1;
        private Button suma;
        private Button Reset;
        private Label label2;
    }
}