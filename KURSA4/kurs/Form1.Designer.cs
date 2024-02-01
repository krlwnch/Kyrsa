using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;



namespace kurs
{
    partial class log
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vhod = new System.Windows.Forms.Button();
            this.Reg = new System.Windows.Forms.Button();
            this.par = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // Vhod
            // 
            this.Vhod.Location = new System.Drawing.Point(60, 132);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(105, 23);
            this.Vhod.TabIndex = 2;
            this.Vhod.Text = "Авторизоваться";
            this.Vhod.UseVisualStyleBackColor = true;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(60, 161);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(105, 26);
            this.Reg.TabIndex = 3;
            this.Reg.Text = "Регистрация";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // par
            // 
            this.par.Location = new System.Drawing.Point(38, 106);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(142, 20);
            this.par.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(38, 47);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(142, 20);
            this.Login.TabIndex = 5;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(226, 204);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.par);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Vhod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "log";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox par;
        private System.Windows.Forms.TextBox Login;
    }
}

