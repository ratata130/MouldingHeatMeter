using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Net.Mail;
using System.Net;
using System.IO;

namespace MLD_heat_meter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int HEAT_TRESHOLD = 30; //max temperature
        public const int HEAT_TIME_TRESHOLD = 7200; //1 hour in seconds - 3600

        //-----FOR MOVABLE WINDOW-----//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //-----DECLARING-----//
        string[,,] currentDownload = new string[4, 8, 4];

        public Label[] labelArray = new Label[32]; //array for data labels
        public Label[] labelAvgArray = new Label[4]; //array for AVG data arrays
        public object[,] panelData = new object[4,3]; //array for the green panels (for color changing)
        public int[] aboveTresholdSec = new int[] { 0, 0, 0, 0 }; //array for storing the AVG temperature for the modules
        public string emailAddressFrom = "hu2kiosk@lego.com";
        public string[] emailList;
        public string emailFile = "email.txt";
        public bool emailSent = false;


        public string getData()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HUAHONENER;User ID=PointViewer;Password=Lego2017");
                SqlCommand cmd = new SqlCommand("SELECT * FROM [hwreportsview].[dbo].[MLD_Points_View] WHERE PointName LIKE 'HU2101%' OR PointName LIKE 'HU2102%' OR PointName LIKE 'HU2108%' OR PointName LIKE 'HU2109%'");
                con.Open();
                cmd.Connection = con;
                int id = 71;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    for (int j = 0;j<4;j++)
                        {
                            for(int k = 0;k<8;k++)
                            {
                                reader.Read();
                                if (reader["PointName"].ToString() != "HU2109AHT01TAR01_M.PointValue" || reader["PointName"].ToString() != "HU2108AHT01TAR01_M.PointValue")
                            {
                                    if (id == 87)
                                    {
                                        id = 115;
                                    }
                                    if (id == 123)
                                    {
                                        id++;
                                    }
                                    currentDownload[j, k, 0] = Convert.ToString(id);
                                    currentDownload[j, k, 1] = Convert.ToString(reader["PointName"]);
                                    currentDownload[j, k, 2] = Convert.ToString(reader["Value"]);
                                    currentDownload[j, k, 3] = Convert.ToString(reader["TimeStamp"]);
                                    id++;
                                
                                }
                                else
                                {
                                k--;
                                id--;  
                                }
                            }
                        }
                    }
                con.Close();
                return "completed";
            }
            catch (SqlException e)
            {
                //MessageBox.Show("getData_" + e.Message);
                logger("getData_" + e.Message);
                return "failed";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                logger("getData_" + ex.Message);
                return "failed";
            }
        }

        public void logger(string logData)
        {
            string logTime = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            string outString = logTime + " :        " + logData;

            File.AppendAllText("MLD_HeatMonitor_log.txt", outString + Environment.NewLine);
        }

        

        public void readEmailList()
        {
            int i = 0;
            try
            {
                var lines = File.ReadAllLines(emailFile);
                emailList = new string[lines.Length];
                foreach (var line in lines)
                {
                    emailList[i] = line;
                    i++;
                }
            }
            catch (Exception e)
            {
                logger(e.Message);
                MessageBox.Show("readEmailList_" + e.Message);
            }
        }

        public void dataHandler(string ret)
        {
            if (ret == "completed")
            {
                int k = 0;
                for (int i = 0; i < 4; i++)
                {
                    double avgTemp = 0.0;
                    for (int j = 0; j < 8; j++)
                    {
                        Label temp = labelArray[k];
                        temp.Text = "ID: " + currentDownload[i, j, 0] + Environment.NewLine + currentDownload[i, j, 2] + "°C";
                        temp.BackColor = Color.Transparent;
                        toolTip1.SetToolTip(temp, currentDownload[i, j, 1]);
                        avgTemp += Convert.ToDouble(currentDownload[i, j, 2]);
                        k++;
                    }
                    Label avgTempLabel = labelAvgArray[i];
                    avgTemp /= 8;
                    avgTempLabel.Text = "Modul átlag: " + avgTemp.ToString("0.##") + "°C";
                    avgTempLabel.Tag = avgTemp.ToString("0.##");
                }
                label3.Text = "Frissítve: " + labelDate.Text;
            }

        }

        public string timeShow(int sec)
        {
            TimeSpan t = TimeSpan.FromSeconds(sec);
            string timeData = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds,
                t.Milliseconds);
            return timeData;
        }

        public string sendEmail(string body)
        {
            try
            {

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = false;
                mail.Body = body;
                mail.From = new MailAddress(emailAddressFrom, "NoReply - MLD hőmérséklet riasztás");
                foreach (string email in emailList)
                {
                    mail.To.Add(email);
                }
                mail.Subject = "MLD hőmérséklet riasztás - " + DateTime.Now.Year + ". " + DateTime.Now.Month + ". " + DateTime.Now.Day + ". " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                mail.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = true;
                smtp.Host = "smtp2.corp.lego.com";
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("sendMail_" + e.Message);
            }
            return "Figyelmeztető email elküldve!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readEmailList();
            labelDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            labelArray = new Label[] { labelID1, labelID2, labelID3, labelID4, labelID5, labelID6, labelID7, labelID8, labelID9, labelID10, labelID11, labelID12, labelID13, labelID14, labelID15, labelID16, labelID17, labelID18, labelID19, labelID20, labelID21, labelID22, labelID23, labelID24, labelID25, labelID26, labelID27, labelID28, labelID29, labelID30, labelID31, labelID32 };
            labelAvgArray = new Label[] {labelAVG1,labelAVG2, labelAVG3, labelAVG4 };
            panelData[0, 0] = panel1;panelData[0, 1] = 0; panelData[0, 2] = labelSec1;
            panelData[1, 0] = panel2; panelData[1, 1] = 0; panelData[1, 2] = labelSec2;
            panelData[2, 0] = panel3; panelData[2, 1] = 0; panelData[2, 2] = labelSec3;
            panelData[3, 0] = panel4; panelData[3, 1] = 0; panelData[3, 2] = labelSec4;

            dataHandler(getData());
            timer1.Start();
            logger("***********Application started***********");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos, hogy be szeretnéd zárni a monitorozást?", "Bezárás?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                logger("***********Application closed***********");
                Application.Exit();
            }
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos, hogy be szeretnéd zárni a monitorozást?", "Bezárás?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                logger("***********Application closed***********");
                Application.Exit();
            }

            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            if(DateTime.Now.Second == 30) dataHandler(getData());

            int i = 0;
            foreach(Label temp in labelAvgArray)
            {
                Panel tempPanel = (Panel)panelData[i, 0];
                Label tempLabel = (Label)panelData[i, 2];
                if (Convert.ToDouble(temp.Tag) > HEAT_TRESHOLD)
                {
                    if(aboveTresholdSec[i] == 0)
                    {
                        tempPanel.BackColor = Color.Red;
                        aboveTresholdSec[i]++;
                        tempLabel.Text = timeShow(aboveTresholdSec[i]);
                        tempLabel.Visible = true;
                        logger("Magas átlaghőmérséklet a(z) " + i + i + " modulban. Számláló elindítva!");
                    }
                    else
                    {
                        if (aboveTresholdSec[i] == HEAT_TIME_TRESHOLD)
                        {
                            readEmailList();
                            string body = "Kedves címzett! " + Environment.NewLine + Environment.NewLine + "A következő területen tartósan 30°C felett volt a hőmérséklet az elmúlt két órában:";
                            body += Environment.NewLine + "- Modul " + (i + 1).ToString() + " (Átlag hőmérséklet: " + temp + "°C)";
                            tempLabel.Text = sendEmail(body);
                            aboveTresholdSec[i]++;
                            logger("Figyelmeztető email elkülve a(z) " + i + 1 + "modul tartósan magas hőmérséklete miatt!");
                        }
                        else
                        {
                            if (tempLabel.Text != "Figyelmeztető email elküldve!")
                            {
                                aboveTresholdSec[i]++;
                                tempLabel.Text = timeShow(aboveTresholdSec[i]);
                                tempLabel.Visible = true;
                            }
                        }
                    }
                    if(tempPanel.BackColor == Color.Red)
                    {
                        tempPanel.BackColor = Color.Orange;
                    }
                    else
                    {
                        tempPanel.BackColor = Color.Red;
                    }
                }
                else
                {
                    if (aboveTresholdSec[i] > 0)
                    {
                        tempPanel.BackColor = Color.DarkGreen;
                        tempLabel.Visible = false;
                        logger("Az átlaghőmérséklet a(z) " + i + i + " modulban újra 30°C alatti. Eltelt idő: " + timeShow(aboveTresholdSec[i]));
                        string body = "Kedves címzett! " + Environment.NewLine + Environment.NewLine + "A következő területen vissza a magas hőmérsékleti jelzés véget ért:";
                        body += Environment.NewLine + "- Modul " + (i + 1).ToString() + " (Átlag hőmérséklet: " + temp.Tag + "°C)";
                        
                        aboveTresholdSec[i] = 0;
                        if(emailSent)
                        {
                            sendEmail(body);
                            emailSent = false;
                        }
                    }
                }
                i++;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            emailHandler emailWindow = new emailHandler();
            emailWindow.Show();
        }

        private void labelID10_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            logViewer logs = new logViewer();
            logs.Show();
        }
    }
}
