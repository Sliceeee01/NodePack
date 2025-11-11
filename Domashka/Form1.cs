using System;
using System.Windows.Forms;

namespace Domashka
{
    public partial class Form1 : Form
    {
        private int time = 10;
        private int click = 0;
        private bool play = false;
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"Время: {time}";
            label2.Text = $"Нажатий: {click}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = 10;
            click = 0;
            play = false;
            button1.Enabled = true;
            label1.Text = $"Время: {time}";
            label2.Text = $"Нажатий: {click}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!play)
            {

                play = true;
                timer1.Start();
            }

            click++;
            label1.Text = $"Время: {time}";
            label2.Text = $"Нажатий: {click}";
        }
    
     private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = $"Время: {time}";
            label2.Text = $"Нажатий: {time}";

            if (time <= 0)
            {
                timer1.Stop();
                button1.Enabled = false;
                MessageBox.Show($"Ваш результат: {click} кликов");
            }
        }
    } }

