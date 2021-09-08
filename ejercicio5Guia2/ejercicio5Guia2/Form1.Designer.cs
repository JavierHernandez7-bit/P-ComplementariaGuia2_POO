
namespace ejercicio5Guia2
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
            this.txbCalculo1 = new System.Windows.Forms.TextBox();
            this.txbCalculo2 = new System.Windows.Forms.TextBox();
            this.txtCalculo3 = new System.Windows.Forms.TextBox();
            this.txbCalculo4 = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.listbArreglo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCalculo1
            // 
            this.txbCalculo1.Location = new System.Drawing.Point(287, 39);
            this.txbCalculo1.Name = "txbCalculo1";
            this.txbCalculo1.ReadOnly = true;
            this.txbCalculo1.Size = new System.Drawing.Size(157, 27);
            this.txbCalculo1.TabIndex = 0;
            // 
            // txbCalculo2
            // 
            this.txbCalculo2.Location = new System.Drawing.Point(287, 116);
            this.txbCalculo2.Name = "txbCalculo2";
            this.txbCalculo2.ReadOnly = true;
            this.txbCalculo2.Size = new System.Drawing.Size(157, 27);
            this.txbCalculo2.TabIndex = 1;
            // 
            // txtCalculo3
            // 
            this.txtCalculo3.Location = new System.Drawing.Point(287, 193);
            this.txtCalculo3.Name = "txtCalculo3";
            this.txtCalculo3.ReadOnly = true;
            this.txtCalculo3.Size = new System.Drawing.Size(157, 27);
            this.txtCalculo3.TabIndex = 2;
            // 
            // txbCalculo4
            // 
            this.txbCalculo4.Location = new System.Drawing.Point(287, 277);
            this.txbCalculo4.Name = "txbCalculo4";
            this.txbCalculo4.ReadOnly = true;
            this.txbCalculo4.Size = new System.Drawing.Size(157, 27);
            this.txbCalculo4.TabIndex = 3;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(280, 34);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(85, 27);
            this.txbNumero.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(423, 32);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 29);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // listbArreglo
            // 
            this.listbArreglo.FormattingEnabled = true;
            this.listbArreglo.ItemHeight = 20;
            this.listbArreglo.Location = new System.Drawing.Point(12, 95);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(165, 324);
            this.listbArreglo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese un valor al arreglo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Número mayor de pares negativos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Porcentajes de 0 en el arreglo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Promedio de impares positivos: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbCalculo1);
            this.groupBox1.Controls.Add(this.txbCalculo4);
            this.groupBox1.Controls.Add(this.txtCalculo3);
            this.groupBox1.Controls.Add(this.txbCalculo2);
            this.groupBox1.Location = new System.Drawing.Point(214, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 331);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Calculo ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mayor de pares positivos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculos Basicos ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCalculo1;
        private System.Windows.Forms.TextBox txbCalculo2;
        private System.Windows.Forms.TextBox txtCalculo3;
        private System.Windows.Forms.TextBox txbCalculo4;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox listbArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

