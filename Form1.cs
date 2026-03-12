using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchMe_Click(object sender, EventArgs e)
        {
            
        }

        private void CatchButton_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();
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

        }
    }
}
