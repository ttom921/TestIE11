using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace testMRWebBrowser
{

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //string myFile = Path.Combine(applicationDirectory, "S_RCDATA\\index.html");

            webBrowser1.ScriptErrorsSuppressed = true;
            //http://localhost:4400/ 
            //http://172.18.2.160/

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //object ret = mrWebBrowser.SendToJS("ShowAlert", new object[] { "XXXXXXXXXXXXXXXAAAA" });
            object[] args = { "argString1", "argString2" };
            object ret = webBrowser1.Document.InvokeScript("callMe", args);
        }

        public void OnWebPageReady(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
