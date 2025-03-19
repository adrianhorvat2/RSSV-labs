namespace LV1_RSSV
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        private DateTime alarmTime;
        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }


        private void vrijeme(object s, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {
                lbl_vrijeme.Text = DateTime.Now.ToLongTimeString();

                if (DateTime.Now.ToString("HH:mm:ss") == alarmTime.ToString("HH:mm:ss"))
                {
                    txt_alarm.Text = "ALARM! Vrijeme je: " + alarmTime.ToString("HH:mm:ss");
                }
            });
        }

        private void btn_start_alarm_Click(object sender, EventArgs e)
        {

            if (DateTime.TryParse(txt_inputTime.Text, out alarmTime))
            {
                txt_alarm.Text = "Alarm postavljen na: " + alarmTime.ToString("HH:mm:ss");
                t.Start();
            }
            else
            {
                txt_alarm.Text = "Pogrešan format vremena! Unesi vrijeme u formatu HH:mm:ss.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
