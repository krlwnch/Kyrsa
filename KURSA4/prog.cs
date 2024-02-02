using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KURSA4
{
    public partial class prog : Form
    {
        int userid;
        char[] characters = new char[] {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т',
                                        'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                        'Э', 'Ю', 'Я',

                                        'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                        'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
                                        'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
                                        'э', 'ю', 'я',

                                        ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', ',', '.', '"', '!', '?'};

        public prog(int id)
        {
            userid = id;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Login_FormClosed);
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //зашифровать
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox_p.Text, out long p) ||
                !long.TryParse(textBox_q.Text, out long q) ||
                !IsTheNumberSimple(p) || !IsTheNumberSimple(q))
            {
                MessageBox.Show("Введите корректные простые числа для p и q!");
                return;
            }

            try
            {
                string textToEncrypt;
                using (StreamReader sr = new StreamReader("in.txt"))
                {
                    textToEncrypt = sr.ReadToEnd();
                }

                long n = p * q;
                long m = (p - 1) * (q - 1);
                long e_ = Calculate_e();
                long d = Calculate_d(e_, m);

                List<string> encryptedText = RSA_Encode(textToEncrypt, e_, n);

                using (StreamWriter sw = new StreamWriter("out1.txt"))
                {
                    foreach (string item in encryptedText)
                        sw.WriteLine(item);
                }

                textBox_d.Text = d.ToString();
                textBox_n.Text = n.ToString();
                Process.Start("out1.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении или записи файла: {ex.Message}");
            }
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox_d.Text, out long d) ||
                !long.TryParse(textBox_n.Text, out long n))
            {
                MessageBox.Show("Введите корректные значения для d и n!");
                return;
            }

            try
            {
                List<string> encryptedText;
                using (StreamReader sr = new StreamReader("out1.txt"))
                {
                    encryptedText = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        encryptedText.Add(sr.ReadLine());
                    }
                }

                string decryptedText = RSA_Decode(encryptedText, d, n);

                using (StreamWriter sw = new StreamWriter("out2.txt"))
                {
                    sw.WriteLine(decryptedText);
                }

                Process.Start("out2.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении или записи файла: {ex.Message}");
            }
        }


        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            long d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                long a = (long)(rand.NextDouble() * (n - 2)) + 1;
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1) return false;
                    if (x == n - 1) break;
                }

                if (x != n - 1) return false;
            }

            return true;
        }

        // Зашифровать
        private List<string> RSA_Encode(string s, long e, long n)
        {
            List<string> result = new List<string>();
            BigInteger bi;
            BigInteger n_ = new BigInteger(n);

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);
                if (index == -1)
                {
                    // Обработка неизвестного символа
                    continue; // или добавьте логику для обработки этого случая
                }

                bi = new BigInteger(index);
                bi = BigInteger.ModPow(bi, e, n_);

                result.Add(bi.ToString());
            }

            return result;
        }

        // Расшифровать
        private string RSA_Decode(List<string> input, long d, long n)
        {
            string result = "";
            BigInteger n_ = new BigInteger(n);

            foreach (string item in input)
            {
                BigInteger bi = BigInteger.Parse(item);
                bi = BigInteger.ModPow(bi, d, n_);

                int index = (int)bi;
                if (index < 0 || index >= characters.Length)
                {
                    // Обработка неверного индекса
                    continue; // или добавьте логику для обработки этого случая
                }

                result += characters[index].ToString();
            }

            return result;
        }

        private long Calculate_e()
        {
            return 65537; // Часто используемое значение e в RSA
        }

        // Метод для вычисления d
        private long Calculate_d(long e, long m)
        {
            long d = 1;
            while ((d * e) % m != 1 || d == e)
            {
                d++;
            }
            return d;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            log login = new log();
            login.ShowDialog();
            Application.Exit();
        }
    }
}
