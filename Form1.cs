using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int score = 0; //점수 계산기
        private int missCount = 0;      // 놓친 횟수
        private const int maxMiss = 20; // 게임 오버 기준


        private void GameOver()
        {
            MessageBox.Show("Game Over!");

            CatchButton.Enabled = false;   // 게임 버튼 비활성화
            RestartButton.Enabled = true;  // 다시 시작 버튼 활성화

            this.Text = $"점수: {score} (게임 종료)";
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;

            // 버튼 크기 초기화
            CatchButton.Width = 150;
            CatchButton.Height = 60;

            // 버튼 활성화
            CatchButton.Enabled = true;
            RestartButton.Enabled = false;

            this.Text = "점수: 0";
        }



        private void CatchMe_Click(object sender, EventArgs e)
        {
            // 점수 +100
            score += 100;

            // 버튼 크기 10% 축소
            CatchButton.Width = (int)(CatchButton.Width * 0.9);
            CatchButton.Height = (int)(CatchButton.Height * 0.9);

            // 잡았을 때 효과음
            System.Media.SystemSounds.Asterisk.Play();

            // 점수 표시
            this.Text = $"점수: {score}";

            MessageBox.Show("축하합니다~!");


        }

        private void CatchButton_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();
            System.Media.SystemSounds.Beep.Play();
            // 점수 -10
            score -= 10;

            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - CatchButton.Width;// CatchButton.Width 버튼이 넘어가지 않도록 조치
            int maxY = this.ClientSize.Height - CatchButton.Height;//CatchButton.Height 버튼이 넘어가지 않도록 조치
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치할당(새로운Point 객체생성)
            CatchButton.Location = new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력), // 점수 표시
            this.Text = $"버튼위치: ({nextX}, {nextY},점수: {score})";
           
            

            // 놓친 횟수 증가
            missCount++;

            // 게임 오버 체크
            if (missCount >= maxMiss)
            {
                GameOver();
                return;
            }

        }
    }
}
