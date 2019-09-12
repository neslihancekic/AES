
using System;
using System.Text;
using System.Windows.Forms;


namespace AES
{

    class Program : System.Windows.Forms.Form
    {


        private Panel top;
        private System.ComponentModel.IContainer components;
        private ns1.BunifuImageButton exitbutton;
        private ns1.BunifuImageButton minimizebutton;
        private Panel panelcontainer;
        public Panel accountspanel;
        public ns1.BunifuImageButton aeslogo;
        private ns1.BunifuElipse bunifuElipse1;
        public ns1.BunifuCustomLabel logout;
        public ns1.BunifuImageButton logoutbutton;
        private ns1.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private ns1.BunifuDragControl bunifuDragControl1;

       


        Program() // ADD THIS CONSTRUCTOR

        {

            InitializeComponent();

        }
        static void Main()
        {
            Application.EnableVisualStyles();
          
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.top = new System.Windows.Forms.Panel();
            this.aeslogo = new ns1.BunifuImageButton();
            this.logout = new ns1.BunifuCustomLabel();
            this.logoutbutton = new ns1.BunifuImageButton();
            this.minimizebutton = new ns1.BunifuImageButton();
            this.exitbutton = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.accountspanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new ns1.BunifuFormFadeTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeslogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.top.Controls.Add(this.aeslogo);
            this.top.Controls.Add(this.logout);
            this.top.Controls.Add(this.logoutbutton);
            this.bunifuTransition1.SetDecoration(this.top, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.top, "top");
            this.top.Name = "top";
            // 
            // aeslogo
            // 
            this.aeslogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.aeslogo, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.aeslogo, "aeslogo");
            this.aeslogo.ImageActive = null;
            this.aeslogo.Name = "aeslogo";
            this.aeslogo.TabStop = false;
            this.aeslogo.Zoom = 10;
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.Name = "logout";
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.logoutbutton, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.logoutbutton, "logoutbutton");
            this.logoutbutton.ImageActive = null;
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.TabStop = false;
            this.logoutbutton.Zoom = 10;
            this.logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // minimizebutton
            // 
            this.minimizebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.minimizebutton, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.minimizebutton, "minimizebutton");
            this.minimizebutton.ImageActive = null;
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.TabStop = false;
            this.minimizebutton.Zoom = 10;
            this.minimizebutton.Click += new System.EventHandler(this.Minimizebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.exitbutton, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.exitbutton, "exitbutton");
            this.exitbutton.ImageActive = null;
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.TabStop = false;
            this.exitbutton.Zoom = 10;
            this.exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelcontainer
            // 
            resources.ApplyResources(this.panelcontainer, "panelcontainer");
            this.bunifuTransition1.SetDecoration(this.panelcontainer, BunifuAnimatorNS.DecorationType.None);
            this.panelcontainer.Name = "panelcontainer";
            // 
            // accountspanel
            // 
            this.accountspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.accountspanel, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.accountspanel, "accountspanel");
            this.accountspanel.Name = "accountspanel";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Custom;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Program
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.minimizebutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.accountspanel);
            this.Controls.Add(this.panelcontainer);
            this.Controls.Add(this.top);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Program";
            this.Opacity = 0.95D;
            this.Load += new System.EventHandler(this.Program_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeslogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        static Program _obj;


        public static Program Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Program();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelcontainer; }
            set { panelcontainer = value; }
        }
        public Panel ActPnlContainer
        {
            get { return accountspanel; }
            set { accountspanel = value; }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Program_Load(object sender, EventArgs e)
        {
            logoutbutton.Visible = false;
            logout.Visible = false;
            accountspanel.Visible = false;
           
            _obj = this;

            bunifuFormFadeTransition1.ShowAsyc(_obj);

            login uc = new login
            {
                Dock = DockStyle.Fill
            };
            panelcontainer.Controls.Add(uc);
            
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }

    }
}
