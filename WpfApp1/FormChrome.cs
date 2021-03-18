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
using WpfApp1.Utils;

namespace WpfApp1
{
    public partial class FormChrome : Form
    {
        string title;

        public FormChrome()
        {
            InitializeComponent();
            Cef.Initialize(new CefSettings());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(title) == false)
            {
                MessageBox.Show(title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var doc = chromiumWebBrowser1.Document;
            //var elem = doc.ElementFromPoint(750, 365);
            //MessageBox.Show("/" + elem.TagName + "/" + elem.GetAttribute("id") + "/" + elem.GetAttribute("class") + "/");
            //elem.SetAttribute("value", "test");
            //chromiumWebBrowser1.ExecuteScriptAsync("document.getElementsByName('userid')[0].value='test';document.getElementsByName('password')[0].value='test';");
            chromiumWebBrowser1.ExecuteScriptAsync("document.getElementById('ibx_psnNo').value='test';document.getElementById('ibx_pwd').value='test';");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
        }

        private void chromiumWebBrowser1_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            title = e.Title;
        }
    }
}
