﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace kurs
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void otmen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new log().Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rega_Click(object sender, EventArgs e)
        {
            if (regp1.Text == "" || regp2.Text == "" || log.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (regp1.Text == regp2.Text)
            {
                bool ok = false;
                const string filename = "data.db";
                SQLiteConnection data = new SQLiteConnection(@"Data Source=" + filename + "; Version=3;");
                MD5 md5 = new MD5CryptoServiceProvider();
                string hash = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes((log.Text + regp1.Text)))).Replace("-", String.Empty);
                SQLiteCommand checkUser = new SQLiteCommand("SELECT id FROM users WHERE username = '" + log.Text + "'", data);
                SQLiteCommand addUser = new SQLiteCommand("INSERT INTO 'users' ('username', 'hash') VALUES ('" + log.Text + "','" + hash + "');", data);
                data.Open();
                SQLiteDataReader reader = checkUser.ExecuteReader();
                if (!reader.HasRows)
                {
                    addUser.ExecuteNonQuery();
                    ok = true;
                }
                data.Close();

                if (ok)
                {
                    this.Hide();
                    new log().Show();
                    MessageBox.Show("Пользователь зарегистрирован.", "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Text = "";
                    regp1.Text = "";
                    regp2.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Пользователь существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                regp1.Text = "";
                regp2.Text = "";
            }
        }
    }
}
