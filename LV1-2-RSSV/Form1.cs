using System.Timers;

namespace LV1_2_RSSV
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer t;
        private StreamReader r;
        private int threshold;
        private string filePath = @"C:\Users\student\Desktop\test.txt";
        private string currentLine;
        private int lineNumber;
        public Form1()
        {
            InitializeComponent();
            //Kreiranje timer-a s periodom od 1000 ms
            t = new System.Timers.Timer(1000);
            //Dodavanje događaja timer-u; izvršava se periodno
            t.Elapsed += new System.Timers.ElapsedEventHandler(ReadNumber);
        }

        private void ReadNumber(object sender, ElapsedEventArgs e)
        {
            if (r != null && !r.EndOfStream)
            {
                currentLine = r.ReadLine();

                if (int.TryParse(currentLine, out int number))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        lbl_vrijeme.Text = DateTime.Now.ToLongTimeString();

                        txt_readNumber.AppendText(number.ToString() + Environment.NewLine);

                        if (number > threshold)
                        {
                            txt_alarm.Text = "Number" + number + " is below threshold!";
                        }

                    });
                }
            }
            else
            {
                t.Stop();
                Invoke((MethodInvoker)delegate
                {
                    txt_alarm.Text = "End of file.";
                    r.Close();
                });
            }
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                try
                {
                    r = new StreamReader(filePath);
                    lineNumber = 0;

                    t.Start();
                    btn_start_stop.Text = "Stop";
                }
                catch (Exception ex)
                {
                    txt_alarm.Text = "Error opening file: " + ex.Message;
                }
            }
            else
            {
                t.Stop();
                r.Close();
                btn_start_stop.Text = "Start Reading";
                txt_alarm.Text = "Reading stopped.";
            }
        }

        private void btn_setThreshold_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_threshold.Text, out threshold))
            {
                txt_alarm.Text = "Threshold set to: " + threshold;
            }
            else
            {
                txt_alarm.Text = "Invalid threshold input!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
