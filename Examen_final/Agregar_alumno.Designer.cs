namespace Examen_final
{
    partial class Agregar_alumno
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
            this.dni_alumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido_alumno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_alumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nota_alumno = new System.Windows.Forms.TextBox();
            this.agregar_alumno_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dni_alumno
            // 
            this.dni_alumno.Location = new System.Drawing.Point(295, 115);
            this.dni_alumno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dni_alumno.Name = "dni_alumno";
            this.dni_alumno.Size = new System.Drawing.Size(160, 33);
            this.dni_alumno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese apellido";
            // 
            // apellido_alumno
            // 
            this.apellido_alumno.Location = new System.Drawing.Point(295, 238);
            this.apellido_alumno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.apellido_alumno.Name = "apellido_alumno";
            this.apellido_alumno.Size = new System.Drawing.Size(160, 33);
            this.apellido_alumno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese nombre";
            // 
            // nombre_alumno
            // 
            this.nombre_alumno.Location = new System.Drawing.Point(295, 343);
            this.nombre_alumno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nombre_alumno.Name = "nombre_alumno";
            this.nombre_alumno.Size = new System.Drawing.Size(160, 33);
            this.nombre_alumno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese nota";
            // 
            // nota_alumno
            // 
            this.nota_alumno.Location = new System.Drawing.Point(306, 469);
            this.nota_alumno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nota_alumno.Name = "nota_alumno";
            this.nota_alumno.Size = new System.Drawing.Size(160, 33);
            this.nota_alumno.TabIndex = 6;
            // 
            // agregar_alumno_btn
            // 
            this.agregar_alumno_btn.Location = new System.Drawing.Point(189, 559);
            this.agregar_alumno_btn.Name = "agregar_alumno_btn";
            this.agregar_alumno_btn.Size = new System.Drawing.Size(101, 53);
            this.agregar_alumno_btn.TabIndex = 8;
            this.agregar_alumno_btn.Text = "button1";
            this.agregar_alumno_btn.UseVisualStyleBackColor = true;
            this.agregar_alumno_btn.Click += new System.EventHandler(this.agregar_alumno_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Agregar alumno";
            // 
            // Agregar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agregar_alumno_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nota_alumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre_alumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido_alumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni_alumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Agregar_alumno";
            this.Text = "Agregar_alumno";
            this.Load += new System.EventHandler(this.Agregar_alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dni_alumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido_alumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_alumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nota_alumno;
        private System.Windows.Forms.Button agregar_alumno_btn;
        private System.Windows.Forms.Label label5;
    }
}