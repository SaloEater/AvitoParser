using AvitoParser.Properties;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace AvitoParser
{
    public partial class Form1 : Form
    {
        private Dictionary<string, bool> firstOpen;

        //private List<String> removedPosts = new List<String>();

        private List<String> links = new List<String>();

        public int newItemID = 1;

        public Form1()
        {
            InitializeComponent();
            FormClosed += Form1_FormClosed;
            timer1.Interval = int.Parse(textBoxTimerDelay.Text) * 1000;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream file = new FileStream("links.txt", FileMode.Open);
            StreamWriter fileWriter = new StreamWriter(file);

            fileWriter.Write(string.Join("\n", GetActiveLinks().ToArray()));
            fileWriter.Close();
            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstOpen = new Dictionary<string, bool>();
            this.Refresh();
            Console.WriteLine("Removed");

            TabList.Click += TabList_Click;

            GetLinks();         
        }

        private void TabList_Click(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            if (mouseEventArgs.Button == MouseButtons.Right)
            {// iterate through all the tab pages
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    Rectangle r = tabControl.GetTabRect(i);
                    if (r.Contains(mouseEventArgs.Location))
                    {
                        if (i < 2) return;
                        tabControl.SelectedIndex = i;                        
                        contextMenuStrip1.Show(MousePosition);
                    }
                }
            }
        }

        private void GetLinks()
        {
            FileStream file = new FileStream("links.txt", FileMode.Open);
            StreamReader fileReader = new StreamReader(file);

            while (!fileReader.EndOfStream)
            {
                listBoxLinks.Items.Add(fileReader.ReadLine());
            }
            fileReader.Close();
            file.Close();
        }

        private void TimerTask()
        {
            try
            {
                LinkParser linkParser = new LinkParser();
                var links = linkParser.GetProducts(GetActiveLinks());
                DeployNewScanResuls(links);
                DateTime timer = DateTime.Now.AddSeconds(GetTimerNumber());
            }
            catch
            {
                //Just for push
                int a = 0;
            }              
        }

        private List<string> GetActiveLinks()
        {
            List<string> list = new List<string>();
            foreach(string link in listBoxLinks.Items)
            {
                list.Add(link);
            }

            return list;
        }

        private double GetTimerNumber()
        {
            return Convert.ToDouble(textBoxTimerDelay.Text);
        }

        public void DeployNewScanResuls(Dictionary<String, List<Link>> productsList)
        {
            newItemID = 0;
            foreach(KeyValuePair<String, List<Link>> products in productsList)
            {
                foreach (Link product in products.Value)
                {
                    AddProductToTab(GetTab("tabPage" + products.Key), product);
                }
                firstOpen[products.Key] = false;
            }
            
        }

        private void MoveElementsHigher(int v, Control.ControlCollection controls, int height)
        {
            for (int i = v; i < controls.Count; i++)
            {
                controls[i].Location = new Point(controls[i].Location.X, controls[i].Location.Y - height);
            }
        }

        private TabPage GetTab(string tabName)
        {
            foreach (TabPage tabPage in TabList.TabPages)
            {
                if (tabPage.Name.Equals(tabName)) return tabPage;
            }
            return CreateTabPage(tabName);
        }

        private TabPage CreateTabPage(string tabName)
        {
            string[] splitted = tabName.Split('/');
            TabPage tabPage = new TabPage();
            tabPage.Name = tabName;
            tabPage.Text = splitted[splitted.Length-2]+'/'+ splitted[splitted.Length - 1];
            tabPage.AutoScroll = true;

            LinkTabPage panel = new LinkTabPage(); 

            tabPage.Controls.Add(panel);
            TabList.Controls.Add(tabPage);

            firstOpen.Add(tabName, true);

            return tabPage;
        }

        private bool NotificationAllowed()
        {
            return checkBox1.CheckState == CheckState.Checked ? true : false;
        }

        private void ShowNotification(Link product)
        {
            var osInfo = OSVersionInfo.GetOSVersionInfo();
            Notification toastNotification = new Notification(product.title, product.price, 5, FormAnimator.AnimationMethod.Center, FormAnimator.AnimationDirection.Up, product.link);
            toastNotification.Show();
        }

        private bool IsNewItem(TabPage page, Link product)
        {
            foreach(Control p in page.Controls)
            {
                if (p.GetType() != typeof(Product)) continue;
                Product item = (Product)p;
                if (item.link.Equals(product.link)) return false;
            }
            return true;
        } 

        private void AddProductToTab(TabPage page, Link product)
        {
            if (IsNewItem(page, product))
            {
                AddProduct(page, product);
                if(!firstOpen[page.Name])ShowNotification(product);
            }
        }

        private void AddProduct(TabPage page, Link product)
        {
            Product item = new Product(product);

            ((LinkTabPage)page.Controls[0]).AddToQueue(item);
        }

        private void ButtonRemoveLink_Click(object sender, EventArgs e)
        {
            ((Control)sender).Parent.Dispose();
        }

        private void buttonLoadLinksFromFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Abort || result == DialogResult.Cancel) return;

            FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader fileReader = new StreamReader(fileStream);

            while(!fileReader.EndOfStream)
            {
                listBoxLinks.Items.Add(fileReader.ReadLine());
            }

        }

        private void buttonClearLinks_Click(object sender, EventArgs e)
        {
            listBoxLinks.Items.Clear();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TabList.SelectedIndex > 1)
            {
                int nextIndex = TabList.SelectedIndex - 1;
                TabList.SelectedTab.Dispose();
                TabList.SelectedIndex = nextIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinkInput linkInput = new LinkInput(listBoxLinks);
            linkInput.Show();
        }

        private void buttonRemoveLink_Click_1(object sender, EventArgs e)
        {
            listBoxLinks.Items.RemoveAt(listBoxLinks.SelectedIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(TimerTask));
                thread.Start();
            }
            catch (Exception)
            {
                Notification toastNotification = new Notification("Ошибка Авито", "", 5, FormAnimator.AnimationMethod.Center, FormAnimator.AnimationDirection.Up, "error");
                toastNotification.Show();
            }
        }

        private void textBoxTimerDelay_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBoxTimerDelay.Text) * 1000;
        }
    }
}
