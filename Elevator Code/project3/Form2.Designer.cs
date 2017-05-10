
namespace project3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.goingdownbtn = new System.Windows.Forms.Button();
            this.goingupbtn = new System.Windows.Forms.Button();
            this.lift1 = new System.Windows.Forms.Panel();
            this.uprightdoor = new System.Windows.Forms.Panel();
            this.upleftdoor = new System.Windows.Forms.Panel();
            this.lift2 = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DirectionP2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DirectionP1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.goingfirstfloorbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groundfloor = new System.Windows.Forms.Button();
            this.upleftdoor2 = new System.Windows.Forms.Panel();
            this.downleftdoor2 = new System.Windows.Forms.Panel();
            this.downrightdoor2 = new System.Windows.Forms.Panel();
            this.uprightdoor2 = new System.Windows.Forms.Panel();
            this.firstfloor = new System.Windows.Forms.Button();
            this.goingdowntimer = new System.Windows.Forms.Timer(this.components);
            this.goinguptimer = new System.Windows.Forms.Timer(this.components);
            this.doorsopentimer = new System.Windows.Forms.Timer(this.components);
            this.doorsclosetimer = new System.Windows.Forms.Timer(this.components);
            this.closegrounddoorstimer = new System.Windows.Forms.Timer(this.components);
            this.grounddoortimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statuspanel = new System.Windows.Forms.Panel();
            this.lift1.SuspendLayout();
            this.background.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // goingdownbtn
            // 
            this.goingdownbtn.BackColor = System.Drawing.Color.SlateGray;
            this.goingdownbtn.Location = new System.Drawing.Point(3, 136);
            this.goingdownbtn.Name = "goingdownbtn";
            this.goingdownbtn.Size = new System.Drawing.Size(25, 47);
            this.goingdownbtn.TabIndex = 0;
            this.goingdownbtn.Text = "v";
            this.goingdownbtn.UseVisualStyleBackColor = false;
            this.goingdownbtn.Click += new System.EventHandler(this.goingdownbtn_Click);
            // 
            // goingupbtn
            // 
            this.goingupbtn.BackColor = System.Drawing.Color.SlateGray;
            this.goingupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goingupbtn.Location = new System.Drawing.Point(3, 122);
            this.goingupbtn.Name = "goingupbtn";
            this.goingupbtn.Size = new System.Drawing.Size(25, 47);
            this.goingupbtn.TabIndex = 4;
            this.goingupbtn.Text = "^";
            this.goingupbtn.UseVisualStyleBackColor = false;
            this.goingupbtn.Click += new System.EventHandler(this.goingupbtn_Click);
            // 
            // lift1
            // 
            this.lift1.BackColor = System.Drawing.SystemColors.Info;
            this.lift1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lift1.BackgroundImage")));
            this.lift1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lift1.Controls.Add(this.uprightdoor);
            this.lift1.Controls.Add(this.upleftdoor);
            this.lift1.Location = new System.Drawing.Point(48, 49);
            this.lift1.Name = "lift1";
            this.lift1.Size = new System.Drawing.Size(284, 249);
            this.lift1.TabIndex = 6;
            // 
            // uprightdoor
            // 
            this.uprightdoor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uprightdoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uprightdoor.BackgroundImage")));
            this.uprightdoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uprightdoor.Location = new System.Drawing.Point(142, 0);
            this.uprightdoor.Name = "uprightdoor";
            this.uprightdoor.Size = new System.Drawing.Size(139, 248);
            this.uprightdoor.TabIndex = 11;
            // 
            // upleftdoor
            // 
            this.upleftdoor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.upleftdoor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upleftdoor.BackgroundImage")));
            this.upleftdoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upleftdoor.Location = new System.Drawing.Point(3, 0);
            this.upleftdoor.Name = "upleftdoor";
            this.upleftdoor.Size = new System.Drawing.Size(138, 248);
            this.upleftdoor.TabIndex = 10;
            // 
            // lift2
            // 
            this.lift2.BackColor = System.Drawing.Color.DimGray;
            this.lift2.Location = new System.Drawing.Point(54, 6);
            this.lift2.Name = "lift2";
            this.lift2.Size = new System.Drawing.Size(281, 647);
            this.lift2.TabIndex = 7;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Silver;
            this.background.Controls.Add(this.panel4);
            this.background.Controls.Add(this.panel7);
            this.background.Controls.Add(this.panel3);
            this.background.Controls.Add(this.panel6);
            this.background.Controls.Add(this.panel5);
            this.background.Controls.Add(this.panel2);
            this.background.Controls.Add(this.upleftdoor2);
            this.background.Controls.Add(this.downleftdoor2);
            this.background.Controls.Add(this.downrightdoor2);
            this.background.Controls.Add(this.uprightdoor2);
            this.background.Controls.Add(this.lift1);
            this.background.Controls.Add(this.lift2);
            this.background.Location = new System.Drawing.Point(46, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(391, 679);
            this.background.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.DirectionP2);
            this.panel4.Location = new System.Drawing.Point(0, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 46);
            this.panel4.TabIndex = 8;
            // 
            // DirectionP2
            // 
            this.DirectionP2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DirectionP2.Location = new System.Drawing.Point(151, 9);
            this.DirectionP2.Name = "DirectionP2";
            this.DirectionP2.Size = new System.Drawing.Size(74, 27);
            this.DirectionP2.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Tan;
            this.panel7.Controls.Add(this.DirectionP1);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(391, 50);
            this.panel7.TabIndex = 15;
            // 
            // DirectionP1
            // 
            this.DirectionP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DirectionP1.Location = new System.Drawing.Point(151, 10);
            this.DirectionP1.Name = "DirectionP1";
            this.DirectionP1.Size = new System.Drawing.Size(74, 27);
            this.DirectionP1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 278);
            this.panel3.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Tan;
            this.panel6.Controls.Add(this.goingfirstfloorbtn);
            this.panel6.Controls.Add(this.goingupbtn);
            this.panel6.Location = new System.Drawing.Point(360, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(31, 256);
            this.panel6.TabIndex = 14;
            // 
            // goingfirstfloorbtn
            // 
            this.goingfirstfloorbtn.BackColor = System.Drawing.Color.SlateGray;
            this.goingfirstfloorbtn.Location = new System.Drawing.Point(3, 69);
            this.goingfirstfloorbtn.Name = "goingfirstfloorbtn";
            this.goingfirstfloorbtn.Size = new System.Drawing.Size(25, 47);
            this.goingfirstfloorbtn.TabIndex = 11;
            this.goingfirstfloorbtn.Text = "1";
            this.goingfirstfloorbtn.UseVisualStyleBackColor = false;
            this.goingfirstfloorbtn.Click += new System.EventHandler(this.goingfirstfloorbtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Location = new System.Drawing.Point(0, 397);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 256);
            this.panel5.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.groundfloor);
            this.panel2.Controls.Add(this.goingdownbtn);
            this.panel2.Location = new System.Drawing.Point(360, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 276);
            this.panel2.TabIndex = 12;
            // 
            // groundfloor
            // 
            this.groundfloor.BackColor = System.Drawing.Color.SlateGray;
            this.groundfloor.Location = new System.Drawing.Point(3, 83);
            this.groundfloor.Name = "groundfloor";
            this.groundfloor.Size = new System.Drawing.Size(25, 47);
            this.groundfloor.TabIndex = 10;
            this.groundfloor.Text = "G";
            this.groundfloor.UseVisualStyleBackColor = false;
            this.groundfloor.Click += new System.EventHandler(this.groundfloor_Click);
            // 
            // upleftdoor2
            // 
            this.upleftdoor2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.upleftdoor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upleftdoor2.BackgroundImage")));
            this.upleftdoor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upleftdoor2.Location = new System.Drawing.Point(27, 49);
            this.upleftdoor2.Name = "upleftdoor2";
            this.upleftdoor2.Size = new System.Drawing.Size(162, 250);
            this.upleftdoor2.TabIndex = 0;
            // 
            // downleftdoor2
            // 
            this.downleftdoor2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.downleftdoor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downleftdoor2.BackgroundImage")));
            this.downleftdoor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downleftdoor2.Location = new System.Drawing.Point(30, 397);
            this.downleftdoor2.Name = "downleftdoor2";
            this.downleftdoor2.Size = new System.Drawing.Size(159, 256);
            this.downleftdoor2.TabIndex = 0;
            // 
            // downrightdoor2
            // 
            this.downrightdoor2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.downrightdoor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downrightdoor2.BackgroundImage")));
            this.downrightdoor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downrightdoor2.Location = new System.Drawing.Point(190, 397);
            this.downrightdoor2.Name = "downrightdoor2";
            this.downrightdoor2.Size = new System.Drawing.Size(171, 256);
            this.downrightdoor2.TabIndex = 1;
            // 
            // uprightdoor2
            // 
            this.uprightdoor2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uprightdoor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uprightdoor2.BackgroundImage")));
            this.uprightdoor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uprightdoor2.Location = new System.Drawing.Point(184, 49);
            this.uprightdoor2.Name = "uprightdoor2";
            this.uprightdoor2.Size = new System.Drawing.Size(177, 249);
            this.uprightdoor2.TabIndex = 1;
            // 
            // firstfloor
            // 
            this.firstfloor.Location = new System.Drawing.Point(0, 0);
            this.firstfloor.Name = "firstfloor";
            this.firstfloor.Size = new System.Drawing.Size(75, 23);
            this.firstfloor.TabIndex = 0;
            // 
            // goingdowntimer
            // 
            this.goingdowntimer.Tick += new System.EventHandler(this.goingdowntimer_Tick);
            // 
            // goinguptimer
            // 
            this.goinguptimer.Tick += new System.EventHandler(this.goinguptimer_Tick);
            // 
            // doorsopentimer
            // 
            this.doorsopentimer.Tick += new System.EventHandler(this.doorsopentimer_Tick);
            // 
            // doorsclosetimer
            // 
            this.doorsclosetimer.Tick += new System.EventHandler(this.doorsclosetimer_Tick);
            // 
            // closegrounddoorstimer
            // 
            this.closegrounddoorstimer.Tick += new System.EventHandler(this.closegrounddoorstimer_Tick);
            // 
            // grounddoortimer
            // 
            this.grounddoortimer.Tick += new System.EventHandler(this.grounddoortimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 679);
            this.panel1.TabIndex = 9;
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(529, 360);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(141, 43);
            this.logbtn.TabIndex = 13;
            this.logbtn.Text = " VIEW LOG";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(529, 268);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(141, 43);
            this.homebtn.TabIndex = 14;
            this.homebtn.Text = "HOME SCREEN";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(443, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = " call the lift ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Takes you to first floor";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(440, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = " call the lift ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Takes you to ground floor";
            // 
            // statuspanel
            // 
            this.statuspanel.Location = new System.Drawing.Point(529, 12);
            this.statuspanel.Name = "statuspanel";
            this.statuspanel.Size = new System.Drawing.Size(200, 68);
            this.statuspanel.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 695);
            this.Controls.Add(this.statuspanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.background);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form1";
            this.lift1.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goingdownbtn;
        private System.Windows.Forms.Button goingupbtn;
        private System.Windows.Forms.Panel lift1;
        private System.Windows.Forms.Panel lift2;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel DirectionP2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel DirectionP1;
        private System.Windows.Forms.Timer goingdowntimer;
        private System.Windows.Forms.Timer goinguptimer;
        private System.Windows.Forms.Panel uprightdoor;
        private System.Windows.Forms.Panel upleftdoor;
        private System.Windows.Forms.Timer doorsopentimer;
        private System.Windows.Forms.Timer doorsclosetimer;
        private System.Windows.Forms.Button groundfloor;
        private System.Windows.Forms.Button firstfloor;
        private System.Windows.Forms.Timer closegrounddoorstimer;
        private System.Windows.Forms.Timer grounddoortimer;
        private System.Windows.Forms.Button goingfirstfloorbtn;
        private System.Windows.Forms.Panel downrightdoor2;
        private System.Windows.Forms.Panel downleftdoor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel uprightdoor2;
        private System.Windows.Forms.Panel upleftdoor2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel statuspanel;
    }
}
