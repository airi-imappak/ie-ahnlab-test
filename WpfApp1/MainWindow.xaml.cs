using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Utils;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private FormFireFox form1;
        private WindowEdge win1;
        private FormIE form2;
        private FormChrome form3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser1.Navigate(textBox1.Text);//, null, null, "User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; rv:11.0) like Gecko" + Environment.NewLine);
            }
            catch { }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (webBrowser1.IsLoaded == false) return;
            var doc = webBrowser1.Document as mshtml.HTMLDocument;
            MessageBox.Show(doc.title);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (webBrowser1.IsLoaded == false) return;

            var doc = webBrowser1.Document as mshtml.HTMLDocument;
            //var elem = doc.elementFromPoint(750, 365); ga.shinhan
            ////https://hmp.hanwhalife.com/online/ga
            //var elem = doc.elementFromPoint(550, 180);
            //MessageBox.Show("/" + elem.tagName + "/" + elem.id + "/" + elem.className + "/");
            //elem.setAttribute("value", "test");
            //elem = doc.elementFromPoint(550, 250);
            //MessageBox.Show("/" + elem.tagName + "/" + elem.id + "/" + elem.className + "/");
            //elem.setAttribute("value", "test");
            ////http://u-channel-ga.samsunglife.com/
            //var elem = doc.getElementById("muserid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("pass");
            //elem.setAttribute("value", "test");
            ////https://e-life.heungkuklife.co.kr
            //var elem = doc.getElementById("EMPN");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("PWD");
            //elem.setAttribute("value", "test");
            ////http://ga.myangel.co.kr/?incar
            //var elem = doc.getElementById("mf_wfmMain_ibxId");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("mf_wfmMain_ibxPassword");
            //elem.setAttribute("value", "test");
            ////https://erp.samsungfire.com
            //var elem = doc.getElementById("j_userid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("j_password");
            //elem.setAttribute("value", "test");
            ////https://sp.hi.co.kr/
            //var elem = doc.getElementById("ipt_id");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("ipt_password");
            //elem.setAttribute("value", "test");
            ////https://www.mdbins.com/
            //var frame1 = doc.frames.item(1) as mshtml.HTMLWindow2;
            //var doc1 = frame1.document as mshtml.HTMLDocument;
            //var elem = doc1.getElementById("username_tmp");
            //elem.setAttribute("value", "test");
            //elem = doc1.getElementById("password");
            //elem.setAttribute("value", "test");
            ////http://sales.meritzfire.com/
            //var elem = doc.getElementById("userid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("password");
            //elem.setAttribute("value", "test");
            ////http://portal.hwgeneralins.com/?incar popup 처리 코드 추가 필요
            //var elems = doc.getElementsByName("userid");
            //if (elems != null && elems.length > 0)
            //    elems.item(0).setAttribute("value", "test");
            //elems = doc.getElementsByName("password");
            //if (elems != null && elems.length > 0)
            //    elems.item(0).setAttribute("value", "test");
            ////http://sales.kbinsure.co.kr
            //var elem = doc.getElementById("userid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("pwd");
            //elem.setAttribute("value", "test");
            ////https://lottero.lotteins.co.kr/ncrmwebroot/webfw/html/nawlogon.jsp
            //var elem = doc.getElementById("pfmStfno");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("pfmPwd");
            //elem.setAttribute("value", "test");
            ////https://ga.shinhanlife.co.kr/gas/loginVw3.do
            //var elem = doc.getElementById("prafNo");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("loginPassword");
            //elem.setAttribute("value", "test");
            ////https://ga.aig.co.kr/login.do
            //var elem = doc.getElementById("userid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("passwd");
            //elem.setAttribute("value", "test");
            ////https://sales.heungkukfire.co.kr/#/login
            //var elems = doc.getElementsByTagName("input");
            //foreach (mshtml.IHTMLElement elem in elems)
            //{
            //    if (elem.className.Contains("-fdp-text-field__input"))
            //    {
            //        elem.setAttribute("value", "test");
            //    }
            //}
            //elems = doc.getElementsByName("usrPswd");
            //if (elems != null && elems.length > 0)
            //    elems.item(0).setAttribute("value", "test");
            ////https://sso.kyobo.com:5443/3rdParty/certLoginFormPage.jsp
            //var elem = doc.getElementById("userid");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("password");
            //elem.setAttribute("value", "test");
            ////https://ga.orangelife.co.kr/comanga001m.mdv
            //var elem = doc.getElementById("txtFcNo");
            //elem.setAttribute("value", "test");
            //elem = doc.getElementById("txtPw");
            //elem.setAttribute("value", "test");
            //https://sfa.nhlife.co.kr:8443/
            var elem = doc.getElementById("ibx_psnNo");
            elem.setAttribute("value", "test");
            elem = doc.getElementById("ibx_pwd");
            elem.setAttribute("value", "test");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            form1 = new FormFireFox();
            form1.Show();
            form1.Focus();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            win1 = new WindowEdge();
            win1.Show();
            win1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            form2 = new FormIE();
            form2.Show();
            form2.Focus();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            form3 = new FormChrome();
            form3.Show();
            form3.Focus();
        }
    }
}
