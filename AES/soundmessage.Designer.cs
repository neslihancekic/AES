using System.Drawing;

namespace AES
{
    partial class soundmessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soundmessage));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.accountname = new ns1.BunifuCustomLabel();
            this.progressbar = new ns1.BunifuProgressBar();
            this.playbutton = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // accountname
            // 
            this.accountname.AutoSize = true;
            this.accountname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.accountname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.accountname.Location = new System.Drawing.Point(3, 0);
            this.accountname.Name = "accountname";
            this.accountname.Size = new System.Drawing.Size(98, 16);
            this.accountname.TabIndex = 2;
            this.accountname.Text = "accountname";
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.AliceBlue;
            this.progressbar.BorderRadius = 5;
            this.progressbar.Location = new System.Drawing.Point(40, 30);
            this.progressbar.MaximumValue = 100;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.progressbar.Size = new System.Drawing.Size(251, 10);
            this.progressbar.TabIndex = 6;
            this.progressbar.Value = 30;
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Lavender;
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.ImageActive = null;
            this.playbutton.Location = new System.Drawing.Point(6, 17);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(28, 32);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playbutton.TabIndex = 5;
            this.playbutton.TabStop = false;
            this.playbutton.Zoom = 10;
            this.playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // soundmessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.accountname);
            this.MinimumSize = new System.Drawing.Size(300, 47);
            this.Name = "soundmessage";
            this.Size = new System.Drawing.Size(300, 52);
            this.Load += new System.EventHandler(this.soundmessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuCustomLabel accountname;
        private ns1.BunifuProgressBar progressbar;
        private ns1.BunifuImageButton playbutton;
    }
}
