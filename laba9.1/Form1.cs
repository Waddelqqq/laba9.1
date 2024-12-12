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
                MessageBox.Show("��������� ���� ����� �����", "��������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // �������� ���������� ����� �� ���������� ����
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int res = a + b;

                if (99 < res && res < 1000)
                {
                    // ���������, �������� �� ����� ���� ������ ������
                    if (res % 2 == 0)
                    {
                        MessageBox.Show("����� ���� ����� ������");
                        textBox3.Text = res.ToString();
                    }

                    else
                    {
                        MessageBox.Show("����� ���� ����� ��������");
                        textBox3.Text = res.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("������� ������ �����");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
