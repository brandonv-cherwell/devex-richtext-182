﻿namespace RichTextPOC2
{
    partial class RteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHeading4 = new System.Windows.Forms.Button();
            this.buttonHeading3 = new System.Windows.Forms.Button();
            this.buttonHeading2 = new System.Windows.Forms.Button();
            this.buttonHeading1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonHeading4);
            this.panel1.Controls.Add(this.buttonHeading3);
            this.panel1.Controls.Add(this.buttonHeading2);
            this.panel1.Controls.Add(this.buttonHeading1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(500, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 72);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Tag = "S";
            this.buttonSave.Text = "Save and Close";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonHeading4
            // 
            this.buttonHeading4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHeading4.Location = new System.Drawing.Point(375, 0);
            this.buttonHeading4.Name = "buttonHeading4";
            this.buttonHeading4.Size = new System.Drawing.Size(125, 72);
            this.buttonHeading4.TabIndex = 3;
            this.buttonHeading4.Tag = "4";
            this.buttonHeading4.Text = "Heading 4";
            this.buttonHeading4.UseVisualStyleBackColor = true;
            this.buttonHeading4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonHeading3
            // 
            this.buttonHeading3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHeading3.Location = new System.Drawing.Point(250, 0);
            this.buttonHeading3.Name = "buttonHeading3";
            this.buttonHeading3.Size = new System.Drawing.Size(125, 72);
            this.buttonHeading3.TabIndex = 2;
            this.buttonHeading3.Tag = "3";
            this.buttonHeading3.Text = "Heading 3";
            this.buttonHeading3.UseVisualStyleBackColor = true;
            this.buttonHeading3.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonHeading2
            // 
            this.buttonHeading2.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHeading2.Location = new System.Drawing.Point(125, 0);
            this.buttonHeading2.Name = "buttonHeading2";
            this.buttonHeading2.Size = new System.Drawing.Size(125, 72);
            this.buttonHeading2.TabIndex = 1;
            this.buttonHeading2.Tag = "2";
            this.buttonHeading2.Text = "Heading 2";
            this.buttonHeading2.UseVisualStyleBackColor = true;
            this.buttonHeading2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonHeading1
            // 
            this.buttonHeading1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHeading1.Location = new System.Drawing.Point(0, 0);
            this.buttonHeading1.Name = "buttonHeading1";
            this.buttonHeading1.Size = new System.Drawing.Size(125, 72);
            this.buttonHeading1.TabIndex = 0;
            this.buttonHeading1.Tag = "1";
            this.buttonHeading1.Text = "Heading 1";
            this.buttonHeading1.UseVisualStyleBackColor = true;
            this.buttonHeading1.Click += new System.EventHandler(this.button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.richEditControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 378);
            this.panel2.TabIndex = 1;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(800, 378);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // RteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RteForm";
            this.Text = "RTE Form 18.2.7";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHeading4;
        private System.Windows.Forms.Button buttonHeading3;
        private System.Windows.Forms.Button buttonHeading2;
        private System.Windows.Forms.Button buttonHeading1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}