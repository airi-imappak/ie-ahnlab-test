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
using WpfApp1.Utils;

namespace WpfApp1
{
    public partial class FormIE : Form
    {
        ExtendedWebBrowser wb = new ExtendedWebBrowser();

        public FormIE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(webBrowser1.Version.ToString());
            //UserAgentHelper.ChangeUserAgent("Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko");
            webBrowser1.Navigate(textBox1.Text);//, null, null, "User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko");
            //wb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko";
            //wb.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                MessageBox.Show(webBrowser1.Document.Title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                var doc = webBrowser1.Document;
                var elem = doc.GetElementFromPoint(new Point(750, 365));
                MessageBox.Show("/" + elem.TagName + "/" + elem.Id + "/" + elem.GetAttribute("class") + "/");
                elem.SetAttribute("value", "test");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }
    }
}
