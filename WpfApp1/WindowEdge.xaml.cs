using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WindowEdge : Window
    {
        string html;

        public WindowEdge()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            //webView.NavigationStarting += EnsureHttps;

            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
            webView.CoreWebView2.WebResourceResponseReceived += CoreWebView2_WebResourceResponseReceived;

            //await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        private async void CoreWebView2_WebResourceResponseReceived(object sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            //var stream = await e.Response.GetContentAsync();
        }

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            var msg = e.WebMessageAsJson;
            if (string.IsNullOrEmpty(msg) == false)
            {
                msg = e.TryGetWebMessageAsString();
                html = msg;
            }
            //webView.CoreWebView2.PostWebMessageAsString(msg);
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            var uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            webView.CoreWebView2.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (webView.IsLoaded == false) return;
            MessageBox.Show(webView.CoreWebView2.DocumentTitle);
        }

        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            if (webView.IsLoaded == false) return;

            //var doc = new mshtml.HTMLDocument();
            ////await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(document.documentElement.outerHTML);");
            ////var res = webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("function evalHtml() { return document.documentElement.outerHTML; }");
            //////res.Wait();
            ////html = string.Empty;
            ////await webView.CoreWebView2.ExecuteScriptAsync("window.chrome.webview.postMessage(document.documentElement.outerHTML)");
            ////////res.Wait();
            //////var html = res.Result;
            ////doc.write(html);

            //if (doc == null) return;

            //var elem = doc.elementFromPoint(750, 365);
            //var elem = doc.elementFromPoint(550, 180);
            //MessageBox.Show("/" + elem.tagName + "/" + elem.id + "/" + elem.className + "/");
            //elem.setAttribute("value", "test");
            //elem = doc.elementFromPoint(550, 250);
            //MessageBox.Show("/" + elem.tagName + "/" + elem.id + "/" + elem.className + "/");
            //elem.setAttribute("value", "test");
            //await webView.ExecuteScriptAsync("document.getElementById('txtFcNo').value='test';document.getElementById('txtPw').value='test';");
            //await webView.ExecuteScriptAsync("document.getElementsByName('userid')[0].value='test';document.getElementsByName('password')[0].value='test';");
            //await webView.ExecuteScriptAsync(";document.getElementById('usrPswd').value='test';");
            //await webView.ExecuteScriptAsync(";alert('test1');pwd=document.getElementById('usrPswd');alert('test2');pwd.value='test';alert('test3');pwd.dispatchEvent(new Event('focus'));alert('test4');pwd.dispatchEvent(new KeyboardEvent('keypress',{'key':'\n'}));alert('test5');document.getElementsByClassName('-fdp-text-field__input')[0].value='test';");
            //await webView.ExecuteScriptAsync(";pwd=document.getElementById('usrPswd');pwd.value='test';");
            await webView.ExecuteScriptAsync(";pwd=$('#usrPswd');pwd.val('test');pwd.keypress();");
            //await webView.ExecuteScriptAsync(";pwd.dispatchEvent(new KeyboardEvent('keypress',{keyCode:13}));");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                webView.CoreWebView2.Navigate(textBox1.Text);
            }
        }
    }
}
