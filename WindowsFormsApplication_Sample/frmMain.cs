using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tencent.YoutuYun.Common;
using Tencent.YoutuYun.Models.detectface;
using Tencent.YoutuYun.Models.facecompare;
using Tencent.YoutuYun.Models.faceshape;
using Tencent.YoutuYun.SDK;

namespace WindowsFormsApplication_Sample
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

        }

        private void btn_faceidentify_Click(object sender, EventArgs e)
        {

            string path = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string result = Youtu.faceshape(path);
            faceshapeResponse faceshape = JsonHelper<faceshapeResponse>.ToEntity(result);
            if (faceshape.errorcode == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = drawPorint(path, faceshape.face_shape[0]);
            }
            else
            {
                MessageBox.Show(faceshape.errormsg);
            }
        }
        /// <summary>
        /// 轮廓描绘
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="faceShape"></param>
        /// <returns></returns>
        Bitmap drawPorint(string Path, Face_Shape faceShape)
        {

            Bitmap bmp = new Bitmap(Path);
            Graphics g = Graphics.FromImage(bmp);
            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Red);
            int g_width = 3;
            int g_height = 3;
            faceShape.face_profile.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.left_eye.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.left_eyebrow.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.mouth.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.nose.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.right_eye.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            faceShape.right_eyebrow.ForEach(o =>
            {
                g.DrawEllipse(pen, o.x, o.y, g_width, g_height);
                g.FillEllipse(brush, o.x, o.y, g_width, g_height);
            });
            g.Dispose();
            return bmp;
        }
        private void btn_detectface_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string result = Youtu.detectface(path);
            detectfaceResponse faceshape = JsonHelper<detectfaceResponse>.ToEntity(result);
            if (faceshape.errorcode == 0)
            {
                string dis = "";

                System.Reflection.PropertyInfo[] properties = faceshape.face[0].GetType().GetProperties();
                foreach (System.Reflection.PropertyInfo prop in properties)
                {

                    dis += prop.Name + ":" + prop.GetValue(faceshape.face[0], null).ToString() + "\n";

                }
                MessageBox.Show(dis, "检测结果");
            }



        }

        private void btn_facecompare_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string result = Youtu.facecompareurl("http://open.youtu.qq.com/content/img/faceshape.jpg", "http://open.youtu.qq.com/content/img/faceshape.jpg");
            facecompareResponse faceshape = JsonHelper<facecompareResponse>.ToEntity(result);
            if (faceshape.errorcode == 0)
            {
                MessageBox.Show(faceshape.similarity.ToString("0.00"));
            }
            else
            {
                MessageBox.Show(faceshape.errormsg);
            }

        }
    }
}
