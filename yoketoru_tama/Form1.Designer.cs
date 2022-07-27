
namespace yoketoru_tama
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.itemcountLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.titleButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.kousinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(264, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 72);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる";
            // 
            // itemcountLabel
            // 
            this.itemcountLabel.AutoSize = true;
            this.itemcountLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemcountLabel.ForeColor = System.Drawing.Color.Black;
            this.itemcountLabel.Location = new System.Drawing.Point(644, 37);
            this.itemcountLabel.Name = "itemcountLabel";
            this.itemcountLabel.Size = new System.Drawing.Size(78, 28);
            this.itemcountLabel.TabIndex = 1;
            this.itemcountLabel.Text = "★:00";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameoverLabel.Location = new System.Drawing.Point(293, 148);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(233, 48);
            this.gameoverLabel.TabIndex = 2;
            this.gameoverLabel.Text = "GameOver";
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.highscoreLabel.Location = new System.Drawing.Point(269, 181);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(235, 40);
            this.highscoreLabel.TabIndex = 3;
            this.highscoreLabel.Text = "HighScore:00";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(238, 405);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(334, 36);
            this.copyrightLabel.TabIndex = 4;
            this.copyrightLabel.Text = "Copyright© 2022 たま";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(267, 256);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 113);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.titleButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.Location = new System.Drawing.Point(267, 256);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(250, 113);
            this.titleButton.TabIndex = 6;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scoreLabel.Location = new System.Drawing.Point(603, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(123, 28);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score:00";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(127, 33);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time:00";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tempLabel.Location = new System.Drawing.Point(40, 109);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(86, 28);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "(・ω・)";
            this.tempLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countdownLabel.Location = new System.Drawing.Point(357, 181);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(52, 56);
            this.countdownLabel.TabIndex = 10;
            this.countdownLabel.Text = "3";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(267, 256);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(250, 113);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "次へ";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // kousinLabel
            // 
            this.kousinLabel.AutoSize = true;
            this.kousinLabel.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kousinLabel.Location = new System.Drawing.Point(213, 85);
            this.kousinLabel.Name = "kousinLabel";
            this.kousinLabel.Size = new System.Drawing.Size(371, 56);
            this.kousinLabel.TabIndex = 12;
            this.kousinLabel.Text = "ハイスコア更新!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kousinLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.itemcountLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label itemcountLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label kousinLabel;
    }
}

