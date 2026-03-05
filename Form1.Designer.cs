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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(412, 331);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            label2.ForeColor = Color.Lime;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
