using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvitoParser
{
    public partial class LinkTabPage : UserControl
    {
        int itemSize = 94;

        List<String> removedPosts = new List<String>();

        List<Product> queue = new List<Product>();

        bool queueRecreated = false;

        public LinkTabPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void Add(Product item)
        {
            if (removedPosts.Contains(item.link) || ExistProduct(item)) return;
            item.SetItemSpace(buttonClear.Top);
            item.SetRemovedPosts(removedPosts);
            foreach(Control c in panel1.Controls)
            {
                if (c.GetType() != typeof(Product)) continue;
                c.Location = new Point(c.Location.X, c.Location.Y + itemSize + buttonClear.Top);
            }
            item.Location = new Point(0, buttonClear.Top*2 + buttonClear.Height);
            panel1.Controls.Add(item);
        }

        private bool ExistProduct(Product item)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c.GetType() != typeof(Product)) continue;
                Product product = (Product)c;
                if (product.link.Equals(item.link)) return true;
            }
            return false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < panel1.Controls.Count; i++)
            {
                Control c = panel1.Controls[i];
                if (c.GetType() != typeof(Product)) continue;
                Product product = (Product)c;
                removedPosts.Add(product.link);
                c.Dispose();
                i--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(new Product(new Link()));
        }

        public void ForceRefresh()
        {
            queueRecreated = true;
        }

        internal void AddToQueue(Product item)
        {
            queue.Add(item);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(queueRecreated)
            {
                queueRecreated = false;
                foreach (Product item in queue)
                    Add(item);
            }
        }
    }
}
