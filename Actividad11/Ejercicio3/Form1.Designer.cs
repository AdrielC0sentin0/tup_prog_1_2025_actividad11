namespace Ejercicio3
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
            button1 = new Button();
            button2 = new Button();
            tbValor = new TextBox();
            tbPromedio = new TextBox();
            tbResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(227, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 115);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 1;
            button2.Text = "Calcular Promedio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(121, 86);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 3;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(121, 116);
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(100, 23);
            tbPromedio.TabIndex = 4;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(7, 252);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(214, 100);
            tbResultado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 92);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 6;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 117);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 7;
            label2.Text = "Promedio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 232);
            label3.Name = "label3";
            label3.Size = new Size(146, 17);
            label3.TabIndex = 8;
            label3.Text = "Resultado Ordenado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 22);
            label4.Name = "label4";
            label4.Size = new Size(257, 25);
            label4.TabIndex = 9;
            label4.Text = "Calculadora de promedios";
            // 
            // button3
            // 
            button3.Location = new Point(227, 279);
            button3.Name = "button3";
            button3.Size = new Size(116, 43);
            button3.TabIndex = 10;
            button3.Text = "Listar ordenado";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 146);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 13;
            label5.Text = "Buscar Numero";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(121, 145);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(100, 23);
            tbBuscar.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(227, 144);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(354, 364);
            Controls.Add(label5);
            Controls.Add(tbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbResultado);
            Controls.Add(tbPromedio);
            Controls.Add(tbValor);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculadora de promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox tbValor;
        private TextBox tbPromedio;
        private TextBox tbResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private TextBox tbBuscar;
        private Button btnBuscar;
    }
}
