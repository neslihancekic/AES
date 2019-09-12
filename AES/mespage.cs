

using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Security.Cryptography;


namespace AES
{
    public partial class mespage : UserControl
    {


        public mespage()
        {

            InitializeComponent();
        }
        string key, username, chatname;

        public void Get_key(string s) { key = s; }
        public void Get_username(string s) { username = s; }
        public void Get_chatname(string s) { chatname = s; }
        private string bytearraytostring(byte[] a)
        {
            string newt = "";
            for(int i = 0; i < a.Length; i++)
            {
                newt += Convert.ToChar(a[i]);
            }
            
            return newt;
        }
        int poss = 10;
        public void Addmessage(byte[] a, string account)
        {
            string s = bytearraytostring(a);
            Invoke(new MethodInvoker(
         delegate
         {
             mespanel.VerticalScroll.Value = 0;
             message item = new AES.message(s, account);
             mespanel.Controls.Add(item);
             item.Top = poss;
             item.Location = new Point(5, poss + mespanel.AutoScrollPosition.Y);
             poss = (item.Top + item.Height + 10);
             mespanel.ScrollControlIntoView(item);
         }));

        }
        public void Addmymessage(byte[] a, string account)
        {
            string s = bytearraytostring(a);
            Invoke(new MethodInvoker(
         delegate
         {
             mespanel.VerticalScroll.Value = 0;
             message item = new AES.message(s, account);
             mespanel.Controls.Add(item);
             item.Top = poss;
             item.Location = new Point(420, poss + mespanel.AutoScrollPosition.Y);
             poss = (item.Top + item.Height + 10);
             mespanel.ScrollControlIntoView(item);
         }));
        }
        public void Addpmessage(string a, byte[] s)
        {
            Image b = byteArrayToImage(s);
            Invoke(new MethodInvoker(
        delegate
        {
            mespanel.VerticalScroll.Value = 0;
            picturemessage item = new AES.picturemessage(a, b);
            mespanel.Controls.Add(item);
            item.Top = poss;
            item.Location = new Point(5, poss + mespanel.AutoScrollPosition.Y);
            poss = (item.Top + item.Height + 10);
            mespanel.ScrollControlIntoView(item);
        }));

        }
        public void Addmypmessage(string a, byte[] s)
        {
          
            Image b = byteArrayToImage(s);
            Invoke(new MethodInvoker(
       delegate
       {
            mespanel.VerticalScroll.Value = 0;
            picturemessage item = new AES.picturemessage(a, b);
            mespanel.Controls.Add(item);
            item.Top = poss;
            item.Left = 420;
            //mespanel.AutoScrollPosition = new Point(0, 0);
            item.Location = new Point(420, poss + mespanel.AutoScrollPosition.Y);
            poss = (item.Top + item.Height + 10);
                mespanel.ScrollControlIntoView(item);
            }));

        }


        private string Encryption(byte[] asciiBytesText, string key)
        {


            en encrypt = new en();


            List<byte[,]> stateList = new List<byte[,]>();

            int counter = 0;

            int numberofmatrix = asciiBytesText.Length / 16;
            if (asciiBytesText.Length % 16 != 0) { numberofmatrix++; }
            for (int a = 0; a < numberofmatrix; a++)
            {
                byte[,] state = new byte[4, 4];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (counter < asciiBytesText.Length)
                        {
                            state[j, i] = asciiBytesText[counter];
                        }
                        else
                        {
                            state[j, i] = 0;
                        }

                        counter++;
                    }
                }
                stateList.Add(state);
            }


            /* HEX TRANSITION OF PLAIN TEXT*/

            /* HEX TRANSITION OF KEY*/
            byte[] asciiBytesKey = Encoding.ASCII.GetBytes(key);

            byte[,] cipherkey = new byte[4, 4];

            counter = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (counter < asciiBytesKey.Length)
                    {
                        cipherkey[j, i] = asciiBytesKey[counter];
                    }
                    else
                    {
                        cipherkey[j, i] = 0;
                    }
                    counter++;
                }
            }

            string newtext = "";

            /* HEX TRANSITION OF KEY*/

            stateList.ForEach(x =>
            {

                x = encrypt.schedule(x, cipherkey);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        newtext += x[j, i] + " ";

                    }
                }
            });

            return newtext;

        }
        private byte[] Decryption(string t, string key)
        {
            dec decrypt = new dec();

            string[] newt = t.Split(' ');

            int charnumber = newt.Length / 16;

            List<byte[,]> stateList = new List<byte[,]>();



            int counter = 0;
            for (int a = 0; a < charnumber; a++)
            {
                byte[,] state = new byte[4, 4];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        state[j, i] = Convert.ToByte(newt[counter]);

                        counter++;
                    }
                }
                stateList.Add(state);
            }

            /* HEX TRANSITION OF PLAIN TEXT*/

            /* HEX TRANSITION OF KEY*/
            byte[] asciiBytesKey = Encoding.ASCII.GetBytes(key);

            byte[,] cipherkey = new byte[4, 4];

            counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (counter < asciiBytesKey.Length)
                    {
                        cipherkey[j, i] = asciiBytesKey[counter];
                    }
                    else
                    {
                        cipherkey[j, i] = 0;
                    }
                    counter++;
                }
            }
            /* HEX TRANSITION OF KEY*/


            List<byte> nbyte = new List<byte>();
            stateList.ForEach(x =>
            {

                x = decrypt.schedule(x, cipherkey);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        nbyte.Add(x[j, i]);

                    }
                }
            });
            byte[] newByte = new byte[nbyte.Count];
            for(int i = 0; i < nbyte.Count; i++)
            {
                newByte[i] = nbyte[i];
            }

            /*string newtext = "";
            stateList.ForEach(x =>
            {

                x = decrypt.schedule(x, cipherkey);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        newtext += Convert.ToChar(x[j, i]);

                    }
                }
            });
            */
            return newByte;
        }




        private async void Sendbutton_Click(object sender, EventArgs e)
        {
            byte[] asciiBytesText = Encoding.ASCII.GetBytes(entermes.Text);
            string ciphertext = Encryption(asciiBytesText, key);
            entermes.Text = "";
            var data = new Data()
            {
                type = "t",
                text = ciphertext,
                account = username,
                room = chatname,
            };

            using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
            {
                await firebase
                    .Child("Messages")
                    .PostAsync(data);
            }
        }
        public byte[] imageToByteArray(Bitmap bitmap)
        {
            byte[] result = null;

            if (bitmap != null)
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, bitmap.RawFormat);
                result = stream.ToArray();
            }

            return result;
            /* MemoryStream ms = new MemoryStream();
             imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
             return ms.ToArray();*/
        }
        public Bitmap byteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                Bitmap bm = new Bitmap(ms);
                return bm;

              // return Image.FromStream(ms);
            }
            /* MemoryStream ms = new MemoryStream(byteArrayIn);
             Image returnImage = Image.FromStream(ms);
             return returnImage;*/
        }

        public void Getfile()
        {
             openFileDialog1.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                Bitmap picture=(Bitmap)Image.FromFile(openFileDialog1.FileName);
                picture.SetResolution(1,1);

                byte[] asciiBytesText = imageToByteArray(picture);
              
               
                
                Invoke((MethodInvoker)async delegate
                 {
                     
                     
                     string ciphertext = Encryption(asciiBytesText, key);
                     entermes.Text = "";
                     var data = new Data()
                     {
                         type = "p",
                         text = ciphertext,
                         account = username,
                         room = chatname,
                     };
                     using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
                     {
                         await firebase
                             .Child("Messages")
                             .PostAsync(data);
                     }
                 });
             }
        }

        [Obsolete]
        private void Picture_Click(object sender, EventArgs e)
        {

            try
            {
                Thread threadGetFile = new Thread(new ThreadStart(Getfile))
                {
                    ApartmentState = ApartmentState.STA
                };
                threadGetFile.Start();
               


            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
            
        }
     

        private void Roompasswordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                roompasswordbox.Visible = false;
                entermes.Visible = true;
                picture.Visible = true;
                sendbutton.Visible = true;
                key = roompasswordbox.Text;
                string  n = null, l = null, t = null;
                byte[] m = null;


                using (FirebaseClient firebase = new FirebaseClient(ConfigurationManager.AppSettings["BasePath"].ToString()))
                {
                    var observable = firebase
                        .Child("Messages")
                        .AsObservable<Data>()
                        .Subscribe(d =>
                        {
                          try
                          {

                                m = Decryption(d.Object.text, key);
                                n = d.Object.account;
                                l = d.Object.room;
                                t = d.Object.type;


                                if (l == chatname)
                                {
                                    if (n == username)
                                    {
                                        if (t == "t")
                                        {
                                            Addmymessage(m, n);

                                        }
                                        else if (t == "p")
                                        {
                                           Addmypmessage(n, m);
                                        }


                                    }
                                    else
                                    {
                                        if (t == "t")
                                        {
                                            Addmessage(m, n);
                                        }
                                        else if (t == "p")
                                        {
                                            Addpmessage(n, m);
                                        }
                                    }
                                }
                          }
                          catch
                          {
                          }



                        });
                }


            }

        }


        private void Entermes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Sendbutton_Click(sender, e);
                e.Handled = true;
            }

        }



        private void Mespage_Load(object sender, EventArgs e)
        {

            /*var auth = ConfigurationManager.AppSettings["AuthSecret"].ToString(); // your app secret
            var client = new FirebaseClient(
              ConfigurationManager.AppSettings["BasePath"].ToString(),
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth)
              });*/

           

            entermes.Visible = false;
            picture.Visible = false;
            sendbutton.Visible = false;



        }


    }
}
