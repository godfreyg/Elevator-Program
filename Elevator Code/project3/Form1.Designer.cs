namespace project3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.liftviewbtn = new System.Windows.Forms.Button();
            this.logviewbtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liftviewbtn
            // 
            this.liftviewbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.liftviewbtn.Location = new System.Drawing.Point(344, 129);
            this.liftviewbtn.Name = "liftviewbtn";
            this.liftviewbtn.Size = new System.Drawing.Size(272, 57);
            this.liftviewbtn.TabIndex = 0;
            this.liftviewbtn.Text = "View Lift";
            this.liftviewbtn.UseVisualStyleBackColor = true;
            this.liftviewbtn.Click += new System.EventHandler(this.liftviewbtn_Click);
            // 
            // logviewbtn1
            // 
            this.logviewbtn1.Location = new System.Drawing.Point(344, 250);
            this.logviewbtn1.Name = "logviewbtn1";
            this.logviewbtn1.Size = new System.Drawing.Size(272, 60);
            this.logviewbtn1.TabIndex = 1;
            this.logviewbtn1.Text = "View Log";
            this.logviewbtn1.UseVisualStyleBackColor = true;
            this.logviewbtn1.Click += new System.EventHandler(this.logviewbtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 443);
            this.Controls.Add(this.logviewbtn1);
            this.Controls.Add(this.liftviewbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button liftviewbtn;
        private System.Windows.Forms.Button logviewbtn1;
    }
}

