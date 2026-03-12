using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private Random _rand = new Random();
        //랜덤 변수 생성
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchMe_Click(object sender, EventArgs e)
        {
            
        }

        private void CatchButton_MouseEnter(object sender, EventArgs e)
        {
            // 버튼이 이동할 수 있는 최대 X, Y 범위 계산
            int maxX = this.ClientSize.Width - CatchButton.Width;
            int maxY = this.ClientSize.Height - CatchButton.Height;
            //ClientSize.Width - CatchButton.Width -- x,y값이 윈도우 창 너비를 벗어나지 못하도록 설정

            // 랜덤 위치 생성
            int newX = _rand.Next(0, maxX);
            int newY = _rand.Next(0, maxY);

            // 버튼 위치 이동
            CatchButton.Location = new Point(newX, newY);

            //Form 제목 위치 자표 표시
            this.Text = $"버튼 위치: ({newX}, {newY})";

        }
    }
}
