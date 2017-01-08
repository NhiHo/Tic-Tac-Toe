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
    public partial class Form2 : Form
    {
        Form1 tt;
        public Form2(Form1 tt)
        {
            InitializeComponent();
            this.tt = tt;
            Write();
        }
        public void Write()
        {
            NC1.Text = tt.listname[0];
            NC2.Text = tt.listname[1];
            NC3.Text = tt.listname[2];
            NC4.Text = tt.listname[3];
            NC5.Text = tt.listname[4];
            NC6.Text = tt.listname[5];
            NC7.Text = tt.listname[6];
            NC8.Text = tt.listname[7];
            NC9.Text = tt.listname[8];
            NC10.Text = tt.listname[9];
            NC11.Text = tt.listname[10];
            NC12.Text = tt.listname[11];

            D1.Text = tt.listdiem[0].ToString();
            D2.Text = tt.listdiem[1].ToString();
            D3.Text = tt.listdiem[2].ToString();
            D4.Text = tt.listdiem[3].ToString();
            D5.Text = tt.listdiem[4].ToString();
            D6.Text = tt.listdiem[5].ToString();
            D7.Text = tt.listdiem[6].ToString();
            D8.Text = tt.listdiem[7].ToString();
            D9.Text = tt.listdiem[8].ToString();
            D10.Text = tt.listdiem[9].ToString();
            D11.Text = tt.listdiem[10].ToString();
            D12.Text = tt.listdiem[11].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
