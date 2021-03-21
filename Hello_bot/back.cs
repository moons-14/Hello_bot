using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace Hello_bot
{
    public partial class back : Form
    {
        Timer timer = new Timer();
        public back()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            string mess;
            if (Properties.Settings.Default.all_hello)
            {
                mess = "こんにちは";
            }
            else
            {
                if (datetime.Hour > 9 && datetime.Hour < 19)
                {
                    mess = "こんにちは";
                }
                else if (datetime.Hour > 19 || datetime.Hour < 2)
                {
                    mess = "こんばんは";
                }
                else
                {
                    mess = "おはようございます";
                }
            }
            if (Properties.Settings.Default.pikon_1_on)
            {
                DateTime datetime_set = Properties.Settings.Default.pikon_1;
                if (datetime.ToLongTimeString() == datetime_set.ToLongTimeString())
                {
                    if (Properties.Settings.Default.hop_on)
                    {
                        MessageBox.Show(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です",
                    "moonsアラーム!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    }
                    var type = ToastTemplateType.ToastText01;
                    var content = ToastNotificationManager.GetTemplateContent(type);
                    var text = content.GetElementsByTagName("text").First();
                    text.AppendChild(content.CreateTextNode(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です"));
                    var notifier = ToastNotificationManager.CreateToastNotifier("Microsoft.Windows.Computer");
                    notifier.Show(new ToastNotification(content));

                }

            }
            if (Properties.Settings.Default.pikon_2_on)
            {
                DateTime datetime_set = Properties.Settings.Default.pikon_2;
                if (datetime.ToLongTimeString() == datetime_set.ToLongTimeString())
                {
                    if (Properties.Settings.Default.hop_on)
                    {
                        MessageBox.Show(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です",
                    "moonsアラーム!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    }
                    var type = ToastTemplateType.ToastText01;
                    var content = ToastNotificationManager.GetTemplateContent(type);
                    var text = content.GetElementsByTagName("text").First();
                    text.AppendChild(content.CreateTextNode(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です"));
                    var notifier = ToastNotificationManager.CreateToastNotifier("Microsoft.Windows.Computer");
                    notifier.Show(new ToastNotification(content));

                }

            }
            if (Properties.Settings.Default.pikon_3_on)
            {
                DateTime datetime_set = Properties.Settings.Default.pikon_3;
                if (datetime.ToLongTimeString() == datetime_set.ToLongTimeString())
                {
                    if (Properties.Settings.Default.hop_on)
                    {
                        MessageBox.Show(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です",
                        "moonsアラーム!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    }

                    var type = ToastTemplateType.ToastText01;
                    var content = ToastNotificationManager.GetTemplateContent(type);
                    var text = content.GetElementsByTagName("text").First();
                    text.AppendChild(content.CreateTextNode(mess + "\n現在の時刻は" + datetime.Hour + "時" + datetime.Minute + "分です"));
                    var notifier = ToastNotificationManager.CreateToastNotifier("Microsoft.Windows.Computer");
                    notifier.Show(new ToastNotification(content));

                }

            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void オプションToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void moons挨拶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
