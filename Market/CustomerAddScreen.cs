using Market.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class CustomerAddScreen : Form
    {
        public CustomerAddScreen()
        {
            InitializeComponent();
        }

        private void CustomerAddScreen_Load(object sender, EventArgs e)
        {
            this.MinimumSize = ParentForm.Size;
            this.VerticalScroll.Enabled = false;
            this.HorizontalScroll.Enabled = false;

        }
        FormMain formMain = new FormMain();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = txtName.Text;
            customer.Adress = txtAdress.Text;
            customer.Phone = txtPhone.Text;
            customer.Gender = CheckGender(radioButton1);
            customer.ImagePath = txtImgRoute.Text;
            customer.Id = GenerateId();
            
            formMain.customers.Add(customer);
            RefreshListBox();

        }
        void RefreshListBox()
        {
            checkedListBox1.Items.Clear();
            foreach (var item in formMain.customers)
            {
                checkedListBox1.Items.Add(item);
            }
        }
        string CheckGender(RadioButton radio)
        {
            if (radio.Checked)
            {
                return "Erkek";
            }
            else
            {
                return "Kadın";
            }
        }
        string path;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            var dialogResult = dialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {

            }
            else
            {
                path = dialog.FileName;
                txtImgRoute.Text = path;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        Customer SelectedCustomer;
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   SelectedCustomer = (Customer)checkedListBox1.SelectedItem;
            pictureBox1.ImageLocation = SelectedCustomer.ImagePath;
        }
        public int GenerateId()
        {
            return FormMain.id + 1;
        }
    }
}
