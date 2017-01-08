using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace tic_tac_toe
{
    public partial class Bangkq : Form
    {
        Form1 tt;
        public Bangkq(Form1 tt)
        {

            InitializeComponent();
            this.tt = tt;
            WriteScore();
        }
        public Bangkq()
        {
            InitializeComponent();
        }
        public void WriteScore()
        {
            List<Label> labelname = new List<Label>();
            List<Label> labeldiem = new List<Label>();
            labelname.Add(NC1); labelname.Add(NC2); labelname.Add(NC3); labelname.Add(NC4); labelname.Add(NC5);
            labelname.Add(NC6); labelname.Add(NC7); labelname.Add(NC8); labelname.Add(NC9); labelname.Add(NC10);
            labelname.Add(NC11);labelname.Add(NC12);
            labeldiem.Add(D1); labeldiem.Add(D2); labeldiem.Add(D3); labeldiem.Add(D4); labeldiem.Add(D5);
            labeldiem.Add(D6); labeldiem.Add(D7); labeldiem.Add(D8); labeldiem.Add(D9); labeldiem.Add(D10);
            labeldiem.Add(D11);labeldiem.Add(D12);
            for (int i = 0; i <= 11; i++)
            {
                labelname[i].Text = tt.listname[i].ToString();
                labeldiem[i].Text = tt.listdiem[i].ToString();

            }
            labelname[tt.vt].ForeColor = Color.Red;
            labeldiem[tt.vt].ForeColor = Color.Red;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         /*   if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa nhập tên");
                return;
            }*/
         
        }
        private void Bangkq_Load(object sender, EventArgs e)
        {
          /*  FileStream fs = new FileStream("E://test.txt", FileMode.Open);

            StreamReader rd = new StreamReader(fs, Encoding.Unicode);
            
                string giatri = rd.ReadToEnd();
                richTextBox1.Text = giatri.ToString();
            
           */
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            tt.listname[tt.vt] = tt.Ten;
            StreamWriter sw = new StreamWriter("D:\\test.txt");
            for (int i = 0; i <= 11; i++)
            {
                sw.WriteLine(tt.listname[i]);
                sw.WriteLine(tt.listdiem[i].ToString());
            }
            sw.Close();
            this.Close();
        }
    }
}
