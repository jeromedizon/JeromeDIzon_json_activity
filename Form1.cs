using System;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            btnView.Click += BtnView_Click;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            OpenForm(new FormView());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAdd());
        }

        private void OpenForm(Form form)
        {
            using (form)
            {
                form.ShowDialog();
            }
        }
    }
}
