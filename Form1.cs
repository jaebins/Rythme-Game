using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;

namespace RythmeGame
{
    public partial class Form1 : Form
    {
        const int JUDGE_NOTELINE = 700;
        const int SLEEP_TIME = 5;
        const int REACH_TINM = 1;

        MediaPlayer.MediaPlayer media = new MediaPlayer.MediaPlayer();
        Dictionary<int, Image> songCovers = new Dictionary<int, Image>();

        PictureBox[] notes = new PictureBox[10];
        PictureBox backgroundImage;

        string[] songNames = new string[50];
        string[] songMp3Paths = new string[50];

        string songPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/JaebinsRythmeGame";
        int[] noteXs = new int[5];
        int[] noteY = new int[5];
        int noteAppend = 0;
        int noteCount = 0;
        int songCount = 0;
        int songPage = 0;
        int combo = 0;
        bool isGameStart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = new PictureBox
                {
                    Image = Properties.Resources.note,
                    Size = new Size(but_Judge1.Size.Width, Properties.Resources.note.Height),
                    Location = new Point(187, -1),
                    Visible = false
                };

                Controls.Add(notes[i]);
            }

            string getSongInfoPath = songPath + "/" + "songList.xml";
            XmlDocument xml = new XmlDocument();
            XmlElement parentDoc = xml.CreateElement("songCovers");
            DirectoryInfo basicGameFolder = new DirectoryInfo(songPath);

            if (File.Exists(getSongInfoPath)) // 만약 디렉토리 풀더가 있다면
            {
                foreach (var item in basicGameFolder.GetDirectories())
                {
                    DirectoryInfo di = new DirectoryInfo(item.FullName);
                    XmlElement songDoc = xml.CreateElement("NumberSong_" + songCount);

                    foreach (var item2 in di.GetFiles())
                    {
                        if (item2.Name.Contains(".mp3"))
                        {
                            songDoc.InnerText = item2.Name.Substring(0, item2.Name.Length - 4);
                            songNames[songCount] = songDoc.InnerText;
                            songMp3Paths[songCount] = item2.FullName;
                        }
                        else if (item2.Name.Contains(".jpg") || item2.Name.Contains(".jpeg") || item2.Name.Contains(".png"))
                        {
                            songCovers.Add(songCount, Bitmap.FromFile(item2.FullName));
                        }
                    }

                    if (!String.IsNullOrEmpty(songDoc.InnerText))
                    {
                        parentDoc.AppendChild(songDoc);
                        songCount++;
                    }
                }

                xml.AppendChild(parentDoc);
                xml.Save(getSongInfoPath);
            }
            else // 만약 디렉토리 풀더가 없다면
            {
                MessageBox.Show("파일을 생성합니다.");
                basicGameFolder.Create();
                DirectoryInfo basicSong = new DirectoryInfo(songPath + "/0_비망록");
                basicSong.Create();

                string songCoverPath = "..\\..\\Resources\\SongCover.jpg";
                File.Move(songCoverPath, songPath + "\\0_비망록\\비망록.jpg");
                string songMp3Path = "..\\..\\SongFiles\\song.mp3";
                File.Move(songMp3Path, songPath + "\\0_비망록\\비망록.mp3");

                File.Create(songPath + "/" + "songList.xml");
            }

            but_Back.Image = Properties.Resources.ArrowLeft;
            but_Next.Image = Properties.Resources.arrowRight;
            but_Quit.Image = Properties.Resources.Quit;
            but_Start.Image = Properties.Resources.Continue;
            but_Judge1.Image = Properties.Resources.JudgementKey;
            but_Judge2.Image = Properties.Resources.JudgementKey;
            but_Judge3.Image = Properties.Resources.JudgementKey;
            but_Judge4.Image = Properties.Resources.JudgementKey;
            Pic_MusicCover.Image = songCovers[0];

            MusicStart();
        }

        private void but_Next_MouseClick(object sender, MouseEventArgs e)
        {
            TurnSongPage(1);
        }

        private void but_Back_MouseClick(object sender, MouseEventArgs e)
        {
            TurnSongPage(-1);
        }

        private void TurnSongPage(int value)
        {
            if (songPage != songCount - value && value != -1)
            {
                songPage += value;
            }
            else if (songPage != 0 && value != 1)
            {
                songPage += value;
            }

            Label_Title.Text = songNames[songPage];
            Pic_MusicCover.Image = songCovers[songPage];

            media.Stop();
            MusicStart();
        }

        private void but_Start_Click(object sender, EventArgs e)
        {
            but_Back.Visible = false;
            but_Next.Visible = false;
            but_Start.Visible = false;
            Label_Title.Visible = false;
            Pic_MusicCover.Visible = false;

            JudgeMentLine1.Visible = true;
            JudgeMentLine2.Visible = true;
            JudgeMentLine3.Visible = true;
            but_Judge1.Visible = true;
            but_Judge2.Visible = true;
            but_Judge3.Visible = true;
            but_Judge4.Visible = true;
            but_Quit.Visible = true;

            media.Stop();
            GameStart();
        }

        private void GameStart()
        {
            isGameStart = true;
            MusicStart();
            backgroundImage = new PictureBox()
            {
                Image = new Bitmap(songCovers[songPage], new Size(Width, Height)),
                Size = new Size(Width, Height),
                Location = new Point(0, 0)
            };

            Controls.Add(backgroundImage);
            backgroundImage.SendToBack();

            Thread t1 = new Thread(CreateNote);
            t1.IsBackground = true;
            t1.Start();
        }

        private void CreateNote()
        {
            while (true)
            {
                if (!isGameStart)
                {
                    noteCount = 0;
                    break;
                }

                Random ran = new Random();
                int ranPos = ran.Next(0, 4);
                int noteX = 0;

                if (ranPos == 0)
                {
                    noteX = 187;
                }
                else if (ranPos == 1)
                {
                    noteX = 287;
                }
                else if (ranPos == 2)
                {
                    noteX = 387;
                }
                else
                {
                    noteX = 487;
                }

               noteAppend = ran.Next(0, 2);

                if (noteAppend == 0)
                {
                    Task t1 = Task.Run(() => DropNoteAsync(noteX));
                }
                else if (noteAppend == 1)
                {
                    Task t1 = Task.Run(() => DropNoteAsync(noteX));

                    if (noteX == 487)
                    {
                        noteX -= 100;
                        Task t2 = Task.Run(() => DropNoteAsync(noteX));
                    }
                    else
                    {
                        noteX += 100;
                        Task t2 = Task.Run(() => DropNoteAsync(noteX));
                    }
                }

                Delay(1000);
            }
        }

        private async Task DropNoteAsync(int noteX)
        {
            await Task.Run(() =>
            {
                int newNoteCount = noteCount;
                noteY[newNoteCount] = 0;
                noteXs[newNoteCount] = noteX;
                noteCount++;

                this.Invoke(new Action(delegate ()
                {
                    notes[newNoteCount].Visible = true;
                    notes[newNoteCount].BringToFront();
                }));

                while (true)
                {
                    if (noteY[newNoteCount] > JUDGE_NOTELINE || !isGameStart)
                    {
                        noteCount--;
                        this.Invoke(new Action(delegate ()
                        {
                            notes[newNoteCount].Visible = false;
                        }));
                        break;
                    }

                    noteY[newNoteCount] += 7;
                    this.Invoke(new Action(delegate ()
                    {
                        notes[newNoteCount].Location = new Point(noteX, noteY[newNoteCount]);
                    }));

                    Delay(SLEEP_TIME);
                }

                noteAppend = 0;
            });
        }

        private void MusicStart() // 나중에 음악 키기
        {
            media = new MediaPlayer.MediaPlayer();
            media.Open(songMp3Paths[songPage]);
            media.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    ClickKey(but_Judge1, 187);
                    break;
                case Keys.F:
                    ClickKey(but_Judge2, 287);
                    break;
                case Keys.J:
                    ClickKey(but_Judge3, 387);
                    break;
                case Keys.K:
                    ClickKey(but_Judge4, 487);
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    NoClickKey(but_Judge1);
                    break;
                case Keys.F:
                    NoClickKey(but_Judge2);
                    break;
                case Keys.J:
                    NoClickKey(but_Judge3);
                    break;
                case Keys.K:
                    NoClickKey(but_Judge4);
                    break;
            }
        }

        private void ClickKey(PictureBox judgeKey, int clicknoteXs)
        {
            judgeKey.Image = Properties.Resources.JudgementKeyClick;

            if(noteAppend == 0)
            {
                SuccessHit(0, clicknoteXs);
            }
            else
            {
                for (int i = 0; i < noteAppend; i++)
                {
                    SuccessHit(i, clicknoteXs);
                }
            }
        }

        private void SuccessHit(int value, int clicknoteXs)
        {
            if (noteY[value] < JUDGE_NOTELINE && noteY[value] > 550 && noteXs[value] == clicknoteXs)
            {
                combo++;
                Label_Combo.Visible = true;
                Label_Combo.Text = combo.ToString() + " Combo!";
                Label_Combo.BringToFront();

                //Task.Run(() => SuceesEvent());
                
                Console.WriteLine("성공");
            }
            else
            {
                combo = 0;
                Label_Combo.Visible = false;
                Label_Combo.Text = combo.ToString();
            }
        }

        private async Task SuceesEvent()
        {
            await Task.Run(() =>
            {
                int comboTextSize = (int)Label_Combo.Font.Size;
                for (int i = 0; i < 25; i++)
                {
                    comboTextSize++;
                    this.Invoke(new Action(delegate ()
                    {
                        Label_Combo.Font = new Font("Impact", comboTextSize);
                    }));
                    Delay(5);
                }
                for (int i = 0; i < 25; i++)
                {
                    comboTextSize--;
                    this.Invoke(new Action(delegate ()
                    {
                        Label_Combo.Font = new Font("Impact", comboTextSize);
                    }));
                    Delay(5);
                }
            });
        }

        private void NoClickKey(PictureBox judgeKey)
        {
            judgeKey.Image = Properties.Resources.JudgementKey;
        }

        private void but_Quit_Click(object sender, EventArgs e)
        {
            isGameStart = false;
            media.Stop();
            MusicStart();

            but_Back.Visible = true;
            but_Next.Visible = true;
            but_Start.Visible = true;
            Label_Title.Visible = true;
            Pic_MusicCover.Visible = true;

            JudgeMentLine1.Visible = false;
            JudgeMentLine2.Visible = false;
            JudgeMentLine3.Visible = false;
            but_Judge1.Visible = false;
            but_Judge2.Visible = false;
            but_Judge3.Visible = false;
            but_Judge4.Visible = false;
            but_Quit.Visible = false;
            backgroundImage.Visible = false;
            Label_Combo.Visible = false;
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}
