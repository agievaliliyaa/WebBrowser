using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebBrowser
{
    public partial class MainForm : Form
    {
        int i = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddTabBtn_Click(object sender, EventArgs e)
        {

            WebBrowser webBrowser = new WebBrowser();   
            webBrowser.Visible = true;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            MainTabControl.TabPages.Add("New Page");
            MainTabControl.SelectTab(i);
            MainTabControl.SelectedTab.Controls.Add(webBrowser);
            i += 1;

        }

        void webBrowser_DocumentCompleted (object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MainTabControl.SelectedTab.Text = ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            if (FavTabBtn.Text != null)
            {
                ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).Navigate(FavTabBtn.Text);
            }
            else
            {

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).GoBack();  
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).GoForward();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).Refresh();
        }

        private void DeleteTabBtn_Click(object sender, EventArgs e)
        {
            if(MainTabControl.TabPages.Count > 1)
            {
                MainTabControl.TabPages.RemoveAt(MainTabControl.SelectedIndex);
                MainTabControl.SelectTab(MainTabControl.TabPages.Count - 1);
                i -= 1;
            }
            else
            {
                Application.Exit();
            }
        }

        private void SearchTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).Navigate(FavTabBtn.Text);
            }
            else
            {

            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)MainTabControl.SelectedTab.Controls[0]).Stop();
        }

      
    }
}
