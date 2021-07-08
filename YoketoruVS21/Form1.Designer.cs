
namespace YoketoruVS21
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.titleButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Vladimir Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.titleLabel.Location = new System.Drawing.Point(278, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(220, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2021";
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightlabel.Location = new System.Drawing.Point(255, 392);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(276, 28);
            this.copyrightlabel.TabIndex = 2;
            this.copyrightlabel.Text = "Copyright©2021 あいざわまさや";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Vivaldi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(42, 77);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(109, 32);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            this.timeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Vivaldi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightLabel.Location = new System.Drawing.Point(669, 76);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(44, 24);
            this.rightLabel.TabIndex = 4;
            this.rightLabel.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.hiLabel.Location = new System.Drawing.Point(287, 185);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(184, 37);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore100";
            this.hiLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GameOverLabel.Location = new System.Drawing.Point(255, 256);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(209, 54);
            this.GameOverLabel.TabIndex = 6;
            this.GameOverLabel.Text = "GameOver";
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearLabel.ForeColor = System.Drawing.Color.Red;
            this.ClearLabel.Location = new System.Drawing.Point(307, 256);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(124, 54);
            this.ClearLabel.TabIndex = 7;
            this.ClearLabel.Text = "Clear!";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSalmon;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.startButton.Location = new System.Drawing.Point(287, 313);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 73);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "スタート!!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.Green;
            this.titleButton.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleButton.Location = new System.Drawing.Point(287, 316);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(164, 73);
            this.titleButton.TabIndex = 9;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLabel.Location = new System.Drawing.Point(76, 203);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(44, 37);
            this.tempLabel.TabIndex = 10;
            this.tempLabel.Text = "★";
            this.tempLabel.UseWaitCursor = true;
            this.tempLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.titleLabel);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tempLabel;
    }
}

