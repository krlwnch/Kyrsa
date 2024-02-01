namespace kurs
{
    partial class prog
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
            System.Windows.Forms.Button baza;
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.shifr = new System.Windows.Forms.Button();
            this.tblk = new System.Windows.Forms.Button();
            this.vivod_click = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Button();
            this.spravka = new System.Windows.Forms.Button();
            baza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baza
            // 
            baza.BackColor = System.Drawing.Color.DarkOrchid;
            baza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            baza.ForeColor = System.Drawing.Color.Black;
            baza.Location = new System.Drawing.Point(631, 313);
            baza.Name = "baza";
            baza.Size = new System.Drawing.Size(142, 96);
            baza.TabIndex = 8;
            baza.Text = "Внос в базу";
            baza.UseVisualStyleBackColor = false;
            baza.Click += new System.EventHandler(this.baza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный текст";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(532, 196);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зашифрованный текст";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 313);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(530, 237);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // shifr
            // 
            this.shifr.BackColor = System.Drawing.Color.LightGreen;
            this.shifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr.ForeColor = System.Drawing.Color.Black;
            this.shifr.Location = new System.Drawing.Point(627, 37);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(146, 89);
            this.shifr.TabIndex = 4;
            this.shifr.Text = "Шифровка";
            this.shifr.UseVisualStyleBackColor = false;
            this.shifr.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblk
            // 
            this.tblk.BackColor = System.Drawing.Color.Firebrick;
            this.tblk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblk.ForeColor = System.Drawing.Color.Black;
            this.tblk.Location = new System.Drawing.Point(720, 535);
            this.tblk.Name = "tblk";
            this.tblk.Size = new System.Drawing.Size(72, 61);
            this.tblk.TabIndex = 7;
            this.tblk.Text = "Тык\r\n";
            this.tblk.UseVisualStyleBackColor = false;
            this.tblk.Click += new System.EventHandler(this.tblk_Click);
            // 
            // vivod_click
            // 
            this.vivod_click.BackColor = System.Drawing.Color.LightSeaGreen;
            this.vivod_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivod_click.ForeColor = System.Drawing.Color.Black;
            this.vivod_click.Location = new System.Drawing.Point(631, 415);
            this.vivod_click.Name = "vivod_click";
            this.vivod_click.Size = new System.Drawing.Size(142, 94);
            this.vivod_click.TabIndex = 9;
            this.vivod_click.Text = "Последние данные";
            this.vivod_click.UseVisualStyleBackColor = false;
            this.vivod_click.Click += new System.EventHandler(this.vivod_click_Click);
            // 
            // file
            // 
            this.file.BackColor = System.Drawing.Color.Khaki;
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file.ForeColor = System.Drawing.Color.Black;
            this.file.Location = new System.Drawing.Point(631, 216);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(142, 91);
            this.file.TabIndex = 10;
            this.file.Text = "Сохранить в файл";
            this.file.UseVisualStyleBackColor = false;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // spravka
            // 
            this.spravka.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.spravka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spravka.ForeColor = System.Drawing.Color.Black;
            this.spravka.Location = new System.Drawing.Point(682, 154);
            this.spravka.Name = "spravka";
            this.spravka.Size = new System.Drawing.Size(38, 31);
            this.spravka.TabIndex = 11;
            this.spravka.Text = "?";
            this.spravka.UseVisualStyleBackColor = false;
            this.spravka.Click += new System.EventHandler(this.spravka_Click);
            // 
            // prog
            // 
            this.ClientSize = new System.Drawing.Size(815, 619);
            this.Controls.Add(this.spravka);
            this.Controls.Add(this.file);
            this.Controls.Add(this.vivod_click);
            this.Controls.Add(baza);
            this.Controls.Add(this.tblk);
            this.Controls.Add(this.shifr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "prog";
            this.Text = "Шифровальщик по квадрату Полибия";
            this.Load += new System.EventHandler(this.prog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button shifr;
        private System.Windows.Forms.Button tblk;
        private System.Windows.Forms.Button vivod_click;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Button spravka;
    }
}