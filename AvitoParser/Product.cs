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
    public partial class Product : UserControl
    {
        public string link;
        List<string> removedPosts;
        int itemSpace = 0;

        public Product(Link product)
        {
            InitializeComponent();
            labelTitle.Text = product.title;
            labelPrice.Text = product.price;
            link = product.link;
        }

        public void SetRemovedPosts(List<string> removedPosts)
        {
            this.removedPosts = removedPosts;
        }

        public void SetItemSpace(int space)
        {
            itemSpace = space;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Chrome.exe", link);

            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show("Google Chrome не обнаружен");
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var parentControls = Parent.Controls;
            for (int i = 0; i < parentControls.Count; i++)
            {
                if (parentControls[i].GetType() != typeof(Product)) continue;
                var item = ((Product)parentControls[i]);
                if (item.link.Equals(link)) continue;
                item.Location = new Point(item.Location.X, item.Location.Y - Height - itemSpace);
            }
            removedPosts.Add(link);
            Dispose();
        }
    }
}
