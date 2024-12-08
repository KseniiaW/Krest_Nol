using System;
using System.Drawing;
using System.Windows.Forms;

namespace Krest_Nol
{
    public partial class Form1 : Form
    {
        private int player;
        private int x = 12, y = 12;
        private Button[,] buttons = new Button[3, 3];
        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "Текущий ход: Игрок 1 ";
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(150, 150);
                    buttons[i, j].TextAlign = ContentAlignment.MiddleCenter;
                }
            }
            setButtons();
            this.BackgroundImage = Image.FromFile("4275180.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void setButtons()
        {
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 156 * j, 12 + 156 * i);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Ink Free"), 100, FontStyle.Bold);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    label1.Text = "Текущий ход: Игрок 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    label1.Text = "Текущий ход: Игрок 1";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }

        private void checkWin()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    endGame(buttons[0, 0].Text);
                return;
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 0].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    endGame(buttons[1, 0].Text);
                return;
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    endGame(buttons[2, 0].Text);
                return;
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    endGame(buttons[0, 0].Text);
                return;
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    endGame(buttons[0, 1].Text);
                return;
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    endGame(buttons[0, 2].Text);
                return;
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    endGame(buttons[0, 0].Text);
                return;
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    endGame(buttons[2, 0].Text);
                return;
            }

            // Проверка на ничью
            bool isDraw = true;
            foreach (var button in buttons)
            {
                if (button.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                endGame("Ничья", -1);
            }
        }

        private void endGame(string symbol, int playerNumber = -1)
        {
            gameOver = true;
            string message = "";
            if (symbol == "Ничья")
            {
                message = "Ничья";
            }
            else
            {
                string playerName = symbol == "x" ? "Игрок 1" : "Игрок 2";
                message = $"{playerName} победил!";
            }
            MessageBox.Show(message);
            resetGame();
        }

        private void resetGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
            player = 1;
            label1.Text = "Текущий ход: Игрок 1";
            gameOver = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}