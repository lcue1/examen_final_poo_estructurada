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
            this.eliminar_alumno = new System.Windows.Forms.Button();
            this.modifica_alumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar_alumnos
            // 
            this.mostrar_alumnos.Location = new System.Drawing.Point(79, 47);
            this.mostrar_alumnos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mostrar_alumnos.Name = "mostrar_alumnos";
            this.mostrar_alumnos.Size = new System.Drawing.Size(204, 69);
            this.mostrar_alumnos.TabIndex = 0;
            this.mostrar_alumnos.Text = "Mostrar alumnos";
            this.mostrar_alumnos.UseVisualStyleBackColor = true;
            this.mostrar_alumnos.Click += new System.EventHandler(this.mostrar_alumnos_Click);
            // 
            // introducir_alumno
            // 
            this.introducir_alumno.Location = new System.Drawing.Point(65, 173);
            this.introducir_alumno.Margin = new System.Windows.Forms.Padding(5);
            this.introducir_alumno.Name = "introducir_alumno";
            this.introducir_alumno.Size = new System.Drawing.Size(218, 64);
            this.introducir_alumno.TabIndex = 1;
            this.introducir_alumno.Text = "Introducir alumno";
            this.introducir_alumno.UseVisualStyleBackColor = true;
            this.introducir_alumno.Click += new System.EventHandler(this.introducir_alumno_Click);
            // 
            // eliminar_alumno
            // 
            this.eliminar_alumno.Location = new System.Drawing.Point(79, 303);
            this.eliminar_alumno.Margin = new System.Windows.Forms.Padding(5);
            this.eliminar_alumno.Name = "eliminar_alumno";
            this.eliminar_alumno.Size = new System.Drawing.Size(218, 64);
            this.eliminar_alumno.TabIndex = 2;
            this.eliminar_alumno.Text = "Eliminar alumno";
            this.eliminar_alumno.UseVisualStyleBackColor = true;
            // 
            // modifica_alumno
            // 
            this.modifica_alumno.Location = new System.Drawing.Point(79, 459);
            this.modifica_alumno.Margin = new System.Windows.Forms.Padding(5);
            this.modifica_alumno.Name = "modifica_alumno";
            this.modifica_alumno.Size = new System.Drawing.Size(218, 64);
            this.modifica_alumno.TabIndex = 3;
            this.modifica_alumno.Text = "Modificar alumno";
            this.modifica_alumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 565);
            this.Controls.Add(this.modifica_alumno);
            this.Controls.Add(this.eliminar_alumno);
            this.Controls.Add(this.introducir_alumno);
            this.Controls.Add(this.mostrar_alumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mostrar_alumnos;
        private System.Windows.Forms.Button introducir_alumno;
        private System.Windows.Forms.Button eliminar_alumno;
        private System.Windows.Forms.Button modifica_alumno;
    }
}

