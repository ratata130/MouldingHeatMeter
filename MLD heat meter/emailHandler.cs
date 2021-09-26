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

namespace MLD_heat_meter
{
    public partial class emailHandler : Form
    {
        public emailHandler()
        {
            InitializeComponent();
        }
        public string emailFile = "email.txt";
        public void reLoadData()
        {
            try
            {
                var lines = File.ReadAllLines(emailFile);
                listBox1.Items.Clear();
                foreach (var line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }catch(Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            
        }

        public void writeData()
        {
            if (File.Exists(emailFile))
            {
                File.Delete(emailFile);
            }
            foreach (string line in listBox1.Items)
            {
                File.AppendAllText(emailFile, line + Environment.NewLine);
            }
            reLoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailHandler_Load(object sender, EventArgs e)
        {
            reLoadData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 9)
            {
                listBox1.Items.Add(textBox1.Text);
                writeData();
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                writeData();
            }
        }
    }
}
