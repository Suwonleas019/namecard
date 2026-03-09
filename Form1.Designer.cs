namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            김수환 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(563, 342);
            button1.Name = "button1";
            button1.Size = new Size(225, 71);
            button1.TabIndex = 0;
            button1.Text = "배경색　바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // 김수환
            // 
            김수환.AutoSize = true;
            김수환.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            김수환.ForeColor = SystemColors.HotTrack;
            김수환.Location = new Point(344, 165);
            김수환.Name = "김수환";
            김수환.Size = new Size(232, 28);
            김수환.TabIndex = 1;
            김수환.Text = "수원대　컴퓨터ＳＷ학과";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(344, 58);
            label1.Name = "label1";
            label1.Size = new Size(239, 89);
            label1.TabIndex = 3;
            label1.Text = "김수환";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(344, 209);
            label2.Name = "label2";
            label2.Size = new Size(384, 23);
            label2.TabIndex = 4;
            label2.Text = "ｋｓｈｗａｎ３４３４７７＠ｇｍａｉｌ．ｃｏｍ\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(344, 252);
            label3.Name = "label3";
            label3.Size = new Size(231, 23);
            label3.TabIndex = 5;
            label3.Text = "０１０－５９１９－４３４９";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(354, 297);
            button2.Name = "button2";
            button2.Size = new Size(156, 60);
            button2.TabIndex = 6;
            button2.Text = "Git Hub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(76, 318);
            button3.Name = "button3";
            button3.Size = new Size(182, 53);
            button3.TabIndex = 7;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Original";
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(김수환);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label 김수환;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
