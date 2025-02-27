namespace Examen_final
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
            this.mostrar_alumnos = new System.Windows.Forms.Button();
            this.introducir_alumno = new System.Windows.Forms.Button();
            this.editar_alumno_btn = new System.Windows.Forms.Button();
            this.buscar_editar_eliminar_btn = new System.Windows.Forms.TextBox();
            this.eliminar_alumno_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar_alumno_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar_alumnos
            // 
            this.mostrar_alumnos.Location = new System.Drawing.Point(37, 24);
            this.mostrar_alumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostrar_alumnos.Name = "mostrar_alumnos";
            this.mostrar_alumnos.Size = new System.Drawing.Size(94, 29);
            this.mostrar_alumnos.TabIndex = 0;
            this.mostrar_alumnos.Text = "Mostrar alumnos";
            this.mostrar_alumnos.UseVisualStyleBackColor = true;
            this.mostrar_alumnos.Click += new System.EventHandler(this.mostrar_alumnos_Click);
            // 
            // introducir_alumno
            // 
            this.introducir_alumno.Location = new System.Drawing.Point(35, 70);
            this.introducir_alumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.introducir_alumno.Name = "introducir_alumno";
            this.introducir_alumno.Size = new System.Drawing.Size(101, 29);
            this.introducir_alumno.TabIndex = 1;
            this.introducir_alumno.Text = "Introducir alumno";
            this.introducir_alumno.UseVisualStyleBackColor = true;
            this.introducir_alumno.Click += new System.EventHandler(this.introducir_alumno_Click);
            // 
            // editar_alumno_btn
            // 
            this.editar_alumno_btn.Location = new System.Drawing.Point(158, 235);
            this.editar_alumno_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editar_alumno_btn.Name = "editar_alumno_btn";
            this.editar_alumno_btn.Size = new System.Drawing.Size(106, 32);
            this.editar_alumno_btn.TabIndex = 3;
            this.editar_alumno_btn.Text = "Editar";
            this.editar_alumno_btn.UseVisualStyleBackColor = true;
            this.editar_alumno_btn.Click += new System.EventHandler(this.editar_eliminar_alumno_Click);
            // 
            // buscar_editar_eliminar_btn
            // 
            this.buscar_editar_eliminar_btn.Location = new System.Drawing.Point(227, 186);
            this.buscar_editar_eliminar_btn.Name = "buscar_editar_eliminar_btn";
            this.buscar_editar_eliminar_btn.Size = new System.Drawing.Size(100, 20);
            this.buscar_editar_eliminar_btn.TabIndex = 4;
            // 
            // eliminar_alumno_btn
            // 
            this.eliminar_alumno_btn.Location = new System.Drawing.Point(299, 235);
            this.eliminar_alumno_btn.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_alumno_btn.Name = "eliminar_alumno_btn";
            this.eliminar_alumno_btn.Size = new System.Drawing.Size(106, 32);
            this.eliminar_alumno_btn.TabIndex = 5;
            this.eliminar_alumno_btn.Text = "Eliminar";
            this.eliminar_alumno_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Secccion buscar editar y eliminar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese DNI y elija una opcion";
            // 
            // buscar_alumno_btn
            // 
            this.buscar_alumno_btn.Location = new System.Drawing.Point(30, 235);
            this.buscar_alumno_btn.Margin = new System.Windows.Forms.Padding(2);
            this.buscar_alumno_btn.Name = "buscar_alumno_btn";
            this.buscar_alumno_btn.Size = new System.Drawing.Size(106, 32);
            this.buscar_alumno_btn.TabIndex = 8;
            this.buscar_alumno_btn.Text = "Buscar";
            this.buscar_alumno_btn.UseVisualStyleBackColor = true;
            this.buscar_alumno_btn.Click += new System.EventHandler(this.buscar_alumno_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 325);
            this.Controls.Add(this.buscar_alumno_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar_alumno_btn);
            this.Controls.Add(this.buscar_editar_eliminar_btn);
            this.Controls.Add(this.editar_alumno_btn);
            this.Controls.Add(this.introducir_alumno);
            this.Controls.Add(this.mostrar_alumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrar_alumnos;
        private System.Windows.Forms.Button introducir_alumno;
        private System.Windows.Forms.Button editar_alumno_btn;
        private System.Windows.Forms.TextBox buscar_editar_eliminar_btn;
        private System.Windows.Forms.Button eliminar_alumno_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_alumno_btn;
    }
}

