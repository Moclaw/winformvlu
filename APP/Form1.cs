using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đóng ứng dụng không?", "Message box", MessageBoxButtons.YesNoCancel);
            if (result.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao = string.Empty;
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Bạn chưa đồng ý?","Thông báo");
                textBox1.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text)) thongbao += "Chưa nhập tên đăng nhập \n";
                if (string.IsNullOrEmpty(textBox6.Text)) thongbao += "Chưa nhập Mật Khẩu \n";
                if (string.IsNullOrEmpty(textBox5.Text)) thongbao += "Chưa nhập Email \n";
                if (string.IsNullOrEmpty(textBox4.Text)) thongbao += "Chưa nhập Số điện thoại\n";
                if (string.IsNullOrEmpty(textBox3.Text)) thongbao += "Chưa nhập Địa chỉ \n";
                MessageBox.Show(thongbao, "Thông báo!");            }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox6.Text = null;
            textBox5.Text = null;
            textBox4.Text = null;
            textBox3.Text = null;
            radioButton1.Checked = true;
            textBox1.Focus();
        }
    }
}
