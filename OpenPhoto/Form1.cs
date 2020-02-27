using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OpenPhoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] pictureBytes;
        //定义按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.JPG|*.gif|*.GIF|*.bmp|*.BMP";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog1.FileName;
                FileStream fs = new FileStream(fullPath, FileMode.Open);
                pictureBytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                pictureBytes = br.ReadBytes(Convert.ToInt32(fs.Length));
                MemoryStream ms = new MemoryStream(pictureBytes);
                Bitmap bmpt = new Bitmap(ms);
                //显示图片
                showPicBox.Image = bmpt;
            }
            else
            {
                MessageBox.Show("图片打开失败");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
