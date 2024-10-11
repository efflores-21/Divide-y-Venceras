namespace Divide_y_Venceras_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnMetrosAKilometros = new System.Windows.Forms.Button();
            this.btnKgAGramos = new System.Windows.Forms.Button();
            this.btnLitrosAMililitros = new System.Windows.Forms.Button();
            this.btnCelsiusAFahrenheit = new System.Windows.Forms.Button();
            this.btnHorasAMinutos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el Valor que se va a Convertir";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnMetrosAKilometros
            // 
            this.btnMetrosAKilometros.Location = new System.Drawing.Point(12, 141);
            this.btnMetrosAKilometros.Name = "btnMetrosAKilometros";
            this.btnMetrosAKilometros.Size = new System.Drawing.Size(109, 23);
            this.btnMetrosAKilometros.TabIndex = 2;
            this.btnMetrosAKilometros.Text = "Metros a Kilometro";
            this.btnMetrosAKilometros.UseVisualStyleBackColor = true;
            this.btnMetrosAKilometros.Click += new System.EventHandler(this.btnMetrosAKilometros_Click);
            // 
            // btnKgAGramos
            // 
            this.btnKgAGramos.Location = new System.Drawing.Point(12, 54);
            this.btnKgAGramos.Name = "btnKgAGramos";
            this.btnKgAGramos.Size = new System.Drawing.Size(97, 23);
            this.btnKgAGramos.TabIndex = 3;
            this.btnKgAGramos.Text = "Kg a Gramos";
            this.btnKgAGramos.UseVisualStyleBackColor = true;
            this.btnKgAGramos.Click += new System.EventHandler(this.btnKgAGramos_Click);
            // 
            // btnLitrosAMililitros
            // 
            this.btnLitrosAMililitros.Location = new System.Drawing.Point(12, 83);
            this.btnLitrosAMililitros.Name = "btnLitrosAMililitros";
            this.btnLitrosAMililitros.Size = new System.Drawing.Size(102, 23);
            this.btnLitrosAMililitros.TabIndex = 4;
            this.btnLitrosAMililitros.Text = "Litros a Mililitros\r\n";
            this.btnLitrosAMililitros.UseVisualStyleBackColor = true;
            this.btnLitrosAMililitros.Click += new System.EventHandler(this.btnLitrosAMililitros_Click);
            // 
            // btnCelsiusAFahrenheit
            // 
            this.btnCelsiusAFahrenheit.Location = new System.Drawing.Point(12, 170);
            this.btnCelsiusAFahrenheit.Name = "btnCelsiusAFahrenheit";
            this.btnCelsiusAFahrenheit.Size = new System.Drawing.Size(123, 23);
            this.btnCelsiusAFahrenheit.TabIndex = 5;
            this.btnCelsiusAFahrenheit.Text = "Celsius A Fahrenheit";
            this.btnCelsiusAFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelsiusAFahrenheit.Click += new System.EventHandler(this.btnCelsiusAFahrenheit_Click);
            // 
            // btnHorasAMinutos
            // 
            this.btnHorasAMinutos.Location = new System.Drawing.Point(10, 112);
            this.btnHorasAMinutos.Name = "btnHorasAMinutos";
            this.btnHorasAMinutos.Size = new System.Drawing.Size(111, 23);
            this.btnHorasAMinutos.TabIndex = 6;
            this.btnHorasAMinutos.Text = "Horas A Minutos";
            this.btnHorasAMinutos.UseVisualStyleBackColor = true;
            this.btnHorasAMinutos.Click += new System.EventHandler(this.btnHorasAMinutos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHorasAMinutos);
            this.Controls.Add(this.btnCelsiusAFahrenheit);
            this.Controls.Add(this.btnLitrosAMililitros);
            this.Controls.Add(this.btnKgAGramos);
            this.Controls.Add(this.btnMetrosAKilometros);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnMetrosAKilometros;
        private System.Windows.Forms.Button btnKgAGramos;
        private System.Windows.Forms.Button btnLitrosAMililitros;
        private System.Windows.Forms.Button btnCelsiusAFahrenheit;
        private System.Windows.Forms.Button btnHorasAMinutos;
        private System.Windows.Forms.Button btnSalir;
    }
}

