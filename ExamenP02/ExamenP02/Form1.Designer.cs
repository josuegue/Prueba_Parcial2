
namespace ExamenP02
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonP_1 = new System.Windows.Forms.Button();
            this.buttonP_2 = new System.Windows.Forms.Button();
            this.buttonP_3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPP1 = new System.Windows.Forms.Button();
            this.buttonPP2 = new System.Windows.Forms.Button();
            this.buttonPP3 = new System.Windows.Forms.Button();
            this.buttonSumatoria = new System.Windows.Forms.Button();
            this.buttonClfAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.White;
            this.buttonCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargar.Location = new System.Drawing.Point(28, 25);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(101, 32);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.BackColor = System.Drawing.Color.White;
            this.buttonNombres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonNombres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNombres.Location = new System.Drawing.Point(20, 74);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(109, 28);
            this.buttonNombres.TabIndex = 1;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = false;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click_1);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxRuta.Location = new System.Drawing.Point(150, 32);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(297, 20);
            this.textBoxRuta.TabIndex = 2;
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxContenido.Location = new System.Drawing.Point(343, 58);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(264, 258);
            this.textBoxContenido.TabIndex = 3;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.HorizontalScrollbar = true;
            this.listBoxResultado.Location = new System.Drawing.Point(613, 32);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(264, 277);
            this.listBoxResultado.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(139, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Presiona para confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa la seccion";
            // 
            // textBoxDatos
            // 
            this.textBoxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxDatos.Location = new System.Drawing.Point(135, 127);
            this.textBoxDatos.Name = "textBoxDatos";
            this.textBoxDatos.Size = new System.Drawing.Size(152, 20);
            this.textBoxDatos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Promedio de parciales por seccion ";
            // 
            // buttonP_1
            // 
            this.buttonP_1.BackColor = System.Drawing.Color.White;
            this.buttonP_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonP_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonP_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonP_1.Location = new System.Drawing.Point(12, 222);
            this.buttonP_1.Name = "buttonP_1";
            this.buttonP_1.Size = new System.Drawing.Size(83, 25);
            this.buttonP_1.TabIndex = 9;
            this.buttonP_1.Text = "Parcial 1";
            this.buttonP_1.UseVisualStyleBackColor = false;
            this.buttonP_1.Click += new System.EventHandler(this.buttonP_1_Click_1);
            // 
            // buttonP_2
            // 
            this.buttonP_2.BackColor = System.Drawing.Color.White;
            this.buttonP_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonP_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonP_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonP_2.Location = new System.Drawing.Point(117, 222);
            this.buttonP_2.Name = "buttonP_2";
            this.buttonP_2.Size = new System.Drawing.Size(89, 25);
            this.buttonP_2.TabIndex = 10;
            this.buttonP_2.Text = "Parcial 2";
            this.buttonP_2.UseVisualStyleBackColor = false;
            this.buttonP_2.Click += new System.EventHandler(this.buttonP_2_Click_1);
            // 
            // buttonP_3
            // 
            this.buttonP_3.BackColor = System.Drawing.Color.White;
            this.buttonP_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonP_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonP_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonP_3.Location = new System.Drawing.Point(221, 222);
            this.buttonP_3.Name = "buttonP_3";
            this.buttonP_3.Size = new System.Drawing.Size(94, 27);
            this.buttonP_3.TabIndex = 11;
            this.buttonP_3.Text = "Parcial 3";
            this.buttonP_3.UseVisualStyleBackColor = false;
            this.buttonP_3.Click += new System.EventHandler(this.buttonP_3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Promedio general por parcial ";
            // 
            // buttonPP1
            // 
            this.buttonPP1.BackColor = System.Drawing.Color.White;
            this.buttonPP1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPP1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPP1.Location = new System.Drawing.Point(12, 306);
            this.buttonPP1.Name = "buttonPP1";
            this.buttonPP1.Size = new System.Drawing.Size(80, 26);
            this.buttonPP1.TabIndex = 13;
            this.buttonPP1.Text = "Parcial 1";
            this.buttonPP1.UseVisualStyleBackColor = false;
            this.buttonPP1.Click += new System.EventHandler(this.buttonPP1_Click_1);
            // 
            // buttonPP2
            // 
            this.buttonPP2.BackColor = System.Drawing.Color.White;
            this.buttonPP2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPP2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPP2.Location = new System.Drawing.Point(112, 306);
            this.buttonPP2.Name = "buttonPP2";
            this.buttonPP2.Size = new System.Drawing.Size(94, 26);
            this.buttonPP2.TabIndex = 14;
            this.buttonPP2.Text = "Parcial 2";
            this.buttonPP2.UseVisualStyleBackColor = false;
            this.buttonPP2.Click += new System.EventHandler(this.buttonPP2_Click_1);
            // 
            // buttonPP3
            // 
            this.buttonPP3.BackColor = System.Drawing.Color.White;
            this.buttonPP3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPP3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPP3.Location = new System.Drawing.Point(226, 308);
            this.buttonPP3.Name = "buttonPP3";
            this.buttonPP3.Size = new System.Drawing.Size(89, 24);
            this.buttonPP3.TabIndex = 15;
            this.buttonPP3.Text = "Parcial 3";
            this.buttonPP3.UseVisualStyleBackColor = false;
            this.buttonPP3.Click += new System.EventHandler(this.buttonPP3_Click_1);
            // 
            // buttonSumatoria
            // 
            this.buttonSumatoria.BackColor = System.Drawing.Color.White;
            this.buttonSumatoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSumatoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSumatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSumatoria.Location = new System.Drawing.Point(28, 350);
            this.buttonSumatoria.Name = "buttonSumatoria";
            this.buttonSumatoria.Size = new System.Drawing.Size(267, 28);
            this.buttonSumatoria.TabIndex = 16;
            this.buttonSumatoria.Text = "Sumatoria del parcial 1 al 3 por Alumno";
            this.buttonSumatoria.UseVisualStyleBackColor = false;
            this.buttonSumatoria.Click += new System.EventHandler(this.buttonSumatoria_Click_1);
            // 
            // buttonClfAlumnos
            // 
            this.buttonClfAlumnos.BackColor = System.Drawing.Color.White;
            this.buttonClfAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClfAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonClfAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClfAlumnos.Location = new System.Drawing.Point(20, 384);
            this.buttonClfAlumnos.Name = "buttonClfAlumnos";
            this.buttonClfAlumnos.Size = new System.Drawing.Size(285, 27);
            this.buttonClfAlumnos.TabIndex = 17;
            this.buttonClfAlumnos.Text = "Clasificacion de Alumnos por  seccion ";
            this.buttonClfAlumnos.UseVisualStyleBackColor = false;
            this.buttonClfAlumnos.Click += new System.EventHandler(this.buttonClfAlumnos_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.buttonClfAlumnos);
            this.Controls.Add(this.buttonSumatoria);
            this.Controls.Add(this.buttonPP3);
            this.Controls.Add(this.buttonPP2);
            this.Controls.Add(this.buttonPP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonP_3);
            this.Controls.Add(this.buttonP_2);
            this.Controls.Add(this.buttonP_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonP_1;
        private System.Windows.Forms.Button buttonP_2;
        private System.Windows.Forms.Button buttonP_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPP1;
        private System.Windows.Forms.Button buttonPP2;
        private System.Windows.Forms.Button buttonPP3;
        private System.Windows.Forms.Button buttonSumatoria;
        private System.Windows.Forms.Button buttonClfAlumnos;
    }
}

