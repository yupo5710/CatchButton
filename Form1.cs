using System.Media;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartButton.Enabled = false;
        }

        private int score = 0;
        private int missCount = 0;
        private const int maxMiss = 20;
        private bool isGameOver = false;

        private void GameOver()
        {
            isGameOver = true;
            MessageBox.Show("Game Over!");

            CatchButton.Enabled = false;
            RestartButton.Enabled = true;

            this.Text = $"점수: {score} (게임 종료)";
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;
            isGameOver = false;

            CatchButton.Width = 150;
            CatchButton.Height = 60;

            CatchButton.Enabled = true;
            RestartButton.Enabled = false;

            this.Text = "점수: 0";
        }

        private void CatchMe_Click(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                return;
            }

            score += 100;

            CatchButton.Width = (int)(CatchButton.Width * 0.9);
            CatchButton.Height = (int)(CatchButton.Height * 0.9);

            SystemSounds.Asterisk.Play();

            this.Text = $"점수: {score}";

            MessageBox.Show("축하합니다~!");
        }

        private void CatchButton_MouseEnter(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                return;
            }

            Random rd = new Random();
            SystemSounds.Beep.Play();

            score -= 10;

            int maxX = this.ClientSize.Width - CatchButton.Width;
            int maxY = this.ClientSize.Height - CatchButton.Height;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            CatchButton.Location = new Point(nextX, nextY);

            this.Text = $"점수: {score}";

            missCount++;

            if (missCount >= maxMiss)
            {
                GameOver();
            }
        }
    }
}
