namespace RichTextPOC2
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.richTextBoxHtml = new System.Windows.Forms.RichTextBox();
            this.buttonOpenRTE = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonOpenRTE);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 82);
            this.panelHeader.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.statusStrip1);
            this.panelBody.Controls.Add(this.richTextBoxHtml);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 82);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 368);
            this.panelBody.TabIndex = 1;
            // 
            // richTextBoxHtml
            // 
            this.richTextBoxHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHtml.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxHtml.Name = "richTextBoxHtml";
            this.richTextBoxHtml.Size = new System.Drawing.Size(800, 368);
            this.richTextBoxHtml.TabIndex = 0;
            this.richTextBoxHtml.Text = "";
            // 
            // buttonOpenRTE
            // 
            this.buttonOpenRTE.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpenRTE.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenRTE.Name = "buttonOpenRTE";
            this.buttonOpenRTE.Size = new System.Drawing.Size(184, 82);
            this.buttonOpenRTE.TabIndex = 0;
            this.buttonOpenRTE.Text = "Open RTE";
            this.buttonOpenRTE.UseVisualStyleBackColor = true;
            this.buttonOpenRTE.Click += new System.EventHandler(this.buttonOpenRTE_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "formMain";
            this.Text = "Main Form";
            this.panelHeader.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.RichTextBox richTextBoxHtml;
        private System.Windows.Forms.Button buttonOpenRTE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

