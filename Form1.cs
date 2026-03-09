using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Suwonleas019/namecard";

            try
            {
                // 시스템의 기본 브라우저를 사용하여 URL을 엽니다.
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 외부 프로세스(브라우저) 실행을 위해 필요
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.DodgerBlue; // 테두리 색상 역할
            pictureBox1.Padding = new Padding(3);     // 3픽셀 두께의 테두리 효과
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Padding = new Padding(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == null || pictureBox1.Tag.ToString() == "Original")
            {
                // 두 번째 사진으로 교체
                pictureBox1.Image = Properties.Resources.imiage2;
                pictureBox1.Tag = "imiage2";

                // 버튼 텍스트도 센스 있게 바꿔줄 수 있습니다.
                button3.Text = "사진 변경";
            }
            else
            {
                // 다시 첫 번째 사진으로 교체
                pictureBox1.Image = Properties.Resources.imiage1;
                pictureBox1.Tag = "Original";

                button3.Text = "사진 변경";
            }
        }
    }
}

