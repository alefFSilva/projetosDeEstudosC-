﻿namespace caelumApostila
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnMediaIdades = new System.Windows.Forms.Button();
            this.btnBhaskara = new System.Windows.Forms.Button();
            this.btnVerificaIdadeENacionalidade = new System.Windows.Forms.Button();
            this.btnValorDaNF = new System.Windows.Forms.Button();
            this.btnLacoFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(23, 26);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(75, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnMediaIdades
            // 
            this.btnMediaIdades.Location = new System.Drawing.Point(174, 26);
            this.btnMediaIdades.Name = "btnMediaIdades";
            this.btnMediaIdades.Size = new System.Drawing.Size(75, 23);
            this.btnMediaIdades.TabIndex = 1;
            this.btnMediaIdades.Text = "Média Idades";
            this.btnMediaIdades.UseVisualStyleBackColor = true;
            this.btnMediaIdades.Click += new System.EventHandler(this.btnMediaIdades_Click);
            // 
            // btnBhaskara
            // 
            this.btnBhaskara.Location = new System.Drawing.Point(23, 64);
            this.btnBhaskara.Name = "btnBhaskara";
            this.btnBhaskara.Size = new System.Drawing.Size(75, 23);
            this.btnBhaskara.TabIndex = 2;
            this.btnBhaskara.Text = "Bhaskara";
            this.btnBhaskara.UseVisualStyleBackColor = true;
            this.btnBhaskara.Click += new System.EventHandler(this.btnBhaskara_Click);
            // 
            // btnVerificaIdadeENacionalidade
            // 
            this.btnVerificaIdadeENacionalidade.Location = new System.Drawing.Point(174, 64);
            this.btnVerificaIdadeENacionalidade.Name = "btnVerificaIdadeENacionalidade";
            this.btnVerificaIdadeENacionalidade.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaIdadeENacionalidade.TabIndex = 3;
            this.btnVerificaIdadeENacionalidade.Text = "Pode votar?";
            this.btnVerificaIdadeENacionalidade.UseVisualStyleBackColor = true;
            this.btnVerificaIdadeENacionalidade.Click += new System.EventHandler(this.btnVerificaIdadeENacionalidade_Click);
            // 
            // btnValorDaNF
            // 
            this.btnValorDaNF.Location = new System.Drawing.Point(23, 111);
            this.btnValorDaNF.Name = "btnValorDaNF";
            this.btnValorDaNF.Size = new System.Drawing.Size(75, 23);
            this.btnValorDaNF.TabIndex = 4;
            this.btnValorDaNF.Text = "Valor da NF";
            this.btnValorDaNF.UseVisualStyleBackColor = true;
            this.btnValorDaNF.Click += new System.EventHandler(this.btnValorDaNF_Click);
            // 
            // btnLacoFor
            // 
            this.btnLacoFor.Location = new System.Drawing.Point(174, 111);
            this.btnLacoFor.Name = "btnLacoFor";
            this.btnLacoFor.Size = new System.Drawing.Size(75, 23);
            this.btnLacoFor.TabIndex = 5;
            this.btnLacoFor.Text = "Laço FOR";
            this.btnLacoFor.UseVisualStyleBackColor = true;
            this.btnLacoFor.Click += new System.EventHandler(this.btnLacoFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLacoFor);
            this.Controls.Add(this.btnValorDaNF);
            this.Controls.Add(this.btnVerificaIdadeENacionalidade);
            this.Controls.Add(this.btnBhaskara);
            this.Controls.Add(this.btnMediaIdades);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "Form1";
            this.Text = "Exercícios Caelum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnMediaIdades;
        private System.Windows.Forms.Button btnBhaskara;
        private System.Windows.Forms.Button btnVerificaIdadeENacionalidade;
        private System.Windows.Forms.Button btnValorDaNF;
        private System.Windows.Forms.Button btnLacoFor;
    }
}

