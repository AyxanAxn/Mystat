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

    public partial class UserControl1 : UserControl
    {
        // public static int num { get; set; } = 5;
        public bool check { get; set; } = false;
        public bool check2 { get; set; } = false;
        public string NameInUserC { get; set; }
        public string SurnameInUserC { get; set; }
        public string FatherUserC { get; set; }
        public DateTime LogInDate { get; set; }
        public Guna.UI2.WinForms.Guna2HtmlLabel Label { get; set; }
        public bool isInTheClass { set {
                InClassRdoBtn.Checked = value;
            } } 

        public Image Photo
        {
            set
            {
                SmallPictureBox.Image = value;
                BigPictureBox.Image = value;
            }
        }
        public UserControl1()
        {
            InitializeComponent();



            guna2TextBox1.Hide();
          
        }




        private void UserControl1_Load(object sender, EventArgs e)
        {

            guna2HtmlLabel7.Text = $"{NameInUserC} {SurnameInUserC} {FatherUserC}";
            guna2HtmlLabel1.Text = LogInDate.ToShortDateString();
        }

        private void ConfigureCrystalNum(int num)
        {
            int.TryParse(Label.Text, out int res);
            int first, second;
           

          
            first = num;
            res += num;
            Label.Text = res.ToString();
        }
        private int temp = 0;


        private void CheckImages(int num)
        {
            if (num == 3)
            {
                Diamondlbl1.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
                Diamondlbl2.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
                Diamondlbl3.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
            }
            else if (num == 2)
            {
                Diamondlbl1.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
                Diamondlbl2.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
                Diamondlbl3.Image = Properties.Resources.blackDiamond;
            }
            else if (num == 1)
            {
                Diamondlbl1.Image = Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png;
                Diamondlbl2.Image = Properties.Resources.blackDiamond;
                Diamondlbl3.Image = Properties.Resources.blackDiamond;
            }
            else
            {
                Diamondlbl1.Image = Properties.Resources.blackDiamond;
                Diamondlbl2.Image = Properties.Resources.blackDiamond;
                Diamondlbl3.Image = Properties.Resources.blackDiamond;
            }
        }
        private void Diamondlbl1_Click(object sender, EventArgs e)
        {
            int.TryParse(Label.Text, out int result);
            result += temp;
            if (result > 0 && Diamondlbl1.Image != Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png)
            {

                result -= 1;
                CheckImages(1);

                temp = 1;
                Label.Text = result.ToString();
            }
            else if (result < 1)
            {
                MessageBox.Show("you don't have enough crystals!",
"window title",
MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            }
        }
        private void Diamondlbl2_Click(object sender, EventArgs e)
        {
            int.TryParse(Label.Text, out int result);
            result += temp;
            if (result > 1 && Diamondlbl2.Image != Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png)
            {

                result -= 2;
                temp = 2;
                Label.Text = result.ToString();
                // ConfigureCrystalNum(2);
                CheckImages(2);
            }
            else if (result < 2)
            {
                MessageBox.Show("you don't have enough crystals!",
"window title",
MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            }
        }
        private void Diamondlbl3_Click(object sender, EventArgs e)
        {
            int.TryParse(Label.Text, out int result);
            result += temp;
            if (result >= 3 && Diamondlbl3.Image != Properties.Resources._12_126417_clipart_diamond_cute_mobile_legends_diamond_png)
            {
                result -= 3;

                CheckImages(3);
                temp = 3;
                Label.Text = result.ToString();
            }
            else if (result <= 2)
            {
                MessageBox.Show("you don't have enough crystals!",
"window title",
MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            int.TryParse(Label.Text, out int num);
            CheckImages(-1);
            num += temp;
            Label.Text = num.ToString();
            temp = 0;
        }



        private void SmallPictureBox_MouseHover(object sender, EventArgs e)
        {
            BigPictureBox.Visible = true;



        }


        private void SmallPictureBox_MouseLeave(object sender, EventArgs e)
        {
            BigPictureBox.Visible = false;
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            guna2ImageButton5.Hide();
            guna2TextBox1.Show();
        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = true;
            guna2ComboBox2.Enabled = true;
            Diamondlbl1.Enabled = true;
            Diamondlbl2.Enabled = true;
            Diamondlbl3.Enabled = true;

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.SelectedItem = default;
            guna2ComboBox2.SelectedItem = default;
            guna2ComboBox1.Enabled = false;
            guna2ComboBox2.Enabled = false;
            Diamondlbl1.Enabled = false;
            Diamondlbl2.Enabled = false;
            Diamondlbl3.Enabled = false;
            int.TryParse(Label.Text, out int num);
            CheckImages(-1);
            num += temp;
            Label.Text = num.ToString();
            temp = 0;


        }
    }
}
