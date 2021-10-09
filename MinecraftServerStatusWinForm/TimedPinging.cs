using System;
using System.Media;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ServerStatusWinForm
{
    public partial class TimedPinging : Form
    {
        public TimedPinging()
        {
            InitializeComponent();

            timerSeconds.Start();
        }

        private void PingServer()
        {
            Ping myPing = new();
            try
            {
                PingReply reply = myPing.Send(UserInput.Text, 10000);
                ServerStatusDisplay.Text = $"Status: {reply.Status} \nTime: {reply.RoundtripTime}";
                SystemSounds.Beep.Play();
            }
            catch (Exception)
            {
                ServerStatusDisplay.Text = $"It's not up yet. \nLast check at: {DateTime.Now.ToLongTimeString()}";
            }
        }

        private void TimerSetting_TextChanged(object sender, EventArgs e)
        {
            int timer = 60;
            Int32.TryParse(TimerSetting.Text, out timer);

            if (timer > 0 && timer < 100)
            {
                timerSeconds.Interval = timer * 1000;
            }
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            TimeTillNextCheck.PerformStep();

            if (TimeTillNextCheck.Value == 0)
            {
                PingServer();
                TimeTillNextCheck.Value = 5;
            }
        }
    }
}
