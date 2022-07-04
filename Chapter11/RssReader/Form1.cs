using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        IEnumerable<string> xTitle,xLink;

        public Form1()
        {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e)
        {
            ClearPage();
            using (var wc = new WebClient())
            {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));
                foreach (var data in xTitle)
                {
                    lbRssTitle.Items.Add(data);
                }
                if (!cbRssUrl.Items.Contains(cbRssUrl.Text)) {
                    cbRssUrl.Items.Add(cbRssUrl.Text);
                }
            
            }

        }

        private void ClearPage() {
            lbRssTitle.Items.Clear();
        }

        private void cbRssUrl_TextChanged(object sender, EventArgs e) {
            if (cbRssUrl.Text != "") {
                btRssGet.Enabled = true;
            }
            if (cbRssUrl.Text == "") {
                btRssGet.Enabled = false;
            }
        }

        private void btForward_Click(object sender, EventArgs e) {
            wvBrouser.GoForward();
        }

        private void btBack_Click(object sender, EventArgs e) {
            wvBrouser.GoBack();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackForwardButtonMuskCheck();
        }

        private void wvBrouser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            BackForwardButtonMuskCheck();
        }

        private void lbRssTitle_Click(object sender, EventArgs e)
        {
                int index = lbRssTitle.SelectedIndex;   //選択した箇所のインデックスを取得（０～　）
                if (index == -1) return;
                var url = xLink.ElementAt(index);
                wvBrouser.Source =new Uri(url);
            
        }

        private void BackForwardButtonMuskCheck() {
            btBack.Enabled = wvBrouser.CanGoBack;
            btForward.Enabled = wvBrouser.CanGoForward;
        }
    }
}
