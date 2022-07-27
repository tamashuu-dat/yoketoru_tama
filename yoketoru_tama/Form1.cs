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

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax + PlayerIndex;
        const int ItemIndex = EnemyMax + EnemyIndex;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◇";
        const string ItemText = "★";

        static Random rand = new Random();

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
            }
        }

        void UpdateGame()
        {
            Point fpos = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = fpos.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = fpos.Y - chrs[PlayerIndex].Height / 2;
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
                    
                    for(int i=EnemyIndex;i<ChrMax;i++)
                    {
                        if(i<ItemIndex)
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        }
                        else
                        {
                            chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                            chrs[i].Top = rand.Next(-ClientSize.Height,(ClientSize.Height - chrs[i].Height) - ClientSize.Height);
                        }
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
    }
}
