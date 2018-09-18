using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvitoParser
{
    public partial class LinkInput : Form
    {
        ListBox listBox;

        public LinkInput(ListBox listBoxLinks)
        {
            InitializeComponent();
            listBox = listBoxLinks;
            FormClosed += LinkInput_FormClosed;
        }

        private void LinkInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] links = richTextBoxLinks.Text.Split('\n');
            foreach(string link in links)
            {
                if(!listBox.Items.Contains(link) && link != "")listBox.Items.Add(link);
            }
        }
    }
}
