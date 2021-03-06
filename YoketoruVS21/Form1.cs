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
using System.IO;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int SpeedMax = 20;
       

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;

        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;
        const int StartTime = 200;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();


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

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        int itemcount=0;
        int time = 0;
        int hiscore = 0;

        public Form1()
        {
            InitializeComponent();
            if(File.Exists("hisc.txt"))
            {
                string hi = File.ReadAllText("hisc");
                string trimhi = hi.Trim();
                int fhi;
                if(int.TryParse(trimhi,out fhi))
                {
                    hiscore = fhi;
                }
            }

            for(int i=0;i<ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
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
                Controls.Add(chrs[i]);
            }
            

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
            if (isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }



            if (nextState!=State.None)
            {
                iniProc();
            }

            if(currentState==State.Game)
            {
                UpdateGame();
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
                    hiLabel.Text = "HighScore" + hiscore;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyrightlabel.Visible = false;
                    hiLabel.Visible = false;
                    

                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                    }

                    itemcount = ItemMax;
                    time = StartTime + 1;

                    break;

                    
                case State.Gameover:
                   // MessageBox.Show("GameOver");
                    GameOverLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    //MessageBox.Show("Clear");
                    ClearLabel.Visible = true;
                    titleButton.Visible = true;
                    hiLabel.Visible = true;
                    if(time>hiscore)
                    {
                        hiscore = time;
                        hiLabel.Text = "HighScore" + hiscore;

                    }
                    break;
                   
                      
            }
        }

        void UpdateGame()
        {
            time--;
            timeLabel.Text = "Time" + time;
            if(time<=0)
            {
                nextState = State.Gameover;
            }

            Point mp = PointToClient(MousePosition);

            //  TODO:mpがプレイヤーラベルの中心になるように設定
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            for(int i=EnemyIndex;i<ChrMax; i++)
            {
                if (!chrs[i].Visible) continue;

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];

                if(chrs[i].Left<0)
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
                if (chrs[i].Bottom> ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                //当たり判定
                if(    (mp.X>=chrs[i].Left)
                    && (mp.X < chrs[i].Right)
                    && (mp.Y >= chrs[i].Top)
                    && (mp.Y< chrs[i].Bottom)
                    )
                {
                    //MessageBox.Show("重なった！！");

                    if (i < ItemIndex)
                        //if(chrs[i].Text == Enem)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        chrs[i].Visible = false;
                        itemcount--;
                        if(itemcount<=0)
                        {
                            nextState = State.Clear;
                        }
                        rightLabel.Text = "★" + itemcount;

                        //vx[i] = 0;
                        //vy[i] = 0;
                        //chrs[i].Left = 10000;

                    }
                }

                
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
    }
}
