using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,  // 無効
            Title,      // タイトル
            Game,       // ゲーム
            Gameover,   // ゲームオーバー
            Clear       // クリア
        }
        State currentState = State.None;
        State nextState = State.Title;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                    timeLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightlabel.Visible= true;
                    hiLabel.Visible = true;
                    GameOverLabel.Visible = false;
                    titleButton.Visible = false;
                    ClearLabel.Visible = false;

                    break;
                case State.Game:
                    timeLabel.Visible = false;
                    startButton.Visible = false;
                    copyrightlabel.Visible = false;
                    hiLabel.Visible = false;
                    break;
            }
        }
    }
}
