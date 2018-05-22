using System;
using System.Collections.Generic;

namespace solution_pilkarze
{
    [System.Runtime.InteropServices.Guid("CEC3D851-2D3A-46ED-9B44-B23E61E281BA")]
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.liga = new System.Windows.Forms.Label();
            this.opcje = new System.Windows.Forms.Label();
            this.wyswietl = new System.Windows.Forms.Button();
            this.ilosc_bramek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // liga
            // 
            this.liga.AutoSize = true;
            this.liga.Location = new System.Drawing.Point(52, 65);
            this.liga.Name = "liga";
            this.liga.Size = new System.Drawing.Size(27, 13);
            this.liga.TabIndex = 3;
            this.liga.Text = "Liga";
            // 
            // opcje
            // 
            this.opcje.AutoSize = true;
            this.opcje.Location = new System.Drawing.Point(44, 101);
            this.opcje.Name = "opcje";
            this.opcje.Size = new System.Drawing.Size(35, 13);
            this.opcje.TabIndex = 4;
            this.opcje.Text = "Opcje";
            // 
            // wyswietl
            // 
            this.wyswietl.Location = new System.Drawing.Point(209, 183);
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(75, 23);
            this.wyswietl.TabIndex = 5;
            this.wyswietl.Text = "Wyświetl";
            this.wyswietl.UseVisualStyleBackColor = true;
            this.wyswietl.Click += new System.EventHandler(this.button1_Click);
            // 
            // ilosc_bramek
            // 
            this.ilosc_bramek.Location = new System.Drawing.Point(209, 212);
            this.ilosc_bramek.Name = "ilosc_bramek";
            this.ilosc_bramek.Size = new System.Drawing.Size(75, 23);
            this.ilosc_bramek.TabIndex = 6;
            this.ilosc_bramek.Text = "Ilość bramek";
            this.ilosc_bramek.UseVisualStyleBackColor = true;
            this.ilosc_bramek.Click += new System.EventHandler(this.ilosc_bramek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 247);
            this.Controls.Add(this.ilosc_bramek);
            this.Controls.Add(this.wyswietl);
            this.Controls.Add(this.opcje);
            this.Controls.Add(this.liga);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Piłkarze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void awans(Liga liga) // metody z interfejsu (zgodnie z UML)
        {
            throw new NotImplementedException();
        }

        #endregion


        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label liga;
        private System.Windows.Forms.Label opcje;
        private System.Windows.Forms.Button wyswietl;
        private System.Windows.Forms.Button ilosc_bramek;
    }
}

