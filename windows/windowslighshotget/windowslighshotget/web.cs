using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace printfinder
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void web_Load(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            try
            {
                webBrowser1.Url = new Uri(vars.fulllink.ToLower());
            }
            catch
            {
                webBrowser1.Url = new Uri("data: image / jpeg; base64,/ 9j / 4AAQSkZJRgABAQAAAQABAAD / 2wCEAAkGBw8PDw8NDRAPDQ8QDw0NDQ0ODQ8PDw8NFRUWFhUVFhUYHiggGBolGxUVITEiJSkrLi4uFx8zODMtNygtLisBCgoKDg0OFxAQGi0lHx0rLS0rKy0tLS0rLSstLS0tKy0rLS0tLS0tLS0tLS0tLS0rKy0tLS0tLS0tLS0tLS0tLf / AABEIAMIBAwMBIgACEQEDEQH / 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");
            }
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.InnerHtml = webBrowser1.Document.GetElementById("screenshot-image").OuterHtml;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
                string link =main.RandomString(6);
                vars.fulllink = "https://prnt.sc/" + link;
                webBrowser1.Url = new Uri(vars.fulllink.ToLower());
                webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;


            Thread.Sleep(100);
            this.Update();
            
        }
    }
}
