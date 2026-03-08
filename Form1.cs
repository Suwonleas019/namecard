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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Tag == null || pictureBox1.Tag.ToString() == "ini1")
            {
               
                pictureBox1.Image = Properties.Resources.ini2;
                pictureBox1.Tag = "ini2";
            }
            else
            {
               
                pictureBox1.Image = Properties.Resources.ini1;
                pictureBox1.Tag = "ini1";
            }
        }
    }
}

