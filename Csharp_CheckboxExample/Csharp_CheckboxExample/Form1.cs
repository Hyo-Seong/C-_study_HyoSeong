using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_CheckboxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//checkBox1은 전체선택 같은 경우
            checkBox2.Checked = checkBox1.Checked;//1이 체크될 경우 2도 체크함, 반대의 경우도 동일
            checkBox3.Checked = checkBox1.Checked;//1이 체크될 경우 3도 체크함, 반대의 경우도 동일
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("완료!");
            Delay(1000);
            checkBox1.Checked = true;
            checkBox1.Checked = false;
        }

        private static DateTime Delay(int MS)

        {

            DateTime ThisMoment = DateTime.Now;

            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);

            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)

            {

                System.Windows.Forms.Application.DoEvents();

                ThisMoment = DateTime.Now;

            }

            return DateTime.Now;

        }
        //출처: http://bananamandoo.tistory.com/27 [바나나만두의 넋두리]
    }
}
