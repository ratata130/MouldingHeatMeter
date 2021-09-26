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
    public partial class logViewer : Form
    {
        public logViewer()
        {
            InitializeComponent();
        }

        public string logFile = "MLD_HeatMonitor_log.txt";

        public void reLoadData()
        {
            try
            {
                var lines = File.ReadAllLines(logFile);
                listBox1.Items.Clear();
                foreach (var line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }

        }

        private void logViewer_Load(object sender, EventArgs e)
        {
            reLoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
