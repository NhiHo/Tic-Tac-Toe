using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class play : Form
    {
       
        public play()
        {
            InitializeComponent();
            
        }
        private string a;
        private string b;
        public string GetNC1
        {
            // truyền tham số vào đối tượng GetNC1 để sau này lưu tên người chơi 1
            set { a = value; }
            get { return a; }

        }
        public string GetNC2
        {
            // truyền tham số vào đối tượng GetNC1 để sau này lưu tên người chơi 2
            set { b = value; }
            get { return b; }

        }
       
       
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //kiểm tra xem người chơi đã nhập tên hay chưa
            if (txtNC1.Text=="")
            { MessageBox.Show("Chưa nhập tên người chơi 1"); }
            else if (txtNC2.Text=="")
            { MessageBox.Show("Chưa nhập tên người chơi 2"); }
            else
            {
                play pl = new play();
                pl.GetNC1 = txtNC1.Text;
                pl.GetNC2 = txtNC2.Text;
                Form1 frm = new Form1(pl);
                frm.Show();
                this.Hide();
            }
            //string NC1 = txtNC1.Text;
            // string NC2 = txtNC2.Text;
        }

        private void play_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
