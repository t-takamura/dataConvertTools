using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConvertTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string str = textBox1.Text;
            byte[] data = Encoding.GetEncoding("shift_jis").GetBytes(str);

            for (int i = 0; i < data.Length; i++)
            {
                label1.Text += Convert.ToString(data[i], 16);
            }
            Clipboard.SetText(label1.Text);
        }
    }
}
