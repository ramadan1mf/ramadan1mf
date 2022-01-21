using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace التقاط_صورة
{
    public partial class btnclear : Form
    {
        public btnclear()
        {
            InitializeComponent();
            InitializeComponent();
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(150, 10);
            Point p2 = new Point(90, 90);
            this.CreateGraphics().DrawLine(Pens.Red, p1, p2);

            Point p1_2 = new Point(150, 10);
            Point p2_2 = new Point(200, 90);
            this.CreateGraphics().DrawLine(Pens.Red, p1_2, p2_2);


            Point p1_3 = new Point(200, 90);
            Point p2_3 = new Point(90, 90);
            this.CreateGraphics().DrawLine(Pens.Red, p1_3, p2_3);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Point p1_4 = new Point(200, 90);
            Point p2_4 = new Point(90, 90);
            this.CreateGraphics().DrawLine(Pens.Red, p1_4, p2_4);
        }

        private void line2_Click(object sender, EventArgs e)
        {
            Point p1_4 = new Point(200, 90);
            Point p2_4 = new Point(90, 90);
            this.CreateGraphics().DrawLine(Pens.Red, p1_4, p2_4);

        }

        private void btnrec_Click(object sender, EventArgs e)
        {

            this.CreateGraphics().DrawRectangle(Pens.Red, 30, 40, 250, 150);
            this.CreateGraphics().DrawRectangle(Pens.Blue, 30, 300, 250, 150);
        }

        private void rectp_Click(object sender, EventArgs e)
        {
            Point p1_5 = new Point(30, 90);
            Point p1_6 = new Point(279, 90);

            this.CreateGraphics().DrawLine(Pens.Brown, p1_5, p1_6);
            this.CreateGraphics().DrawRectangle(Pens.Red, 30, 40, 250, 150);

            Point n1 = new Point(70, 40);
            Point n2 = new Point(70, 90);


            this.CreateGraphics().DrawLine(Pens.Red, n1, n2);

        }

        private void btnpie_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPie(Pens.Red, 20, 40, 200, 200, 5, 360);//عمل دائرة
        }

        private void nuup_ValueChanged(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);

            this.CreateGraphics().DrawPie(Pens.Black, 20, 40, 200, 200, 10, (float)numericUpDown1.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPie(Pens.Black, 20, 40, 20, 20, 10,(float)numericUpDown1.Value);
        }

        private void btnpolygon_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(30, 50);
            Point p2 = new Point(120, 200);
            Point p3 = new Point(60, 250);
            Point P4 = new Point(90, 350);
            Point[] allp = { p1, p2, p3, P4 };
            this.CreateGraphics().DrawPolygon(Pens.Red, allp);

        }

        private void btnsaham_Click(object sender, EventArgs e)
        {
            Point p11 = new Point(20, 40);
            Point p22 = new Point(40, 30);
            Point p33 = new Point(40, 40);
            Point P44 = new Point(100, 40);
            Point p55 = new Point(100, 45);
            Point p66 = new Point(40, 45);
            Point p77 = new Point(40, 55);

            Point[] allp1 = { p11, p22, p33, P44, p55, p66, p77 };
            this.CreateGraphics().DrawPolygon(Pens.Red, allp1);

        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawImage(Properties.Resources.ram, 10, 10, 90, 90);
        }



        private void btnstring_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            Font myfont = new Font("tahoma", 50, FontStyle.Bold);
            Point p = new Point(20, 30);

            this.CreateGraphics().DrawString(str, myfont, Brushes.Red, p);
            SizeF strsize = this.CreateGraphics().MeasureString(str, myfont);

            this.CreateGraphics().FillRectangle(Brushes.Gold, 20 + strsize.Width, 30, 200, 100);
        }

        private void btnmath_Click(object sender, EventArgs e)
        {
            txtmath.Text = Math.PI + "";
        }

        private void btnshowsal_Click(object sender, EventArgs e)
        {
            double ahmed = 150;
            double amr = 210;
            double moha = 220;
            double aahmed = 230;
            double aamr = 240;
            double amoha = 250;

            double total = ahmed + amr + moha+ aahmed + aamr + amoha;
            double ahmedp = Math.Round((ahmed / total) * 100);
            double amrp = Math.Round((amr / total) * 100);
            double mohap = Math.Round((moha / total) * 100);
            double aahmedp = Math.Round((aahmed / total) * 100);
            double aamrp = Math.Round((aamr / total) * 100);
            double amohap = Math.Round((amoha / total) * 100);

             MessageBox.Show(ahmedp + "   ;  " + amrp + "  ;  " + mohap+ aahmedp + "   ;  " +aamrp + "  ;  " + amohap);
            int ahmedpPie = (int)Math.Round((ahmedp*360)/100);
            int amrpPie = (int)Math.Round((amrp * 360) / 100);
            int mohapPie = (int)Math.Round((mohap * 360) / 100);
            int aahmedpPie = (int)Math.Round((aahmedp * 360) / 100);
            int aamrpPie = (int)Math.Round((aamrp * 360) / 100);
            int amohapPie = (int)Math.Round((amohap * 360) / 100);

             MessageBox.Show(ahmedpPie + "   ;  " + amrpPie + "  ;  " + mohapPie+ aahmedpPie + "   ;  " + aamrpPie + "  ;  " + amohapPie);
            this.CreateGraphics().FillPie(Brushes.Black , 10, 20, 100, 100, 0 , ahmedpPie);
            this.CreateGraphics().FillPie(Brushes.Firebrick, 10, 20, 100, 100,ahmedpPie,amrpPie);
            this.CreateGraphics().FillPie(Brushes.Blue, 10, 20, 100, 100, ahmedpPie+ amrpPie,aahmedpPie);
            this.CreateGraphics().FillPie(Brushes.Red, 10, 20, 100, 100, ahmedpPie + amrpPie+ aahmedpPie,amohapPie);
            this.CreateGraphics().FillPie(Brushes.BlueViolet, 10, 20, 100, 100, ahmedpPie + amrpPie + aahmedpPie+ amohapPie,mohapPie);
            this.CreateGraphics().FillPie(Brushes.DarkGoldenrod, 10, 20, 100, 100, ahmedpPie + amrpPie + aahmedpPie + amohapPie+ mohapPie,aamrpPie);


        }

        private void btngradrect_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(20, 0);
            Point p2 = new Point(220, 0);
            LinearGradientBrush gb = new LinearGradientBrush(p1, p2, Color.DarkBlue,Color.AliceBlue);

            this.CreateGraphics().FillRectangle(gb,20,20,200,200);
        }

        private void ptnpt_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnprintf_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog3.ShowDialog()==DialogResult.OK)
            {

                printDocument2.Print();

            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //طباعة الشاشة

            int w = this.Width + 20;
            int h = this.Height + 30;
            e.PageSettings.Landscape = true;
            e.PageSettings.PaperSize = new PaperSize("Mypaber", h, w);

            Bitmap bmp = new Bitmap( w , h);
            Rectangle rec = new Rectangle(0, 0, w, h);
            this.DrawToBitmap(bmp, rec);
            e.Graphics.DrawImage(bmp, rec);
        }

        private void btnclear_Load(object sender, EventArgs e)
        {
            printDocument2.DefaultPageSettings.PaperSize = new PaperSize("Mypaber", this.Height, this.Width);
            printDocument2.DefaultPageSettings.Landscape = true;
       
        }

        private void btnptscreen_Click(object sender, EventArgs e)
        {
            int ynow = this.Top;
            this.Top = Screen.PrimaryScreen.Bounds.Height + 1000;


            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grf = Graphics.FromImage(bmp);
            //grf.CopyFromScreen(Screen.PrimaryScreen.Bounds.Width/2, 0, 0, 0, bmp.Size);
            grf.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            bmp.Save("mypic.jpg", System.Drawing.Imaging.ImageFormat.Icon);
            System.Diagnostics.Process.Start("mypic.jpg");

            this.Top = ynow;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
                   
    }
  


