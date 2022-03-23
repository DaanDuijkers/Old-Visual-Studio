using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //because we are using files

namespace AppAboutTextfiles
{
    public partial class Form1 : Form
    {
        private string filename = "../../myTest.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("You clicked cancel");
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btSaveToFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            saveFileDialog1.FileName = filename;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                filename = saveFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("You clicked cancel");
            }

            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
               
            }
            catch (IOException)
            {
                listBox1.Items.Add("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }

            listBox1.Items.Add("*************saving is done*********************");
        }

        private void btLoadFromFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                String s;
                s = sr.ReadLine();
                while (s != null)
                {
                    listBox1.Items.Add(s);
                    s = sr.ReadLine();
                }
            }
            catch (IOException)
            {
                listBox1.Items.Add("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            listBox1.Items.Add("*************loading is done*********************");
        }


    }
}
