using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextPOC2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonOpenRTE_Click(object sender, EventArgs e)
        {
            var rteForm = new RteForm();
            if (!string.IsNullOrWhiteSpace(this.richTextBoxHtml.Text))
            {
                rteForm.SetHtml(richTextBoxHtml.Text);
            }
            var result = rteForm.ShowDialog();
            richTextBoxHtml.Text = rteForm.GetHtml();
        }
    }
}
