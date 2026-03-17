using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0; // ⭐ 3단계 추가

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수 생성기 준비
            Random rd = new Random();

            // 2. 가용 영역 계산
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 3. 랜덤 좌표 추출
            int nextX = rd.Next(0, maxX - 372);
            int nextY = rd.Next(0, maxY - 158);

            // 4. 위치 이동
            runbutton.Location = new Point(nextX, nextY);

            // ❌ 좌표 출력은 점수랑 충돌하니까 제거
            // this.Text = $"버튼위치: ({nextX}, {nextY})";

            // ⭐ 추가된 랜덤 이동 (기존 유지)
            Random rand = new Random();
            int x = rand.Next(0, this.ClientSize.Width - runbutton.Width);
            int y = rand.Next(0, this.ClientSize.Height - runbutton.Height);
            runbutton.Location = new Point(x, y);

            // ⭐ 3단계: 점수 감소
            score -= 10;
            this.Text = "점수: " + score;

            // 도망 소리
            SoundPlayer player = new SoundPlayer(@"C:\Users\사용자\Downloads\Blop Sound.wav");
            player.Play();
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            // 메시지
            MessageBox.Show("축하합니다~!");

            // 잡았을 때 소리
            SoundPlayer catchSound = new SoundPlayer(@"C:\Users\사용자\Downloads\Coin 1.wav");
            catchSound.Play();

            // ⭐ 3단계: 점수 증가
            score += 100;
            this.Text = "점수: " + score;

            // ⭐ 3단계: 버튼 크기 감소 (난이도)
            if (runbutton.Width > 20 && runbutton.Height > 20)
            {
                runbutton.Width = (int)(runbutton.Width * 0.9);
                runbutton.Height = (int)(runbutton.Height * 0.9);
            }
        }
    }
}