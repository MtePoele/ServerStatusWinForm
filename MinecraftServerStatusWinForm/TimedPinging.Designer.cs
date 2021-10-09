
namespace ServerStatusWinForm
{
    partial class TimedPinging
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
            this.TimeTillNextCheck = new System.Windows.Forms.ProgressBar();
            this.ServerStatusDisplay = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TimerSetting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeTillNextCheck
            // 
            this.TimeTillNextCheck.Enabled = false;
            this.TimeTillNextCheck.Location = new System.Drawing.Point(12, 65);
            this.TimeTillNextCheck.MarqueeAnimationSpeed = 50000;
            this.TimeTillNextCheck.Maximum = 5;
            this.TimeTillNextCheck.Name = "TimeTillNextCheck";
            this.TimeTillNextCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeTillNextCheck.Size = new System.Drawing.Size(192, 29);
            this.TimeTillNextCheck.Step = -1;
            this.TimeTillNextCheck.TabIndex = 0;
            this.TimeTillNextCheck.Value = 5;
            // 
            // ServerStatusDisplay
            // 
            this.ServerStatusDisplay.Location = new System.Drawing.Point(12, 105);
            this.ServerStatusDisplay.Name = "ServerStatusDisplay";
            this.ServerStatusDisplay.Size = new System.Drawing.Size(185, 93);
            this.ServerStatusDisplay.TabIndex = 1;
            this.ServerStatusDisplay.Text = "Program running";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(12, 32);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(192, 27);
            this.UserInput.TabIndex = 1;
            this.UserInput.Text = "ItVitae.MCJoin.nl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server adress:";
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 60000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timer in seconds (1 - 99)";
            // 
            // TimerSetting
            // 
            this.TimerSetting.Location = new System.Drawing.Point(425, 32);
            this.TimerSetting.Name = "TimerSetting";
            this.TimerSetting.Size = new System.Drawing.Size(125, 27);
            this.TimerSetting.TabIndex = 5;
            this.TimerSetting.Text = "60";
            this.TimerSetting.TextChanged += new System.EventHandler(this.TimerSetting_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 80);
            this.label3.TabIndex = 6;
            this.label3.Text = "Makes \"Windows Beep\" sound when server is online.\r\nTimer has 5 steps. So 60 secon" +
    "ds above means\r\nchecking every 5 minutes.\r\nIt also displays time of last check i" +
    "f not up yet.";
            // 
            // TimedPinging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimerSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.ServerStatusDisplay);
            this.Controls.Add(this.TimeTillNextCheck);
            this.Name = "TimedPinging";
            this.Text = "Is the server online?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar TimeTillNextCheck;
        private System.Windows.Forms.Label ServerStatusDisplay;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimerSetting;
        private System.Windows.Forms.Label label3;
    }
}

