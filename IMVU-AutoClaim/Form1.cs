using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace IMVU_AutoClaim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Button.CheckForIllegalCrossThreadCalls = false;

            //webBrowser1.Navigate("https://imvu.com/next/home/", null, null, "User-Agent:Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.157 Mobile Safari/537.36");
        }

        //create cefBrowser instance
        public ChromiumWebBrowser browser;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            browser = new ChromiumWebBrowser("https://pt.secure.imvu.com/");
            browser.Dock = DockStyle.Fill;
            
            Controls.Add(browser);
            browser.Visible = false;
            browser.LoadingStateChanged += OnLoadingStateChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chromiumWebBrowser1.Load("https://www.google.com/");
            label6.Text = "Please login to get started";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Click login button
            var scriptClickLoginPage = @"document.getElementsByClassName('sign-in')[0].click();";
            browser.ExecuteScriptAsync(scriptClickLoginPage);

            //Fill in the access fields
            var scriptFillUserName = @"document.getElementsByName('avatarname')[0].value = '" + textBox1.Text + "'";
            var scriptFillPassword = @"document.getElementsByName('password')[0].value = '" + textBox2.Text + "'";

            browser.ExecuteScriptAsync(scriptFillUserName);
            browser.ExecuteScriptAsync(scriptFillPassword);

            //Click login button
            var scriptClickLoginButton = @"document.getElementsByClassName('btn-primary')[0].click();";
            browser.ExecuteScriptAsync(scriptClickLoginButton);


            //check if the user page was loaded correctly
            while (checkLogin() == false)
            {
                checkLogin();
                
            }

            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            timer1.Start();
        }

        public bool checkLogin()
        {
            if (browser.Address.ToString().Contains("/next/home/"))
            {
                MessageBox.Show("Success, your account " + "(" + textBox1.Text + ")" + " has been logged in");
                label2.Text = textBox1.Text;
                label6.Text = "Loading...";
                return true;
                
            }

            return false;
        }
       
        //document.getElementsByClassName('reward-name')[0].textContent;
        //document.getElementsByClassName('reward-description')[0].textContent;
        //document.getElementsByClassName('dialog-x')[0].click();
        private async void button4_Click(object sender, EventArgs e)
        {
            //Get Credit balance
            string scriptChkCredits = "document.getElementsByClassName('wallet-balance__value')[0].textContent;";
            JavascriptResponse response = await browser.EvaluateScriptAsync(scriptChkCredits);
            string resultS = response.Result.ToString();

            label1.Text = resultS;

            label6.Text = "AutoClaim started successfully!";
            label8.Text = "Working!";
            label8.ForeColor = Color.Green;
            timer2.Start();
        }


        //Check that the web page has completely loaded
        //Invoke button login
        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            if (!args.IsLoading)
            {
                button1.BeginInvoke((Action)delegate ()
                {
                    button1.Enabled = true;
                    
                });
            }
        }

        //Start page load timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            button4.Enabled = true;
            label6.Text = "Please start now";
            timer1.Stop();
        }

        //Start autoClaim injection
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Click wallet button
            var scriptClickWallet = @"document.getElementsByClassName('wallet-balance')[0].click();";
            browser.ExecuteScriptAsync(scriptClickWallet);
            //check if the bonus is released
            var scriptCheckBonus = @"document.getElementsByClassName('available')[0].click();";
            browser.ExecuteScriptAsync(scriptCheckBonus);
            //spin now
            var scriptSpinNow = @"document.getElementsByClassName('spin')[0].click();";
            browser.ExecuteScriptAsync(scriptSpinNow);
            //Close Spin
            var scriptCloseSpin = @"document.getElementsByClassName('dialog-x')[0].click();";
            browser.ExecuteScriptAsync(scriptCloseSpin);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
