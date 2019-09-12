namespace AES
{
    partial class leftpanelitem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leftpanelitem));
            this.chatname = new ns1.BunifuCustomLabel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.arrow = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // chatname
            // 
            this.chatname.AutoSize = true;
            this.chatname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chatname.Location = new System.Drawing.Point(36, 9);
            this.chatname.Name = "chatname";
            this.chatname.Size = new System.Drawing.Size(94, 21);
            this.chatname.TabIndex = 3;
            this.chatname.Text = "chatname";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Lavender;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(27, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Lavender;
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.ImageActive = null;
            this.arrow.Location = new System.Drawing.Point(212, 9);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(23, 30);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow.TabIndex = 5;
            this.arrow.TabStop = false;
            this.arrow.Zoom = 10;
            // 
            // leftpanelitem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.chatname);
            this.Name = "leftpanelitem";
            this.Size = new System.Drawing.Size(240, 45);
            this.Click += new System.EventHandler(this.Leftpanelitem_Click);
            this.MouseEnter += new System.EventHandler(this.Leftpanelitem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Leftpanelitem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ns1.BunifuCustomLabel chatname;
        private ns1.BunifuImageButton bunifuImageButton1;
        public ns1.BunifuImageButton arrow;
    }
}
