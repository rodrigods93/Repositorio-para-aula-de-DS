﻿namespace Projeto_04_02_20
{
    partial class frmCursos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDigiteCurso = new System.Windows.Forms.Label();
            this.txtNumeroCurso = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(225, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cursos";
            // 
            // lblDigiteCurso
            // 
            this.lblDigiteCurso.AutoSize = true;
            this.lblDigiteCurso.Location = new System.Drawing.Point(164, 102);
            this.lblDigiteCurso.Name = "lblDigiteCurso";
            this.lblDigiteCurso.Size = new System.Drawing.Size(152, 13);
            this.lblDigiteCurso.TabIndex = 1;
            this.lblDigiteCurso.Text = "Digite um número para o Curso";
            // 
            // txtNumeroCurso
            // 
            this.txtNumeroCurso.Location = new System.Drawing.Point(167, 118);
            this.txtNumeroCurso.Name = "txtNumeroCurso";
            this.txtNumeroCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCurso.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(167, 144);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(167, 201);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumeroCurso);
            this.Controls.Add(this.lblDigiteCurso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCursos";
            this.Text = "Cursos - ETEC Horácio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDigiteCurso;
        private System.Windows.Forms.TextBox txtNumeroCurso;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSair;
    }
}

