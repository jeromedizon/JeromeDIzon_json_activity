using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroceryApp
{
    public partial class FormAdd : Form
    {
        private readonly List<GroceryItem> groceries = new List<GroceryItem>();
        private readonly string filePath = "shoppinglist.json";

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (groceries.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items only.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = txtName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(itemName))
            {
                groceries.Add(new GroceryItem { Id = groceries.Count + 1, Name = itemName });
                listBox1.Items.Add(itemName);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (groceries.Count > 0)
            {
                string json = JsonSerializer.Serialize(groceries, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json); // <<--- NO async
                MessageBox.Show("Shopping list saved successfully!", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("No items to save.", "Warning");
            }
        }

    }
}
