using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoru_tama
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax + PlayerIndex;
        const int ItemIndex = EnemyMax + EnemyIndex;
        const int StartTime = 0;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◇";
        const string ItemText = "★";

        static Random rand = new Random();

        int itemcount;
        int time;
        int score;
        int hightscore = 0;
        int countdown;

        enum State
        {
            None=-1,
            Title,
            Game,
            Gameover,
            Score
        }
        State currentState = State.None;
        State nextState=State.Title;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if (i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
                chrs[i].Font = tempLabel.Font;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                iniProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }
            }

            if(currentState==State.Game)
            {
                UpdateGame();
                itemcountLabel.Text = ("★:" + itemcount);
                scoreLabel.Text = ("Score:" + score);
            }
        }

        void UpdateGame()
        {
            timer1.Interval = 1000;
            countdown--;
            if(countdown>0)
            {
                countdownLabel.Text = ("" + countdown);
            }
            else if(countdown==0)
            {
                countdownLabel.Text = ("Start!!");
            }
            else
            {
                timer1.Interval = 100;
                countdownLabel.Visible = false;
            }

            if(!countdownLabel.Visible)
            {
                time++;
                score++;
                timeLabel.Text = ("Time:" + time);
                Point fpos = PointToClient(MousePosition);
                chrs[PlayerIndex].Left = fpos.X - chrs[PlayerIndex].Width / 2;
                chrs[PlayerIndex].Top = fpos.Y - chrs[PlayerIndex].Height / 2;

                for (int i = EnemyIndex; i < ChrMax; i++)
                {
                    chrs[i].Left += vx[i];
                    chrs[i].Top += vy[i];

                    if (i < ItemIndex)
                    {
                        if (chrs[i].Left < 0)
                        {
                            vx[i] = Math.Abs(vx[i]);
                        }
                        if (chrs[i].Top < 0)
                        {
                            vy[i] = Math.Abs(vy[i]);
                        }
                        if (chrs[i].Right > ClientSize.Width)
                        {
                            vx[i] = -Math.Abs(vx[i]);
                        }
                        if (chrs[i].Bottom > ClientSize.Height)
                        {
                            vy[i] = -Math.Abs(vy[i]);
                        }
                        //当たり判定
                        if ((chrs[PlayerIndex].Left+5 < chrs[i].Right)
                                && (chrs[PlayerIndex].Top+5 < chrs[i].Bottom)
                                && (chrs[PlayerIndex].Right-5 > chrs[i].Left)
                                && (chrs[PlayerIndex].Bottom-5 > chrs[i].Top))
                        {
                            nextState = State.Gameover;
                        }
                    }
                    else
                    {
                        if (chrs[i].Left < 0)
                        {
                            vx[i] = Math.Abs(vx[i]);
                        }
                        if (chrs[i].Right > ClientSize.Width)
                        {
                            vx[i] = -Math.Abs(vx[i]);
                        }
                        if (chrs[i].Top > ClientSize.Height)
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(-ClientSize.Height, (ClientSize.Height - chrs[i].Height) - ClientSize.Height);
                        }

                        //当たり判定
                        if ((chrs[PlayerIndex].Left <= chrs[i].Right)
                                && (chrs[PlayerIndex].Top <= chrs[i].Bottom)
                                && (chrs[PlayerIndex].Right >= chrs[i].Left)
                                && (chrs[PlayerIndex].Bottom >= chrs[i].Top))
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(-ClientSize.Height, (ClientSize.Height - chrs[i].Height) - ClientSize.Height);
                            score += 50;
                            itemcount++;
                        }
                    }
                }
            }
            
        }

        void iniProc()
        {
            currentState = nextState;
            nextState = State.None;
            
            switch(currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    copyrightLabel.Visible = true;
                    highscoreLabel.Visible = true;
                    startButton.Visible = true;
                    gameoverLabel.Visible = false;
                    itemcountLabel.Visible = false;
                    titleButton.Visible = false;
                    nextButton.Visible = false;
                    scoreLabel.Visible = false;
                    timeLabel.Visible = false;
                    countdownLabel.Visible = false;
                    kousinLabel.Visible = false;
                    for (int i = PlayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    copyrightLabel.Visible = false;
                    highscoreLabel.Visible = false;
                    startButton.Visible = false;
                    scoreLabel.Visible = true;
                    timeLabel.Visible = true;
                    itemcountLabel.Visible = true;
                    countdownLabel.Visible = true;

                    for (int i=EnemyIndex;i<ChrMax;i++)
                    { 
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        if (i<ItemIndex)
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                            vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        }
                        else
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(-ClientSize.Height,(ClientSize.Height - chrs[i].Height) - ClientSize.Height);
                            vy[i] = rand.Next(SpeedMax + 1);
                        }
                    }

                    itemcount = 0;
                    time = StartTime;
                    score = 0;
                    countdown = 4;

                    for (int i = PlayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = true;
                    }
                    break;

                case State.Gameover:
                    gameoverLabel.Visible = true;
                    nextButton.Visible = true;
                    break;

                case State.Score:
                    highscoreLabel.Visible = true;
                    titleButton.Visible = true;
                    gameoverLabel.Visible = false;
                    nextButton.Visible = false;

                    if(score>hightscore)
                    {
                        hightscore = score;
                        kousinLabel.Visible = true;
                    }
                    highscoreLabel.Text = ("HiScore:" + hightscore);
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextState = State.Score;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
