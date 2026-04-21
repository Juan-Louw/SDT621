using System;
using System.Windows.Forms;

namespace ClassActivity3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Product ID", 100);
            listView1.Columns.Add("Product Name", 150);
            listView1.Columns.Add("Price", 100);
            listView1.FullRowSelect = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string productId = txtProductId.Text;
            string productName = txtProductName.Text;
            string price = txtPrice.Text;

            ListViewItem item = new ListViewItem(productId);
            item.SubItems.Add(productName);
            item.SubItems.Add("R" + price);

            listView1.Items.Add(item);

            ClearBoxes();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtProductId.Text = item.SubItems[0].Text;
                txtProductName.Text = item.SubItems[1].Text;
                txtPrice.Text = item.SubItems[2].Text.Replace("R", "");
            }
            else
            {
                MessageBox.Show("Please select a product.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                item.SubItems[0].Text = txtProductId.Text;
                item.SubItems[1].Text = txtProductName.Text;
                item.SubItems[2].Text = "R" + txtPrice.Text;

                MessageBox.Show("Product updated.");
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Product deleted.");
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void ClearBoxes()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtProductId.Focus();
        }
    }
}