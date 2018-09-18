namespace AvitoParser {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxTimerDelay = new System.Windows.Forms.TextBox();
            this.TabList = new System.Windows.Forms.TabControl();
            this.tabPageLinks = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRemoveLink = new System.Windows.Forms.Button();
            this.listBoxLinks = new System.Windows.Forms.ListBox();
            this.panelLinks = new System.Windows.Forms.Panel();
            this.buttonLoadLinksFromFile = new System.Windows.Forms.Button();
            this.buttonClearLinks = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPageSettings.SuspendLayout();
            this.TabList.SuspendLayout();
            this.tabPageLinks.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.AutoScroll = true;
            this.tabPageSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageSettings.Controls.Add(this.checkBox1);
            this.tabPageSettings.Controls.Add(this.textBox2);
            this.tabPageSettings.Controls.Add(this.textBoxTimerDelay);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(761, 455);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Настройки";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Включить оповещения";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Задержка между проверками";
            // 
            // textBoxTimerDelay
            // 
            this.textBoxTimerDelay.Location = new System.Drawing.Point(6, 6);
            this.textBoxTimerDelay.Name = "textBoxTimerDelay";
            this.textBoxTimerDelay.Size = new System.Drawing.Size(50, 20);
            this.textBoxTimerDelay.TabIndex = 2;
            this.textBoxTimerDelay.Text = "5";
            this.textBoxTimerDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimerDelay.TextChanged += new System.EventHandler(this.textBoxTimerDelay_TextChanged);
            // 
            // TabList
            // 
            this.TabList.Controls.Add(this.tabPageSettings);
            this.TabList.Controls.Add(this.tabPageLinks);
            this.TabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabList.Location = new System.Drawing.Point(0, 0);
            this.TabList.Name = "TabList";
            this.TabList.Padding = new System.Drawing.Point(50, 3);
            this.TabList.SelectedIndex = 0;
            this.TabList.Size = new System.Drawing.Size(769, 481);
            this.TabList.TabIndex = 0;
            // 
            // tabPageLinks
            // 
            this.tabPageLinks.AutoScroll = true;
            this.tabPageLinks.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageLinks.Controls.Add(this.button2);
            this.tabPageLinks.Controls.Add(this.buttonRemoveLink);
            this.tabPageLinks.Controls.Add(this.listBoxLinks);
            this.tabPageLinks.Controls.Add(this.panelLinks);
            this.tabPageLinks.Controls.Add(this.buttonLoadLinksFromFile);
            this.tabPageLinks.Controls.Add(this.buttonClearLinks);
            this.tabPageLinks.Location = new System.Drawing.Point(4, 22);
            this.tabPageLinks.Name = "tabPageLinks";
            this.tabPageLinks.Size = new System.Drawing.Size(761, 455);
            this.tabPageLinks.TabIndex = 2;
            this.tabPageLinks.Text = "Ссылки";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRemoveLink
            // 
            this.buttonRemoveLink.Location = new System.Drawing.Point(294, 3);
            this.buttonRemoveLink.Name = "buttonRemoveLink";
            this.buttonRemoveLink.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveLink.TabIndex = 12;
            this.buttonRemoveLink.Text = "Удалить";
            this.buttonRemoveLink.UseVisualStyleBackColor = true;
            this.buttonRemoveLink.Click += new System.EventHandler(this.buttonRemoveLink_Click_1);
            // 
            // listBoxLinks
            // 
            this.listBoxLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLinks.FormattingEnabled = true;
            this.listBoxLinks.Location = new System.Drawing.Point(4, 32);
            this.listBoxLinks.Name = "listBoxLinks";
            this.listBoxLinks.Size = new System.Drawing.Size(749, 420);
            this.listBoxLinks.TabIndex = 11;
            // 
            // panelLinks
            // 
            this.panelLinks.AutoScroll = true;
            this.panelLinks.AutoSize = true;
            this.panelLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLinks.Location = new System.Drawing.Point(4, 33);
            this.panelLinks.Name = "panelLinks";
            this.panelLinks.Size = new System.Drawing.Size(0, 0);
            this.panelLinks.TabIndex = 10;
            // 
            // buttonLoadLinksFromFile
            // 
            this.buttonLoadLinksFromFile.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLoadLinksFromFile.Location = new System.Drawing.Point(84, 3);
            this.buttonLoadLinksFromFile.Name = "buttonLoadLinksFromFile";
            this.buttonLoadLinksFromFile.Size = new System.Drawing.Size(123, 23);
            this.buttonLoadLinksFromFile.TabIndex = 8;
            this.buttonLoadLinksFromFile.Text = "Загрузить из файла";
            this.buttonLoadLinksFromFile.UseVisualStyleBackColor = false;
            this.buttonLoadLinksFromFile.Click += new System.EventHandler(this.buttonLoadLinksFromFile_Click);
            // 
            // buttonClearLinks
            // 
            this.buttonClearLinks.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClearLinks.Location = new System.Drawing.Point(3, 3);
            this.buttonClearLinks.Name = "buttonClearLinks";
            this.buttonClearLinks.Size = new System.Drawing.Size(75, 23);
            this.buttonClearLinks.TabIndex = 7;
            this.buttonClearLinks.Text = "Очистить";
            this.buttonClearLinks.UseVisualStyleBackColor = false;
            this.buttonClearLinks.Click += new System.EventHandler(this.buttonClearLinks_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(769, 481);
            this.Controls.Add(this.TabList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Avito Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.TabList.ResumeLayout(false);
            this.tabPageLinks.ResumeLayout(false);
            this.tabPageLinks.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabControl TabList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxTimerDelay;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPageLinks;
        private System.Windows.Forms.Button buttonClearLinks;
        private System.Windows.Forms.Button buttonLoadLinksFromFile;
        private System.Windows.Forms.Panel panelLinks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxLinks;
        private System.Windows.Forms.Button buttonRemoveLink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

