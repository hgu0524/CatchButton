using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        int missCount = 0;

        int originalWidth;
        int originalHeight;

        public Form1()
        {
            InitializeComponent();

            // 버튼 원래 크기 저장
            originalWidth = runbutton.Width;
            originalHeight = runbutton.Height;

            this.Text = "점수: 0";
        }

        private void runbutton_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();

            int x = rand.Next(0, this.ClientSize.Width - runbutton.Width);
            int y = rand.Next(0, this.ClientSize.Height - runbutton.Height);

            runbutton.Location = new Point(x, y);

            // 점수 감소
            score -= 10;

            // 놓친 횟수 증가
            missCount++;

            this.Text = $"점수: {score}";

            // 도망 소리
            SoundPlayer runSound = new SoundPlayer(@"C:\Users\사용자\Downloads\Blop Sound.wav");
            runSound.Play();

            // 게임 오버
            if (missCount >= 20)
            {
                MessageBox.Show("Game Over");
                runbutton.Enabled = false;
            }
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            // 점수 증가
            score += 100;
            this.Text = $"점수: {score}";

            // 버튼 크기 감소
            if (runbutton.Width > 20 && runbutton.Height > 20)
            {
                runbutton.Width = (int)(runbutton.Width * 0.9);
                runbutton.Height = (int)(runbutton.Height * 0.9);
            }

            MessageBox.Show("축하합니다~!");

            // 잡기 소리
            SoundPlayer catchSound = new SoundPlayer(@"C:\Users\사용자\Downloads\Coin 1.wav");
            catchSound.Play();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // 점수 초기화
            score = 0;
            missCount = 0;

            this.Text = "점수: 0";

            // 버튼 다시 활성화
            runbutton.Enabled = true;

            // 버튼 크기 원래대로 복구 ⭐
            runbutton.Width = originalWidth;
            runbutton.Height = originalHeight;

            // 버튼 위치 중앙으로
            runbutton.Location = new Point(
                this.ClientSize.Width / 2 - runbutton.Width / 2,
                this.ClientSize.Height / 2 - runbutton.Height / 2
            );
        }
    }
}