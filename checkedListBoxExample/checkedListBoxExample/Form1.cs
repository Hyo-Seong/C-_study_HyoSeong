using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkedListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Console.WriteLine("aaaa");
            Console.ReadLine();
            InitializeComponent();
            Debug.WriteLine("aaaa");
            checkedListBox1.Items.Add("대한민국");
            checkedListBox1.Items.Add("미국");
            checkedListBox1.Items.Add("일본");
            checkedListBox1.Items.Add("대만");
            checkedListBox1.Items.Add("중국");
            checkedListBox1.Items.Add("캐나다");
            checkedListBox1.Items.Add("독일");
            checkedListBox1.Items.Add("영국");
            checkedListBox1.Items.Add("홍콩");
   
        }

        public void main(string[] args)
        {
            Debug.WriteLine("aaaa");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            string item = checkedListBox1.SelectedItem.ToString();
            MessageBox.Show(index + "/" + item + "이 선택됨" +e);
            Console.WriteLine(index + "/" + item + "이 선택됨");
        }
    }
}
