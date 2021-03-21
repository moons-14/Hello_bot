using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_bot
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            checkBox1.Checked = Properties.Settings.Default.all_hello;
            checkBox2.Checked = Properties.Settings.Default.pikon_on;
            checkBox3.Checked = Properties.Settings.Default.hop_on;
            dateTimePicker1.Checked = Properties.Settings.Default.pikon_1_on;
            dateTimePicker2.Checked = Properties.Settings.Default.pikon_2_on;
            dateTimePicker3.Checked = Properties.Settings.Default.pikon_3_on;
            
            if (Properties.Settings.Default.pikon_1.ToString() != null&& Properties.Settings.Default.pikon_1.ToString() != "")
            {
                dateTimePicker1.Value = Properties.Settings.Default.pikon_1;
            }
            if (Properties.Settings.Default.pikon_2.ToString() != null && Properties.Settings.Default.pikon_2.ToString() != "")
            {
                dateTimePicker2.Value = Properties.Settings.Default.pikon_2;
            }
            if (Properties.Settings.Default.pikon_3.ToString() != null && Properties.Settings.Default.pikon_3.ToString() != "")
            {
                dateTimePicker3.Value = Properties.Settings.Default.pikon_3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.all_hello = checkBox1.Checked;
            Properties.Settings.Default.pikon_on = checkBox2.Checked;
            Properties.Settings.Default.hop_on = checkBox3.Checked;
            Properties.Settings.Default.pikon_1_on = dateTimePicker1.Checked;
                Properties.Settings.Default.pikon_1 = dateTimePicker1.Value;
            Properties.Settings.Default.pikon_2_on = dateTimePicker2.Checked;
                Properties.Settings.Default.pikon_2 = dateTimePicker2.Value;
            Properties.Settings.Default.pikon_3_on = dateTimePicker3.Checked;
                Properties.Settings.Default.pikon_3 = dateTimePicker3.Value;

            Properties.Settings.Default.Save();
            this.Close();
        }
            
    }
}
