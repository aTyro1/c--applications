
namespace pictureandfiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dp = new System.Windows.Forms.PictureBox();
            this.openbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.tiktak = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dp)).BeginInit();
            this.SuspendLayout();
            // 
            // dp
            // 
            this.dp.Image = ((System.Drawing.Image)(resources.GetObject("dp.Image")));
            this.dp.Location = new System.Drawing.Point(48, 64);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(371, 367);
            this.dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dp.TabIndex = 0;
            this.dp.TabStop = false;
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(522, 128);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 1;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(522, 202);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "Save";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(522, 269);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // tiktak
            // 
            this.tiktak.Enabled = true;
            this.tiktak.Interval = 1000;
            this.tiktak.Tick += new System.EventHandler(this.timer_tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(511, 376);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 15);
            this.timer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 513);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.dp);
            this.Name = "Form1";
            this.Text = "Display Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dp;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label timer;
        public System.Windows.Forms.Timer tiktak;
    }
}

