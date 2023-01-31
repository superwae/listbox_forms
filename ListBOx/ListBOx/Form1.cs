using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBOx
{
    public partial class Form1 : Form
    {
        string cweb="";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cweb = textBox1.Text;
            listBox1.Items.Add(cweb);
            count++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 cweb = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(cweb);
                listBox1.Items.Remove(cweb);
            }
            catch(NullReferenceException )
            {
                MessageBox.Show("please select an item");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cweb =listBox2.SelectedItem.ToString();
                listBox1.Items.Add(cweb);
                listBox2.Items.Remove(cweb);
            }
            catch (Exception error)
            {
                MessageBox.Show("please select an item");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            listBox1.Items.Clear();
          

        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);
                listBox1.Items.Add(listBox2.SelectedItem);
            }
            listBox2.Items.Clear();

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(listBox1.SelectedItem.ToString());
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(listBox1.SelectedItem.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show("invalied website");
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(listBox2.SelectedItem.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show("invalied website");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

