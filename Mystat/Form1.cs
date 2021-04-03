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
    
        public List<Info> student { get; set; }
        public UserControl1 user { get; set; }

        private readonly List<Bitmap> Images=new List<Bitmap>();
        public List<UserControl1> userControl1s = new List<UserControl1>();

        public Form1()
        {
           
            InitializeComponent();
            guna2Button1.Enabled = false;
            TopicTxtbpx.Enabled = false;
            guna2Button1.Enabled = false;
            guna2Button3.Enabled = false;
            guna2Button2.Enabled = false;


            Images.Add(Properties.Resources.user) ;
            Images.Add(Properties.Resources.user2) ;
            Images.Add(Properties.Resources.user) ;
            Images.Add(Properties.Resources.user2) ;
            Images.Add(Properties.Resources.user) ;


            student = new List<Info> {
            new Info{
                Name="Ayxan",
                Surname="Axundov",
                LogInDate=new DateTime(2018,04,28),
                Brithday=new DateTime(2001,06,06),
                FatherName="Aqil",
                
                },
                new Info{
                Name="Shemseddin",
                Surname="Axundov",
                FatherName="Aqil",
                Brithday=new DateTime(2002,06,13),
                LogInDate=new DateTime(2018,04,28),
                },
                 new Info{
                Name="Emin",
                Surname="Quluzade",
                FatherName="Ilqar",
                Brithday=new DateTime(2001,07,11),
                LogInDate=new DateTime(2018,04,28),
                },
                new Info{
                Name="Zaur",
                Surname="Ceferov",
                FatherName="Ceyhun",
                Brithday=new DateTime(2001,06,12),
                LogInDate=new DateTime(2001,06,12),
                },
                new Info{
                Name="Arifeli",
                Surname="Bagirli",
                FatherName="Father",
                Brithday=new DateTime(2018,04,28),
                LogInDate=new DateTime(2018,04,28),
                }
            };


          
            for (int i = 0; i < student.Count; i++)
            {

                var userControl = new UserControl1();
                userControl.NameInUserC = student[i].Name;
                userControl.SurnameInUserC = student[i].Surname;
                userControl.LogInDate = student[i].LogInDate;
                //userContri].Image = student[i].Photo;
                userControl.Label = DiamondLbl;
                userControl.Photo = Images[i];
                userControl1s.Add(userControl);
                flowLayoutPanel1.Controls.Add(userControl1s[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // DiamondLbl.Text = user.num.ToString();
            


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {



        }

        private void Diamondlbl2_MouseMove(object sender, MouseEventArgs e)
        {
            //user.Diamondlbl1.Checked = true;
            //user.Diamondlbl1.ImageSize = new System.Drawing.Size(22, 22);
        }

        private void Diamondlbl2_MouseLeave(object sender, EventArgs e)
        {
           // user.Diamondlbl1.Checked = false;

        }

        private void Diamondlbl3_Move(object sender, EventArgs e)
        {

        }

        private void Diamondlbl3_MouseLeave(object sender, EventArgs e)
        {
            //user.Diamondlbl1.Checked = false;
            //user.Diamondlbl2.Checked = false;
        }

        private void Diamondlbl3_MouseMove(object sender, MouseEventArgs e)
        {

            //user.Diamondlbl1.Checked = true;
            //user.Diamondlbl2.Checked = true;
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            user.guna2ImageButton5.Hide();
            user.guna2TextBox1.Show();

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
            user.guna2ImageButton5.Show();
            user.guna2TextBox1.Hide();
        }

        private void coreteacherLbl_CheckedChanged(object sender, EventArgs e)
        {

            if (coreteacherLbl.Checked == true)
            {
                guna2Button1.Enabled = true;
                TopicTxtbpx.Enabled  = true;
                guna2Button1.Enabled = true;
                guna2Button3.Enabled = true;
                guna2Button2.Enabled = true;
            }
            else if (coreteacherLbl.Checked == false)
            {
                guna2Button1.Enabled = false;
                TopicTxtbpx.Enabled  = false;
                guna2Button1.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button2.Enabled = false;
            }

        }
        


        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            userControl1s.ForEach(uc=>uc.isInTheClass=true);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string aaa;
            aaa= TopicTxtbpx.Text;
            mainTopicLbl.Text += $" {aaa}";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            TopicTxtbpx.Text = "";

        }
    }
}
