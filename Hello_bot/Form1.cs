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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        


        private void オプションToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新規挨拶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string mess;
            if (Properties.Settings.Default.all_hello)
            {
                mess = "こんにちは";
            }
            else
            {
                if (dt.Hour > 9 && dt.Hour < 19)
                {
                    mess = "こんにちは";
                }
                else if (dt.Hour > 19 || dt.Hour < 2)
                {
                    mess = "こんばんは";
                }
                else
                {
                    mess = "おはようございます";
                }
            }
            
            MessageBox.Show(mess+"\n現在の時刻は" + dt.Hour + "時です",
            "moons挨拶",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
            DialogResult result = MessageBox.Show("あいさつを返しますか?\n前のウィンドウに戻る場合はキャンセルをクリックしてください",
            "moons挨拶",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                answer answer = new answer();
                answer.Show();
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時
                
            }
        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // アイコン非表示
            // アプリケーション終了
            Application.Exit();
        }

        private void moons挨拶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void オプションToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version β0.1.0",
            "moons挨拶バージョン情報",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
        }
    }
}
