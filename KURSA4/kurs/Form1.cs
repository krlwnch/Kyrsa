﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.IO;

namespace kurs
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new reg().Show();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            int id = 0;
            const string filename = "data.db";
            SQLiteConnection data = new SQLiteConnection(@"Data Source=" + filename + "; Version=3;");
            MD5 md5 = new MD5CryptoServiceProvider();
            string hash = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes((Login.Text + par.Text)))).Replace("-", String.Empty);
            SQLiteCommand checkUser = new SQLiteCommand("SELECT id, hash FROM users WHERE username = '" + Login.Text + "'", data);
            data.Open();
            SQLiteDataReader reader = checkUser.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (reader.GetString(1) == hash)
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }
            data.Close();

            if (id == 0)
            {
                MessageBox.Show("Некоректные данные для входа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login.Text = "";
                par.Text = "";
            }
            else
            {
                this.Hide();
                new prog(id).Show();
                Login.Text = "";
                par.Text = "";
            }
        }


       
        private void Login_Load(object sender, EventArgs e)
        {
            const string filename = "data.db";
            SQLiteConnection data;
            if (!File.Exists(filename))
            {
                SQLiteConnection.CreateFile(filename);
                data = new SQLiteConnection(@"Data Source=" + filename + "; Version=3;");
                SQLiteCommand createtables = new SQLiteCommand("CREATE TABLE IF NOT EXISTS 'users' ( 'id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 'username' TEXT NOT NULL, 'hash' TEXT NOT NULL); CREATE TABLE IF NOT EXISTS 'database' ('id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 'userid' TEXT NOT NULL, 'file' TEXT NOT NULL);", data);
                data.Open();
                createtables.ExecuteNonQuery();
                data.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
