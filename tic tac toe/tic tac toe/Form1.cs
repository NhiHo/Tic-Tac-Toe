using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        public int vt = -1;
        play pl = new play();
        bool turn = true;
        int turncount = 0;
        // tạo ra 2 danh sách tên và điểm
        public List<String> listname = new List<String>();
        public List<int> listdiem = new List<int>();
        public int high = 0;
         string ten;
        public string Ten
        {
            set { ten = value; }
            get { return ten; }

        }
        
        public Form1(play pl)
        {
            InitializeComponent();
            txtdiemNC1.Enabled = false;
            txtNC1.Text = pl.GetNC1;
            txtNC2.Text = pl.GetNC2;
            txtdiemNC1.Enabled = false;
            txtDiemHoa.Enabled = false;
            txtdiemNC2.Enabled = false;
            txtNC1.Enabled = false;
            txtNC2.Enabled = false;
            Highscore();
           

            // End();

        }

        private void abuotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Dương Hoàng Anh và Hồ Xuân Ý Nhi", "Tic Tac Toe");
        }

        private void button_enter(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            // Đánh X và O
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else b.Text = "O";
           
            turn = !turn;
            turncount++;
            b.Enabled = false;
            checkforwin();
            End();
        }
        private void checkforwin()
        {
            // kiểm tra xem ai thắng
            bool win = false;
            //hàng ngang win
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                win = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                win = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                win = true;
            }
            //hàng dọc win
           if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                win = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                win = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                win = true;
            }
            //hàng chéo
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                win = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                win = true;
            }

            if (win)
            {
                //kiểm tra kết quả để lưu điểm
                Button();
                string winter = "";
                if (turn)
                {

                
                    txtdiemNC2.Text = (Int32.Parse(txtdiemNC2.Text) + 1).ToString();
                   
                    MessageBox.Show(winter +txtNC2.Text +" "+ "Win", "Thông báo");
                }
                else
                {
                 
                   
                    txtdiemNC1.Text = (Int32.Parse(txtdiemNC1.Text) + 1).ToString();
                    string a = txtdiemNC2.Text;
                 
                    MessageBox.Show(winter + txtNC1.Text+ " "  + "Win", "Thông báo");
                }
                
                fileToolStripMenuItem.PerformClick();
            }
            else
            {
                if (turncount == 9)
                {
                    MessageBox.Show("Hòa ", "Thông báo");
                    txtDiemHoa.Text = (Int32.Parse(txtDiemHoa.Text) + 1).ToString();
                    fileToolStripMenuItem.PerformClick();
                }
            }
        }
        public void End()
        {
            // tính điểm chung cuộc
            if (txtdiemNC1.Text == "3")
      
            {
                MessageBox.Show(txtNC1.Text + "" + "Thắng chung cuộc");
                txtccNC1.Text = (Int32.Parse(txtccNC1.Text) + 1).ToString();
                txtdiemNC1.Text = 0.ToString();
                txtdiemNC2.Text = 0.ToString();
                txtDiemHoa.Text = 0.ToString();
            }
            if (txtdiemNC2.Text == "3")
            {
                MessageBox.Show(txtNC2.Text + "" + "Thắng chung cuộc");
                txtccNC2.Text = (Int32.Parse(txtccNC2.Text) + 1).ToString();
                txtdiemNC1.Text = 0.ToString();
                txtdiemNC2.Text = 0.ToString();
                txtDiemHoa.Text = 0.ToString();
            }
        }
    
        private void Button()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lưu kết quả 
            if (CheckHighScore() == true)
            {
                DialogResult dialogResult =
                    MessageBox.Show("Bạn có muốn lưu lại kết quả không?",
                    "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateScore();
                    Bangkq kq = new Bangkq(this);
                    kq.ShowDialog();
                }
            }
            DialogResult dialogResult1 =
                    MessageBox.Show("Bạn chắc chắn muốn thoát không?",
                    "Lưu ý", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes) Application.Exit();
            else return;
            Close();
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turncount = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }

            }
        }
        public void Highscore()
         {
            //truyền đường dẫn vào file để lưu kết quả vào file txt
             StreamReader reader = new StreamReader("D:\\test.txt");
             listname.Clear();
             listdiem.Clear();
             for (int i = 0; i <= 11; i++)
             {
                 listname.Add(reader.ReadLine());
                 listdiem.Add(int.Parse(reader.ReadLine()));
             }
             reader.Close();
         }
         public bool CheckHighScore()
         {
            //kiểm tra điểm cao để lưu kết quả
             vt = -1;
            if (Int32.Parse(txtccNC1.Text) > Int32.Parse(txtccNC2.Text))
            {
                high = Int32.Parse(txtccNC1.Text);
                ten = txtNC1.Text;
            }
            else { high = Int32.Parse(txtccNC2.Text); ten = txtNC2.Text; }
             for (int i = 0; i <= 11; i++)
             {
                 if (high > listdiem[i])
                 { vt = i; break; }

             }
             if (vt == -1)
                 return false;
             else
                 return true;
         }
         public void UpdateScore()
         {
            // cập nhật thông tin vào file điểm cao
             listname.Insert(vt, "Player");
             listdiem.Insert(vt, high);
             listname.RemoveAt(10);
             listdiem.RemoveAt(10);
         }
        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        { //hiển thị bảng kết quả
            Form2 frm = new Form2(this);
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
