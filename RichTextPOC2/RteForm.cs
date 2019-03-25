using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using r = DevExpress.XtraRichEdit;

namespace RichTextPOC2
{
    public partial class RteForm : Form
    {
        public RteForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var control = (Control)sender;
            var tag = control.Tag.ToString();

            switch (tag)
            {
                case "1":
                    var cmd1 = new r.Commands.SetParagraphHeading1LevelCommand(this.richEditControl1);
                    cmd1.Execute();
                    toolStripStatusLabel1.Text = "SetParagraphHeading1LevelCommand";
                    break;
                case "2":
                    var cmd2 = new r.Commands.SetParagraphHeading2LevelCommand(this.richEditControl1);
                    cmd2.Execute();
                    toolStripStatusLabel1.Text = "SetParagraphHeading2LevelCommand";
                    break;
                case "3":
                    var cmd3 = new r.Commands.SetParagraphHeading3LevelCommand(this.richEditControl1);
                    cmd3.Execute();
                    toolStripStatusLabel1.Text = "SetParagraphHeading3LevelCommand";
                    break;
                case "4":
                    var cmd4 = new r.Commands.SetParagraphHeading4LevelCommand(this.richEditControl1);
                    cmd4.Execute();
                    toolStripStatusLabel1.Text = "SetParagraphHeading4LevelCommand";
                    break;
                case "S":
                    Close();
                    break;
            }
        }

        public void SetHtml(string html)
        {
            richEditControl1.HtmlText = html;
        }

        public string GetHtml()
        {
            return richEditControl1.HtmlText;
        }
    }
}
