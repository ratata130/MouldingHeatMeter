namespace MLD_heat_meter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAVG1 = new System.Windows.Forms.Label();
            this.labelID8 = new System.Windows.Forms.Label();
            this.labelID4 = new System.Windows.Forms.Label();
            this.labelID3 = new System.Windows.Forms.Label();
            this.labelID7 = new System.Windows.Forms.Label();
            this.labelID2 = new System.Windows.Forms.Label();
            this.labelID6 = new System.Windows.Forms.Label();
            this.labelID5 = new System.Windows.Forms.Label();
            this.labelID1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAVG2 = new System.Windows.Forms.Label();
            this.labelID16 = new System.Windows.Forms.Label();
            this.labelID12 = new System.Windows.Forms.Label();
            this.labelID11 = new System.Windows.Forms.Label();
            this.labelID15 = new System.Windows.Forms.Label();
            this.labelID10 = new System.Windows.Forms.Label();
            this.labelID14 = new System.Windows.Forms.Label();
            this.labelID13 = new System.Windows.Forms.Label();
            this.labelID9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAVG3 = new System.Windows.Forms.Label();
            this.labelID24 = new System.Windows.Forms.Label();
            this.labelID20 = new System.Windows.Forms.Label();
            this.labelID19 = new System.Windows.Forms.Label();
            this.labelID23 = new System.Windows.Forms.Label();
            this.labelID18 = new System.Windows.Forms.Label();
            this.labelID22 = new System.Windows.Forms.Label();
            this.labelID21 = new System.Windows.Forms.Label();
            this.labelID17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelAVG4 = new System.Windows.Forms.Label();
            this.labelID32 = new System.Windows.Forms.Label();
            this.labelID28 = new System.Windows.Forms.Label();
            this.labelID27 = new System.Windows.Forms.Label();
            this.labelID31 = new System.Windows.Forms.Label();
            this.labelID26 = new System.Windows.Forms.Label();
            this.labelID30 = new System.Windows.Forms.Label();
            this.labelID29 = new System.Windows.Forms.Label();
            this.labelID25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSec1 = new System.Windows.Forms.Label();
            this.labelSec2 = new System.Windows.Forms.Label();
            this.labelSec3 = new System.Windows.Forms.Label();
            this.labelSec4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MLD Hőmérséklet monitorozás";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.labelAVG1);
            this.panel1.Controls.Add(this.labelID8);
            this.panel1.Controls.Add(this.labelID4);
            this.panel1.Controls.Add(this.labelID3);
            this.panel1.Controls.Add(this.labelID7);
            this.panel1.Controls.Add(this.labelID2);
            this.panel1.Controls.Add(this.labelID6);
            this.panel1.Controls.Add(this.labelID5);
            this.panel1.Controls.Add(this.labelID1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 302);
            this.panel1.TabIndex = 3;
            // 
            // labelAVG1
            // 
            this.labelAVG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVG1.ForeColor = System.Drawing.Color.White;
            this.labelAVG1.Location = new System.Drawing.Point(3, 122);
            this.labelAVG1.Name = "labelAVG1";
            this.labelAVG1.Size = new System.Drawing.Size(263, 25);
            this.labelAVG1.TabIndex = 9;
            this.labelAVG1.Text = "Modul átlag: <temp>";
            this.labelAVG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID8
            // 
            this.labelID8.AutoSize = true;
            this.labelID8.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID8.ForeColor = System.Drawing.Color.White;
            this.labelID8.Location = new System.Drawing.Point(207, 192);
            this.labelID8.Name = "labelID8";
            this.labelID8.Size = new System.Drawing.Size(60, 32);
            this.labelID8.TabIndex = 8;
            this.labelID8.Text = "ID: <id>\r\n<temp>";
            this.labelID8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID4
            // 
            this.labelID4.AutoSize = true;
            this.labelID4.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID4.ForeColor = System.Drawing.Color.White;
            this.labelID4.Location = new System.Drawing.Point(71, 255);
            this.labelID4.Name = "labelID4";
            this.labelID4.Size = new System.Drawing.Size(60, 32);
            this.labelID4.TabIndex = 4;
            this.labelID4.Text = "ID: <id>\r\n<temp>";
            this.labelID4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID3
            // 
            this.labelID3.AutoSize = true;
            this.labelID3.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID3.ForeColor = System.Drawing.Color.White;
            this.labelID3.Location = new System.Drawing.Point(71, 47);
            this.labelID3.Name = "labelID3";
            this.labelID3.Size = new System.Drawing.Size(60, 32);
            this.labelID3.TabIndex = 3;
            this.labelID3.Text = "ID: <id>\r\n<temp>";
            this.labelID3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID7
            // 
            this.labelID7.AutoSize = true;
            this.labelID7.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID7.ForeColor = System.Drawing.Color.White;
            this.labelID7.Location = new System.Drawing.Point(207, 47);
            this.labelID7.Name = "labelID7";
            this.labelID7.Size = new System.Drawing.Size(60, 32);
            this.labelID7.TabIndex = 7;
            this.labelID7.Text = "ID: <id>\r\n<temp>";
            this.labelID7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID2
            // 
            this.labelID2.AutoSize = true;
            this.labelID2.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID2.ForeColor = System.Drawing.Color.White;
            this.labelID2.Location = new System.Drawing.Point(5, 192);
            this.labelID2.Name = "labelID2";
            this.labelID2.Size = new System.Drawing.Size(60, 32);
            this.labelID2.TabIndex = 2;
            this.labelID2.Text = "ID: <id>\r\n<temp>";
            this.labelID2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID6
            // 
            this.labelID6.AutoSize = true;
            this.labelID6.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID6.ForeColor = System.Drawing.Color.White;
            this.labelID6.Location = new System.Drawing.Point(139, 192);
            this.labelID6.Name = "labelID6";
            this.labelID6.Size = new System.Drawing.Size(60, 32);
            this.labelID6.TabIndex = 6;
            this.labelID6.Text = "ID: <id>\r\n<temp>";
            this.labelID6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID5
            // 
            this.labelID5.AutoSize = true;
            this.labelID5.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID5.ForeColor = System.Drawing.Color.White;
            this.labelID5.Location = new System.Drawing.Point(139, 47);
            this.labelID5.Name = "labelID5";
            this.labelID5.Size = new System.Drawing.Size(60, 32);
            this.labelID5.TabIndex = 5;
            this.labelID5.Text = "ID: <id>\r\n<temp>";
            this.labelID5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID1
            // 
            this.labelID1.AutoSize = true;
            this.labelID1.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID1.ForeColor = System.Drawing.Color.White;
            this.labelID1.Location = new System.Drawing.Point(3, 47);
            this.labelID1.Name = "labelID1";
            this.labelID1.Size = new System.Drawing.Size(60, 32);
            this.labelID1.TabIndex = 1;
            this.labelID1.Text = "ID: <id>\r\n<temp>";
            this.labelID1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modul 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.labelAVG2);
            this.panel2.Controls.Add(this.labelID16);
            this.panel2.Controls.Add(this.labelID12);
            this.panel2.Controls.Add(this.labelID11);
            this.panel2.Controls.Add(this.labelID15);
            this.panel2.Controls.Add(this.labelID10);
            this.panel2.Controls.Add(this.labelID14);
            this.panel2.Controls.Add(this.labelID13);
            this.panel2.Controls.Add(this.labelID9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(298, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 302);
            this.panel2.TabIndex = 10;
            // 
            // labelAVG2
            // 
            this.labelAVG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVG2.ForeColor = System.Drawing.Color.White;
            this.labelAVG2.Location = new System.Drawing.Point(3, 124);
            this.labelAVG2.Name = "labelAVG2";
            this.labelAVG2.Size = new System.Drawing.Size(266, 25);
            this.labelAVG2.TabIndex = 9;
            this.labelAVG2.Text = "Modul átlag: <temp>";
            this.labelAVG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID16
            // 
            this.labelID16.AutoSize = true;
            this.labelID16.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID16.ForeColor = System.Drawing.Color.White;
            this.labelID16.Location = new System.Drawing.Point(207, 192);
            this.labelID16.Name = "labelID16";
            this.labelID16.Size = new System.Drawing.Size(60, 32);
            this.labelID16.TabIndex = 8;
            this.labelID16.Text = "ID: <id>\r\n<temp>";
            this.labelID16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID12
            // 
            this.labelID12.AutoSize = true;
            this.labelID12.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID12.ForeColor = System.Drawing.Color.White;
            this.labelID12.Location = new System.Drawing.Point(71, 192);
            this.labelID12.Name = "labelID12";
            this.labelID12.Size = new System.Drawing.Size(60, 32);
            this.labelID12.TabIndex = 4;
            this.labelID12.Text = "ID: <id>\r\n<temp>";
            this.labelID12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID11
            // 
            this.labelID11.AutoSize = true;
            this.labelID11.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID11.ForeColor = System.Drawing.Color.White;
            this.labelID11.Location = new System.Drawing.Point(71, 47);
            this.labelID11.Name = "labelID11";
            this.labelID11.Size = new System.Drawing.Size(60, 32);
            this.labelID11.TabIndex = 3;
            this.labelID11.Text = "ID: <id>\r\n<temp>";
            this.labelID11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID15
            // 
            this.labelID15.AutoSize = true;
            this.labelID15.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID15.ForeColor = System.Drawing.Color.White;
            this.labelID15.Location = new System.Drawing.Point(207, 47);
            this.labelID15.Name = "labelID15";
            this.labelID15.Size = new System.Drawing.Size(60, 32);
            this.labelID15.TabIndex = 7;
            this.labelID15.Text = "ID: <id>\r\n<temp>";
            this.labelID15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID10
            // 
            this.labelID10.AutoSize = true;
            this.labelID10.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID10.ForeColor = System.Drawing.Color.White;
            this.labelID10.Location = new System.Drawing.Point(5, 192);
            this.labelID10.Name = "labelID10";
            this.labelID10.Size = new System.Drawing.Size(60, 32);
            this.labelID10.TabIndex = 2;
            this.labelID10.Text = "ID: <id>\r\n<temp>";
            this.labelID10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelID10.Click += new System.EventHandler(this.labelID10_Click);
            // 
            // labelID14
            // 
            this.labelID14.AutoSize = true;
            this.labelID14.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID14.ForeColor = System.Drawing.Color.White;
            this.labelID14.Location = new System.Drawing.Point(139, 255);
            this.labelID14.Name = "labelID14";
            this.labelID14.Size = new System.Drawing.Size(60, 32);
            this.labelID14.TabIndex = 6;
            this.labelID14.Text = "ID: <id>\r\n<temp>";
            this.labelID14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID13
            // 
            this.labelID13.AutoSize = true;
            this.labelID13.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID13.ForeColor = System.Drawing.Color.White;
            this.labelID13.Location = new System.Drawing.Point(139, 47);
            this.labelID13.Name = "labelID13";
            this.labelID13.Size = new System.Drawing.Size(60, 32);
            this.labelID13.TabIndex = 5;
            this.labelID13.Text = "ID: <id>\r\n<temp>";
            this.labelID13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID9
            // 
            this.labelID9.AutoSize = true;
            this.labelID9.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID9.ForeColor = System.Drawing.Color.White;
            this.labelID9.Location = new System.Drawing.Point(3, 47);
            this.labelID9.Name = "labelID9";
            this.labelID9.Size = new System.Drawing.Size(60, 32);
            this.labelID9.TabIndex = 1;
            this.labelID9.Text = "ID: <id>\r\n<temp>";
            this.labelID9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Modul 2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.labelAVG3);
            this.panel3.Controls.Add(this.labelID24);
            this.panel3.Controls.Add(this.labelID20);
            this.panel3.Controls.Add(this.labelID19);
            this.panel3.Controls.Add(this.labelID23);
            this.panel3.Controls.Add(this.labelID18);
            this.panel3.Controls.Add(this.labelID22);
            this.panel3.Controls.Add(this.labelID21);
            this.panel3.Controls.Add(this.labelID17);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(613, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 302);
            this.panel3.TabIndex = 10;
            // 
            // labelAVG3
            // 
            this.labelAVG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVG3.ForeColor = System.Drawing.Color.White;
            this.labelAVG3.Location = new System.Drawing.Point(3, 125);
            this.labelAVG3.Name = "labelAVG3";
            this.labelAVG3.Size = new System.Drawing.Size(263, 25);
            this.labelAVG3.TabIndex = 9;
            this.labelAVG3.Text = "Modul átlag: <temp>";
            this.labelAVG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID24
            // 
            this.labelID24.AutoSize = true;
            this.labelID24.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID24.ForeColor = System.Drawing.Color.White;
            this.labelID24.Location = new System.Drawing.Point(207, 191);
            this.labelID24.Name = "labelID24";
            this.labelID24.Size = new System.Drawing.Size(60, 32);
            this.labelID24.TabIndex = 8;
            this.labelID24.Text = "ID: <id>\r\n<temp>";
            this.labelID24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID20
            // 
            this.labelID20.AutoSize = true;
            this.labelID20.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID20.ForeColor = System.Drawing.Color.White;
            this.labelID20.Location = new System.Drawing.Point(71, 255);
            this.labelID20.Name = "labelID20";
            this.labelID20.Size = new System.Drawing.Size(60, 32);
            this.labelID20.TabIndex = 4;
            this.labelID20.Text = "ID: <id>\r\n<temp>";
            this.labelID20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID19
            // 
            this.labelID19.AutoSize = true;
            this.labelID19.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID19.ForeColor = System.Drawing.Color.White;
            this.labelID19.Location = new System.Drawing.Point(71, 46);
            this.labelID19.Name = "labelID19";
            this.labelID19.Size = new System.Drawing.Size(60, 32);
            this.labelID19.TabIndex = 3;
            this.labelID19.Text = "ID: <id>\r\n<temp>";
            this.labelID19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID23
            // 
            this.labelID23.AutoSize = true;
            this.labelID23.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID23.ForeColor = System.Drawing.Color.White;
            this.labelID23.Location = new System.Drawing.Point(207, 46);
            this.labelID23.Name = "labelID23";
            this.labelID23.Size = new System.Drawing.Size(60, 32);
            this.labelID23.TabIndex = 7;
            this.labelID23.Text = "ID: <id>\r\n<temp>";
            this.labelID23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID18
            // 
            this.labelID18.AutoSize = true;
            this.labelID18.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID18.ForeColor = System.Drawing.Color.White;
            this.labelID18.Location = new System.Drawing.Point(5, 255);
            this.labelID18.Name = "labelID18";
            this.labelID18.Size = new System.Drawing.Size(60, 32);
            this.labelID18.TabIndex = 2;
            this.labelID18.Text = "ID: <id>\r\n<temp>";
            this.labelID18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID22
            // 
            this.labelID22.AutoSize = true;
            this.labelID22.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID22.ForeColor = System.Drawing.Color.White;
            this.labelID22.Location = new System.Drawing.Point(139, 191);
            this.labelID22.Name = "labelID22";
            this.labelID22.Size = new System.Drawing.Size(60, 32);
            this.labelID22.TabIndex = 6;
            this.labelID22.Text = "ID: <id>\r\n<temp>";
            this.labelID22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID21
            // 
            this.labelID21.AutoSize = true;
            this.labelID21.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID21.ForeColor = System.Drawing.Color.White;
            this.labelID21.Location = new System.Drawing.Point(139, 46);
            this.labelID21.Name = "labelID21";
            this.labelID21.Size = new System.Drawing.Size(60, 32);
            this.labelID21.TabIndex = 5;
            this.labelID21.Text = "ID: <id>\r\n<temp>";
            this.labelID21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID17
            // 
            this.labelID17.AutoSize = true;
            this.labelID17.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID17.ForeColor = System.Drawing.Color.White;
            this.labelID17.Location = new System.Drawing.Point(3, 46);
            this.labelID17.Name = "labelID17";
            this.labelID17.Size = new System.Drawing.Size(60, 32);
            this.labelID17.TabIndex = 1;
            this.labelID17.Text = "ID: <id>\r\n<temp>";
            this.labelID17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(269, 35);
            this.label21.TabIndex = 0;
            this.label21.Text = "Modul 3";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.labelAVG4);
            this.panel4.Controls.Add(this.labelID32);
            this.panel4.Controls.Add(this.labelID28);
            this.panel4.Controls.Add(this.labelID27);
            this.panel4.Controls.Add(this.labelID31);
            this.panel4.Controls.Add(this.labelID26);
            this.panel4.Controls.Add(this.labelID30);
            this.panel4.Controls.Add(this.labelID29);
            this.panel4.Controls.Add(this.labelID25);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Location = new System.Drawing.Point(899, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 302);
            this.panel4.TabIndex = 10;
            // 
            // labelAVG4
            // 
            this.labelAVG4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVG4.ForeColor = System.Drawing.Color.White;
            this.labelAVG4.Location = new System.Drawing.Point(1, 125);
            this.labelAVG4.Name = "labelAVG4";
            this.labelAVG4.Size = new System.Drawing.Size(267, 25);
            this.labelAVG4.TabIndex = 9;
            this.labelAVG4.Text = "Modul átlag: <temp>";
            this.labelAVG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID32
            // 
            this.labelID32.AutoSize = true;
            this.labelID32.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID32.ForeColor = System.Drawing.Color.White;
            this.labelID32.Location = new System.Drawing.Point(207, 191);
            this.labelID32.Name = "labelID32";
            this.labelID32.Size = new System.Drawing.Size(60, 32);
            this.labelID32.TabIndex = 8;
            this.labelID32.Text = "ID: <id>\r\n<temp>";
            this.labelID32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID28
            // 
            this.labelID28.AutoSize = true;
            this.labelID28.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID28.ForeColor = System.Drawing.Color.White;
            this.labelID28.Location = new System.Drawing.Point(71, 191);
            this.labelID28.Name = "labelID28";
            this.labelID28.Size = new System.Drawing.Size(60, 32);
            this.labelID28.TabIndex = 4;
            this.labelID28.Text = "ID: <id>\r\n<temp>";
            this.labelID28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID27
            // 
            this.labelID27.AutoSize = true;
            this.labelID27.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID27.ForeColor = System.Drawing.Color.White;
            this.labelID27.Location = new System.Drawing.Point(71, 46);
            this.labelID27.Name = "labelID27";
            this.labelID27.Size = new System.Drawing.Size(60, 32);
            this.labelID27.TabIndex = 3;
            this.labelID27.Text = "ID: <id>\r\n<temp>";
            this.labelID27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID31
            // 
            this.labelID31.AutoSize = true;
            this.labelID31.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID31.ForeColor = System.Drawing.Color.White;
            this.labelID31.Location = new System.Drawing.Point(207, 46);
            this.labelID31.Name = "labelID31";
            this.labelID31.Size = new System.Drawing.Size(60, 32);
            this.labelID31.TabIndex = 7;
            this.labelID31.Text = "ID: <id>\r\n<temp>";
            this.labelID31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID26
            // 
            this.labelID26.AutoSize = true;
            this.labelID26.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID26.ForeColor = System.Drawing.Color.White;
            this.labelID26.Location = new System.Drawing.Point(5, 191);
            this.labelID26.Name = "labelID26";
            this.labelID26.Size = new System.Drawing.Size(60, 32);
            this.labelID26.TabIndex = 2;
            this.labelID26.Text = "ID: <id>\r\n<temp>";
            this.labelID26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID30
            // 
            this.labelID30.AutoSize = true;
            this.labelID30.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID30.ForeColor = System.Drawing.Color.White;
            this.labelID30.Location = new System.Drawing.Point(139, 255);
            this.labelID30.Name = "labelID30";
            this.labelID30.Size = new System.Drawing.Size(60, 32);
            this.labelID30.TabIndex = 6;
            this.labelID30.Text = "ID: <id>\r\n<temp>";
            this.labelID30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID29
            // 
            this.labelID29.AutoSize = true;
            this.labelID29.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID29.ForeColor = System.Drawing.Color.White;
            this.labelID29.Location = new System.Drawing.Point(139, 46);
            this.labelID29.Name = "labelID29";
            this.labelID29.Size = new System.Drawing.Size(60, 32);
            this.labelID29.TabIndex = 5;
            this.labelID29.Text = "ID: <id>\r\n<temp>";
            this.labelID29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID25
            // 
            this.labelID25.AutoSize = true;
            this.labelID25.BackColor = System.Drawing.Color.DarkGreen;
            this.labelID25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID25.ForeColor = System.Drawing.Color.White;
            this.labelID25.Location = new System.Drawing.Point(3, 46);
            this.labelID25.Name = "labelID25";
            this.labelID25.Size = new System.Drawing.Size(60, 32);
            this.labelID25.TabIndex = 1;
            this.labelID25.Text = "ID: <id>\r\n<temp>";
            this.labelID25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(269, 35);
            this.label31.TabIndex = 0;
            this.label31.Text = "Modul 4";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(7, 478);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(256, 25);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "<date>";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSec1
            // 
            this.labelSec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec1.ForeColor = System.Drawing.Color.Black;
            this.labelSec1.Location = new System.Drawing.Point(15, 383);
            this.labelSec1.Name = "labelSec1";
            this.labelSec1.Size = new System.Drawing.Size(264, 25);
            this.labelSec1.TabIndex = 11;
            this.labelSec1.Text = "<time>";
            this.labelSec1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSec1.Visible = false;
            // 
            // labelSec2
            // 
            this.labelSec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec2.ForeColor = System.Drawing.Color.Black;
            this.labelSec2.Location = new System.Drawing.Point(293, 383);
            this.labelSec2.Name = "labelSec2";
            this.labelSec2.Size = new System.Drawing.Size(267, 25);
            this.labelSec2.TabIndex = 12;
            this.labelSec2.Text = "<time>";
            this.labelSec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSec2.Visible = false;
            // 
            // labelSec3
            // 
            this.labelSec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec3.ForeColor = System.Drawing.Color.Black;
            this.labelSec3.Location = new System.Drawing.Point(614, 383);
            this.labelSec3.Name = "labelSec3";
            this.labelSec3.Size = new System.Drawing.Size(267, 25);
            this.labelSec3.TabIndex = 13;
            this.labelSec3.Text = "<time>";
            this.labelSec3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSec3.Visible = false;
            // 
            // labelSec4
            // 
            this.labelSec4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec4.ForeColor = System.Drawing.Color.Black;
            this.labelSec4.Location = new System.Drawing.Point(898, 383);
            this.labelSec4.Name = "labelSec4";
            this.labelSec4.Size = new System.Drawing.Size(267, 25);
            this.labelSec4.TabIndex = 14;
            this.labelSec4.Text = "<time>";
            this.labelSec4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSec4.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panelMinimize);
            this.panel5.Controls.Add(this.panelClose);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1179, 60);
            this.panel5.TabIndex = 15;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Greenfield MLD hőmérséklet monitorozás";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMinimize
            // 
            this.panelMinimize.BackgroundImage = global::MLD_heat_meter.Properties.Resources.hide;
            this.panelMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMinimize.Location = new System.Drawing.Point(1067, 5);
            this.panelMinimize.Name = "panelMinimize";
            this.panelMinimize.Size = new System.Drawing.Size(50, 50);
            this.panelMinimize.TabIndex = 2;
            this.panelMinimize.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MLD_heat_meter.Properties.Resources.close;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClose.Location = new System.Drawing.Point(1123, 5);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(50, 50);
            this.panelClose.TabIndex = 1;
            this.panelClose.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::MLD_heat_meter.Properties.Resources.logs1;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(178, 425);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 50);
            this.panel7.TabIndex = 17;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::MLD_heat_meter.Properties.Resources.email;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(12, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 50);
            this.panel6.TabIndex = 16;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(613, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "<date>";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelSec4);
            this.Controls.Add(this.labelSec3);
            this.Controls.Add(this.labelSec2);
            this.Controls.Add(this.labelSec1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID1;
        private System.Windows.Forms.Label labelID8;
        private System.Windows.Forms.Label labelID4;
        private System.Windows.Forms.Label labelID3;
        private System.Windows.Forms.Label labelID7;
        private System.Windows.Forms.Label labelID2;
        private System.Windows.Forms.Label labelID6;
        private System.Windows.Forms.Label labelID5;
        private System.Windows.Forms.Label labelAVG1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAVG2;
        private System.Windows.Forms.Label labelID16;
        private System.Windows.Forms.Label labelID12;
        private System.Windows.Forms.Label labelID11;
        private System.Windows.Forms.Label labelID15;
        private System.Windows.Forms.Label labelID10;
        private System.Windows.Forms.Label labelID14;
        private System.Windows.Forms.Label labelID13;
        private System.Windows.Forms.Label labelID9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAVG3;
        private System.Windows.Forms.Label labelID24;
        private System.Windows.Forms.Label labelID20;
        private System.Windows.Forms.Label labelID19;
        private System.Windows.Forms.Label labelID23;
        private System.Windows.Forms.Label labelID18;
        private System.Windows.Forms.Label labelID22;
        private System.Windows.Forms.Label labelID21;
        private System.Windows.Forms.Label labelID17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelAVG4;
        private System.Windows.Forms.Label labelID32;
        private System.Windows.Forms.Label labelID28;
        private System.Windows.Forms.Label labelID27;
        private System.Windows.Forms.Label labelID31;
        private System.Windows.Forms.Label labelID26;
        private System.Windows.Forms.Label labelID30;
        private System.Windows.Forms.Label labelID29;
        private System.Windows.Forms.Label labelID25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSec1;
        private System.Windows.Forms.Label labelSec2;
        private System.Windows.Forms.Label labelSec3;
        private System.Windows.Forms.Label labelSec4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
    }
}

