using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace laba9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните поля ввода чисел", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Получаем трёхзначное число из текстового поля
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int res = a + b;

                if (99 < res && res < 1000)
                {
                    // Проверяем, является ли сумма цифр чётным числом
                    if (res % 2 == 0)
                    {
                        MessageBox.Show("Сумма цифр числа чётная");
                        textBox3.Text = res.ToString();
                    }

                    else
                    {
                        MessageBox.Show("Сумма цифр числа нечётная");
                        textBox3.Text = res.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("введите другие числа");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
