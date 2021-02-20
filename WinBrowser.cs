using CefSharp;
using CefSharp.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WinBrowser.Helper;

namespace WinBrowser
{
    public partial class WinBrowser : Form
    {
        public ChromiumWebBrowser chromiumWebBrowser;

        private string lastAddress = string.Empty;
        private string nextAddress = string.Empty;
        public WinBrowser()
        {
            InitializeComponent();
            enableCefPropsnSettings();
            loadBrowser();
        }

        private void enableCefPropsnSettings()
        {
            // For high DPI Support
            Cef.EnableHighDPISupport();

            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WinBrowse\\Cache")
            };

            //Example of setting a command line argument
            //Enables WebRTC
            // - CEF Doesn't currently support permissions on a per browser basis see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access
            // - CEF Doesn't currently support displaying a UI for media access permissions
            //
            //NOTE: WebRTC Device Id's aren't persisted as they are in Chrome see https://bitbucket.org/chromiumembedded/cef/issues/2064/persist-webrtc-deviceids-across-restart
            //settings.CefCommandLineArgs.Add("enable-media-stream");
            ////https://peter.sh/experiments/chromium-command-line-switches/#use-fake-ui-for-media-stream
            //settings.CefCommandLineArgs.Add("use-fake-ui-for-media-stream");
            ////For screen sharing add (see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access#comment-58677180)
            //settings.CefCommandLineArgs.Add("enable-usermedia-screen-capturing");

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
        }

        private void loadBrowser()
        {
            chromiumWebBrowser = new ChromiumWebBrowser("www.google.com");
            //chromiumWebBrowser = new ChromiumWebBrowser();
            pnlBrowser.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;
            //chromiumWebBrowser.FindForm();
            chromiumWebBrowser.AddressChanged += ChromiumWebBrowser_AddressChanged;
        }

        private void ChromiumWebBrowser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            this.InvokeSync(f => txtSearchBox.Text = chromiumWebBrowser.Address);
            lastAddress = txtSearchBox.Text;
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                triggerSearch();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            triggerSearch();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser.CanGoBack)
            {
                nextAddress = chromiumWebBrowser.Address;
                chromiumWebBrowser.Load(lastAddress);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser.CanGoForward)
            {
                lastAddress = chromiumWebBrowser.Address;
                chromiumWebBrowser.Load(nextAddress);
            }
        }

        private void triggerSearch()
        {
            chromiumWebBrowser.PerformLayout();
            if (cmbSearchEngine.Text == SearchEngines.Google.ToString())
                chromiumWebBrowser.Load("https://www.google.com/search?q=" + txtSearchBox.Text);
            else if (cmbSearchEngine.Text == SearchEngines.Bing.ToString())
                chromiumWebBrowser.Load("https://www.bing.com/search?q=" + txtSearchBox.Text);
            else if (cmbSearchEngine.Text == SearchEngines.Yahoo.ToString())
                chromiumWebBrowser.Load("https://search.yahoo.com/search?p=" + txtSearchBox.Text);
            else if (cmbSearchEngine.Text == SearchEngines.DuckDuckGo.ToString())
                chromiumWebBrowser.Load("https://duckduckgo.com/?q=" + txtSearchBox.Text);
            else
                chromiumWebBrowser.Load("https://www.bing.com/search?q=" + txtSearchBox.Text);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                chromiumWebBrowser.Dock = DockStyle.Fill;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                chromiumWebBrowser.Dock = DockStyle.Fill;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}

