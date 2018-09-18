namespace AvitoParser
{
    partial class LinkInput
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
            this.richTextBoxLinks = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxLinks
            // 
            this.richTextBoxLinks.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxLinks.Name = "richTextBoxLinks";
            this.richTextBoxLinks.Size = new System.Drawing.Size(256, 128);
            this.richTextBoxLinks.TabIndex = 0;
            this.richTextBoxLinks.Text = "";
            // 
            // LinkInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 146);
            this.Controls.Add(this.richTextBoxLinks);
            this.Name = "LinkInput";
            this.Text = "LinkInput";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLinks;
    }
}