using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AES
{
    public partial class leftpanel : UserControl
    {

        string key, user;
        public void getbox(string a, string b) { key = a; user = b; }
        int poss = 10;
        public void additem(string s)
        {

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    leftpanelitem item = new AES.leftpanelitem();
                    item.arrow.Visible = false;
                    item.getbox(key, user);
                    item.chatname.Text = s;
                    accountpanel.Controls.Add(item);
                    item.Top = poss;
                    poss = (item.Top + item.Height + 10);


                });
            }

        }

        public leftpanel()
        {
            InitializeComponent();
        }
        int check = 0;
        private void getcheck(int a) { check = a; }
        private async void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            var data = new Room()
            {
                name = leftbox.Text,
            };

            var firebase1 = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString());
            var r = await firebase1
              .Child("Rooms")
              .OrderByKey()
              .OnceAsync<Room>();

            foreach (var d in r)
            {
                if (data.name == d.Object.name)
                {
                    check++;
                }
            }


            Console.WriteLine(check);

            if (check == 0)
            {
                using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
                {
                    await firebase
                        .Child("Rooms/")
                        .PostAsync(data);
                };
                leftbox.Text = "";
                HorizontalScroll.Visible = false;
            }
            else
            {
                MessageBox.Show("böyle bir oda var!");
            }
        }

        private void Rehber_Click(object sender, EventArgs e)
        {

            if (Program.Instance.ActPnlContainer.Controls["leftpanel"].Created == true)
            {
                Program.Instance.ActPnlContainer.Controls["leftpanel"].Dispose();
            }

            leftpanel um = new leftpanel();
            using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
            {
                var observable = firebase
                    .Child("Accounts")
                    .AsObservable<Accounts>()
                    .Subscribe(d =>
                    {
                        try
                        {

                            um.additem(d.Object.username);
                        }
                        catch
                        {
                        }

                    });

            }

            um.getbox(key, user);
            um.Dock = DockStyle.Fill;

            Program.Instance.ActPnlContainer.Controls.Add(um);
            Program.Instance.ActPnlContainer.Controls["leftpanel"].BringToFront();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (Program.Instance.ActPnlContainer.Controls["leftpanel"].Created == true)
            {
                Program.Instance.ActPnlContainer.Controls["leftpanel"].Dispose();
            }

            leftpanel um = new leftpanel();
            using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
            {
                var observable = firebase
                    .Child("Rooms")
                    .AsObservable<Room>()
                    .Subscribe(d =>
                    {
                        try
                        {

                            um.additem(d.Object.name);
                        }
                        catch
                        {
                        }

                    });

            }
            um.getbox(key, user);
            um.Dock = DockStyle.Fill;

            Program.Instance.ActPnlContainer.Controls.Add(um);
            Program.Instance.ActPnlContainer.Controls["leftpanel"].BringToFront();

        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Program.Instance.aeslogo.Visible = false;
            animation3.Show(Program.Instance.aeslogo);
            if (Program.Instance.ActPnlContainer.Width == 40)
            {
                Program.Instance.ActPnlContainer.Visible = false;
                Program.Instance.ActPnlContainer.Width = 274;
                animator1.Show(Program.Instance.ActPnlContainer);
            }
            else
            {
                Program.Instance.ActPnlContainer.Visible = false;
                Program.Instance.ActPnlContainer.Width = 40;
                animator2.Show(Program.Instance.ActPnlContainer);
            }
            
        }

        private void Leftpanel_Load(object sender, EventArgs e)
        {

            //BunifuImageButton2_Click(sender,e);


        }

    }
}
