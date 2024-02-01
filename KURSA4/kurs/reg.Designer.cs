namespace kurs
{
    partial class reg
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
            this.rega = new System.Windows.Forms.Button();
            this.Otmen = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.regp1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regp2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rega
            // 
            this.rega.Location = new System.Drawing.Point(57, 201);
            this.rega.Name = "rega";
            this.rega.Size = new System.Drawing.Size(136, 23);
            this.rega.TabIndex = 0;
            this.rega.Text = "Зарегестрироваться";
            this.rega.UseVisualStyleBackColor = true;
            this.rega.Click += new System.EventHandler(this.rega_Click);
            // 
            // Otmen
            // 
            this.Otmen.Location = new System.Drawing.Point(57, 230);
            this.Otmen.Name = "Otmen";
            this.Otmen.Size = new System.Drawing.Size(136, 23);
            this.Otmen.TabIndex = 1;
            this.Otmen.Text = "Отмена";
            this.Otmen.UseVisualStyleBackColor = true;
            this.Otmen.Click += new System.EventHandler(this.otmen_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(57, 43);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(136, 20);
            this.log.TabIndex = 2;
            this.log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // regp1
            // 
            this.regp1.Location = new System.Drawing.Point(57, 102);
            this.regp1.Name = "regp1";
            this.regp1.Size = new System.Drawing.Size(136, 20);
            this.regp1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Придумайте пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Придумайте логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль";
            // 
            // regp2
            // 
            this.regp2.Location = new System.Drawing.Point(57, 157);
            this.regp2.Name = "regp2";
            this.regp2.Size = new System.Drawing.Size(136, 20);
            this.regp2.TabIndex = 7;
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 269);
            this.Controls.Add(this.regp2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regp1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Otmen);
            this.Controls.Add(this.rega);
            this.Name = "reg";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rega;
        private System.Windows.Forms.Button Otmen;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox regp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regp2;
    }
}