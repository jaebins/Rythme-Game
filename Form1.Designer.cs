
namespace RythmeGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label_Title = new System.Windows.Forms.Label();
            this.JudgeMentLine1 = new System.Windows.Forms.PictureBox();
            this.but_Quit = new System.Windows.Forms.Button();
            this.but_Judge4 = new System.Windows.Forms.PictureBox();
            this.but_Judge3 = new System.Windows.Forms.PictureBox();
            this.but_Judge2 = new System.Windows.Forms.PictureBox();
            this.but_Judge1 = new System.Windows.Forms.PictureBox();
            this.but_Start = new System.Windows.Forms.PictureBox();
            this.Pic_MusicCover = new System.Windows.Forms.PictureBox();
            this.but_Back = new System.Windows.Forms.PictureBox();
            this.but_Next = new System.Windows.Forms.PictureBox();
            this.JudgeMentLine2 = new System.Windows.Forms.PictureBox();
            this.JudgeMentLine3 = new System.Windows.Forms.PictureBox();
            this.Label_Combo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MusicCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("함초롬바탕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Title.Location = new System.Drawing.Point(39, 59);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(221, 83);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "비망록";
            // 
            // JudgeMentLine1
            // 
            this.JudgeMentLine1.BackgroundImage = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine1.Image = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine1.Location = new System.Drawing.Point(287, 2);
            this.JudgeMentLine1.Name = "JudgeMentLine1";
            this.JudgeMentLine1.Size = new System.Drawing.Size(5, 673);
            this.JudgeMentLine1.TabIndex = 7;
            this.JudgeMentLine1.TabStop = false;
            this.JudgeMentLine1.Visible = false;
            // 
            // but_Quit
            // 
            this.but_Quit.BackColor = System.Drawing.Color.Transparent;
            this.but_Quit.Image = global::RythmeGame.Properties.Resources.Quit;
            this.but_Quit.Location = new System.Drawing.Point(616, 708);
            this.but_Quit.Name = "but_Quit";
            this.but_Quit.Size = new System.Drawing.Size(156, 81);
            this.but_Quit.TabIndex = 6;
            this.but_Quit.UseVisualStyleBackColor = false;
            this.but_Quit.Visible = false;
            this.but_Quit.Click += new System.EventHandler(this.but_Quit_Click);
            // 
            // but_Judge4
            // 
            this.but_Judge4.Image = global::RythmeGame.Properties.Resources.JudgementKey;
            this.but_Judge4.Location = new System.Drawing.Point(487, 2);
            this.but_Judge4.Name = "but_Judge4";
            this.but_Judge4.Size = new System.Drawing.Size(100, 800);
            this.but_Judge4.TabIndex = 2;
            this.but_Judge4.TabStop = false;
            this.but_Judge4.Visible = false;
            // 
            // but_Judge3
            // 
            this.but_Judge3.Image = global::RythmeGame.Properties.Resources.JudgementKey;
            this.but_Judge3.Location = new System.Drawing.Point(387, 2);
            this.but_Judge3.Name = "but_Judge3";
            this.but_Judge3.Size = new System.Drawing.Size(100, 800);
            this.but_Judge3.TabIndex = 3;
            this.but_Judge3.TabStop = false;
            this.but_Judge3.Visible = false;
            // 
            // but_Judge2
            // 
            this.but_Judge2.BackgroundImage = global::RythmeGame.Properties.Resources.JudgementKey;
            this.but_Judge2.Location = new System.Drawing.Point(287, 2);
            this.but_Judge2.Name = "but_Judge2";
            this.but_Judge2.Size = new System.Drawing.Size(100, 800);
            this.but_Judge2.TabIndex = 4;
            this.but_Judge2.TabStop = false;
            this.but_Judge2.Visible = false;
            // 
            // but_Judge1
            // 
            this.but_Judge1.BackgroundImage = global::RythmeGame.Properties.Resources.JudgementKey;
            this.but_Judge1.Location = new System.Drawing.Point(187, 2);
            this.but_Judge1.Name = "but_Judge1";
            this.but_Judge1.Size = new System.Drawing.Size(100, 800);
            this.but_Judge1.TabIndex = 5;
            this.but_Judge1.TabStop = false;
            this.but_Judge1.Visible = false;
            // 
            // but_Start
            // 
            this.but_Start.Location = new System.Drawing.Point(187, 580);
            this.but_Start.Name = "but_Start";
            this.but_Start.Size = new System.Drawing.Size(380, 137);
            this.but_Start.TabIndex = 3;
            this.but_Start.TabStop = false;
            this.but_Start.Click += new System.EventHandler(this.but_Start_Click);
            // 
            // Pic_MusicCover
            // 
            this.Pic_MusicCover.Location = new System.Drawing.Point(213, 181);
            this.Pic_MusicCover.Name = "Pic_MusicCover";
            this.Pic_MusicCover.Size = new System.Drawing.Size(354, 393);
            this.Pic_MusicCover.TabIndex = 2;
            this.Pic_MusicCover.TabStop = false;
            // 
            // but_Back
            // 
            this.but_Back.Location = new System.Drawing.Point(-80, 314);
            this.but_Back.Name = "but_Back";
            this.but_Back.Size = new System.Drawing.Size(289, 105);
            this.but_Back.TabIndex = 1;
            this.but_Back.TabStop = false;
            this.but_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.but_Back_MouseClick);
            // 
            // but_Next
            // 
            this.but_Next.Location = new System.Drawing.Point(560, 301);
            this.but_Next.Name = "but_Next";
            this.but_Next.Size = new System.Drawing.Size(289, 105);
            this.but_Next.TabIndex = 0;
            this.but_Next.TabStop = false;
            this.but_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.but_Next_MouseClick);
            // 
            // JudgeMentLine2
            // 
            this.JudgeMentLine2.BackgroundImage = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine2.Image = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine2.Location = new System.Drawing.Point(387, 2);
            this.JudgeMentLine2.Name = "JudgeMentLine2";
            this.JudgeMentLine2.Size = new System.Drawing.Size(5, 673);
            this.JudgeMentLine2.TabIndex = 8;
            this.JudgeMentLine2.TabStop = false;
            this.JudgeMentLine2.Visible = false;
            // 
            // JudgeMentLine3
            // 
            this.JudgeMentLine3.BackgroundImage = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine3.Image = global::RythmeGame.Properties.Resources.JudgementLine;
            this.JudgeMentLine3.Location = new System.Drawing.Point(487, 2);
            this.JudgeMentLine3.Name = "JudgeMentLine3";
            this.JudgeMentLine3.Size = new System.Drawing.Size(5, 673);
            this.JudgeMentLine3.TabIndex = 9;
            this.JudgeMentLine3.TabStop = false;
            this.JudgeMentLine3.Visible = false;
            // 
            // Label_Combo
            // 
            this.Label_Combo.AutoSize = true;
            this.Label_Combo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Combo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Combo.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Combo.ForeColor = System.Drawing.Color.Brown;
            this.Label_Combo.Location = new System.Drawing.Point(593, 181);
            this.Label_Combo.Name = "Label_Combo";
            this.Label_Combo.Size = new System.Drawing.Size(45, 38);
            this.Label_Combo.TabIndex = 10;
            this.Label_Combo.Text = "12";
            this.Label_Combo.Visible = false;
            // 
            // timer1
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 801);
            this.Controls.Add(this.Label_Combo);
            this.Controls.Add(this.JudgeMentLine3);
            this.Controls.Add(this.JudgeMentLine2);
            this.Controls.Add(this.JudgeMentLine1);
            this.Controls.Add(this.but_Quit);
            this.Controls.Add(this.but_Judge4);
            this.Controls.Add(this.but_Judge3);
            this.Controls.Add(this.but_Judge2);
            this.Controls.Add(this.but_Judge1);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.but_Start);
            this.Controls.Add(this.Pic_MusicCover);
            this.Controls.Add(this.but_Back);
            this.Controls.Add(this.but_Next);
            this.Name = "Form1";
            this.Text = "bbd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Judge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MusicCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeMentLine3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox but_Next;
        private System.Windows.Forms.PictureBox but_Back;
        private System.Windows.Forms.PictureBox Pic_MusicCover;
        private System.Windows.Forms.PictureBox but_Start;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.PictureBox but_Judge1;
        private System.Windows.Forms.PictureBox but_Judge2;
        private System.Windows.Forms.PictureBox but_Judge3;
        private System.Windows.Forms.PictureBox but_Judge4;
        private System.Windows.Forms.Button but_Quit;
        private System.Windows.Forms.PictureBox JudgeMentLine2;
        private System.Windows.Forms.PictureBox JudgeMentLine3;
        public System.Windows.Forms.PictureBox JudgeMentLine1;
        private System.Windows.Forms.Label Label_Combo;
        private System.Windows.Forms.Timer timer1;
    }
}

