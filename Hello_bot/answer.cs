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
    public partial class answer : Form
    {
        public answer()
        {
            InitializeComponent();
        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            MessageBox.Show(mess + "\n現在の時刻は" + dt.Hour + "時です",
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


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("~~~ヾ(＾∇＾)おはよー♪",
            "moons挨拶",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(^-^*)/ｺﾝﾁｬ!",
            "moons挨拶",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ｺﾝﾊﾞﾝヮ♪(-ω-｀*) ",
            "moons挨拶",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
        }
    }
}
