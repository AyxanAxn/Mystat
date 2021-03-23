using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mystat
{
    public partial class Form1 : Form
    {
        private Panel CreateNewPanel(int studentNum) {
            var newUserPanel = new Panel();
            newUserPanel.BackColor = Color.Red;
            newUserPanel.Size = new Size(1331, 100);
            int a=348;
            newUserPanel.Location = new Point(0, a );
            a += 106;
            newUserPanel.Name = $"UserPanel{studentNum}";
            this.Controls.Add(newUserPanel);


            var newLabel = new Label();
            newLabel.ForeColor = Color.Blue;
           // newLabel





            return newUserPanel;
            
        }


        public Form1()
        {
            InitializeComponent();
            guna2TextBox1.Hide();
           // string[] a= {};
           // for (int i = 1; i <= 12; i++)
           // {
           //     a[i] =  i.ToString();
           // }
           // guna2ComboBox1.Items.AddRange(a);
           //// guna2ComboBox1.Items.Add();
           // for (int i = 0; i < 3; i++)
           // {
           // CreateNewPanel(i);
           // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void Diamondlbl2_MouseMove(object sender, MouseEventArgs e)
        {
            Diamondlbl1.Checked = true;
            Diamondlbl1.ImageSize=new System.Drawing.Size(22,22);
        }

        private void Diamondlbl2_MouseLeave(object sender, EventArgs e)
        {
            Diamondlbl1.Checked = false;

        }

        private void Diamondlbl3_Move(object sender, EventArgs e)
        {

        }

        private void Diamondlbl3_MouseLeave(object sender, EventArgs e)
        {
            Diamondlbl1.Checked = false;
            Diamondlbl2.Checked = false;
        }

        private void Diamondlbl3_MouseMove(object sender, MouseEventArgs e)
        {

            Diamondlbl1.Checked = true;
            Diamondlbl2.Checked = true;
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            guna2ImageButton5.Hide();
            guna2TextBox1.Show();

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            //guna2ImageButton5.Show();
            //guna2TextBox1.Hide();
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            //guna2ImageButton5.Show();
            //guna2TextBox1.Hide();
        }

        private void guna2TextBox1_MouseEnter(object sender, EventArgs e)
        {
            guna2ImageButton5.Show();
            guna2TextBox1.Hide();
        }

      
        private void Diamondlbl1_Click(object sender, EventArgs e)
        {
            int num = 5;
            num-= 1;
            DiamondLbl.Text = num.ToString();
            Diamondlbl1.Checked = true;
        }

        private void Diamondlbl2_Click(object sender, EventArgs e)
        {
            int num = 5;
            num -= 2;
            DiamondLbl.Text = num.ToString();
            Diamondlbl1.Checked = true;
            Diamondlbl2.Checked = true;
        }

        private void Diamondlbl3_Click(object sender, EventArgs e)
        {
            int num = 5;
            num -= 3;
            DiamondLbl.Text = num.ToString();
            Diamondlbl1.Checked = true;
            Diamondlbl2.Checked = true;
            Diamondlbl3.Checked = true;
        }
    }
}
