﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace kurs
{
    public partial class prog : Form
    {
        int userid;
        public prog(int id)
        {
            userid = id;
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e) // knopka
        {
            string input = textBox1.Text; // считывание исходной строки 
            string output = "";
            bool exit; //датчик ошибки шифрования
            char ch1;// некодированный символ
            string ch2;// кодированный символ

            input = input.ToLower(); input = input.Replace(" ", ""); // привод строки к рабочей форме

            var a = new char[6, 6];
            a[0, 0] ='а'; a[0, 1] ='б'; a[0, 2] ='в'; a[0, 3] ='г'; a[0, 4] ='д'; a[0, 5] ='е'; // таблица
            a[1, 0] ='ё'; a[1, 1] ='ж'; a[1, 2] ='з'; a[1, 3] ='и'; a[1, 4] ='й'; a[1, 5] ='к';
            a[2, 0] ='л'; a[2, 1] ='м'; a[2, 2] ='н'; a[2, 3] ='о'; a[2, 4] ='п'; a[2, 5] ='р';
            a[3, 0] ='с'; a[3, 1] ='т'; a[3, 2] ='у'; a[3, 3] ='ф'; a[3, 4] ='х'; a[3, 5] ='ц';
            a[4, 0] ='ч'; a[4, 1] ='ш'; a[4, 2] ='щ'; a[4, 3] ='ъ'; a[4, 4] ='ы'; a[4, 5] ='ь';
            a[5, 0] ='э'; a[5, 1] ='ю'; a[5, 2] ='я'; a[5, 3] ='.'; a[5, 4] =','; a[5, 5] ='?';



            for (int l = 0; l < input.Length; l++) // цикл шифрования
            {

                exit = false;
                ch1 = input[l];
                for (byte i = 0; i < 6; i++)
                {
                    for (byte j = 0; j < 6; j++)
                    {
                        if (ch1 == a[i, j])
                        {
                            ch2 = (i + 1).ToString() + (j + 1).ToString();
                            output += ch2;
                            exit = true;
                        }
                    }
                    if (exit)
                        break;
                }
                if (exit == false) // Если символа нет в таблице
                {
                    MessageBox.Show("Символ не определяется в данной кодировке", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            textBox2.Text = output;
            


        }

        private void vnos(string output)
        {
            const string filename = "data.db";
            SQLiteConnection data = new SQLiteConnection(@"Data Source=" + filename + "; Version=3;");
            SQLiteCommand add = new SQLiteCommand("INSERT INTO 'database' ('file', 'userid') VALUES ('" + output + "','" + userid + "');", data);
            data.Open();
            add.ExecuteNonQuery();
            data.Close();
        }

        private void vivod()
        {
            const string filename = "data.db";
            SQLiteConnection data = new SQLiteConnection(@"Data Source=" + filename + "; Version=3;");
            SQLiteCommand add = new SQLiteCommand("SELECT file FROM database WHERE userid =" + userid + " ORDER BY id DESC ", data);
            data.Open();
            SQLiteDataReader dr = add.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                MessageBox.Show("Последние данные: " + dr.GetValue(0), "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
            }
            data.Close();
        }


        private void textfile()
        {
            string path = Path.Combine(Environment.CurrentDirectory,"shifr.txt");
            
            StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Open, FileAccess.Write));
            sw.WriteLine(textBox2.Text);
            sw.Close();
        }

        private void baza_Click(object sender, EventArgs e)
        {
            vnos(textBox2.Text);

        }

        private void vivod_click_Click(object sender, EventArgs e)
        {
            vivod();
        }


        private void file_Click(object sender, EventArgs e)
        {
            textfile();
        }

        private void prog_Load(object sender, EventArgs e)
        {
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spravka_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Для шифрования введите текст в поле \"Исходный текст\"," +
                " при нажатии кнопки \"Шифровать\" выполняется алгоритм шифрования и программа выводит результат в поле " +
                "\"Зашифрованный текст\".\n\n Кнопка \"Внос в базу\" нужна для вноса последних данных из блока" +
                " \"Зашифрованный текст\" в базу данных.\n\n Кнопка \"Сохранить в файл\" сохраняет результат работы программы" +
                " в текстовый файл.\n\n\n Все права защищены. Автор - Толстолес Егор Павлович\r\nТУСУР, " +
                "Факультет Безопасности, 2022", "СПРАВКА", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
