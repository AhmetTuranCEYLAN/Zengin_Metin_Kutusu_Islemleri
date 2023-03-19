using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zengin_Metin_Kutusu_İslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in richTextBox1.Lines)
            {
                listBox1.Items.Add(item);

                foreach (var item2 in listBox1.Items)
                {
                    listBox1.ForeColor = Color.CadetBlue;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();

            foreach (var item in listBox1.Items)
            {
                if (cl.ShowDialog()==DialogResult.OK)
                {
                    listBox1.ForeColor = cl.Color;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo dizin = new DirectoryInfo(@"C:\Users\toshıba\Desktop\Resimlerim");
            FileInfo[] dosya = dizin.GetFiles();

            foreach (FileInfo item in dosya)
            {
               
                if (item.Extension==".png"||item.Extension==".jpg")
                {
                    Image im = Image.FromFile(item.FullName);
                    Clipboard.SetImage(im);
                    richTextBox1.Paste();
             
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control i in this.Controls)
            {
                if (i is RichTextBox)
                {
                    RichTextBox rb = (RichTextBox)i;
                    rb.Text = "";
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                richTextBox1.Text += item + "\n";
            }    
        }
    }
}
