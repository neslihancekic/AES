namespace AES
{
    partial class mespage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mespage));
            this.entermes = new ns1.BunifuMaterialTextbox();
            this.sendbutton = new ns1.BunifuImageButton();
            this.mespanel = new System.Windows.Forms.Panel();
            this.roompasswordbox = new ns1.BunifuMetroTextbox();
            this.picture = new ns1.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sendbutton)).BeginInit();
            this.mespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // entermes
            // 
            this.entermes.BackColor = System.Drawing.Color.White;
            this.entermes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.entermes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.entermes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.entermes.HintForeColor = System.Drawing.Color.Empty;
            this.entermes.HintText = "";
            this.entermes.isPassword = false;
            this.entermes.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.entermes.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.entermes.LineMouseHoverColor = System.Drawing.Color.Black;
            this.entermes.LineThickness = 3;
            this.entermes.Location = new System.Drawing.Point(7, 541);
            this.entermes.Margin = new System.Windows.Forms.Padding(4);
            this.entermes.Name = "entermes";
            this.entermes.Size = new System.Drawing.Size(646, 44);
            this.entermes.TabIndex = 11;
            this.entermes.Text = "Enter your message...";
            this.entermes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.entermes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entermes_KeyPress);
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.Color.Snow;
            this.sendbutton.Image = ((System.Drawing.Image)(resources.GetObject("sendbutton.Image")));
            this.sendbutton.ImageActive = null;
            this.sendbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendbutton.InitialImage = null;
            this.sendbutton.Location = new System.Drawing.Point(717, 541);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(33, 36);
            this.sendbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendbutton.TabIndex = 10;
            this.sendbutton.TabStop = false;
            this.sendbutton.Zoom = 10;
            this.sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // mespanel
            // 
            this.mespanel.AutoScroll = true;
            this.mespanel.Controls.Add(this.roompasswordbox);
            this.mespanel.Location = new System.Drawing.Point(3, 3);
            this.mespanel.Name = "mespanel";
            this.mespanel.Size = new System.Drawing.Size(761, 531);
            this.mespanel.TabIndex = 12;
            // 
            // roompasswordbox
            // 
            this.roompasswordbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.roompasswordbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roompasswordbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.roompasswordbox.BorderThickness = 3;
            this.roompasswordbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roompasswordbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roompasswordbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roompasswordbox.isPassword = false;
            this.roompasswordbox.Location = new System.Drawing.Point(195, 212);
            this.roompasswordbox.Margin = new System.Windows.Forms.Padding(4);
            this.roompasswordbox.Name = "roompasswordbox";
            this.roompasswordbox.Size = new System.Drawing.Size(370, 44);
            this.roompasswordbox.TabIndex = 0;
            this.roompasswordbox.Text = "Room Password";
            this.roompasswordbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roompasswordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Roompasswordbox_KeyPress);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Snow;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.ImageActive = null;
            this.picture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(669, 541);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(33, 36);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 13;
            this.picture.TabStop = false;
            this.picture.Zoom = 10;
            this.picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mespage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.entermes);
            this.Controls.Add(this.mespanel);
            this.Name = "mespage";
            this.Size = new System.Drawing.Size(764, 595);
            this.Load += new System.EventHandler(this.Mespage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendbutton)).EndInit();
            this.mespanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuMaterialTextbox entermes;
        private ns1.BunifuImageButton sendbutton;
        private System.Windows.Forms.Panel mespanel;
        private ns1.BunifuImageButton picture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuMetroTextbox roompasswordbox;
    }
}
