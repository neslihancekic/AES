namespace AES
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.registerbutton = new ns1.BunifuTileButton();
            this.keybox = new ns1.BunifuMetroTextbox();
            this.namebox = new ns1.BunifuMetroTextbox();
            this.surnamebox = new ns1.BunifuMetroTextbox();
            this.emailbox = new ns1.BunifuMetroTextbox();
            this.usernamebox = new ns1.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registerbutton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registerbutton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.registerbutton.ForeColor = System.Drawing.Color.White;
            this.registerbutton.Image = ((System.Drawing.Image)(resources.GetObject("registerbutton.Image")));
            this.registerbutton.ImagePosition = 20;
            this.registerbutton.ImageZoom = 50;
            this.registerbutton.LabelPosition = 41;
            this.registerbutton.LabelText = "Register";
            this.registerbutton.Location = new System.Drawing.Point(145, 367);
            this.registerbutton.Margin = new System.Windows.Forms.Padding(6);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(128, 129);
            this.registerbutton.TabIndex = 7;
            this.registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // keybox
            // 
            this.keybox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.keybox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keybox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.keybox.BorderThickness = 3;
            this.keybox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keybox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.keybox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keybox.isPassword = false;
            this.keybox.Location = new System.Drawing.Point(41, 288);
            this.keybox.Margin = new System.Windows.Forms.Padding(4);
            this.keybox.Name = "keybox";
            this.keybox.Size = new System.Drawing.Size(370, 44);
            this.keybox.TabIndex = 5;
            this.keybox.Text = "Password";
            this.keybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keybox_KeyPress);
            this.keybox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Keybox_MouseClick);
            // 
            // namebox
            // 
            this.namebox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.namebox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namebox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.namebox.BorderThickness = 3;
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.namebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namebox.isPassword = false;
            this.namebox.Location = new System.Drawing.Point(41, 38);
            this.namebox.Margin = new System.Windows.Forms.Padding(4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(370, 44);
            this.namebox.TabIndex = 4;
            this.namebox.Text = "Name";
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.namebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Namebox_MouseClick);
            // 
            // surnamebox
            // 
            this.surnamebox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.surnamebox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnamebox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.surnamebox.BorderThickness = 3;
            this.surnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnamebox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.surnamebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnamebox.isPassword = false;
            this.surnamebox.Location = new System.Drawing.Point(41, 99);
            this.surnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(370, 44);
            this.surnamebox.TabIndex = 8;
            this.surnamebox.Text = "Surname";
            this.surnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.surnamebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Surnamebox_MouseClick);
            // 
            // emailbox
            // 
            this.emailbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailbox.BorderThickness = 3;
            this.emailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbox.isPassword = false;
            this.emailbox.Location = new System.Drawing.Point(41, 221);
            this.emailbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(370, 44);
            this.emailbox.TabIndex = 9;
            this.emailbox.Text = "E-mail";
            this.emailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Emailbox_MouseClick);
            // 
            // usernamebox
            // 
            this.usernamebox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernamebox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernamebox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernamebox.BorderThickness = 3;
            this.usernamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernamebox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernamebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernamebox.isPassword = false;
            this.usernamebox.Location = new System.Drawing.Point(41, 160);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(4);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(370, 44);
            this.usernamebox.TabIndex = 10;
            this.usernamebox.Text = "Username";
            this.usernamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernamebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Usernamebox_MouseClick);
            // 
            // register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.surnamebox);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.keybox);
            this.Controls.Add(this.namebox);
            this.Name = "register";
            this.Size = new System.Drawing.Size(453, 578);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuTileButton registerbutton;
        public ns1.BunifuMetroTextbox keybox;
        public ns1.BunifuMetroTextbox namebox;
        public ns1.BunifuMetroTextbox surnamebox;
        public ns1.BunifuMetroTextbox emailbox;
        public ns1.BunifuMetroTextbox usernamebox;
    }
}
