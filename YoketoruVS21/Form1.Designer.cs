
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
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
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSalmon;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.startButton.Location = new System.Drawing.Point(307, 259);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 73);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート!!";
            this.startButton.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.startButton);
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
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label hiLabel;
    }
}

