using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Media;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int score = 0; //점수 계산기

        private void PlaySound(string fileName) // 효과음 재생 메서드
        {
            SoundPlayer player = new SoundPlayer(fileName);
            player.Play();
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
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
            // 점수 표시
            this.Text = $"점수: {score}";

        }
    }
}
