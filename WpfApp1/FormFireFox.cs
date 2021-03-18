using Gecko;
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
    public partial class FormFireFox : Form
    {
        public FormFireFox()
        {
            InitializeComponent();
            Xpcom.EnableProfileMonitoring = false;
            var dir = Path.GetDirectoryName(Application.ExecutablePath);
            Xpcom.Initialize(Path.Combine(dir, "Firefox"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geckoWebBrowser1.DocumentTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var doc = geckoWebBrowser1.Document;
            //https://hmp.hanwhalife.com/online/ga
            //var elem = doc.ElementFromPoint(350, 170);
            //MessageBox.Show("/" + elem.TagName + "/" + elem.GetAttribute("id") + "/" + elem.GetAttribute("class") + "/");
            //elem.SetAttribute("value", "test");
            //elem = doc.ElementFromPoint(350, 230);
            //MessageBox.Show("/" + elem.TagName + "/" + elem.GetAttribute("id") + "/" + elem.GetAttribute("class") + "/");
            //elem.SetAttribute("value", "test");
            //http://u-channel-ga.samsunglife.com/
            var elem = doc.GetElementById("ibx_psnNo");
            elem.SetAttribute("value", "test");
            elem = doc.GetElementById("ibx_pwd");
            elem.SetAttribute("value", "test");
            ////http://portal.hwgeneralins.com/?incar
            //var elems = doc.GetElementsByName("userid");
            //if (elems != null && elems.Length > 0)
            //    elems[0].SetAttribute("value", "test");
            //elems = doc.GetElementsByName("password");
            //if (elems != null && elems.Length > 0)
            //    elems[0].SetAttribute("value", "test");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                geckoWebBrowser1.Navigate(textBox1.Text);
            }
        }
    }
}
