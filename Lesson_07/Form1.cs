using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_07
{
    public partial class Form1 : Form
    {

        int attempts = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public object inputNumberTextBot { get; private set; }

        private Random random = new Random();
        private int randomNumber = 0;
        private void Reset()
        {
            randomNumber = random.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number > randomNumber)
                {
                    MessageBox.Show($"Ваше число {number} больше загаданного",
                        "Число не угадано", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempts++;
                }
                else if (number < randomNumber)
                {
                    MessageBox.Show($"Ваше число {number} меньше загаданного",
                        "Число не угадано", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempts++;
                }
                else if (number == randomNumber)
                {
                    MessageBox.Show($"Ура! Победа! ВЫ угадали число. Ответ был: {number}. Ваше кол-во попыток:{attempts} ",
                         "Число угадано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }

    private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }

