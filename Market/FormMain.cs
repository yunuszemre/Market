using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    using Market.Model.Abstract;
    
    public partial class FormMain : Form
    {
        public List<Customer> customers = new List<Customer>();
        public static int id = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void customerAddStrip_Click(object sender, EventArgs e)
        {
            CustomerAddScreen addScreen = new CustomerAddScreen();
            addScreen.MdiParent = this;
            addScreen.Show();
            this.VerticalScroll.Enabled = false;
            this.HorizontalScroll.Enabled = false;
        }
        
    }
}
