using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_007
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int randomNumber = 0;
        int attempt = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            randomNumber = random.Next(0, 100);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NumberTextBox.Text, out int number))
                {
                if (randomNumber == number)
                {
                    MessageBox.Show($"Ура!Вы выиграли! Ответ был:{number}.Количество попыток:{attempt}",
                        "Число уагаданно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    attempt++;
                }
                else if(randomNumber <= number){
                    MessageBox.Show($"Ваше число {number} больше загаданного",
                        "Число не уагаданно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempt++;
                }
                else if (randomNumber >= number)
                {
                    MessageBox.Show($"Ваше число {number} меньше загаданного",
                        "Число не уагаданно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempt++;
                }
            }
            else {
                MessageBox.Show("Вы ввели некорректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
            attempt = 0;
        }
    }
}
