using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace AddressBook
{
    public partial class uxMainMenuForm : Form
    {
        private bool admin = false;

        public uxMainMenuForm()
        {
            InitializeComponent();
        }

        public uxMainMenuForm(bool admin)
        {
            this.admin = admin;
            InitializeComponent();

            if (admin)
            {
                uxButton3.Enabled = true;
                uxButton4.Enabled = true;
            }
        }






    }
    }
}
