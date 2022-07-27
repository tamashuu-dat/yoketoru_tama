using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoru_tama
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                iniProc();
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
