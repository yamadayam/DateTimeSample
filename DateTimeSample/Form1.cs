using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //現在日時
        private void btNow_Click(object sender, EventArgs e) {
            var now = DateTime.Now.ToString("D");
            tbNowDisp.Text = now;
            btBefore.Enabled = true;
            btAfter.Enabled = true;            
        }
        //何日前
        private void btBefore_Click(object sender, EventArgs e) {
            var date1 = DateTime.Parse(tbNowDisp.Text);
            var date2 = date1.AddDays(-(int)nudDayBeforeAfter.Value).AddMonths(-(int)nudMonthBeforeAfter.Value);
            tbMonthDay.Text = date2.ToString("D");
            uruu(date2);
            btBirthdayMath.Enabled = true;
        }
        //何日後
        private void btAfter_Click(object sender, EventArgs e) {
            var date1 = DateTime.Parse(tbNowDisp.Text);
            var date2 = date1.AddDays((int)nudDayBeforeAfter.Value).AddMonths((int)nudMonthBeforeAfter.Value);
            tbMonthDay.Text = date2.ToString("D");
            uruu(date2);
            btBirthdayMath.Enabled = true;
        }
        //閏年判定（三項演算子）
        private int uruu(DateTime date) {
            tbUruu.Text = DateTime.IsLeapYear(date.Year) ? "今年は閏年です。" : "今年は平年です。";
            return 1;
        }

        private void btBirthdayMath_Click(object sender, EventArgs e) {            
            //日数に変換
            var BirthdayDate = mcBirthday.SelectionStart;
            var NowDate = DateTime.Parse(tbMonthDay.Text);
            //日時の差を計算
            var date = (NowDate - BirthdayDate).TotalDays;
            //日数を表示
            tbBirthdayDay.Text = date.ToString();

            if (date<0)
            {
            tbBirthdayDay.Text = null;
            MessageBox.Show("正しい値を入力してください。","日付エラー",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
